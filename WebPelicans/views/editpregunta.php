<script src="js/jquery.js"></script>
<script src="js/alta.js"></script>
<div id="cuerpo" class="row mx-0 py-5 flex-column justify-content-center align-items-center position-relative background-secundary-color">
    <div id="box-form-edit" class="h-50 col-4 p-5 bg-light border text-center">
            <h3>Editar pregunta</h3>
            <form id="myFormAlta">
                <input type="hidden" name="idPregunta" value="<?php echo $_GET["preg"]?>" id="lblPregunta">
                <div class="mb-3 text-start">
                    <label class="form-label">Titulo</label>
                    <input type="text" class="form-control" id="txtTitulo">
                </div>
                <div class="mb-3 text-start">
                    <label class="form-label">Tema</label>
                    <input type="text" class="form-control" id="txtTema">
                </div>
                <div class="mb-3 text-start">
                    <label class="form-label">Dificultad</label>
                    <input type="text" class="form-control" id="txtDificultad">
                </div>
                <div class="mb-3 text-start">
                    <label class="form-label">Autor</label>
                    <input type="text" class="form-control" id="txtAutor" readonly>
                </div>
                <div class="mb-3 text-start">
                    <label class="form-label">Aclaracion</label>
                    <input type="text" class="form-control" id="txtAclaracion">
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
                    <input type="file" class="form-control" id="respuesta">
                </div>
                <button type="submit" class="btn" id="enviarAlta">Aplicar Cambios</button>
            </form>
    </div>
</div>