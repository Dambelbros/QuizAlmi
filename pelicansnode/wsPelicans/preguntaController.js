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
        posCorrecta = -1
        pos = 0
        response.respuestas.forEach(function(respuesta){
            respuesta.correcta
            if (respuesta.correcta) {
                posCorrecta = pos
            }

            pos++;
        })

        tempCambioPregunta = response.respuestas[0]
        response.respuestas[0] = response.respuestas[posCorrecta]
        response.respuestas[posCorrecta] = tempCambioPregunta

        res.json({
            status: 'Ok',
            data: response
        })
    })
}


exports.eliminarPregunta = function(req, res){
    Pregunta.findByIdAndDelete(req.params.idPregunta).then(function(response){
        res.json({
            status: 'Ok',
            data: response
        })
    })
}

exports.anadirPregunta = function(req, res){
    console.log(req.body)
    
    errores = Array()
    if(req.body.titulo == ""){
        errores.push('La pregunta no pude estar vacio');
    }

    if (req.body.tema == "") {
        errores.push('El tema no pude estar vacio');
    }
    
    if (req.body.autor == "") {
        errores.push('El autor no pude estar vacio');
    }

    if (req.body.foto == "") {
        errores.push('La foto no pude estar vacio');
    }

    if (req.body.aclaracion == "") {
        errores.push('La aclaracion no pude estar vacio');
    }

    if(!req.body.respuestas.length==4){
        errores.push('Tiene que haber 4 respuestas.');
    }

    if (errores.length >= 1) {
        res.json({
            status: 'Fail',
            data: errores
        } )
    } else {
        tempRespuestas = []
        tempRespuestas[0] = {
            frase: req.body.respuestas[0],
            correcta: true
        }

        for (let index = 0; index < 4; index++) {
            if (index == 0) {
                tempRespuestas[index] = {
                    frase: req.body.respuestas[index],
                    correcta: true
                }
            } else {
                tempRespuestas[index] = {
                    frase: req.body.respuestas[index],
                    correcta: false
                }
            }
        }

        tempPregunta = new Pregunta();
        tempPregunta.titulo = req.body.titulo
        tempPregunta.tema = req.body.tema
        tempPregunta.autor = req.body.autor
        tempPregunta.respuestas = tempRespuestas
        tempPregunta.foto = req.body.foto
        tempPregunta.aclaracion = req.body.aclaracion
        tempPregunta.dificultad = req.body.dificultad
        tempPregunta.estado = req.body.estado
        tempPregunta.save().then(function(response){
            res.json({
                status: 'Ok',
                data: response
            })
        })
    }
    
}

exports.actualizarPregunta = function(req, res){
    console.log(req.body)
    Pregunta.findById(req.body.idPregunta).then(function(responseTemp){
        responseTemp.titulo = req.body.titulo ? req.body.titulo : responseTemp.titulo
        responseTemp.tema = req.body.tema ? req.body.tema : responseTemp.tema
        responseTemp.foto = req.body.foto ? req.body.foto : responseTemp.foto
        responseTemp.aclaracion = req.body.aclaracion ? req.body.aclaracion : responseTemp.aclaracion
        responseTemp.dificultad = req.body.dificultad ? req.body.dificultad : responseTemp.dificultad
        responseTemp.estado = req.body.estado ? req.body.estado : responseTemp.estado
        
        try {
            tempRespuestas = []

        for (let index = 0; index < 4; index++) {
            if (index == 0) {
                tempRespuestas[index] = {
                    frase: req.body.respuestas[index],
                    correcta: true
                }
            } else {
                tempRespuestas[index] = {
                    frase: req.body.respuestas[index],
                    correcta: false
                }
                }
            }

            responseTemp.respuestas = tempRespuestas;
        } catch (error) {
        }

        console.log(responseTemp)
        
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
        { $match: {dificultad: 'Facil', tema: req.params.tema, estado: 'mostrar' }},
        { $sample: { size: 5 }}
    ]).then(function(pregFacil){
        pregFacil.forEach(function(registro){
            tempRespuestas = []
            console.log(registro.respuestas)
            numAleatorios = generarNumerosAleatorios()
            tempRespuestas[0] = registro.respuestas[numAleatorios[0]]
            tempRespuestas[1] = registro.respuestas[numAleatorios[1]]
            tempRespuestas[2] = registro.respuestas[numAleatorios[2]]
            tempRespuestas[3] = registro.respuestas[numAleatorios[3]]
            registro.respuestas = tempRespuestas
            console.log(registro.respuestas)
            listadoPreguntas.push(registro)
        });

        Pregunta.aggregate([ 
            { $match: {dificultad: 'Medio', tema: req.params.tema, estado: 'mostrar' }},
            { $sample: { size: 5 }}
        ]).then(function(pregMedio){
            pregMedio.forEach(function(registro){
                tempRespuestas = []
                console.log(registro.respuestas)
                numAleatorios = generarNumerosAleatorios()
                tempRespuestas[0] = registro.respuestas[numAleatorios[0]]
                tempRespuestas[1] = registro.respuestas[numAleatorios[1]]
                tempRespuestas[2] = registro.respuestas[numAleatorios[2]]
                tempRespuestas[3] = registro.respuestas[numAleatorios[3]]
                registro.respuestas = tempRespuestas
                console.log(registro.respuestas)
                listadoPreguntas.push(registro)
            });

            Pregunta.aggregate([ 
                { $match: {dificultad: 'Dificil', tema: req.params.tema, estado: 'mostrar' }},
                { $sample: { size: 5 }}
            ]).then(function(pregDificil){
                pregDificil.forEach(function(registro){
                    tempRespuestas = []
                    console.log(registro.respuestas)
                    numAleatorios = generarNumerosAleatorios()
                    tempRespuestas[0] = registro.respuestas[numAleatorios[0]]
                    tempRespuestas[1] = registro.respuestas[numAleatorios[1]]
                    tempRespuestas[2] = registro.respuestas[numAleatorios[2]]
                    tempRespuestas[3] = registro.respuestas[numAleatorios[3]]
                    registro.respuestas = tempRespuestas
                    console.log(registro.respuestas)
                    listadoPreguntas.push(registro)
                }); 

                res.json({
                    status: 'Ok',
                    data: listadoPreguntas
                });
            })
        })
    })
}

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