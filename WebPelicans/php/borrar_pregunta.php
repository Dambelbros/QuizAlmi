<?php
if (isset($_GET['id'])) {
    $url = 'http://192.168.0.120:8080/api/sugerencias/' . $_GET["id"];

    $curl = curl_init($url);
    curl_setopt($curl, CURLOPT_CUSTOMREQUEST, 'DELETE');
    curl_setopt($curl, CURLOPT_RETURNTRANSFER, true);

    $response = curl_exec($curl);
    curl_close($curl);
    
} else {
    echo "error";
}

header("Location: ../revision.php");
?>
