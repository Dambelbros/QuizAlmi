let router = require('express').Router()

var preguntaController = require('./preguntaController');
var partidaController = require('./partidaController');

router.route('/preguntas').get(preguntaController.todasPreguntas);

router.route('/partida')
    .get(partidaController.todasPartidas)
    .post(partidaController.anadirPartida)

router.route('/partida/topJugadas').get(partidaController.topJugadas)

router.route('/partida/:idPregunta').get(partidaController.leerPartida)

router.route('/preguntas').get(preguntaController.todasPreguntas);
router.route('/juego/preguntas/:tema').get(preguntaController.listadoPreguntas)

router.route('/pregunta/:idPregunta').get(preguntaController.leerPregunta)

router.route('/preguntas/autor/:usuario').get(preguntaController.preguntasAutor);

router.route('/pregunta')
    .delete(preguntaController.eliminarPregunta)
    .post(preguntaController.anadirPregunta)
    .put(preguntaController.actualizarPregunta)

module.exports = router;