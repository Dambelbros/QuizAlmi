<?php
require_once 'bbdd.php';

$usuario = $_POST['usuario'];

if (verificarUsuario($usuario)) {
    echo 'existe';
} else {
    echo 'no_existe';
}
?>