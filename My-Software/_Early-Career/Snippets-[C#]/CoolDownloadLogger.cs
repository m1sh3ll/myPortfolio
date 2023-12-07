public string dm(string str, string s)
    {
      string msg = "";
      string vbCrLf = "\r\n";
      switch (str)
      {
        case "No image indicated":
          return "***************************************" + vbCrLf +
              $"    ~ No image indicated ~ {s}.jpg ~ " + vbCrLf +
             "***************************************";
        case "Download Error 0KB":
          return "***************************************" + vbCrLf +
              $"*****    ~ DownloadError {s}.jpg ~ 0 KB *~" + vbCrLf +
              "***************************************";
        case "Download Message":
          return "***************************************" + vbCrLf +
                $"******  ~ Download {s}.jpg ~" + vbCrLf +
                "***************************************";
        case "Completed":
          return "***************************************" + vbCrLf +
                 $"******  ~ Completed ~" + vbCrLf +
                 "***************************************";
      }
      return msg;
    }