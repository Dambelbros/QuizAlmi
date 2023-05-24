<?php
    if (isset($_SERVER['HTTP_ORIGIN'])) {
        header("Access-Control-Allow-Origin: {$_SERVER['HTTP_ORIGIN']}");
        header("Access-Control-Allow-Credentials: true");
        header("Access-Control-Max-Age: 86400");
    }

    if ($_SERVER['REQUEST_METHOD'] == 'OPTIONS') {
        if (isset($_SERVER['HTTP_ACCESS_CONTROL_REQUEST_METHOD'])) {
            header("Access-Control-Allow-Methods: GET, POST, DELETE, PUT, OPTIONS");
        }
        if (isset($_SEVER['HTTP_ACCESS_CONTROL_REQUEST_HEADERS'])) {
            header("Access-Control-Allow-Header: {$_SERVER['HTTP_ACCESS_CONTROL_REQUEST_HEADERS']}");
            exit(0);
        }
    }

    header('Content-Type: application/JSON');
    include_once('php/bbdd.php');

    if ($_POST["funcion"] == 'comprobardni'){
        echo json_encode(comprobar_dni($_POST["dni"]), JSON_UNESCAPED_UNICODE);
    }

    if ($_POST["funcion"] == 'comprobarUsuario'){
        echo json_encode(comprobar_usuario($_POST["usuario"]), JSON_UNESCAPED_UNICODE);
    }

    if ($_POST["funcion"] == 'comprobarEmail'){
        echo json_encode(comprobar_email($_POST["email"]), JSON_UNESCAPED_UNICODE);
    }