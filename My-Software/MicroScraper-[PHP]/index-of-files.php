<?php

    //get current directory
    $working_dir = getcwd();
	$counter = 0;
    //get image directory
    $img_dir = $working_dir . "/";
	
    //change current directory to image directory
    chdir($img_dir);
	
    //using glob() function get images 
    //$files = glob("*.{jpg,jpeg,png,gif,bmp,jfif,JPG,JPEG,PNG,GIF}", GLOB_BRACE );
   // $files = glob("*.*", GLOB_BRACE );
   $files = glob("*.{jpg,jpeg,htm,png,gif,bmp,jfif,mp4,JPG,JPEG,PNG,GIF}", GLOB_BRACE );

    //again change the directory to working directory
    chdir($working_dir);
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Michelle Nesbitt-Tutorials</title>
</head>
<body>
<h1>Index of My Files</h1>

   
    <?php 
     //iterate over image files
    foreach ($files as $file) 
    {
    ?>
        <a href="<?php echo urlencode($file) ?>">
        <img border=0 src="<?php echo $file ?>" style="height: 25px;"/>
        </a>
        &nbsp;&nbsp;
        <a href="<?php echo urlencode($file) ?>">
        <?php echo $file ?></p>
        </a>
        
    <?php 
    
// END CURLY BRACE THING
}
    ?>
</body>
</html>


