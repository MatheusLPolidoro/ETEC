<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Calculadora Restaurante</title>
    <style>
        h1{
            color: red;
            font-family: Arial, Helvetica, sans-serif;
        }
        span{
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form action="recebe.php" method="post">
        <h1>CALCULADORA RESTAURANTE</h1>  
        <span>Valor Conta: </span><br>
        <input type="number" name="valorConta" step="any">
        <br><br>
        <span>Quantidade de Pessoas: </span><br>
        <input type="number" name="qtdPessoas">
        <br><br>
        <input type="submit" value="Calcular">
    </form>
</body>
</html>