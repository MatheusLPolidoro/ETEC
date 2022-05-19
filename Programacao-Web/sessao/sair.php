<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Sair</title>
</head>
<body>
    <?php 
    
    // Iniciando sessao
    session_start();

    // Deletar todas as variaveis de sessao
    session_destroy();

    //  Redirecionamento automatico
    header('location:index.php');

    ?>
</body>
</html>