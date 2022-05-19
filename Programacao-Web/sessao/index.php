<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Pagina 1</title>
</head>
<body>
    <h1>Pagina 1</h1>
    
    <form method="POST" action="">
        <label for="nome">Nome: </label>
        <input type="text" name="nome">
        <input type="submit">
    </form>
    <?php 
    
    // Iniciando a sessao
    session_start();

    if ($_SERVER['REQUEST_METHOD'] === 'POST') {
        // Criando uma variavel na sessao
        $_SESSION['nome'] = $_POST['nome'];
    }
    ?>
</body>
</html>