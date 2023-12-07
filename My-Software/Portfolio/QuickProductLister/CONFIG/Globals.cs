using System;
using System.Text;

namespace MyCommerce.CONFIG
{
  public static class Globals 
  {
    public static string _QLTXTSKUPREFIX;
    public static string _QLSKUSTARTNUMBER;
    public static string _QLQTY;
    public static string _QLPRICE;
    public static string _QLBRAND;
    public static string QUICKEBAYFILENAME;  
    private const string ftp_domain = "";
    private const string folder = "";
    private static string ftp_user = base64d_nerdom("");
    private static string ftp_pass = base64d_nerdom("");
    private const string bycategory = @"BY-CATEGORY";

    public static string FtpDomain
    {
      get { return ftp_domain; }
    }
    public static string FtpFolder
    {
      get { return folder; }
    }
    public static string FtpUser
    {
      get { return ftp_user; }
    }
    public static string FtpPass
    {
      get { return ftp_pass; }
    }
    public static string ByCategory {

      get { return images_program + keystones + bycategory; }
    }
    public static string FramesPath
    {
      get { return images_program + frames; }
    }
    public static string FramesPathPNG
    {
      get { return images_program + pngframes; }
    }
    public static string HistoryPath
    {
      get { return images_program + history; }
    }
    public static string KeystonesPath
    {
      get { return images_program + keystones; }
    }
    public static string ConfigPath
    {
      get { return images_program + config + configtxt; }
    }
    public static string SavedHTMLPath
    {
      get { return images_program + mhtml; }
    }
    public static string ConfigMainPath
    {
      get { return images_program + config; }
    }
    public static string SavedJPEGSPath
    {
      get { return savedjpegs; }
    }
    public static string DataFeedPath
    {
      get { return datafeed_path; }
    }
    public static string FeedTemplates
    {
      get { return datafeed_path + feed_templates; }
    }
    public static string ServerHTMLPath
    {
      get { return savedjpegs + mhtml; }
    }
    public static string base64d_nerdom(string s)
    {
      string base64String = s;

      base64String = base64String.Replace("\r\n", "").Replace("\n", "");
      byte[] base64Bytes = Convert.FromBase64String(base64String);
      string decodedString = Encoding.UTF8.GetString(base64Bytes);
      return decodedString;
    }
  }
}
