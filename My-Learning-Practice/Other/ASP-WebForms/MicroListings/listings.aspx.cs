using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace EmployeeInfo
{
  public partial class listings : System.Web.UI.Page
  {
    private DataFeedAmazon _datafeed;


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSaveAddSkus_Click(object sender, EventArgs e)
    {
      int n = txtSkusPasted.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Length;

      string[] splits = txtSkusPasted.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

      lblCount.Text = n.ToString();
      tree1.Nodes.Clear();
      txtSkusPasted.Enabled = false;
      listboxSkusEdit.Items.Clear();
      btnSaveAddSkus.Enabled = false;

      for (int i = 0; i < n; i++)
      {
        listboxSkusEdit.Items.Add(splits[i]);
      }

      listboxSkusEdit.SelectedIndex = 0;
      _datafeed = new DataFeedAmazon();

      for (int j = 0; j < n; j++)
      {
        _datafeed.SKUS.Add(splits[j]);
      }
    }

    protected void btnEditSkus_Click(object sender, EventArgs e)
    {
      txtSkusPasted.Enabled = true;
      btnSaveAddSkus.Enabled = true;
    }
  }
}