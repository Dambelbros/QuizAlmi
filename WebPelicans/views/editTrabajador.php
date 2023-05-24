
<?php
include_once('php/bbdd.php');
$trab = null;
$url = "";
if (isset($_GET["trab"])) {
    $trab = get_trabajador($_GET["trab"]);
    $url = '?trab=' . $_GET["trab"];
}
?>
<script src="js/jquery.js"></script>
<script src="js/editTrabajador.js"></script>
<link rel="stylesheet" href="css/paneles.css">
<div id="cuerpo" class="row mx-0 py-5 flex-column justify-content-center align-items-center position-relative background-secundary-color">
    <div id="box-form-edit" class="h-50 col-4 p-5 bg-light border text-center">
            <h3>Datos Trabajador</h3>
            <form id="myFormAlta" method="post" action="php/edit_trabajador.php"  enctype="multipart/form-data">
                <div id="avisos">
                </div>
                <input type="hidden" name="idTrabajador" value="<?php echo $_GET["trab"]?>" id="lblTrabajador">
                <div class="mb-3 text-start">                <label for="register-type" class="form-label">Puesto</label>
                <select class="form-select" name="type" id="register-type">
                    <option value="2" <?php if($trab['puesto'] == 2){ echo 'selected';}?>>Revisor</option>
                    <option value="1" <?php if($trab['puesto'] == 1){ echo 'selected';}?>>Gerente</option>
                </select>
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">DNI</label>
                <input type="text" class="form-control" name="dni" id="dni" readonly value="<?php echo $trab['dni']; ?>">
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Usuario</label>
                <input type="text" class="form-control" name="usuario" id="usuario" readonly value="<?php echo $trab['nombre_usuario']; ?>">
                <p id="usuario-error" class="error-message" style="display: none;"></p>
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Email</label>
                <input type="text" class="form-control" name="email" id="email" readonly value="<?php echo $trab['email']; ?>">
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Nombre</label>
                <input type="text" class="form-control" name="nombre" id="txtNombre" value="<?php echo $trab['nombre']; ?>">
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Apellido</label>
                <input type="text" class="form-control" name="apellido" id="txtApellido" value="<?php echo $trab['apellido']; ?>">
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Fecha Nacimiento</label>
                <input type="date" class="form-control" name="txtFechaNac" id="txtFechaNac" value="<?php echo $trab['fecha_nac']; ?>">
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Contraseña</label>
                <input type="password" class="form-control" name="password" id="txtCon" value="<?php echo $trab['contra']; ?>">
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Repite la contraseña</label>
                <input type="password" class="form-control" id="txtReCon" value="<?php echo $trab['contra']; ?>">
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Salario bruto anual</label>
                <input type="numeric" class="form-control" name="salario_bruto" id="txtSa" value="<?php echo $trab['salario']; ?>">
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Inicio de contrato</label>
                <input type="date" class="form-control" name="fecha_inicio_contrato" id="txtIniCon" value="<?php echo $trab['inicio_con']; ?>">
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Fin de contrato</label>
                <input type="date" class="form-control" name="fecha_fin_contrato" id="txtFinCon" value="<?php echo $trab['fin_con']; ?>">
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