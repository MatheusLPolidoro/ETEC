<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Página Cadastro</title>
</head>
<body>
    <a href="index.php">Voltar para o início</a>
    <form action="" method="POST">
        <fieldset>
            <legend><h1>Cadastrar Post</h1></legend>
            <label for="titulo">Título:</label><br>
            <input type="text" id="titulo"><br>
            <label for="texto">Texto:</label><br>
            <textarea id="texto" row="3">
            </textarea><br>
            <label for="imagem">Imagem:</label><br>
            <input type="text" id="imagem"><br>
            <label for="data">Data:</label><br>
            <input type="date" id="data"><br><br>
            <input type="submit" id="data" value="Gravar">
        </fieldset>
    </form>
</body>
</html>