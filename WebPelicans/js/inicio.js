$(document).ready(function(){
    $.ajax({
        url: 'http://192.168.0.120:8080/api/partida/topJugadas',
        method: 'get',
        data: {},
        success: function(response){
            //console.log(response.data)
            response.data.forEach(function(partida){
                $('.listadoTopDiez').append($('<li>'+partida.jugador+ ' ---------- ' + partida.puntos + '</li>'))

                console.log(partida.jugador)
                console.log(partida.puntos)
            });
        }
    })
})