<?php
include_once "bbdd.php";

if (isset($_POST['id'])) {
    $idTrabajador = $_POST['id'];

  $resultado = delete_trabajador($idTrabajador);

  if ($resultado) {
    echo "Trabajador eliminado correctamente";
  } else {
    echo "Error al eliminar el trabajador";
  }
} else {
  echo "Falta el parámetro 'id'";
}
?>

