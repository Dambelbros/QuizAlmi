<?php
    var_dump($_POST);
    require('../php/bbdd.php');
    actualizar_trabajador_admin_con_contrasena($_POST["type"], $_POST["nombre"], $_POST["apellido"], $_POST["txtFechaNac"], $_POST["password"], $_POST["dni"], $_POST["salario_bruto"], $_POST["fecha_inicio_contrato"], $_POST["fecha_fin_contrato"]);
    header('Location: ../listadoTrabajadores.php');