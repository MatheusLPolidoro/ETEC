<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Matriz</title>
    <link rel="stylesheet" href="css/style.css">
</head>
<body>
    <?php
    $op = array('A', 'B', 'C', 'D');

    $quiz[0][0] =  'O que é uma variavel?';
    $quiz[0][1] =  'um HD';
    $quiz[0][2] =  'uma placa mae';
    $quiz[0][3] =  'um software';
    $quiz[0][4] =  'um espaco reservado na memoria';
    $quiz[0][5] =  'd';
    
    $quiz[1][0] =  'Para que a transferência de dados na Internet seja realizada, o protocolo HTTP necessita estar agregado a outros dois protocolos de rede, quais são esses protocolos?';

    $quiz[1][1] =  'TCP e URL';
    $quiz[1][2] =  'HTTPS e HTML';
    $quiz[1][3] =  'WWW e HTML';
    $quiz[1][4] =  'TCP e IP';
    $quiz[1][5] =  'd';

    $quiz[2][0] =  'Para que a transferência de dados na Internet seja realizada, o protocolo HTTP necessita estar agregado a outros dois protocolos de rede, quais são esses protocolos?';

    $quiz[2][1] =  'TCP e URL';
    $quiz[2][2] =  'HTTPS e HTML';
    $quiz[2][3] =  'WWW e HTML';
    $quiz[2][4] =  'TCP e IP';
    $quiz[2][5] =  'd';

    ?>

    <form method="POST" action="" >
        <?php 
        $questao = 1;
        $pontos = 0;
        for ($col=0; $col < 3; $col++) {
            $op_i = 0;
            echo $questao.' - '.$quiz[$col][0].'<br>';
            for ($row=1; $row < 5; $row++) { 
                echo "<input type='radio' name='$questao' value='$op[$op_i]' required>".$op[$op_i].') '.$quiz[$col][$row].'<br>';
                $op_i++;
            }
            // recebe as respostas do client
            if ($_SERVER['REQUEST_METHOD'] === 'POST') {
                if ($_POST[$questao] == "4"){
                    echo $_POST[$questao];
                    $pontos++;
                }
            }
            echo '<br><br>';
            $questao++;
            echo $pontos;
        }
        ?>
        <input type="submit">
    </form>
</body>
</html>