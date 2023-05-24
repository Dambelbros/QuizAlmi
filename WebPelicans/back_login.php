<?php
    session_start();
    require_once('php/bbdd.php');

    if(isset($_POST['nombre_usuario']) && isset($_POST['password'])) {
        $username = $_POST['nombre_usuario'];
        $pass = $_POST['password'];

        $data_user = validar_login_usuario($username, $pass);

        if(!isset($data_user['id_trabajador']) || $data_user['id_trabajador'] == "") {
            // Usuario no encontrado
            echo "2";
            exit;
        } else {
            // Login exitoso
            $_SESSION['id'] = $data_user['id_trabajador'];
            $_SESSION['usuario'] = $data_user['nombre'];
            $_SESSION['puesto'] = $data_user['puesto'];

            // Verificar el puesto
            if ($_SESSION['puesto'] == 1) {
                header('Location: index.php');
            } elseif ($_SESSION['puesto'] == 2) {
                header('Location: index.php');
            } else {
                // Puesto invalido
                echo "Puesto inválido";
                exit;
            }
        }
    } else {
        echo "No logueado";
        exit;
    }
?>
