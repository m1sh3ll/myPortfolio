<?php
static $titleheader = "E-commerce Inventory 1.0";
static $heading;
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../css/bootswatchTheme.css">
    <link rel="stylesheet" href="../css/mystyles.css">
    <title><?php echo $titleheader . ' - ' . $heading; ?></title>
</head>
<body>   
        <header>
        </header>
        <?php include_once('../includes/Nav.php'); ?>
        <main>
            <section>
                <h1>
                    <?php echo $heading; ?>
                </h1>
            </section>