<nav class="navbar navbar-expand-lg navbar-dark bg-dark">
  <a class="navbar-brand" href="#">Etec</a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Alterna navegação">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="navbarNav">
    <ul class="navbar-nav">
      <li class="nav-item active">
        <a class="nav-link" href="index.php">Início <span class="sr-only">(Página atual)</span></a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="sobre.php">Sobre</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="contato.php">Contato</a>
      </li>
      <li class="nav-item dropdown">
        <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-expanded="false">
          Fornecedores
        </a>
        <div class="dropdown-menu" aria-labelledby="navbarDropdown">
          <a class="dropdown-item" href="cadastrar_fornecedor.php">Cadastrar</a>
          <a class="dropdown-item" href="consultar_fornecedor.php">Consultar</a>
        </div>
      </li>
    </ul>
  </div>

  <?php
    if (isset($_SESSION["logado"])) {
      echo "<p class='my-2 mr-2 my-sm-0 text-white'>".$_SESSION["logado"]."</p>";
      echo "<a class='btn btn-outline-success my-2 my-sm-0' href='sair.php'>Sair</a>";
    }  
  ?>
</nav>