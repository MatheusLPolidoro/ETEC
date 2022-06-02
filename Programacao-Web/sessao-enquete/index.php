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

    $quiz[0][0] =  'Escolha uma sobremesa:';
    $quiz[0][1] =  'Pudim';
    $quiz[0][2] =  'Pave';
    $quiz[0][3] =  'Sorvete';
    $quiz[0][4] =  'Bolo';
    ?>

    <form method="POST">

        <?php
        if (!isset($_SESSION["respostas"])) {
            $_SESSION["respostas"] = array();
        }
        foreach ($quiz as &$questao) {
            $init = True;
            foreach ($questao as &$opcao) {
                if (!$init) {
                    echo '<div class="custom-control custom-radio">';
                    echo "<input class='custom-control-input' id='" . $opcao . "' type='radio' name='" . $pergunta . "' value='" . $opcao . "'required>";
                    echo '<label class="custom-control-label" for="' . $opcao . '">' . $opcao . '</label>';
                    echo '</div>';
                } else {
                    $pergunta = str_replace(" ", "_", $opcao);
                    echo '<h2>' . $opcao . '</h2>';
                    $init = False;
                }
            }
            if ($_SERVER['REQUEST_METHOD'] === 'POST'){
                array_push($_SESSION["respostas"], $_POST[$pergunta]);
                print_r($_SESSION["respostas"]);
            }
            
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