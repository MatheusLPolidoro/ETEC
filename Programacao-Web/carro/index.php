<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width='device-width', initial-scale=1.0">
    <title>Consulta Carro</title>
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
    select, input{
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
    <h1>Informe sua placa</h1>
    <br><br>
    <form action="recebe.php" method="post">
        <select name="placa">
            <option value="0">0</option>
            <option value="1">1</option>
            <option value="2">2</option>
            <option value="3">3</option>
            <option value="4">4</option>
            <option value="5">5</option>
            <option value="6">6</option>
            <option value="7">7</option>
            <option value="8">8</option>
            <option value="9">9</option>
        </select>
        <br><br>
        <input type="submit" value="VERIFICAR" class="botao">
    </form>
</body>
</html>