<?php
    var_dump($_POST);
    $url = 'http://192.168.0.120:8080/api/pregunta';

    $nombreImg = $_FILES['foto']['name'];
    $ruta = $_FILES['foto']['tmp_name'];

    $nombre = "";

    $caracteres = '0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ';
    $largo_caracteres = strlen($caracteres);
    $randomString = '';
    for ($i = 0; $i < 10; $i++) {
        $randomString .= $caracteres[random_int(0, $largo_caracteres - 1)];
    }

    $fecha = getdate();
    $nombre = $fecha['yday'] . '_' . $fecha['mon'] . '_' . $fecha['year'] . '_' . $fecha['hours'] . '_' . $fecha['minutes'] .  '_' . $fecha['seconds'] . '_' . $randomString . '_' . $nombreImg;

    $destino = "../fotos/" . $nombre;
    if (move_uploaded_file($ruta, $destino)) {
        $data = array(
            'titulo' => $_POST["titulo"],
            'tema' => $_POST["tema"],
            'dificultad' => $_POST["dificultad"],
            'autor' => $_POST["autor"],
            'aclaracion' => $_POST["aclaracion"],
            'respuestas' => $_POST["respuesta"],
            'estado' => $_POST["estado"],
            'foto' => '/fotos/' . $nombre
        );

        $jsonData = json_encode($data);
    
        $curl = curl_init($url);
    
        curl_setopt($curl, CURLOPT_POST, true);
        curl_setopt($curl, CURLOPT_POSTFIELDS, $jsonData);
        curl_setopt($curl, CURLOPT_RETURNTRANSFER, true);
        curl_setopt($curl, CURLOPT_HTTPHEADER, array(
            'Content-Type: application/json',
            'Content-Length: ' . strlen($jsonData)
        ));
        $response = curl_exec($curl);
    
        echo '<br>';
        echo '<br>';
    
        echo $response;
    
        curl_close($curl);

        if (isset($_GET["preg"])) {
            $url = 'http://192.168.0.120:8080/api/sugerencias/' . $_GET["preg"];

            $curl = curl_init($url);
            curl_setopt($curl, CURLOPT_CUSTOMREQUEST, 'DELETE');
            curl_setopt($curl, CURLOPT_RETURNTRANSFER, true);

            $response = curl_exec($curl);
            curl_close($curl);
        }
    }
    
    header('Location:listado.php');