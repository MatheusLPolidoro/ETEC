<nav class="navbar navbar-expand-lg navbar-dark bg-dark">
    <a class="navbar-brand" href="index.php">Enquete</a>
    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Alterna navegação">
        <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarNavDropdown">
        <ul class="navbar-nav">
            <li class="nav-item">
                <a class="nav-link" href="resultado.php">Vizualizar resultado</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="zerar.php">Zerar votos</a>
            </li>
        </ul>
    </div>
    <?php
    session_start();
    if (isset($_SESSION["logado"])) {
        echo "<p class='my-2 mr-2 my-sm-0 text-white'>" . $_SESSION["logado"] . "</p>";
        echo "<a class='btn btn-outline-success my-2 my-sm-0' href='sair.php'>Sair</a>";
    } else {
        header("location: login.php");
    }
    ?>
</nav>