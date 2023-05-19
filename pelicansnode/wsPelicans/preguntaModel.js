//Importaciones
var mongoose = require('mongoose');

var PreguntaSchema = mongoose.Schema({
    titulo: { type: String, required: true },
    tema: { type: String, required: true },
    dificultad: { type: String, required: true },
    autor: { type: String, required: true },
    respuestas: { type: Array, required: true },
    foto: { type: String, required: true },
    aclaracion: { type: String, required: true },
    estado: { type: String, required: true }
}, { collection: 'pelicans' });

var Pregunta = module.exports = mongoose.model('pelicans', PreguntaSchema);