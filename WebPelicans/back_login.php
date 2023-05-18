<?php
    require_once('php/bbdd.php');
    $usuario = validar_login_usuario($_POST["nombre_usuario"], $_POST["password"]);

    if ($usuario["id_trabajador"]) {
        session_start();
        $_SESSION["id"] = $usuario["id_trabajador"];
        $_SESSION["usuario"] = $usuario["nombre"];
        $_SESSION["puesto"] = $usuario["puesto"];
        header('Location: listado.php');
    } else {
        header('Location: login.php');
    }

