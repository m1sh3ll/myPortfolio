<?php
require_once "ProductClass.php";
require_once "../model/ProductDB.php";

class ProductController
{
    public static function rowToProduct($row)
    {
        // ProductNo is primary key.
        $product = new ProductClass(
            $row['ProductSKU'],
            $row['ProductTitle'],
            $row['ProductPrice'],
            $row['ProductImageURL'],
            $row['ProductTags'],
            $row['ProductDescription'],
            $row['ProductQuantity'],
            $row['ProductNo']
        );
        return $product;
    }
    
    public static function isSKU($sku)
    {
        $queryRes = ProductDB::getProductBySku($sku);

        if ($queryRes) {
            return true;
        }
        return false;
    }

    public static function isProduct($id)
    {
        $queryRes = ProductDB::getProductByProductNo($id);

        if ($queryRes) {
            return true;
        }
        return false;
    }
    public static function getProductByNo($val)
    {
      $queryRes = ProductDB::getAllProducts();

      if ($queryRes) {         
          foreach ($queryRes as $row) {
            $prod = self::rowToProduct($row);
            if($prod->getNo() == $val) 
            return $prod;
          }       
      }
      return false;
    }
    public static function getAllProducts()
    {
        $queryRes = ProductDB::getAllProducts();

        if ($queryRes) {
            $Product = array();
            foreach ($queryRes as $row) {
                $Product[] = self::rowToProduct($row);
            }
            return $Product;
        }
        return false;
    }
    
     public static function getAllItems()
    {
        return self::getAllProducts();
    }


    public static function DeleteProduct($val)
    {
        return ProductDB::DeleteProduct($val);
    }

    public static function AddProduct($p)
    {
        return ProductDB::AddProduct(
            $p->getSKU(),
            $p->getTitle(),
            $p->getImageURL(),
            $p->getTags(),
            $p->getPrice(),
            $p->getDescription(),
            $p->getQuantity()
        );
    }
    public static function UpdateProduct($p)
    {
        return ProductDB::UpdateProduct(
            $p->getProductNo(),
            $p->getSKU(),
            $p->getTitle(),
            $p->getImageURL(),
            $p->getTags(),
            $p->getPrice(),
            $p->getDescription(),
            $p->getQuantity()
        );
    }




}
