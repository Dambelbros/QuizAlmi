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

    $sql = "SELECT id_trabajador, DNI, nombre, apellido,  fecha_nacimiento, inicio_contrato, fin_contrato, nombre_usuario, email, salario, contrasena, puesto FROM trabajador WHERE id_trabajador = ?";
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

    $vincular = $sentencia->bind_result($id_tra, $dni, $nombre, $apellido, $fecha_nac, $inicio_contrato, $fin_contrato, $nombre_usuario, $email, $salario, $contrasena, $puesto);

    if (!$vincular) {
        echo "FALLO AL VINCULAR LOS DATOS DE LA SENTENCIA: " . $conexion->errno;
    }

    if ($sentencia->fetch()) {
        $devolver["id_trabajador"] = $id_tra;
        $devolver["dni"] = $dni;
        $devolver["nombre"] = $nombre;
        $devolver["apellido"] = $apellido;
        $devolver["fecha_nac"] = $fecha_nac;
        $devolver["inicio_con"] = $inicio_contrato;
        $devolver["fin_con"] = $fin_contrato;
        $devolver["nombre_usuario"] = $nombre_usuario;
        $devolver["email"] = $email;
        $devolver["salario"] = $salario;
        $devolver["contra"] = $contrasena;
        $devolver["puesto"] = $puesto;
    } else {
        echo "FALLO AL EXTRAER LOS DATOS " . $conexion->errno;

    }

    $conexion->close();

    return $devolver;
}

function update_trabajador($id, $dni, $nombre, $apellido, $fecha_nac, $inicio_contrato, $fin_contrato) {
    $conexion = connectBBDD();

    $sql = "UPDATE trabajador SET DNI = ?, nombre = ?, apellido = ?, fecha_nacimiento = ?, inicio_contrato = ?, fin_contrato = ? WHERE id_trabajador = ?";
    $sentencia = $conexion->prepare($sql);

    if (!$sentencia) {
        echo "FALLO AL PREPARAR LA SENTENCIA: " . $conexion->errno;
        return false;
    }

    $asignar = $sentencia->bind_param("ssssssi", $dni, $nombre, $apellido, $fecha_nac, $inicio_contrato, $fin_contrato, $id);

    if (!$asignar) {
        echo "FALLO AL ASIGNAR LA SENTENCIA: " . $conexion->errno;
        return false;
    }

    $ejecutar = $sentencia->execute();

    if (!$ejecutar) {
        echo "FALLO AL EJECUTAR LA SENTENCIA: " . $conexion->errno;
        return false;
    }

    $conexion->close();

    return true;
}

//TOMAMOS SU ID
function get_login_user($usuario, $pass) {

    $conexion = connectBBDD();

    $sql = "SELECT id_trabajador, nombre_usuario, password FROM trabajador WHERE nombre_usuario = ? AND password = ? ";

    $sentencia = $conexion->prepare($sql);

    if(!$sentencia) {
        echo "FALLO AL PREPARAR LA SENTENCIA: " . $conexion->errno;
    }

    $asignar = $sentencia->bind_param("ss", $usuario, $pass);

    if(!$asignar) {
        echo "FALLO AL ASIGNAR LA SENTENCIA: " . $conexion->errno;
    }

    $ejecutar = $sentencia->execute();

    if(!$ejecutar) {
        echo "FALLO AL EJECUTAR LA SENTENCIA: " . $conexion->errno;
    }

    $id_user_to_return = "";
    $user_to_return = "";
    $pass_to_return = "";

    $vincular = $sentencia->bind_result($id_user_to_return, $user_to_return, $pass_to_return);

    if(!$vincular) {
        echo "FALLO AL VINCULAR LOS DATOS DE LA SENTENCIA: " . $conexion->errno;
    }

    if(!$sentencia->fetch()) {
        $id_user_to_return = false;
        echo "FALLO AL EXTRAER LOS DATOS DE LA SENTENCIA EN LAS VARIABLES!! " . $conexion->errno;
    }

    $conexion->close();

    return $id_user_to_return;

}


function validar_login_usuario($usuario, $pass) {
    
    $conexion = connectBBDD();

    $sql = "SELECT id_trabajador, trabajador.nombre, nombre_usuario, puesto.nombre as rol FROM trabajador INNER JOIN puesto  ON trabajador.puesto = puesto.id_puesto WHERE puesto.nombre = 'revisor' AND nombre_usuario = ? AND contrasena = ? ";

    $sentencia = $conexion->prepare($sql);

    if(!$sentencia) {
        echo "FALLO AL PREPARAR LA SENTENCIA: " . $conexion->errno;
    }

    $asignar = $sentencia->bind_param("ss", $usuario, $pass);

    if(!$asignar) {
        echo "FALLO AL ASIGNAR LA SENTENCIA: " . $conexion->errno;
    }

    $ejecutar = $sentencia->execute();

    if(!$ejecutar) {
        echo "FALLO AL EJECUTAR LA SENTENCIA: " . $conexion->errno;
    }

    $id_trabajador = "";
    $nombre = "";
    $nombre_usuario = "";
    $puesto_nombre = "";

    $array_to_return = [];

    $vincular = $sentencia->bind_result($id_trabajador, $nombre, $nombre_usuario, $puesto_nombre);

    if(!$vincular) {
        echo "FALLO AL VINCULAR LOS DATOS DE LA SENTENCIA: " . $conexion->errno;
    }


    // CREAMOS UN ARRAY PARA ALMACENAR LOS RESULTADOS
    $data_user = [];

    $sentencia->fetch();

    $data_user['id_usuario'] = $id_trabajador;
    $data_user['nombre'] = $nombre;
    $data_user['nombre_usuario'] = $nombre_usuario;
    $data_user['rol'] = $puesto_nombre;

    // CERRAMOS LA CONEXIÓN
    $conexion->close();

    return $data_user;
}

function validar_login_usuario_trabajador($usuario, $pass) {
    
    $conexion = connectBBDD();

    $sql = "SELECT id_trabajador, trabajador.nombre, nombre_usuario, puesto.nombre as rol FROM trabajador INNER JOIN puesto  ON trabajador.puesto = puesto.id_puesto WHERE puesto.nombre = 'gerente' AND nombre_usuario = ? AND contrasena = ? ";

    $sentencia = $conexion->prepare($sql);

    if(!$sentencia) {
        echo "FALLO AL PREPARAR LA SENTENCIA: " . $conexion->errno;
    }

    $asignar = $sentencia->bind_param("ss", $usuario, $pass);

    if(!$asignar) {
        echo "FALLO AL ASIGNAR LA SENTENCIA: " . $conexion->errno;
    }

    $ejecutar = $sentencia->execute();

    if(!$ejecutar) {
        echo "FALLO AL EJECUTAR LA SENTENCIA: " . $conexion->errno;
    }

    $id_trabajador = "";
    $nombre = "";
    $nombre_usuario = "";
    $puesto_nombre = "";

    $array_to_return = [];

    $vincular = $sentencia->bind_result($id_trabajador, $nombre, $nombre_usuario, $puesto_nombre);

    if(!$vincular) {
        echo "FALLO AL VINCULAR LOS DATOS DE LA SENTENCIA: " . $conexion->errno;
    }


    // CREAMOS UN ARRAY PARA ALMACENAR LOS RESULTADOS
    $data_user = [];

    $sentencia->fetch();

    $data_user['id_usuario'] = $id_trabajador;
    $data_user['nombre'] = $nombre;
    $data_user['nombre_usuario'] = $nombre_usuario;
    $data_user['rol'] = $puesto_nombre;

    // CERRAMOS LA CONEXIÓN
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
        return false;
    }

    $asignar = $sentencia->bind_param("isssssssdss", $rol, $dni, $usuario, $email, $nombre, $apellido, $fecha_nacimiento, $password, $salario_bruto, $fecha_inicio_contrato, $fecha_fin_contrato);

    if(!$asignar) {
        echo "FALLO AL ASIGNAR LA SENTENCIA: " . $conexion->errno;
        return false;
    }

    $data_to_return = false;

    $ejecutar = $sentencia->execute();
    var_dump($sentencia->error);

    if(!$ejecutar) {
        echo "FALLO AL EJECUTAR LA SENTENCIA: " . $conexion->errno;
    } else {
        $data_to_return = true;
    }
    

    $conexion->close();

    return $data_to_return;

}

function delete_trabajador($id_trabajador) {
    $conexion = connectBBDD();

    $sql = "DELETE FROM trabajador WHERE id_trabajador = ?";
    $sentencia = $conexion->prepare($sql);

    if (!$sentencia) {
        echo "FALLO AL PREPARAR LA SENTENCIA: " . $conexion->errno . " - " . $conexion->error;
        return false;
    }

    $asignar = $sentencia->bind_param("i", $id_trabajador);

    if (!$asignar) {
        echo "FALLO AL ASIGNAR LA SENTENCIA: " . $sentencia->errno . " - " . $sentencia->error;
        return false;
    }

    $ejecutar = $sentencia->execute();

    if (!$ejecutar) {
        echo "FALLO AL EJECUTAR LA SENTENCIA: " . $sentencia->errno . " - " . $sentencia->error;
        return false;
    }

    $conexion->close();

    return true;
}


function get_all_trabajadores() {
    $conexion = connectBBDD();
    
    $sql = "SELECT id_trabajador, DNI, nombre, apellido, fecha_nacimiento, inicio_contrato, fin_contrato FROM trabajador";
    $resultado = $conexion->query($sql);
    
    if (!$resultado) {
        echo "FALLO AL EJECUTAR LA CONSULTA: " . $conexion->errno;
        return false;
    }
    
    $trabajadores = array();
    
    while ($fila = $resultado->fetch_assoc()) {
        $trabajador = array(
            "id" => $fila['id_trabajador'],
            "dni" => $fila['DNI'],
            "nombre" => $fila['nombre'],
            "apellido" => $fila['apellido'],
            "fecha_nacimiento" => $fila['fecha_nacimiento'],
            "inicio_contrato" => $fila['inicio_contrato'],
            "fin_contrato" => $fila['fin_contrato']
        );
        $trabajadores[] = $trabajador;
    }
    
    $conexion->close();
    
    return $trabajadores;
}



function guardar_pregunta($titulo, $respuestaCorrecta) {
    $conexion = connectBBDD();

    if (!$conexion) {
        echo "Error al conectar a la base de datos: " . mysqli_connect_error();
        return false;
    }

    $consulta = $conexion->prepare("INSERT INTO sugerencias (titulo, respuesta) VALUES (?, ?)");

    if (!$consulta) {
        echo "Error al preparar la consulta: " . $conexion->error;
        $conexion->close();
        return false;
    }

    $consulta->bind_param("ss", $titulo, $respuestaCorrecta);
  
    if (!$consulta->execute()) {
        echo "Error al ejecutar la consulta: " . $consulta->error;
        $consulta->close();
        $conexion->close();
        return false;
    }

    $idPregunta = $conexion->insert_id;

    $consulta->close();
    $conexion->close();

    return $idPregunta;
}


function obtener_preguntas() {
    $conexion = connectBBDD();

    $consulta = $conexion->prepare("SELECT id_sugerencias, titulo, respuesta FROM sugerencias");

    $consulta->execute();

    $resultados = $consulta->get_result()->fetch_all(MYSQLI_ASSOC);

    $consulta->close();
    $conexion->close();

    return $resultados;
}

function obtener_pregunta($id) {
    $conexion = connectBBDD();

    $sql = "SELECT id_sugerencias, titulo, respuesta FROM sugerencias WHERE id_sugerencias = ?";
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

    $vincular = $sentencia->bind_result($id_sugerencias, $titulo, $respuesta);

    if (!$vincular) {
        echo "FALLO AL VINCULAR LOS DATOS DE LA SENTENCIA: " . $conexion->errno;
    }

    if ($sentencia->fetch()) {
        $devolver["id_sugerencias"] = $id_sugerencias;
        $devolver["titulo"] = $titulo;
        $devolver["respuesta"] = $respuesta;
    } else {
        echo "FALLO AL EXTRAER LOS DATOS " . $conexion->errno;

    }

    $conexion->close();

    return $devolver;
}

function borrar_pregunta($id) {
    $conexion = connectBBDD();

    $sql = "DELETE FROM sugerencias WHERE id_sugerencias = ?";
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

    $conexion->close();

}

function generarBloquesTrabajadores() {
    $conexion = connectBBDD();

    $query = "SELECT trabajador.DNI, CONCAT(trabajador.nombre, ' ', trabajador.apellido) AS nombre_completo, trabajador.salario
              FROM trabajador
              INNER JOIN puesto ON trabajador.puesto = puesto.id_puesto
              WHERE puesto.nombre = 'revisor' AND salario > (
                SELECT AVG(salario)
                FROM trabajador
                INNER JOIN puesto ON trabajador.puesto = puesto.id_puesto
                WHERE puesto.nombre = 'revisor'
              ) ORDER BY salario DESC";

    $result = mysqli_query($conexion, $query);
    $bloquesHTML = "";
    while ($row = mysqli_fetch_assoc($result)) {
        $dni = $row['DNI'];
        $nombreCompleto = $row['nombre_completo'];
        $salario = $row['salario'];

        $bloquesHTML .= '
        <div class="row mx-0 border" style="border: 35px;">
            <div class="col-4 white">' . $dni . '</div>
            <div class="col-4 white">' . $nombreCompleto . '</div>
            <div class="col-4 white">' . $salario . '</div>
        </div>';
    }

    // Cerrar la conexión a la base de datos
    mysqli_close($conexion);

    // Devolver los bloques HTML generados
    return $bloquesHTML;
}

function actualizar_trabajador_sin_contrasena($nombre, $apellido, $fecha_nac, $dni)
    {
        $conexion = connectBBDD();
        $sql = "UPDATE trabajador SET nombre=?, apellido=?, fecha_nacimiento=? WHERE DNI=?";
        $sentencia = $conexion->prepare($sql);
        $sentencia->bind_param("ssss" , $nombre, $apellido, $fecha_nac, $dni);
        $sentencia->execute();
        $conexion->close();
    }

    function actualizar_trabajador_con_contrasena($nombre, $apellido, $fecha_nac, $contra, $dni)
    {
        $conexion = connectBBDD();
        $sql = "UPDATE trabajador SET nombre=?, apellido=?, fecha_nacimiento=?, contrasena=? WHERE DNI=?";
        $sentencia = $conexion->prepare($sql);
        $sentencia->bind_param("sssss" , $nombre, $apellido, $fecha_nac, $contra, $dni);
        $sentencia->execute();
        $conexion->close();
    }

    function comprobar_dni($id)
    {
        $conexion = connectBBDD();
        $sql = "SELECT COUNT(*) FROM trabajador WHERE DNI=?";
        $sentencia = $conexion->prepare($sql);
        $sentencia->bind_param('s', $id);
        $resultados = $sentencia->execute();

        $sentencia->bind_result($a);

        $cantidad = -1;

        while ($sentencia->fetch()) {
            $cantidad = $a;
        }

        $conexion->close();

        return $cantidad;
    }

    function comprobar_usuario($usuario)
    {
        $conexion = connectBBDD();
        $sql = "SELECT COUNT(*) FROM trabajador WHERE nombre_usuario=?";
        $sentencia = $conexion->prepare($sql);
        $sentencia->bind_param('s', $usuario);
        $resultados = $sentencia->execute();

        $sentencia->bind_result($a);

        $cantidad = -1;

        while ($sentencia->fetch()) {
            $cantidad = $a;
        }

        $conexion->close();

        return $cantidad;
    }

    function comprobar_email($email)
    {
        $conexion = connectBBDD();
        $sql = "SELECT COUNT(*) FROM trabajador WHERE email=?";
        $sentencia = $conexion->prepare($sql);
        $sentencia->bind_param('s', $email);
        $resultados = $sentencia->execute();

        $sentencia->bind_result($a);

        $cantidad = -1;

        while ($sentencia->fetch()) {
            $cantidad = $a;
        }

        $conexion->close();

        return $cantidad;
    }

    function actualizar_trabajador_admin_con_contrasena($puesto, $nombre, $apellido, $fecha_nac, $contra, $dni, $salario, $inicio_contrato, $fin_contrato)
    {
        $conexion = connectBBDD();
        $sql = "UPDATE trabajador SET puesto=?, nombre=?, apellido=?, fecha_nacimiento=?, contrasena=?, salario=?, inicio_contrato=?, fin_contrato=? WHERE DNI=?";
        $sentencia = $conexion->prepare($sql);
        $sentencia->bind_param("issssdsss", $puesto, $nombre, $apellido, $fecha_nac, $contra, $salario, $inicio_contrato, $fin_contrato, $dni);
        $sentencia->execute();
        $conexion->close();
    }