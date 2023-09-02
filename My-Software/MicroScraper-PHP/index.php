<?php

if (isset($_POST['asin1'])) {

  $asin = $_POST['asin1'];

  if (isset($_POST['zoom1'])) {
    $zoom = $_POST['zoom1'];
  }


  $url = "https://www.amazon.com/dp/$asin";

  if (!$ch = curl_init()) {
    echo "Failed to generate curl handle";
  } else {
    curl_setopt($ch, CURLOPT_URL, $url);
    curl_setopt($ch, CURLOPT_SSL_VERIFYPEER, false);
    curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
    curl_setopt($ch, CURLOPT_COOKIE, true);
    if (!$result = curl_exec($ch)) {
      echo "CURL error: ", curl_error($ch);
    } else {
      // var_export($result);
      if (!$count = preg_match_all('@src="([^"]+)"@', $result, $matches)) {
        echo "No matches from CURL result";
      } else {
        //src=https://m.media-amazon.com/images/I/71BBPzTmmRL._AC_SL400_.jpg  _AC_SLHEIGHT_.jpg 
        //https://m.media-amazon.com/images/I/31vS0T757iL._AC_US40_.jpg - THUMB NAIL
        //__AC_SY300_SX300_.jpg
        $unique_matches = array_keys(array_flip($matches[0]));
        // 	// echo "<pre>";
        // 	//var_export($unique_matches);
        // 	//echo "</pre>";       

        //find the first image on the page        
        foreach ($unique_matches as $value) {
          if (str_contains($value, '_AC')) {

            $img = "<img " . $value . ">";
            //  <img src="https://m.media-amazon.com/images/I/71BBPzTmmRL._AC_xxxxxx.jpg">

            if (!$count = preg_match_all('@_AC_([^"]+)"@', $img, $matches2)) {
              echo "No matches from CURL result";
            } else {

              $sub_string = array_keys(array_flip($matches2[0])); //_AC_xxxxxxx.jpg"
            }

            break;
          }
        }
      }
    }
    curl_close($ch);
  }
} else {
  $asin = "";
  $img = "";
  $zoom = "500";
  $sub_string = "";
}

//$imgtag = str_replace("%body%", "_AC_xxxxxxx.jpg\"", "<img text='AC_SL678.jpg'>");
$imgtag = str_replace($sub_string, '_AC_SL' . $zoom . '.jpg"', $img);
?>

<?php require_once('../includes/header.php'); ?>



<div class="container">
  <div class="header1">
  <h1>ASIN search</h1>
  <form method='post'>
    <input type='text' name='asin1' value='<?php
                                            if (isset($_POST['asin1'])) {
                                              echo $asin;
                                            } ?>' />
    <input type='text' name='zoom1' value='<?php echo $zoom; ?>' />
    <input type='submit' name='submit' value='Submit' />
  </form>

  <?php
  echo $img . "<br>";
  echo $imgtag;
  ?>
  </div>
</div>
<div class="container">
  <div class="header1">
    <!-- <fieldset class="form-group">
      <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
    </fieldset> -->
    SKU: $sku Title: $title
  </div>
  <div class="nav1">Images
    <div class="gallery">
      <div class="img1">$imagesrc1</div>
      <div class="img2">$imagesrc2</div>
      <div class="img3">$imagesrc3</div>
      <div class="img4">$imagesrc4</div>
      <div class="img5">$imagesrc5</div>
      <div class="img6">$imagesrc6</div>
      <div class="img7">$imagesrc7</div>
      <div class="img8">$imagesrc8</div>
      <div class="img9">$imagesrc9</div>
      <div class="img10">$imagesrc10</div>
    </div>
  </div>
  <div class="main1">
    <textarea id="desc" name="desc">$desc</textarea>
    <ul>
      <li><input id="b1" type="text" value="$bullet1"></li>
      <li><input id="b2" type="text" value="$bullet2"></li>
      <li><input id="b3" type="text" value="$bullet3"></li>
      <li><input id="b4" type="text" value="$bullet4"></li>
      <li><input id="b5" type="text" value="$bullet5"></li>
    </ul>
    <textarea id="keywords" name="keywords">$keywords</textarea>
    <p>Weight:&nbsp;$weight&nbsp;oz</p>
    <p>Dims:&nbsp;L:&nbsp;$f24&nbsp;$f25 W:&nbsp;$f26&nbsp;$f27 H:&nbsp;$f28&nbsp;$f29</p>
    <p>Feed:&nbsp;$feedtype Item:&nbsp;$itemtype </p>
    <p>Theme:&nbsp;$vartheme Parent:&nbsp;$parent Size:&nbsp;$size Color:&nbsp;$color</p>
    <p>Material:&nbsp;$material Shipping&nbsp;Template:&nbsp;$shippingtemplate</p>
  </div>
  <div class="footer1">
    Price:&nbsp;$$price
    List&nbsp;Price:&nbsp;$$listprice
    $qty&nbsp;in&nbsp;stock
  </div>
  <div class="overlay"></div>
</div> <!-- ! End Item-->





</body>

</html>