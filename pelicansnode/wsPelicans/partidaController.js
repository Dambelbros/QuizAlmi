Partida = require('./partidaModel')
let mongoose = require('mongoose');

exports.anadirPartida = function(req, res){
    tempPreguntas = [] 

    tempPartida = new Partida()
    tempPartida.jugador = req.body.nombre
    tempPartida.puntos = req.body.puntos
    req.body.data.forEach(function(pregunta){
        tempPregunta = {
            _id : mongoose.Types.ObjectId(pregunta[0]),
            acertado : pregunta[1]
        }

        tempPreguntas.push(tempPregunta)
    });

    tempPartida.preguntas = tempPreguntas

    tempPartida.save().then(function(response){
        res.json({
            ok: "Ok",
            data: response
        })
    }).catch(function(error){
        res.json({
            status: 'Error',
            data: []
        })
    })
}

exports.todasPartidas = function(req, res){
    Partida.find().then(function(response){
        res.json({
            status: 'Ok',
            data: response
        })
    }).catch(function(error){
        res.json({
            status: 'Error',
            data: []
        })
    })
}

exports.leerPartida = function(req, res){
    Partida.findById(req.params.idPartida).then(function(response){
        res.json({
            status: 'Ok',
            data: response
        })
    })
}

exports.topJugadas = function(req, res){
    Partida.find().sort({ puntos: -1 }).limit(10).then(function(response){
        res.json({
            status: 'Ok',
            data: response
        })
    }).catch(function(error){
        res.json({
            status: 'Error',
            data: []
        })
    })
}

exports.preguntasPartida = function(req, res){
    Partida.aggregate([
        {
          $match: {
            _id: mongoose.Types.ObjectId(req.params.id)
          }
        },
        {
          $lookup: {
            from: 'pelicans',
            localField: 'preguntas._id',
            foreignField: '_id',
            as: 'preg'
          }
        },
        {
            $unset: [ "preg.tema", "preg.dificultad", "preg.autor", "preg.aclaracion", "preg.respuestas", "preg.foto", "preg.estado", "preg._id" ]
        }
    ]).then(function(response){
        res.json({
            status: 'Ok',
            data: response
        })
    })
}