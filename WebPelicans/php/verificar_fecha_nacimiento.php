<?php
$fechaNacimiento = $_POST['fecha_nacimiento'];

$fechaActual = date('Y-m-d');

if ($fechaNacimiento > $fechaActual) {
    echo 'posterior';
} else {
    echo 'valida';
}
?>
