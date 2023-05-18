<?php
    var_dump($_GET);

    $url = 'http://192.168.0.120:8080/api/pregunta/' . $_GET["preg"];

    $curl = curl_init($url);
    curl_setopt($curl, CURLOPT_CUSTOMREQUEST, 'DELETE');
    curl_setopt($curl, CURLOPT_RETURNTRANSFER, true);

    $response = curl_exec($curl);
    curl_close($curl);

    header('Location:listado.php');