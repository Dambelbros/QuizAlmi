Sugerencia = require('./sugerenciaModel');

exports.getSugerencias = function(req, res){
    Sugerencia.find().then(function(response){
        res.json({
            status: 'Ok',
            data: response
        })
    })
}

exports.getSugerenciaId = function(req, res){
    Sugerencia.findById(req.params.id).then(function(response){
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

exports.eliminarSugerencia = function(req, res){
    Sugerencia.findByIdAndDelete(req.params.id).then(function(response){
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

exports.anadirPregunta = function(req, res){
    console.log(req.body)
    tempSugerencia = new Sugerencia()
    tempSugerencia.titulo = req.body.pregunta
    tempSugerencia.respuesta = req.body.respuesta

    console.log(tempSugerencia)

    tempSugerencia.save().then(function(response){
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