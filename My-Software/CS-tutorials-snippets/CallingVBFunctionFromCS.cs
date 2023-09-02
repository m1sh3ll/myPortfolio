private void FTPUploadImage(string fullImgPath, string site, string folder)
    {
      if (chkAutoUpload.Checked == true)
      {
        NerdomFTP_VB.StartFTP(txtSite.Text,
                              base64d_nerdom(ModuleGLOBALS_CONFIG.BASE64USER),
                              base64d_nerdom(ModuleGLOBALS_CONFIG.BASE64PASS),
                              txtFolder.Text,
                              fullImgPath,
                              Path.GetFileName(fullImgPath),"");

        txtLogs.Text += ModuleGLOBALS_CONFIG.IMAGEURL + " UPLOAD success!";

      }
    }

//pass stored in Base64
    public static string base64d_nerdom(string s)
    {
      string base64String = s;
      base64String = base64String.Replace("\r\n", "").Replace("\n", "");
      byte[] base64Bytes = Convert.FromBase64String(base64String);
      string decodedString = Encoding.UTF8.GetString(base64Bytes);
      return decodedString;
    }