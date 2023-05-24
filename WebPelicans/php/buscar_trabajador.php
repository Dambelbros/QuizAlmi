<?php
include_once "bbdd.php";

$nombre = $_POST['inputTrabajador'];

$trabajador = get_trabajador($nombre);

echo json_encode($trabajador);
?>
