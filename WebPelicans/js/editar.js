var confirmacion = false;

$(document).ready(function(){
    $.ajax({
        url: 'http://192.168.0.120:8080/api/pregunta/' + $('#lblPregunta').val(),
        method: 'get',
        data: {},
        success: function(response){
            $('#txtTitulo').val(response.data.titulo)
            $('#txtAclaracion').val(response.data.aclaracion)
            $('#txtRespUno').val(response.data.respuestas[0].frase)
            $('#txtRespDos').val(response.data.respuestas[1].frase)
            $('#txtRespTres').val(response.data.respuestas[2].frase)
            $('#txtRespCuatro').val(response.data.respuestas[3].frase)
            $('#tbDificultad').val(response.data.dificultad)
            $('#tbTema').val(response.data.tema)
            $('#tbEstado').val(response.data.estado)
        }
    })

    $('#myFormAlta').submit(function(e){
        $('#avisos').empty()

        comprobacion = true
        respuestasIncorrectas = false

        if ($('#txtTitulo').val().length == 0) {
            $('#avisos').append($('<p>Tienes que introducir un titulo</p>'))
            $("#txtTitulo").css('border', '1px solid red');
            comprobacion = false
        } else {
            $("#txtTitulo").css('border', '2px solid black');
        }

        if ($('#txtAclaracion').val().length == 0) {
            $('#avisos').append($('<p>Tienes que introducir una aclaracion</p>'))
            $("#txtAclaracion").css('border', '1px solid red')
            comprobacion = false
        } else {
            $("#txtAclaracion").css('border', '2px solid black');
        }

        if ($('#txtRespUno').val().length == 0) {
            respuestasIncorrectas = true
            $("#txtRespUno").css('border', '1px solid red')
        } else {
            $("#txtRespUno").css('border', '2px solid black');
        }

        if ($('#txtRespDos').val().length == 0) {
            respuestasIncorrectas = true
            $("#txtRespDos").css('border', '1px solid red')
        } else {
            $("#txtRespDos").css('border', '2px solid black');
        }

        if ($('#txtRespTres').val().length == 0) {
            respuestasIncorrectas = true
            $("#txtRespTres").css('border', '1px solid red')
        } else {
            $("#txtRespTres").css('border', '2px solid black');
        }

        if ($('#txtRespCuatro').val().length == 0) {
            respuestasIncorrectas = true
            $("#txtRespCuatro").css('border', '1px solid red')
        } else {
            $("#txtRespCuatro").css('border', '2px solid black');
        }

        if (respuestasIncorrectas) {
            comprobacion = false
            $('#avisos').append($('<p>Tienes que introducir una respuesta correcta</p>'))
        }

        if (!comprobacion) {
            e.preventDefault()
        }
    })
})