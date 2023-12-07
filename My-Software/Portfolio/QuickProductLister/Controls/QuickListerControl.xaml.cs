using DocumentFormat.OpenXml.Office2010.CustomUI;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using MyCommerce.CONFIG;
using System;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace MyCommerce.Controls
{
    /// <summary>
    /// Interaction logic for QuickListerControl.xaml
    /// </summary>
    public partial class QuickListerControl : UserControl
  {
    public string FILENAME;

    public QuickListerControl()
    {
      InitializeComponent();
     
    }

   
    public void reset()
    {
      txtItemName.Clear();
      txtItemSku.Clear();
      txtPrice.Clear();
      imgImage.Source = null;
      txtQuantity.Clear();
      txtImageURL.Clear();
      lblDimensions.Content = "";
    }
    public void UpdateDisplay()
    {
      UpdateDimensions();
      UpdateBlankSkus();
      SetImageURL();
    }
    public void UpdateBlankSkus()
    {
      string ddate = DateTime.Now.ToString("Mddyy-Hms");
      if (txtItemSku.Text == "")
      {
        txtItemSku.Text = $"{Globals._QLTXTSKUPREFIX}{ddate}-{Globals._QLSKUSTARTNUMBER}";
        Globals._QLSKUSTARTNUMBER += 1;
      }
    }
    public void UpdateDimensions()
    {
      Label uLabel = lblDimensions;
      double pHeight = imgImage.Source.Height;
      double pWidth = imgImage.Source.Width;
      uLabel.Content = $"W: {pWidth} H: {pHeight}";

      if (pHeight < 500 && pWidth < 500)
      {
        uLabel.Foreground = System.Windows.Media.Brushes.Red;
      }
      else
      {
        uLabel.Foreground = System.Windows.Media.Brushes.Black;
      }
    }        
    public void SetImageSource(string imagePath)
    {
      try
      {
        BitmapImage bitmap = new BitmapImage();
        bitmap.BeginInit();
        bitmap.UriSource = new Uri(imagePath, UriKind.RelativeOrAbsolute);
        bitmap.EndInit();
        imgImage.Source = bitmap;
        UpdateDimensions();
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
      }
    }

    private string ChooseFileImage()
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog
      {
        Filter = "Image Files|*.jpg",
        Title = "Select an Image"
      };
      openFileDialog1.FilterIndex = 1;
      Nullable<bool> result = openFileDialog1.ShowDialog();
      if (result == true)
      {
        FILENAME = openFileDialog1.FileName;
        return FILENAME;
      }
      return null;
    }

    private void txtItemSku_LostFocus(object sender, RoutedEventArgs e)
    {
      txtItemSku.Text = Strings.Replace(txtItemSku.Text, " ", "-");    
      SetImageURL();
    }

    public void SetImageURL()
    {
      txtImageURL.Text = String.Concat("http://www.",Globals.FtpDomain, "/", Globals.FtpFolder, "/",
        txtItemSku.Text + ".jpg");
    }

    private void btnImgUrl_Click(object sender, RoutedEventArgs e)
    {
      string img = ChooseFileImage();
      if (img != null)
      {
        SetImageSource(img);
      }
      SetImageURL();
    }
  }
}
