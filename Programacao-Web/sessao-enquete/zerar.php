<?php
    session_start();
        foreach ($_SESSION["enquete"] as &$questao) {
        $init = True;
        foreach ($questao as &$opcao) {
            if (!$init) {
                unset($_SESSION[$opcao]);
            } else {
                $init = False;
            }
        }
    }

    header("Location:resultado.php");
?>