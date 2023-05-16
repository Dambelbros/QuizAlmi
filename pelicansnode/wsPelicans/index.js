//Importaciones
let express = require('express');
let bodyParser = require('body-parser');
let mongoose = require('mongoose');

//Servidor
let app = express();
var port = 8080;

//Body Parser
app.use(bodyParser.urlencoded({
    extended: true
}));
app.use(bodyParser.json());
app.use(bodyParser.text({type: '*/*'}));

//Conexion Base de Datos
mongoose.connect('mongodb://localhost:27017/pelicans', {useNewUrlParser: true, useUnifiedTopology: true});
var db = mongoose.connection;

//Rutas
app.get('/', (req, res) => res.json({ message: 'Server Up' }));

//Rutas
let apiRoutes = require('./apiRoutes');
app.use('/api', apiRoutes);

app.listen(8080, function(){
    console.log("Corriendo el servidor en: " + port);
});