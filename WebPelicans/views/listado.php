<script src="js/jquery.js"></script>
<script src="js/listado.js"></script>
<link rel="stylesheet" href="css/paneles.css">
<?php echo '<p id="nombreUsu" style="display: none;">' . $_SESSION["nombre_usuario"] . '</p>'?>
<div id="cuerpo" class="row mx-0 py-5 flex-column justify-content-center align-items-center position-relative background-secundary-color">
</div>

<div id="panelConfirmacionEliminar">
    <h4>¿Estas seguro de eliminar la siguiente pregunta?</h4>
    <p id="lblPregunta"></p>
    <button id="btnCancelar">Cancelar</button>
    <button id="btnEliminar">Eliminar</button>
</div>