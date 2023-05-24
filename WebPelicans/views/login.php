<?php
    ini_set('display_errors', 1);
?>
<script src="js/jquery.js"></script>
<script src="js/login.js"></script>
<div id="cuerpo" class="row mx-0 py-5 flex-column justify-content-center align-items-center position-relative background-secundary-color">
    <div id="box-form-perfil" class="h-50 col-4 p-5 bg-light border text-center" style="margin-bottom: 180px; background-secundary-color">
            <h3>Login</h3>
        <form method="post" id="myFormAlta" action="">
            <div id="avisos">
            </div>
            <div class="mb-3 text-start">
            <label for="login-type" class="form-label">Tipo de usuario</label>
            <select class="form-select" name="type" id="login-type">
                <option value="gerente">gerente</option>
                <option value="revisor">revisor</option>
            </select>
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Usuario</label>
                <input type="text" class="form-control" name="nombre_usuario" id="txtNombre">
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Contraseña</label>
                <input type="password" class="form-control" name="password" id="txtContrasena">
            </div>
            <div class="d-flex justify-content-end">
                <button type="submit" class="btn" id="login">Iniciar Sesión</button>
            </div>
        </form>
    </div>
</div>