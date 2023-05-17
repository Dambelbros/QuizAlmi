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
    })
}

exports.todasPartidas = function(req, res){
    Partida.find().then(function(response){
        res.json({
            status: 'Ok',
            data: response
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
    })
}