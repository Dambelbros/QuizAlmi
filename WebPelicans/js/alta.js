$(document).ready(function(){
    $.ajax({
        url: 'http://192.168.0.120:8080/api/pregunta/' + $('#lblPregunta').val(),
        method: 'get',
        data: {},
        success: function(response){
            console.log(response)
            $('#txtTitulo').val(response.data.titulo)
            $('#txtTema').val(response.data.tema)
            $('#txtDificultad').val(response.data.dificultad)
            $('#txtAutor').val(response.data.autor)
            $('#txtAclaracion').val(response.data.aclaracion)
            $('#txtRespUno').val(response.data.respuestas[0].frase)
            $('#txtRespDos').val(response.data.respuestas[1].frase)
            $('#txtRespTres').val(response.data.respuestas[2].frase)
            $('#txtRespCuatro').val(response.data.respuestas[3].frase)

        }
    })
})