<?php

class ProductClass
{
  private $No; // primary key
  private $SKU;
  private $Title;
  private $Price;
  private $ImageURL;
  private $Tags;
  private $Description;
  private $Quantity;


  public function __construct($sku, $title, $price, $image, $tags, $desc, $qty, $no = null)
  {
    $this->SKU = $sku;
    $this->Title = $title;
    $this->Price = $price;
    $this->ImageURL = $image;
    $this->Tags = $tags;
    $this->Description = $desc;
    $this->Quantity = $qty;
    $this->No = $no;
  }


  function getNo()
  {
    return $this->No;
  }

  function getProductNo()
  {
    return $this->No;
  }

  function setNo($val)
  {
    $this->No = $val;
    
  }

  function getSKU()
  {
    return $this->SKU;
  }


  function setSKU($val)
  {
    $this->SKU = $val;
    
  }

  function getTitle()
  {
    return $this->Title;
  }


  function setTitle($val)
  {
    $this->Title = $val;
  
  }
  
  function getPrice()
  {
    return $this->Price;
  }


  function setPrice($val)
  {
    $this->Price = $val;
    
  }

  function getImageURL()
  {
    return $this->ImageURL;
  }


  function setImageURL($val)
  {
    $this->ImageURL = $val;
   
  }

  function getTags()
  {
    return $this->Tags;
  }


  function setTags($t)
  {
    $this->Tags = $t;
    
  }

  function getDescription()
  {
    return $this->Description;
  }


  function setDescription($d)
  {
    $this->Description = $d;
    
  }

  function getQuantity()
  {
    return $this->Quantity;
  }


  function setQuantity($val)
  {
    $this->Quantity = $val;
    
  }
}
