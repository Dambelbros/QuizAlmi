let router = require('express').Router()

var preguntaController = require('./preguntaController');
var partidaController = require('./partidaController');
var sugerenciaController = require('./sugerenciaController');

router.route('/preguntas').get(preguntaController.todasPreguntas);

router.route('/partida')
    .get(partidaController.todasPartidas)
    .post(partidaController.anadirPartida)

router.route('/partida/topJugadas').get(partidaController.topJugadas)
router.route('/partida/partidaCompleta/:id').get(partidaController.preguntasPartida)

router.route('/partida/:idPregunta').get(partidaController.leerPartida)

router.route('/preguntas').get(preguntaController.todasPreguntas);
router.route('/juego/preguntas/:tema').get(preguntaController.listadoPreguntas)

router.route('/pregunta/:idPregunta')
    .get(preguntaController.leerPregunta)
    .delete(preguntaController.eliminarPregunta)

router.route('/preguntas/autor/:usuario').get(preguntaController.preguntasAutor);

router.route('/pregunta')
    .post(preguntaController.anadirPregunta)
    .put(preguntaController.actualizarPregunta)

router.route('/sugerencias')
    .get(sugerenciaController.getSugerencias)
    .post(sugerenciaController.anadirPregunta)


router.route('/sugerencias/:id')
    .get(sugerenciaController.getSugerenciaId)
    .delete(sugerenciaController.eliminarSugerencia)

module.exports = router;