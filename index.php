<!DOCTYPE html>
<html lang="pt-BR">

    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Document</title>
    </head>

    <body>

        <form>
            Nome: <input type="text" name="nome" placeholder="Digite seu nome"><br><br>
            Idade: <input type="text" name="idade" placeholder="Digite sua idade"><br><br>
            Telefone: <input type="text" name="telefone" placeholder="Digite seu telefone"><br><br>
            CPF: <input type="text" name="cpf" placeholder="Digite seu CPF"><br><br>
            <input type="submit" name="submit" value="Me aperte!" /><br><br>
        </form>


        <?php
            // recebendo valores
            $nome = $_GET['nome'];
            $idade = $_GET['idade'];
            $telefone = $_GET['telefone'];
            $cpf = $_GET['cpf'];

            // mostrar
            echo "Nome: $nome<br>";
            echo "Idade: $idade<br>";
            echo "Telefone: $telefone<br>";
            echo "CPF: $cpf<br>";

            // print '<h1>Olá, mundo</h1>';

        ?>    


    </body>

</html>
