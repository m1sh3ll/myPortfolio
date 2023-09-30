<?php 
session_start();
error_reporting(E_ERROR);
require_once "../utilities/Security.php";
require_once('../controller/ProductClass.php');
require_once('../controller/ProductController.php');
//require_once "../model/UpdateProducts.php";
//$returnurl = "./products.php";

Security::checkHTTPS();
if (!isset($_SESSION['username'])){
    Security::login();
}
if (isset($_GET['logout'])){
    Security::logout();
}
$heading = "Update product";
$id = $_SESSION['hiddenvarupdatep'];
$product = ProductController::getProductByNo($id);

//$th = array();
//$th[7] = "Product ID";
//$th[0] = "SKU";
//$th[1] = "Title";
//$th[2] = "Price";
//$th[3] = "ImageURL";
//$th[4] = "Tags";
//$th[5] = "Description";
//$th[6] = "Quantity";

if(isset($_POST['update_product'])) {

    //$sku = $product->getSKU();
    $title = $_POST['title'];

    //$product->setSKU($sku);
    $product->setTitle($title);
//        $product->setPrice($price);
//        $product->setImageURL($imageurl);
//        $product->setTags($tags);
//        $product->setDescription($description);
//        $product->setQuantity($quantity);
    ProductController::UpdateProduct($product);

//  $price = $_POST['price'];
//  $imageurl = $_POST['imageurl'];
//  $tags = $_POST['tags'];
//  $description = $_POST['description'];
//  $quantity = $_POST['quantity'];
//}else{
//  $sku = $product->getSKU();
 // $title = $product->getTitle();
//  $price = $product->getPrice();
//  $imageurl = $product->getImageURL();
//  $tags = $product->getTags();
//  $description = $product->getDescription();
//  $quantity = $product->getQuantity();
//}

//function checkSkuExists()
//{
//    $valid = ProductController::isSKU($_POST['sku']);
//    if ($valid) {
//        $errors[] = "SKU already exists. ";
//    }
//}

//if (isset($POST['update_product'])) {
   // $id = $_POST['update_product_id'];
   // checkValidateProduct();
    //checkSkuExists();
    //if (count($errors) === 0) {
//        $product->setSKU($sku);
      //  $product->setTitle($title);
//        $product->setPrice($price);
//        $product->setImageURL($imageurl);
//        $product->setTags($tags);
//        $product->setDescription($description);
//        $product->setQuantity($quantity);
      //  ProductController::UpdateProduct($product);
    //}
}

// -> send to the update page
//if (isset($_POST['pass_update_product'])) {
//  $fwdurl = "update_product.php";
//  header("Location: " . $fwdurl . "?hiddenvarupdatep=" . $_POST['hiddenvarupdatep']);
//}

include_once('../includes/Header.php');
?>

<!--<form action="update_product.php" method="POST">-->
   <form class="d-flex" action="update_product.php" method="POST">
    <fieldset>
            <label class="col-sm-3 form-control-lg my-2"> ID <?php echo $id;?></label>
       
<!--        <div class="form-group row mx-auto">-->
<!--            <label for="sku1" class="col-sm-3 form-control-lg my-2"> SKU </label>-->
<!--            <div class="col-sm-6">-->
<!--                <input type="text" maxlength="50" class="form-control form-control-lg" id="sku" name="sku" value="--><?php //echo $sku;?><!--" required>-->
<!--            </div>-->
<!--        </div>-->
        <div class="form-group row mx-auto">
            <label for="title" class="col-sm-3 form-control-lg my-2"> TITLE </label>
            <div class="col-sm-6">
                <input type="text" maxlength="250" class="form-control form-control-lg" id="title" name="title" value="<?php echo $product->getTitle();?>" required>
            </div>
        </div>
<!--        <div class="form-group row mx-auto">-->
<!--            <label for="price1" class="col-sm-3 form-control-lg my-2"> PRICE </label>-->
<!--            <div class="col-sm-6">-->
<!--                <input type="text" maxlength="250" class="form-control form-control-lg" id="price" name="price" value="--><?php //echo $price;?><!--" required>-->
<!--            </div>-->
<!--        </div>-->
<!--        <div class="form-group row mx-auto">-->
<!--            <label for="imageurl1" class="col-sm-3 form-control-lg my-2"> IMAGEURL </label>-->
<!--            <div class="col-sm-6">-->
<!--                <input type="text" maxlength="500" class="form-control form-control-lg" id="imageurl" name="imageurl" value="--><?php //echo $imageurl ;?><!--" required>-->
<!--            </div>-->
<!--        </div>-->
<!--        <div class="form-group row mx-auto">-->
<!--            <label for="tags1" class="col-sm-3 form-control-lg my-2"> TAGS </label>-->
<!--            <div class="col-sm-6">-->
<!--                <input type="text" maxlength="200" class="form-control form-control-lg" id="tags" name="tags" value="--><?php //echo $tags;?><!--" required>-->
<!--            </div>-->
<!--        </div>-->
<!--        <div class="form-group row mx-auto">-->
<!--            <label for="description1" class="col-sm-3 form-control-lg my-2"> DESC </label>-->
<!--            <div class="col-sm-6">-->
<!--                <input type="text" maxlength="500" class="form-control form-control-lg" id="description" name="description" value="--><?php //echo $description;?><!--" required>-->
<!--            </div>-->
<!--        </div>-->
<!--        <div class="form-group row mx-auto">-->
<!--            <label for="quantity1" class="col-sm-3 form-control-lg my-2"> QTY </label>-->
<!--            <div class="col-sm-6">-->
<!--                <input type="text" maxlength="250" class="form-control form-control-lg" id="quantity" name="quantity" value="--><?php //echo $quantity;?><!--" required>-->
<!--            </div>-->
<!--        </div>-->

        <!-- <p class="errors">
        <?php //include('../includes/errors.php');?>
        </p> -->

<!--        <input type="hidden" value="--><?php //echo $id;?><!--" name="update_product_id">-->
        <button name="update_product" id="update_product" type="submit" class="btn btn-primary">Update</button>
        <button class="btn btn-info my-2 my-sm-0" onclick="window.location.href='products.php'">Cancel</button>

    </fieldset>

</form>
<?php
include_once('../includes/Footer.php');
