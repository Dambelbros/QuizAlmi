<script src="js/jquery.js"></script>
<script src="js/altaTrabajadorTest.js"></script>
<div id="cuerpo" class="row mx-0 py-5 flex-column justify-content-center align-items-center position-relative background-secundary-color">
    <div id="box-form" class="h-50 col-4 p-5 bg-light border text-center">
        <h3>Únete a nosotros</h3>
        <form id="myFormAlta">
            <div id="avisos">
            </div>
            <div class="mb-3 text-start">
                <label for="register-type" class="form-label">Puesto</label>
                <select class="form-select" name="type" id="register-type">
                    <option value="2">Revisor</option>
                    <option value="1">Gerente</option>
                </select>
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">DNI</label>
                <input type="text" class="form-control" name="dni" id="txtDni">
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Usuario</label>
                <input type="text" class="form-control" name="usuario" id="txtUsuario">
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Email</label>
                <input type="text" class="form-control" name="email" id="txtEmail">
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Nombre</label>
                <input type="text" class="form-control" name="nombre" id="txtNombre">
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Apellido</label>
                <input type="text" class="form-control" name="apellido" id="txtApellido">
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Fecha Nacimiento</label>
                <input type="date" class="form-control" name="fecha_nacimiento" id="txtFechaNac">
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Contraseña</label>
                <input type="password" class="form-control" name="password" id="txtCon">
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Repite la contraseña</label>
                <input type="password" class="form-control" id="txtReCon">
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Salario bruto anual</label>
                <input type="numeric" class="form-control" name="salario_bruto" id="txtSa">
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Inicio de contrato</label>
                <input type="date" class="form-control" name="fecha_inicio_contrato" id="txtIniCon">
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Fin de contrato</label>
                <input type="date" class="form-control" name="fecha_fin_contrato" id="txtFinCon">
            </div>
            <button type="submit" class="btn" id="enviarAlta">Enviar</button>
        </form>
    </div>
</div>
