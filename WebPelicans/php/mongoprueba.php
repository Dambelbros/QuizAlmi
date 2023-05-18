<?php

require 'vendor/autoload.php';

// Conexión a MongoDB
$mongoClient = new MongoDB\Client("mongodb://localhost:27017");
$database = $mongoClient->myDatabase;
$collection = $database->preguntas;


function insertarPregunta($pregunta, $respuestas) {
    global $collection;
    
    $documento = array(
        "pregunta" => $pregunta,
        "respuestas" => $respuestas
    );
    
    $insertResult = $collection->insertOne($documento);
    
    if ($insertResult->getInsertedCount() > 0) {
        echo "Pregunta insertada con éxito. ID: " . $insertResult->getInsertedId() . "\n";
    } else {
        echo "Error al insertar la pregunta.\n";
    }
}

function modificarPregunta($id, $nuevaPregunta) {
    global $collection;
    
    $updateResult = $collection->updateOne(
        ["_id" => new MongoDB\BSON\ObjectID($id)],
        ['$set' => ["pregunta" => $nuevaPregunta]]
    );
    
    if ($updateResult->getModifiedCount() > 0) {
        echo "Pregunta modificada con éxito.\n";
    } else {
        echo "No se encontró la pregunta o no se realizaron cambios.\n";
    }
}

function borrarPregunta($id) {
    global $collection;
    
    $deleteResult = $collection->deleteOne(["_id" => new MongoDB\BSON\ObjectID($id)]);
    
    if ($deleteResult->getDeletedCount() > 0) {
        echo "Pregunta borrada con éxito.\n";
    } else {
        echo "No se encontró la pregunta.\n";
    }
}

// Ejemplos de uso

// Insertar una pregunta
//insertarPregunta("¿Cuál es la capital de Francia?", ["A" => "París", "B" => "Madrid", "C" => "Londres"]);

// Modificar una pregunta
//modificarPregunta("606defb34e19902b0068edae", "¿Cuál es la capital de España?");

// Borrar una pregunta
//borrarPregunta("606defb34e19902b0068edae");

?>