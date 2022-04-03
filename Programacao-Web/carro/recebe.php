<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Resultado</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <?php 

    $placa = $_POST["placa"];

    switch ($placa)
    {
        case 0:
            $mes_limite = "DEZEMBRO";
            $dia_rodizio = "SEXTA-FEIRA";
            $calendario_ipva = ["21/Jan", "21/Fev", "23/Mar"];
            break;
        case 1:
            $mes_limite = "JULHO";
            $dia_rodizio = "SEGUNDA-FEIRA";
            $calendario_ipva = ["24/Jan", "23/Fev", "25/Mar"];        
            break;
        case 2:
            $mes_limite = "JULHO";
            $dia_rodizio = "SEGUNDA-FEIRA";
            $calendario_ipva = ["25/Jan", "24/Fev", "28/Mar"];        
            break;
        case 3:
            $mes_limite = "AGOSTO";
            $dia_rodizio = "TERÇA-FEIRA";
            $calendario_ipva = ["26/Jan", "25/Fev", "29/Mar"];        
            break;
        case 4:
            $mes_limite = "AGOSTO";
            $dia_rodizio = "TERÇA-FEIRA";
            $calendario_ipva = ["27/Jan", "03/Mar", "04/Abr"];        
            break;
        case 5:
            $mes_limite = "SETEMBRO";
            $dia_rodizio = "QUARTA-FEIRA";
            $calendario_ipva = ["28/Jan", "04/Mar", "05/Abr"];        
            break;
        case 6:
            $mes_limite = "SETEMBRO";
            $dia_rodizio = "QUARTA-FEIRA";
            $calendario_ipva = ["31/Jan", "07/Mar", "06/Abr"];        
            break;
        case 7:
            $mes_limite = "OUTUBRO";
            $dia_rodizio = "QUINTA-FEIRA";
            $calendario_ipva = ["01/Fev", "08/Mar", "07/Abr"];        
            break;
        case 8:
            $mes_limite = "OUTUBRO";
            $dia_rodizio = "QUINTA-FEIRA";
            $calendario_ipva = ["02/Fev", "09/Mar", "08/Abr"];        
            break;
        case 9:
            $mes_limite = "NOVEMBRO";
            $dia_rodizio = "SEXTA-FEIRA";
            $calendario_ipva = ["03/Fev", "10/Mar", "11/Abr"];        
            break;        
        default:
            echo "Numero inválido";
            break;
    }
    ?>
    <a href="index.php">&#8617;</a>
    <img src="images/carros.png" alt="Carros">
    <table>
        <tr>
            <td>MÊS LIMITE <br>PARA PAGAMENTO<br> DO LICENCIAMENTO</td>
            <td colspan="2"><?php echo $mes_limite ?></td>
        </tr>
        <tr>
            <td>DIA DO RODÍZIO SP</td>
            <td colspan="2"><?php echo $dia_rodizio ?></td>
        </tr>
        <tr>
            <td rowspan="3">CALENDARIO IPVA</td>
            <td>1° PARCELA</td>
            <td><?php echo $calendario_ipva[0] ?></td>
        </tr>
        <tr>
            <td>2° PARCELA</td>
            <td><?php echo $calendario_ipva[1] ?></td>
        </tr>
        <tr>
            <td>3° PARCELA</td>
            <td><?php echo $calendario_ipva[2] ?></td>
        </tr>
    </table>
</body>
</html>

