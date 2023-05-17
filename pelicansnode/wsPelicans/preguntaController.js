Pregunta = require('./preguntaModel')

exports.todasPreguntas = function(req, res){
    Pregunta.find().then(function(response){
        res.json({
            status: 'Ok',
            data: response
        })
    })
}

exports.preguntasAutor = function(req, res){
    Pregunta.find({autor: req.params.usuario}).then(function(response){
        res.json({
            status: 'Ok',
            data: response
        })
    })
}

exports.leerPregunta = function(req, res){
    Pregunta.findById(req.params.idPregunta).then(function(response){
        res.json({
            status: 'Ok',
            data: response
        })
    })
}


exports.eliminarPregunta = function(req, res){
    Pregunta.findByIdAndDelete(req.body.idPregunta).then(function(response){
        res.json({
            status: 'Ok',
            data: response
        })
    })
}

exports.anadirPregunta = function(req, res){
    errores = Array()
    if(req.body.titulo == ""){
        errores.append('La pregunta no pude estar vacio');
    }

    if (req.body.tema == "") {
        errores.append('El tema no pude estar vacio');
    }
    
    if (req.body.autor == "") {
        errores.append('El autor no pude estar vacio');
    }

    if (req.body.foto == "") {
        errores.append('La foto no pude estar vacio');
    }

    if (req.body.aclaracion == "") {
        errores.append('La aclaracion no pude estar vacio');
    }

    if(!req.body.respuestas.length==4){
        errores.append('Tiene que haber 4 respuestas.');
    }

    contador = 0;
    req.body.respuestas.forEach(function(respuesta){
        if(respuesta.correcta){
            contador++;
        }
    });
    if (contador != 1) {
        errores.append('Tiene que haber 1 correcta.');
    }

    if (errores.length >= 1) {
        res.json({
            status: 'Fail',
            data: errores
        } )
    } else {
        tempPregunta = new Pregunta();
        tempPregunta.titulo = req.body.titulo
        tempPregunta.tema = req.body.tema
        tempPregunta.autor = req.body.autor
        tempPregunta.respuestas = req.body.respuestas
        tempPregunta.foto = req.body.foto
        tempPregunta.aclaracion = req.body.aclaracion
        tempPregunta.dificultad = req.body.dificultad
        tempPregunta.save().then(function(response){
            res.json({
                status: 'Ok',
                data: response
            })
        })
    }
}

exports.actualizarPregunta = function(req, res){
    Pregunta.findById(req.body.idPregunta).then(function(responseTemp){
        responseTemp.titulo = req.body.titulo ? req.body.titulo : responseTemp.titulo
        responseTemp.tema = req.body.tema ? req.body.tema : responseTemp.tema
        responseTemp.autor = req.body.autor ? req.body.autor : responseTemp.autor
        responseTemp.respuestas = req.body.respuestas ? req.body.respuestas : responseTemp.respuestas
        responseTemp.foto = req.body.foto ? req.body.foto : responseTemp.foto
        responseTemp.aclaracion = req.body.aclaracion ? req.body.aclaracion : responseTemp.aclaracion
        responseTemp.dificultad = req.body.dificultad ? req.body.dificultad : responseTemp.dificultad

        responseTemp.save().then(function(response){
            res.json({
                status: 'Ok',
                data: response
            })
        })
    })
}

exports.listadoPreguntas = function(req, res) {
    var listadoPreguntas = [];

    Pregunta.aggregate([ 
        { $match: {dificultad: 'Facil', tema: req.params.tema }},
        { $sample: { size: 5 }}
    ]).then(function(pregFacil){
        pregFacil.forEach(function(registro){
            tempRespuestas = []
            numAleatorios = generarNumerosAleatorios()
            tempRespuestas[0] = registro.respuestas[numAleatorios[0]]
            tempRespuestas[1] = registro.respuestas[numAleatorios[1]]
            tempRespuestas[2] = registro.respuestas[numAleatorios[2]]
            tempRespuestas[3] = registro.respuestas[numAleatorios[3]]
            registro.respuestas = tempRespuestas
            listadoPreguntas.push(registro)
        });

        Pregunta.aggregate([ 
            { $match: {dificultad: 'Medio', tema: req.params.tema }},
            { $sample: { size: 5 }}
        ]).then(function(pregMedio){
            pregMedio.forEach(function(registro){
                tempRespuestas = []
                numAleatorios = generarNumerosAleatorios()
                tempRespuestas[0] = registro.respuestas[numAleatorios[0]]
                tempRespuestas[1] = registro.respuestas[numAleatorios[1]]
                tempRespuestas[2] = registro.respuestas[numAleatorios[2]]
                tempRespuestas[3] = registro.respuestas[numAleatorios[3]]
                registro.respuestas = tempRespuestas
                listadoPreguntas.push(registro)
            });

            Pregunta.aggregate([ 
                { $match: {dificultad: 'Dificil', tema: req.params.tema }},
                { $sample: { size: 5 }}
            ]).then(function(pregDificil){
                pregDificil.forEach(function(registro){
                    tempRespuestas = []
                    numAleatorios = generarNumerosAleatorios()
                    tempRespuestas[0] = registro.respuestas[numAleatorios[0]]
                    tempRespuestas[1] = registro.respuestas[numAleatorios[1]]
                    tempRespuestas[2] = registro.respuestas[numAleatorios[2]]
                    tempRespuestas[3] = registro.respuestas[numAleatorios[3]]
                    registro.respuestas = tempRespuestas
                    listadoPreguntas.push(registro)
                }); 

                res.json({
                    status: 'Ok',
                    data: listadoPreguntas
                });
            })
        })
    })
};

function generarNumerosAleatorios() {
    var numeros = [];
  
    while (numeros.length < 4) {
      var numero = Math.floor(Math.random() * 4);
  
      if (!numeros.includes(numero)) {
        numeros.push(numero);
      }
    }
  
    return numeros;
  }

/*
exports.listadoPreguntas = function(req, res) {
    var listadoPreguntas = [];

    Pregunta.find({ dificultad: 'Facil', tema: req.params.tema }).then(function(pregFacil) {
        var numerosAleatorios = [];
        
        while (numerosAleatorios.length < 5) {
            var tempNumero = Math.floor(Math.random() * pregFacil.length);
            if (numerosAleatorios.indexOf(tempNumero) === -1) {
                numerosAleatorios.push(tempNumero);
            }
        }
        
        numerosAleatorios.forEach(function(numero) {
            listadoPreguntas.push(pregFacil[numero]);
        });

        Pregunta.find({ dificultad: 'Medio', tema: req.params.tema }).then(function(pregMedio) {
            numerosAleatorios = [];
        
            while (numerosAleatorios.length < 5) {
                tempNumero = Math.floor(Math.random() * pregMedio.length);
                if (numerosAleatorios.indexOf(tempNumero) === -1) {
                    numerosAleatorios.push(tempNumero);
                }
            }
            
            numerosAleatorios.forEach(function(numero) {
                listadoPreguntas.push(pregMedio[numero]);
            });

            Pregunta.find({ dificultad: 'Dificil', tema: req.params.tema }).then(function(pregDificil) {
                numerosAleatorios = [];
        
                while (numerosAleatorios.length < 5) {
                    tempNumero = Math.floor(Math.random() * pregDificil.length);
                    if (numerosAleatorios.indexOf(tempNumero) === -1) {
                        numerosAleatorios.push(tempNumero);
                    }
                }
                
                numerosAleatorios.forEach(function(numero) {
                    listadoPreguntas.push(pregDificil[numero]);
                });

                res.json({
                    status: 'Ok',
                    data: listadoPreguntas
                });
            });
        });
    });
};
*/