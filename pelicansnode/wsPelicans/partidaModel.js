var mongoose = require('mongoose');

var PartidaSchema = mongoose.Schema({
    jugador: { type: String, required: true },
    preguntas: { type: Array, required: true },
    puntos: { type: Number, required: true }
    }, { collection: 'partida' });

var Partida = module.exports = mongoose.model('partida', PartidaSchema);