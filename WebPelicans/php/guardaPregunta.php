<?php
require_once 'bbdd.php';
// Obtener los datos del formulario
$titulo = $_POST['pregunta'];
$respuestaCorrecta = $_POST['respuesta'];

// Guardar la pregunta en la base de datos
$idPregunta = guardar_pregunta($titulo, $respuestaCorrecta);

if ($idPregunta) {
    echo "1";
} else {
    echo "0";
}
?>
