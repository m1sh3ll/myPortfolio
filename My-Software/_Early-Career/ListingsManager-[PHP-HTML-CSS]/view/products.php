<?php
session_start();
error_reporting(E_ERROR);
require_once "../utilities/Security.php";
require_once('../controller/ProductClass.php');
require_once('../controller/ProductController.php');
//require_once "../model/ServerProducts.php";

Security::checkHTTPS();
if (!isset($_SESSION['username'])) {
  Security::login();
}
if (isset($_GET['logout'])) {
  Security::logout();
}

$sku = $_POST['sku'];
$title = $_POST['title'];
$price = $_POST['price'];
$imageurl = $_POST['imageurl'];
$tags = $_POST['tags'];
$description = $_POST['description'];
$quantity = $_POST['quantity'];
$link_url = "add_product.php";

$errors = array();
$prod_array = array();
$prod_array = ProductController::getAllItems();

// -> send to the update page
if (isset($_POST['pass_update_product'])) {
  $_SESSION['hiddenvarupdatep'] = $_POST['hiddenvarupdatep'];
  $_SESSION['update_product'] = $_POST['pass_update_product'];
  header("Location: " . "update_product.php");

  // header("Location: " . $fwdurl . "?hiddenvarupdatep=" . $_POST['hiddenvarupdatep']);
}

if (isset($_POST['delete_product'])) {
  ProductController::deleteProduct($_POST['hiddenvardeletep']);
  unset($_POST['delete_product'], $_POST['hiddenvardeletep']);
}

if (isset($_POST['add_product'])) {
  //checkValidateProduct();
  checkSkuExists();
  if (count($errors) === 0) {
    $product = new ProductClass($sku, $title, $price, $imageurl, $tags, $description, $quantity);
    if (ProductController::AddProduct($product)) {
      $_SESSION['successp'] = "Product Added";
      header('location: products.php');
    }
  }
}

function checkSkuExists()
{
  $valid = ProductController::isSKU($_POST['sku']);
  if ($valid) {
    $errors[] = "SKU already exists. ";
  }
}

include_once('../includes/Header.php');
?>

<form class="d-flex">
  <input class="form-control me-sm-2" type="text" placeholder="Search">
  <button class="btn btn-secondary my-2 my-sm-0" type="submit">Search</button>
</form>
<?php if (isset($_SESSION['successp'])) : ?>
  <div class="error success">
    <h3>
      <?php
      echo $_SESSION['successp'];
      unset($_SESSION['successp']);
      ?>
    </h3>
  </div>
<?php endif ?>
<?php
$totalcount = 9;
?>

<table class="table table-hover">
  <tr>
    <th scope="col">SKU</th>
    <th scope="col">Image</th>
    <th scope="col">Price</th>
    <th scope="col">Title</th>
    <th scope="col">Tags</th>
    <th scope="col">Description</th>
    <th scope="col">Quantity</th>
    <th scope="col">Update</th>
    <th scope="col">Delete</th>
  </tr>

  <?php //PRINT OUT each ROW
  foreach ($prod_array as $product) :   
  ?> 
    <tr>
      <td scope="row"><?php echo $product->getSKU();?></td>
      <td scope="row">
        <a href="<?php echo $product->getImageURL();?>" target="_blank">
      <img alt="Product" src="<?php echo $product->getImageURL();?>" height="100">
    </a></td>
      <td scope="row"><?php echo $product->getPrice();?></td>
      <td scope="row"><?php echo $product->getTitle();?></td>
      <td scope="row"><?php echo $product->getTags();?></td>
      <td scope="row"><?php echo $product->getDescription();?></td>
      <td scope="row"><?php echo $product->getQuantity();?></td>

      <td scope="row">
        <form action="products.php" method="POST">
          <input type="hidden" name="hiddenvarupdatep" value="<?php echo $product->getNo(); ?>" />
          <input type="submit" name="pass_update_product" value="Update" />
        </form>
      </td>

      <td scope="row">
        <form action="products.php" method="POST">
          <input type="hidden" name="hiddenvardeletep" value="<?php echo $product->getNo(); ?>" />
          <input type="submit" name="delete_product" value="Delete" />
        </form>
      </td>
    </tr>

    <tr>      
      <td colspan="9"><input type="text" name="imageurl" style="width:90%;" value="<?php echo $product->getImageURL();?>"</td>
     
    </tr>
  <?php
    $counter = $counter + 1;    //Current product 
  endforeach;                     //End ForEach loop 
  //end tag
  ?>
  <tr>
    <td colspan="9"><?php echo $counter; ?> Total Products</td>
  </tr>
  <tr>
    <td colspan="9">
      <button class="btn btn-info my-2 my-sm-0" onclick="window.location.href = 'add_product.php'">Add Product</button>

    </td>
  </tr>
</table>

<?php include_once('../includes/Footer.php');
