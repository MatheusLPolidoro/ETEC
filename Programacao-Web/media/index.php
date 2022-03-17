<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Média</title>
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
        }
        input{
            padding: 5px;
            font-size: 16px;
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
</head>
<body>
    <h1>MÉDIA DE NOTA</h1>
    <form action="recebe.php" method="post">
        <span>Informe a primeira nota:</span><br>
        <input type="number" name="nota1" step="any" required="required">
        <br><br>

        <span>Informe a segunda nota:</span><br>
        <input type="number" name="nota2" step="any" required="required">
        <br><br>

        <span>Informe a terceira nota:</span><br>
        <input type="number" name="nota3" step="any" required="required">
        <br><br>

        <span>Informe a quarta nota:</span><br>
        <input type="number" name="nota4" step="any" required="required">
        <br><br>

        <input class="botao" type="submit" value="Calcular">
    </form>
</body>
</html>