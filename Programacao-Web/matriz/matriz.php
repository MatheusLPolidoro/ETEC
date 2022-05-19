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
    $quiz[0][5] =  'D';
    
    $quiz[1][0] =  'Para que a transferência de dados na Internet seja realizada, o protocolo HTTP necessita estar agregado a outros dois protocolos de rede, quais são esses protocolos?';

    $quiz[1][1] =  'TCP e URL';
    $quiz[1][2] =  'HTTPS e HTML';
    $quiz[1][3] =  'WWW e HTML';
    $quiz[1][4] =  'TCP e IP';
    $quiz[1][5] =  'D';

    $quiz[2][0] =  'Para que a transferência de dados na Internet seja realizada, o protocolo HTTP necessita estar agregado a outros dois protocolos de rede, quais são esses protocolos?';

    $quiz[2][1] =  'TCP e URL';
    $quiz[2][2] =  'HTTPS e HTML';
    $quiz[2][3] =  'WWW e HTML';
    $quiz[2][4] =  'TCP e IP';
    $quiz[2][5] =  'A';

    ?>

    <form method="POST" action="" >
        <?php 
        $questao = 1;
        $pontos = 0;
        for ($row=0; $row < 3; $row++) {
            $op_i = 0;
            echo $questao.' - '.$quiz[$row][0].'<br>';
            for ($col=1; $col < 5; $col++) { 
                echo "<input type='radio' name='$questao' value='$op[$op_i]' required>".$op[$op_i].') '.$quiz[$row][$col].'<br>';
                $op_i++;
            }
            // recebe as respostas do client
            if ($_SERVER['REQUEST_METHOD'] === 'POST') {
                if ($_POST[$questao] == $quiz[$row][5]){
                    $pontos++;
                }
            }
            echo '<br><br>';
            $questao++;
            if ($row == 2) {
                echo $pontos;
            }
        }
        ?>
        <input type="submit">
    </form>
</body>
</html>