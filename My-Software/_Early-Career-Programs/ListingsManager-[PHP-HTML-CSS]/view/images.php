<?php
session_start();
error_reporting(E_ERROR);
require_once "../utilities/Security.php";
$rootdir = "/riteavsku1/";
$viewfolder = "/cis480/view";
Security::checkHTTPS();
if (!isset($_SESSION['username'])) {
  Security::login();
}
if (isset($_GET['logout'])) {
  Security::logout();
}
include_once('../includes/Header.php');
$working_dir = getcwd();
chdir($working_dir);
$img_dir = $working_dir . $rootdir;
chdir($img_dir);
if (isset($_POST['search'])) {
  if (isset($_POST['searchbox'])) {
    
    $searchterm = $_POST['searchbox'];
    $files = glob("*$searchterm*", GLOB_BRACE);
  }
} else {
  $files = glob("*.*", GLOB_BRACE);
}

$increment = sizeof($files) / 100;
$current_page = isset($_POST['current_page']) ? intval($_POST['current_page']) : 1;
$sizecsv = sizeof($files);
if ($current_page >= $sizecsv) $current_page = ($sizecsv - 1);
if ($current_page < 0) $current_page = 1;
if (isset($_POST['next'])) {
  $current_page++;
  if ($current_page >= $sizecsv) $current_page = 1;
}
if (isset($_POST['previous'])) {
  $current_page--;
  if ($current_page < 0) $current_page = ($sizecsv - 1);
}
if (isset($_POST['first'])) $current_page = 1;
if (isset($_POST['last'])) $current_page = ($sizecsv / $increment);

?>

<form method="post">
  <input type="hidden" name="current_page" value="<?php echo $current_page; ?>" />
  <input type="submit" name="first" value="FIRST" />
  <input type="submit" name="previous" value="PREVIOUS" />
  <input type="submit" name="next" value="NEXT" />
  <input type="submit" name="last" value="LAST" />
  <input type="text" name="searchbox" placeholder="ENTER SEARCH TERMS" />
  <input type="submit" name="search" value="SEARCH" />
</form>
<hr>
<div class="wrapper">
  <?php
  $max = $current_page * $increment;
  $start = $max - $increment;
  while ($start < $max) {
    $file = urlencode($files[$start]);
    $urlsrc =  $viewfolder . $rootdir . $file;
  ?>
    <div>
      <a href="<?php echo $urlsrc; ?>">
        <?php echo $file ?></a>
      <div>
        <a href="<?php echo $urlsrc; ?>">
          <img border="0" src="<?php echo $urlsrc; ?>" style="height: 100px;" /></a>
      </div>
    </div>
  <?php
    $start++;
  } // END CURLY BRACE 
  ?>
</div>

<?php
include_once('../includes/Footer.php');
