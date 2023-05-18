<script src="js/alta.js"></script>
<div id="cuerpo" class="row mx-0 py-5 flex-column justify-content-center align-items-center position-relative background-secundary-color">
    <div id="box-form" class="h-50 col-4 p-5 bg-light border text-center">
            <h3>Nueva pregunta</h3>
            <form id="myFormAlta" method="post" action="back_anadir_pregunta.php" enctype="multipart/form-data">
                <div class="mb-3 text-start">
                    <label class="form-label">Titulo</label>
                    <input type="text" class="form-control" id="pregunta" name="titulo">
                </div>
                <div class="mb-3 text-start">
                    <label class="form-label">Tema</label>
                    <input type="text" class="form-control" id="respuesta" name="tema">
                </div>
                <div class="mb-3 text-start">
                    <label class="form-label">Dificultad</label>
                    <input type="text" class="form-control" id="respuesta" name="dificultad">
                </div>
                <div class="mb-3 text-start">
                    <label class="form-label">Autor</label>
                    <input type="text" class="form-control" id="respuesta" name="autor">
                </div>
                <div class="mb-3 text-start">
                    <label class="form-label">Aclaracion</label>
                    <input type="text" class="form-control" id="respuesta" name="aclaracion">
                </div>
                <div class="mb-3 text-start">
                    <label class="form-label">Respuesta</label>
                    <input type="text" class="respuesta form-control my-2" placeholder="Primera respuesta (Correcta)" name="respuesta[]" value="">
                    <input type="text" class="respuesta form-control my-2" placeholder="Segunda respuesta (Falsa)" name="respuesta[]" value="">
                    <input type="text" class="respuesta form-control my-2" placeholder="Tercera respuesta (Falsa)" name="respuesta[]" value="">
                    <input type="text" class="respuesta form-control my-2" placeholder="Cuarta respuesta (Falsa)" name="respuesta[]" value="">
                </div>
                <div class="mb-3 text-start">
                    <label class="form-label">Imagen</label>
                    <input type="file" class="form-control" id="respuesta" name="foto">
                </div>
                <button type="submit" class="btn" id="enviarAlta">Enviar</button>
            </form>
    </div>
</div>