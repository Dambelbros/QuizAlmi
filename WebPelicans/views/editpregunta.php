<script src="js/jquery.js"></script>
<script src="js/editar.js"></script>
<link rel="stylesheet" href="css/paneles.css">
<div id="cuerpo" class="row mx-0 py-5 flex-column justify-content-center align-items-center position-relative background-secundary-color">
    <div id="box-form-edit" class="h-50 col-4 p-5 bg-light border text-center">
            <h3>Editar pregunta</h3>
            <form id="myFormAlta" method="post" action="back_editar_pregunta.php"  enctype="multipart/form-data">
                <div id="avisos">
                </div>
                <input type="hidden" name="idPregunta" value="<?php echo $_GET["preg"]?>" id="lblPregunta">
                <div class="mb-3 text-start">
                    <label class="form-label">Titulo</label>
                    <input type="text" class="form-control" id="txtTitulo" name="titulo">
                </div>
                <div class="mb-3 text-start">
                    <label class="form-label">Tema</label>
                    <select class="form-control" name="tema" id="tbTema">
                        <option value="informatica">Informática</option>
                        <option value="cultura">Cultura General</option>
                    </select>
                </div>
                <div class="mb-3 text-start">
                    <label class="form-label">Dificultad</label>
                    <select class="form-control" id="tbDificultad" name="dificultad">
                        <option value="Facil">Facil</option>
                        <option value="Medio">Medio</option>
                        <option value="Dificil">Dificil</option>
                    </select>
                </div>
                <div class="mb-3 text-start">
                    <label class="form-label">Aclaracion</label>
                    <input type="text" class="form-control" id="txtAclaracion" name="aclaracion">
                </div>
                <div class="mb-3 text-start">
                    <label class="form-label">Respuesta</label>
                    <input type="text" class="respuesta form-control my-2" placeholder="Primera respuesta (Correcta)" name="respuesta[]" value="" id="txtRespUno">
                    <input type="text" class="respuesta form-control my-2" placeholder="Segunda respuesta (Falsa)" name="respuesta[]" value="" id="txtRespDos">
                    <input type="text" class="respuesta form-control my-2" placeholder="Tercera respuesta (Falsa)" name="respuesta[]" value="" id="txtRespTres">
                    <input type="text" class="respuesta form-control my-2" placeholder="Cuarta respuesta (Falsa)" name="respuesta[]" value="" id="txtRespCuatro">
                </div>
                <div class="mb-3 text-start">
                    <label class="form-label">Imagen</label>
                    <input type="file" class="form-control" id="respuesta" name="foto">
                </div>
                <div class="mb-3 text-start">
                    <label class="form-label">Estado</label>
                    <select class="form-control" name="estado" id="tbEstado">
                        <option value="mostrar">Mostrar</option>
                        <option value="ocultar">Ocultar</option>
                    </select>
                </div>
                <button type="submit" class="btn" id="enviarAlta">Aplicar Cambios</button>
            </form>
    </div>
</div>


<div id="panelConfirmacionActualizar">
    <h4>¿Estas seguro de actualizar la siguiente pregunta?</h4>
    <button id="btnCancelar">Cancelar</button>
    <button id="btnActualizar">Actualizar</button>
</div>