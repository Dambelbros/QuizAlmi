<script src="js/jquery.js"></script>
<script src="js/mostrarSugerencias.js"></script>

<?php
include_once "php/bbdd.php";

$preguntas = obtener_preguntas();
?>
<div id="cuerpo" class="row mx-0 py-5 flex-column justify-content-center align-items-center position-relative background-secundary-color">
</div>

<div id="panelConfirmacionEliminar">
    <h4>¿Estas seguro de eliminar la siguiente pregunta?</h4>
    <p id="lblPregunta"></p>
    <button id="btnCancelar">Cancelar</button>
    <button id="btnEliminar">Eliminar</button>
</div>