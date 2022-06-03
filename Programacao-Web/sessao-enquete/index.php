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

    $_SESSION["enquete"][0][0] =  'Escolha uma sobremesa:';
    $_SESSION["enquete"][0][1] =  'Mousses';
    $_SESSION["enquete"][0][2] =  'Pudins';
    $_SESSION["enquete"][0][3] =  'Bolos';
    $_SESSION["enquete"][0][4] =  'Tortas';
    $_SESSION["enquete"][0][5] =  'Cheesecakes';
    $_SESSION["enquete"][0][6] =  'Verrines';
    $_SESSION["enquete"][0][7] =  'Docinhos';
    $_SESSION["enquete"][0][8] =  'Sorvetes';
    $_SESSION["enquete"][0][9] =  'Pavês';
    $_SESSION["enquete"][0][10] =  'Flans';
    $_SESSION["enquete"][0][11] =  'Panna cottas';

    ?>

    <form method="POST">
        <?php
        foreach ($_SESSION["enquete"] as &$questao) {
            $init = True;
            foreach ($questao as &$opcao) {
                if (!isset($_SESSION[$opcao])) {
                    $_SESSION[$opcao] = 0;
                }
                if (!$init) {
                    $id = strtolower(str_replace(":", "",str_replace(" ", "-", "$opcao-$resposta")));
                    echo "<div class='custom-control custom-radio'>";
                    echo "<input class='custom-control-input' id='$id' type='radio' name='$resposta' value='$opcao' required>";
                    echo "<label class='custom-control-label' for='$id'>$opcao</label>";
                    echo "</div>";
                } else {
                    $resposta = str_replace(" ", "-", $opcao);
                    echo "<h2>$opcao</h2>";
                    $init = False;
                }
            }
            if ($_SERVER["REQUEST_METHOD"] === "POST") {
                $_SESSION[$_POST[$resposta]]++;
            }
            echo "<br>";
        }
        ?>
        <div class="col text-center">
            <input type="submit" class="btn text-center btn-success">
        </div>
    </form>

    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="Js/jquery-3.6.0.min.js"></script>
    <script src="Js/bootstrap.bundle.min.js"></script>
</body>

</html>