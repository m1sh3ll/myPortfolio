using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic;
using MyCommerce.CONFIG;
using MyCommerce.Controls;
using System;
using System.Windows;
using System.Windows.Media.Imaging;
using VBLibrary;
namespace MyCommerce
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private const string ConnectionString = "Data Source=sqlite.db;";
    private const string ProductsConnectionString = "Data Source=E:\\Dropbox\\_Data\\Products.db;";
    private QuickListerControl[] ucArray;
    private int _MaxImages = 20;


    public MainWindow()
    {
      InitializeComponent();
      ucArray = new QuickListerControl[_MaxImages];
      AddUserControls();
      scrlBar1.UpdateLayout();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      txtSkuPrefix.Text = "WPC-";
    }
    private void AddUserControls()
    {
      for (int i = 0; i < _MaxImages; i++)
      {
        ucArray[i] = new QuickListerControl();
        ucArray[i].Name = "UserControl" + i + 1;
        wrpPanel.Children.Add(ucArray[i]);
      }
    }

    static string[] ChooseImageFiles()
    {
      Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
      openFileDialog.Filter = "JPG Files (*.jpg)|*.jpg";
      openFileDialog.FilterIndex = 1;
      openFileDialog.Multiselect = true;
      Nullable<bool> result = openFileDialog.ShowDialog();
      if (result == true)
      {
        return openFileDialog.FileNames;
      }
      return null;
    }


    private void btnChooseImages_Click(object sender, RoutedEventArgs e)
    {
      string[] imgs = ChooseImageFiles();

      if (imgs.Length > 0)
      {
        int j = imgs.Length;
        if (j > _MaxImages) { j = _MaxImages; }
        for (int i = 0; i < j; i++)
        {
          Uri fileUri = new Uri(imgs[i]);
          ucArray[i].imgImage.Source = new BitmapImage(fileUri);
          ucArray[i].FILENAME = imgs[i];
          ucArray[i].UpdateDisplay();
        }
      }
    }



    //------database functions ------------------------->
    #region  "Database Functions"
    private void UpdateDatabase(string newTitle, int productId)
    {
      try
      {
        using (SqliteConnection connection = new SqliteConnection(ConnectionString))
        {
          connection.Open();

          string query = "UPDATE Products SET Title = @NewTitle WHERE Id = @ProductID;";

          using (SqliteCommand command = new SqliteCommand(query, connection))
          {
            command.Parameters.AddWithValue("@NewTitle", newTitle);  // Add to avoid SQL inj
            command.Parameters.AddWithValue("@ProductID", productId);
            command.ExecuteNonQuery();
            connection.Close();
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Error updating database: {ex.Message}");
      }
    }

    private void btnNext_Click(object sender, RoutedEventArgs e)
    {
      // txtItemName.Text = GetFieldValue("item_name", "Amazon", "item_sku", "1DZ-BK-CAT7");
    }

    private string GetFieldValue(string selectItem, string table, string fieldName, string searchValue)
    {
      // Write your SQL query
      string query = $"SELECT {selectItem} FROM {table} WHERE {fieldName} = '{searchValue}';";
      // Create a connection to the SQLite database
      using (SqliteConnection connection = new SqliteConnection(ProductsConnectionString))
      {
        connection.Open();
        using (SqliteCommand command = new SqliteCommand(query, connection))  // Create a command to execute the query
        {
          using (SqliteDataReader reader = command.ExecuteReader()) // Execute the query
          {
            if (reader.Read()) // Check if there are rows in the result set
            {
              return reader[0]?.ToString();
            }
            return null;
          }
        }
      }
    }

    private string btnFirstRecord_Click(object sender, RoutedEventArgs e)
    {
      // Write your SQL query
      string query = $"SELECT item_name FROM Amazon Limit 1;";
      // Create a connection to the SQLite database
      using (SqliteConnection connection = new SqliteConnection(ProductsConnectionString))
      {
        connection.Open();

        using (SqliteCommand command = new SqliteCommand(query, connection))  // Create a command to execute the query
        {
          object result = command.ExecuteScalar();

          // Check if the result is not null
          if (result != null)
          {
            return result.ToString();
          }
          else
          {
            return "";
          }
        }
      }



    }



    private void IncrementButtonClick(object sender, RoutedEventArgs e)
    {
      if (int.TryParse(txtStartNumber.Text, out int currentValue))
      {
        txtStartNumber.Text = (currentValue + 1).ToString();
      }
    }

    private void DecrementButtonClick(object sender, RoutedEventArgs e)
    {
      if (int.TryParse(txtStartNumber.Text, out int currentValue) && currentValue > 0)
      {
        txtStartNumber.Text = (currentValue - 1).ToString();
      }
    }
    #endregion


    private void txtStartNumber_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
    {
      Globals._QLSKUSTARTNUMBER = txtStartNumber.Text;
    }

    private void txtSkuPrefix_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
    {
      Globals._QLTXTSKUPREFIX = txtSkuPrefix.Text;
    }

    private void btnUploadImages_Click(object sender, RoutedEventArgs e)
    {
     
      for (int i = 0; i < ucArray.Length; i++)
      {
        try
        {
          VBLibrary.FTP.StartFTP(Globals.FtpDomain,
          Globals.FtpUser,
          Globals.FtpPass,
          Globals.FtpFolder,
          ucArray[i].FILENAME,
          ucArray[i].txtItemSku.Text + ".jpg", "");
        }
        catch
        {
        }
      }
    }

    private void btnSave_Click(object sender, RoutedEventArgs e)
    {
      Globals.QUICKEBAYFILENAME = $@"{Globals.DataFeedPath}/{DateTime.Now.ToString("MM-dd-yyyy")}_QuickEBAYlistings.txt";

      if (!System.IO.File.Exists(Globals.QUICKEBAYFILENAME))
      {
        VBLibrary.modCSV.CreateBlankEbayFile(Globals.QUICKEBAYFILENAME);
      }

      PostEbayRecords();
    }

    private void PostEbayRecords() {
      for (int i = 0; i < ucArray.Length; i++) {

        modCSV.c_SKU = ucArray[i].txtItemSku.Text;
        modCSV.c_Title = ucArray[i].txtItemName.Text;
        modCSV.c_Price = ucArray[i].txtPrice.Text;
        modCSV.c_Quantity = ucArray[i].txtQuantity.Text;
        modCSV.c_Description = "";
        modCSV.c_Description = modCSV.c_Description.Replace("\"", " ");
        modCSV.c_Description = modCSV.c_Description.Replace("  ", " ");
        modCSV.c_Description = modCSV.c_Description.Replace("  ", " ");
        modCSV.c_Description = modCSV.c_Description.Replace(Constants.vbTab, "");
        modCSV.c_UPC = "";
        modCSV.c_Brand = txtBrand.Text;
        modCSV.c_ImageLink = ucArray[i].txtImageURL.Text;
        modCSV.c_zCondition = "New";
        modCSV.c_ConditionNote = "";
        modCSV.c_EbayCondition = "New";
        modCSV.c_ebayCategory = "32834";
        modCSV.c_neweggCategory = "3";
        modCSV.c_PartNumber = modCSV.c_SKU;
        modCSV.c_Bullet1 = "";
        modCSV.c_Bullet2 = "";
        modCSV.c_Bullet3 = "";
        modCSV.c_Bullet4 = "";
        modCSV.c_Bullet5 = "";
        modCSV.c_zItemType = "";
        modCSV.c_zFeedProductType = "";
        modCSV.PostEbayRecordCSV(Globals.QUICKEBAYFILENAME);
      }
    
    
    }

    
  }
}
