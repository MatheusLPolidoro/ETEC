<?php
    session_start();
    unset($_SESSION["logado"]);
    header ("location: login.php");
?>