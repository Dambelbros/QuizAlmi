<?php
    ini_set('display_errors', 1);
    include_once "php/bbdd.php";
    $data_user = get_trabajador(1);
?>
<script src="js/jquery.js"></script>
<script src="js/perfil.js"></script>
<div id="cuerpo" class="row mx-0 py-5 flex-column justify-content-center align-items-center position-relative background-secundary-color">
    <div id="box-form-perfil" class="h-50 col-4 p-5 bg-light border text-center">
            <h3>Perfil</h3>
        <form method="post" id="myFormAlta" >
            <div id="formulario1">
                <div class="mb-3 text-start">
                    <label class="form-label">DNI</label>
                    <?php
                        echo '<input type="text" class="form-control" id="dni" readonly value="'.$data_user['dni'].'">';
                    ?>
                </div>
                <div class="mb-3 text-start">
                    <label class="form-label">Nombre</label>
                    <?php
                        echo '<input type="text" class="form-control" id="nombre" value="'.$data_user['nombre'].'">';
                    ?>
                </div>
                <div class="mb-3 text-start">
                    <label class="form-label">Apellido</label>
                    <?php
                        echo '<input type="text" class="form-control" id="apellido" value="'.$data_user['apellido'].'">';
                    ?>
                </div>
                <div class="mb-3 text-start">
                    <label class="form-label">Fecha Nacimiento</label>
                    <?php
                        echo '<input type="date" class="form-control" id="fecha_nac" value="'.$data_user['fecha_nac'].'">';
                    ?>
                </div>
                <div class="d-flex justify-content-end">
                    <button type="button" class="btn" id="siguientePerfil">Siguiente</button>
                </div>
            </div>
            
            <div id="formulario2" class="hidden">
                <div class="mb-3 text-start">
                    <label class="form-label">Fecha Inicio Contrato</label>
                    <?php
                        echo '<input type="date" class="form-control" id="ini_contrato" readonly value="'.$data_user['inicio_con'].'">';
                    ?>
                </div>
                <div class="mb-3 text-start">
                    <label class="form-label">Fecha Fin Contrato</label>
                    <?php
                        echo '<input type="date" class="form-control" id="fin_con" readonly value="'.$data_user['fin_con'].'">';
                    ?>
                </div>
                <div class="mb-3 text-start">
                    <label class="form-label">Contraseña</label>
                    <input type="password" class="form-control" id="password">
                </div>
                <div class="mb-3 text-start">
                    <label class="form-label">Repite Contraseña</label>
                    <input type="password" class="form-control" id="repassword">
                </div>
                <div class="d-flex justify-content-between">
                    <button type="button" class="btn" id="anteriorPerfil">Anterior</button>
                    <button type="submit" class="btn" id="confirmarPerfil">Aplicar cambios</button>
                </div>
            </div>
        </form>
    </div>
</div>