<?php
session_start();

require_once 'bbdd.php';

if(isset($_POST['nombre_usuario']) && isset($_POST['password']) && isset($_POST['type'])) {

    $username = $_POST['nombre_usuario'];

    $pass = $_POST['password'];

    $type = $_POST['type'];

    if ($type == 'gerente') {

        $data_user = validar_login_usuario_trabajador($username, $pass);

    } else if ($type == 'revisor') {

        $data_user = validar_login_usuario($_POST['nombre_usuario'], $pass);
        
    } else {
        // Tipo de usuario inválido
        echo "3";
        exit;
    }

    if(!isset($data_user['id_usuario']) || $data_user['id_usuario']=="") {
        // Usuario no encontrado
        echo "2";
        exit;
    } else {

        // Login exitoso
        if (isset($data_user['id_usuario'])) {
            $_SESSION['id_usuario'] = $data_user['id_usuario'];
            $_SESSION['nombre'] = $data_user['nombre'];
            $_SESSION['nombre_usuario'] = $data_user['nombre_usuario'];
            $_SESSION['puesto'] = $data_user['rol'];
        }

        echo "1";
        exit;
    }
} else {
    echo "0";
    exit;
}

?>