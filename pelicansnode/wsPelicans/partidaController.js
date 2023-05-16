Partida = require('./partidaModel')

exports.test = function(req, res){
    console.log(req.body)

    res.json({
        ok: "Ok"
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

exports.anadirPartida = function(req, res){
    tempPartida = new Partida();
    errores = Array()
    if(req.body.jugador == ""){
        errores.append('El jugador no pude estar vacio');
    }
    contador = 0;
    req.body.respuestas.forEach(function(respuesta){
        contador++;
    });

    if (req.body.preguntas == "" || contador != 15) {
        errores.append('Las preguntas no son correctas');
    }
    
    if (req.body.puntos == "") {
        errores.append('Los puntos no pude estar vacio');
    }

    if (errores.length >= 1) {
        res.json({
            status: 'Fail',
            data: errores
        } )
    } else {
        tempPartida.jugador = req.body.jugador
        tempPartida.preguntas = req.body.preguntas
        tempPartida.puntos = req.body.puntos
        tempPartida.save().then(function(response){
            res.json({
                status: 'Ok',
                data: response
            })
        })
    }
}

exports.topJugadas = function(req, res){
    Partida.find().sort({ puntos: -1 }).limit(10).then(function(response){
        res.json({
            status: 'Ok',
            data: response
        })
    })
}