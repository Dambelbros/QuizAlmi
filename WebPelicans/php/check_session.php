<?php
    session_start();

    if (!isset($page)) {
        die("<h1>NO TENGO LA VARIABLE \$pagina DECLARADA</h1>");
    }

    if($page == "registro" || $page == "revision" || $page == "edit_pregunta" || $page == "edit_perfil") {

        if (!isset($_SESSION['id_usuario'])) {
            header('location: login.php');
        }
        
    }
?>