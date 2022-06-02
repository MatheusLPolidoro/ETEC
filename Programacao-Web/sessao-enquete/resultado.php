<!DOCTYPE html>
<html lang="pt-BR">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Enquete</title>

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/style.css">
</head>

<body>

    <?php
    include_once 'menu.php';
        if (!isset($_SESSION["respostas"])) {
        $_SESSION["respostas"] = array();
    }

    print_r($_SESSION["respostas"]);


    ?>

    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="Js/jquery-3.6.0.min.js"></script>
    <script src="Js/bootstrap.bundle.min.js"></script>
</body>

</html>