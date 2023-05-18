<?php
ini_set('display_errors', '1');
function connectBBDD() {

  $mysqli = new mysqli("127.0.0.1", "prueba", "Almi123", "trabajador");
  
    if($mysqli->connect_errno) {
        echo "Fallo en la conexión: ".$mysqli->connect_errno;
        exit;
    }
  
    return $mysqli;
}
function get_trabajador($id) {
    $conexion = connectBBDD();

    $sql = "SELECT id_trabajador, DNI, nombre, apellido, fecha_nacimiento, inicio_contrato, fin_contrato FROM trabajador WHERE id_trabajador = ?";
    $sentencia = $conexion->prepare($sql);

    if (!$sentencia) {
        echo "FALLO AL PREPARAR LA SENTENCIA: " . $conexion->errno;
    }

    $asignar = $sentencia->bind_param("i", $id);

    if (!$asignar) {
        echo "FALLO AL ASIGNAR LA SENTENCIA: " . $conexion->errno;
    }

    $ejecutar = $sentencia->execute();

    if (!$ejecutar) {
        echo "FALLO AL EJECUTAR LA SENTENCIA: " . $conexion->errno;
    }

    $devolver = Array();

    $vincular = $sentencia->bind_result($id_tra, $dni, $nombre, $apellido, $fecha_nac, $inicio_contrato, $fin_contrato);

    if (!$vincular) {
        echo "FALLO AL VINCULAR LOS DATOS DE LA SENTENCIA: " . $conexion->errno;
    }

    if ($sentencia->fetch()) {
        $devolver["id"] = $id_tra;
        $devolver["dni"] = $dni;
        $devolver["nombre"] = $nombre;
        $devolver["apellido"] = $apellido;
        $devolver["fecha_nac"] = $fecha_nac;
        $devolver["inicio_con"] = $inicio_contrato;
        $devolver["fin_con"] = $fin_contrato;
    } else {
        echo "FALLO AL EXTRAER LOS DATOS " . $conexion->errno;

    }

    $conexion->close();

    return $devolver;
}

function validar_login_usuario($usuario, $pass) {
    $conexion = connectBBDD();

    $sql = "SELECT id_trabajador, puesto, nombre_usuario FROM trabajador WHERE nombre_usuario = ? AND contrasena = ?";
    $sentencia = $conexion->prepare($sql);
    $asignar = $sentencia->bind_param("ss", $usuario, $pass);
    $ejecutar = $sentencia->execute();


    $sentencia->bind_result($id, $puesto, $nombre, $nombre_usuario);

    $data_user = [];
    if ($sentencia->fetch()) {
        $data_user['id_trabajador'] = $id;
        $data_user['puesto'] = $puesto;
        $data_user['nombre'] = $nombre;
        $data_user['nombre_usuario'] = $nombre_usuario;
    }

    $conexion->close();

    return $data_user;
}



function register_usuario($rol, $dni, $usuario, $email, $nombre, $apellido, $fecha_nacimiento, $password, $salario_bruto, $fecha_inicio_contrato, $fecha_fin_contrato) {

    $conexion = connectBBDD();

    $sql = "INSERT INTO trabajador (puesto, DNI, nombre_usuario, email, nombre, apellido, fecha_nacimiento, contrasena, salario, inicio_contrato, fin_contrato)
    VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

    $sentencia = $conexion->prepare($sql);

    if(!$sentencia) {
        echo "FALLO AL PREPARAR LA SENTENCIA: " . $conexion->errno;
    }

    $asignar = $sentencia->bind_param("sssssssssss", $rol, $dni, $usuario, $email, $nombre, $apellido, $fecha_nacimiento, $password, $salario_bruto, $fecha_inicio_contrato, $fecha_fin_contrato);

    if(!$asignar) {
        echo "FALLO AL ASIGNAR LA SENTENCIA: " . $conexion->errno;
    }

    $data_to_return = false;

    $ejecutar = $sentencia->execute();

    if(!$ejecutar) {
        echo "FALLO AL EJECUTAR LA SENTENCIA: " . $conexion->errno;
    } else {
        $data_to_return = true;
    }
    

    $conexion->close();

    return $data_to_return;

}




