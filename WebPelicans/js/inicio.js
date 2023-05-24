$(document).ready(function(){
    $.ajax({
        url: 'http://192.168.0.120:8080/api/partida/topJugadas',
        method: 'get',
        data: {},
        success: function(response){
            //console.log(response.data)
            response.data.forEach(function(partida){
                $('#table tbody').empty();
            
                response.data.forEach(function(partida){
                    var row = $('<tr></tr>');
                    row.append('<td class="white">' + partida.jugador + '</td>');
                    row.append('<td class="white">' + partida.puntos + '</td>');
                    $('#table tbody').append(row);
                });            
            });
        }
    })

    $("#enviarPregunta").click(function(event){
        event.preventDefault();
        enviar = true
        $('#avisos').empty()

        if ($('#txtPregunta').val().length == 0) {
            enviar = false
            $('#avisos').append('<p>Tienes que introducir una pregunta</p>')
            $('#txtPregunta').css('border', '1px solid red')
        } else {
            $('#txtPregunta').css('border', '2px solid black')
        }

        if ($('#txtRespuesta').val().length == 0) {
            enviar = false
            $('#avisos').append('<p>Tienes que introducir una respuesta</p>')
            $('#txtRespuesta').css('border', '1px solid red')
        } else {
            $('#txtRespuesta').css('border', '2px solid black')
        }

        let myFormData = $("#myFormPregunta").serialize();
        if (enviar) {
            $.ajax({
                url: "http://192.168.0.120:8080/api/sugerencias",
                method: "post",
                data: myFormData,
                success: function(result) {
                    $("#myFormPregunta")[0].reset();
                    if(result.status == 'Error'){
                        $('#lblSug').text('Error al ingresar la sugerencia')
                    } else {
                        $('#lblSug').text('Sugerencia Ingresada')
                    }
    
                    $('#panelConfirmacionEnviado').show()
                }
            });
        }
    });

    $('#btnAceptar').click(function(){
        $('#panelConfirmacionEnviado').hide()
    })
});
