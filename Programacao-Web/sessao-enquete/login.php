<!DOCTYPE html>
<html lang="pt-BR">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <style>
        body {
            background-color: #212121;
            color: #9a99f5;
        }
        .container{
            margin-top: 100px;
        }
    </style>
</head>

<body>
    <div class="container">
        <div class="d-flex justify-content-center h-500">
            <div class="card">
                <div class="card-header">
                    <h3>Entrar</h3>
                </div>
                <div class="card-body">
                    <form method="post">
                        <div class="input-group form-group">
                            <input type="text" class="form-control" placeholder="usuário" name="usuario">
                        </div>
                        <div class="input-group form-group">
                            <input type="password" class="form-control" placeholder="senha" name="senha">
                        </div>
                        <div class="form-group">
                            <input type="submit" value="Login" class="btn float-right btn-success">
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
    <?php
    if ($_SERVER['REQUEST_METHOD'] === 'POST') {
        session_start();
        if ($_POST["usuario"] == "etec" && $_POST["senha"] == "1234") {
            $_SESSION["logado"] = "etec";
            header("location: index.php");
        } else {
            echo '<div class="d-flex justify-content-center h-500">';
            echo '<div class="alert alert-warning" role="alert">Usuário ou senha incorretos!</div>';
            echo '</div>';
        }
    }
    ?>

    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="Js/jquery-3.6.0.min.js"></script>
    <script src="Js/bootstrap.bundle.min.js"></script>
</body>

</html>