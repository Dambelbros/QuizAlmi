<?php
session_start();

require_once 'bbdd.php';

$rol = $_POST['type'];
$dni = $_POST['dni'];
$usuario = $_POST['usuario'];
$email = $_POST['email'];
$nombre = $_POST['nombre'];
$apellido = $_POST['apellido'];
$fecha_nacimiento = $_POST['fecha_nacimiento'];
$password = $_POST['password'];
$salario_bruto = $_POST['salario_bruto'];
$fecha_inicio_contrato = $_POST['fecha_inicio_contrato'];
$fecha_fin_contrato = $_POST['fecha_fin_contrato'];



$valid_register = register_usuario($rol, $dni, $usuario, $email, $nombre, $apellido, $fecha_nacimiento, $password, $salario_bruto, $fecha_inicio_contrato, $fecha_fin_contrato);

if ($valid_register) {
    echo "1";
} else {
    echo "0";
}