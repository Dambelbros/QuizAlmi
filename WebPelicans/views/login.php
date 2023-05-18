<?php
    ini_set('display_errors', 1);
    //include_once "php/checksesion.php";
?>
<div id="cuerpo" class="row mx-0 py-5 flex-column justify-content-center align-items-center position-relative background-secundary-color">
    <div id="box-form-perfil" class="h-50 col-4 p-5 bg-light border text-center" style="margin-bottom: 180px; background-secundary-color">
            <h3>Login</h3>
        <form method="post" id="myFormAlta" action="back_login.php">
            <div class="mb-3 text-start">
                <label class="form-label">Usuario</label>
                <input type="text" class="form-control" name="nombre_usuario" id="nombre_usuario">
            </div>
            <div class="mb-3 text-start">
                <label class="form-label">Contraseña</label>
                <input type="password" class="form-control" name="password" id="login-password">
            </div>
            <div class="d-flex justify-content-end">
                <button type="submit" class="btn" id="login">Iniciar Sesión</button>
            </div>
        </form>
    </div>
</div>