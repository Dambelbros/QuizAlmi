<script src="js/jquery.js"></script>
<script src="js/inicio.js"></script>
<div id="cuerpo" class="row mx-0 py-5 flex-column justify-content-center align-items-center position-relative background-secundary-color">
    <div id="image1" style="position: absolute;width: 150px;height: 150px;z-index: 0;top: 5%;left: 31%;background-image: url(img/quienQuiereSerMillonario.png);background-size: contain;background-repeat: no-repeat;"></div>
    <div id="image2" style="position: absolute;width: 300px;height: 300px;z-index: 0;top: 1%;left: 55%;background-image: url(img/quienQuiereSerMillonario.png);background-size: contain;background-repeat: no-repeat;"></div>
    <div id="image3" style="position: absolute;width: 350px;height: 350px;z-index: 0;top: 16%;left: 30%;background-image: url(img/quienQuiereSerMillonario.png);background-size: contain;background-repeat: no-repeat;"></div>
<div id="image4" style="position: absolute;width: 230px;height: 230px;z-index: 0;top: 27%;left: 56%;background-image: url(img/quienQuiereSerMillonario.png);background-size: contain;background-repeat: no-repeat;"></div>
    <div id="box-form" class="h-50 col-4 p-5 bg-light border my-3 text-center">
        <h3>Añade tu pregunta</h3>
        <form>
        <div class="mb-3 text-start">
            <label class="form-label">Pregunta</label>
            <input type="text" class="form-control" id="pregunta">
        </div>
        <div class="mb-3 text-start">
            <label class="form-label">Respuesta</label>
            <input type="text" class="form-control" id="respuesta">
        </div>
        <button type="submit" class="btn">Enviar</button>
        </form>
    </div>
    <div id="box-tops" class="col-4 text-center p-5">
        <h3 class="white">TOP 10</h3>
        <ul class="listadoTopDiez">
        </ul>
    </div>
</div>