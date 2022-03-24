<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Conversão de Medidas</title>
</head>
<style>
    body{
        margin-top: 8%;
        margin: 50 auto;
        align:center;
        text-align:center;
    }
    h1{
        color: #4CAF50;
        font-family: Arial, Helvetica, sans-serif;
    }
    form{
        /* topo | direita | inferior | esquerda */
        margin: 0 40% 0 40%;
        padding: 2%;
        border-style: solid;
        border-color: #4CAF50;
        border-radius: 10px;
        transition: all ease .2s;
    }
    span{
        font-family: Arial, Helvetica, sans-serif;
        font-size: 18px;
    }
    .botao {
        background-color: #4CAF50; /* Green */
        border: none;
        color: white;
        padding: 10px 32px;
        text-align: center;
        text-decoration: none;
        display: inline-block;
        font-size: 16px;
        transition: all ease .2s;
        width: 75%px
    }
    input{
        padding: 5px;
        font-size: 16px;
        width: 70%;
    }
    .botao:hover {
        background-color: #4C50AF; /* blue */
        transition: all ease .2s;
    }
    form:hover{
        border-color: #4C50AF; /* blue */
        transition: all ease .2s;
    }
</style>
<body>
    <h1></h1>    
    <form action="recebe.php" method="post">
        <span>Informe o valor a ser convertido</span>
        <br><br>
        <input type="number" name="medida" step="any" required>
        <br><br>
        <input class="botao" type="submit" value="Calcular">
    </form>
</body>
</html>
