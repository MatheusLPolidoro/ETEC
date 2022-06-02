<?php
    session_start();
    unset($_SESSION["respostas"]);
    header("Location:index.php");
?>