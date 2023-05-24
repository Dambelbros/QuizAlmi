var mongoose = require('mongoose');

var SugerenciaSchema = mongoose.Schema({
    titulo: { type: String, required: true },
    respuesta: { type: String, required: true }
    }, { collection: 'sugerencia' });

var Sugerencia = module.exports = mongoose.model('sugerencia', SugerenciaSchema);