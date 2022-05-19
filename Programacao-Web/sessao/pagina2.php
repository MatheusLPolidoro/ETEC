<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Pagina 2</title>
</head>
<body>
    <h1>Pagina 2</h1>
    <?php 
    
    // Iniciando a sessao
    session_start();

    // Exibit valoers varriaveis da sessao
    echo $_SESSION['nome'];
    
    // Deletar variavel de sessao
    unset ($_SESSION['nome_variavel']);

    ?>
</body>
</html>