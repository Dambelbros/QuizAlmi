<?php
ini_set('display_errors', 1);
include_once "bbdd.php";

session_start();

var_dump($_POST);

if (strlen($_POST["txtCon"]) == 0) {
    actualizar_trabajador_sin_contrasena($_POST["txtNombre"], $_POST["txtApellido"], $_POST["txtFecha"], $_POST["txtDni"]);
} else {
    actualizar_trabajador_con_contrasena($_POST["txtNombre"], $_POST["txtApellido"], $_POST["txtFecha"], $_POST["txtCon"], $_POST["txtDni"]);
}

header('Location: ../listado.php');

/*
// Si no está logeado, lo redirige al login
if (!$_SESSION['nombre_usuario']) {
    header("location: index.php");
} else {
    // Verifica si se ha enviado el formulario
    if (isset($_POST['submit'])) {
        // Recupera los valores del formulario
        $id_trabajador = $_POST['id_trabajador'];
        $dni = $_POST['dni'];
        $nombre = $_POST['nombre'];
        $apellido = $_POST['apellido'];
        $fecha_nac = $_POST['fecha_nacimiento'];
        $inicio_contrato = $_POST['fecha_inicio_contrato'];
        $fin_contrato = $_POST['fecha_fin_contrato'];

        $check_modify = update_trabajador($id_trabajador, $dni, $nombre, $apellido, $fecha_nac, $inicio_contrato, $fin_contrato);

        if ($check_modify) {
            $_SESSION['nombre_usuario'] = $_POST['nombre_usuario'];
            header("location: registro.php?id_trabajador=".$_SESSION['id_trabajador']."&success=1");
            exit;
        } else {
            header("location: registro.php?id_trabajador=".$_SESSION['id_trabajador']."&error=2");
            exit;
        }
    }
}
*/
?>
