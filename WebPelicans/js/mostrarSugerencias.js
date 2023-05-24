$(document).ready(function(){
    $.ajax({
        url: 'http://192.168.0.120:8080/api/sugerencias',
        method: 'get',
        data: {},
        success: function(response){
            response.data.forEach(function(sugerencia){
                tempUno = $('<div class="col-6 my-4"></div>')
                tempDos = $('<div class="row mx-0 border" style="border-radius: 35px;"></div>')
                tempUno.append(tempDos)
                tempTres = $('<div class="col-12"></div>')
                tempDos.append(tempTres)
                tempCuatro = $('<div class="row mx-0 justify-content-center"></div>')
                tempTres.append(tempCuatro)
                tempCinco = $('<div class="col-8 py-5 border-primary white d-flex flex-column justify-content-between"></div>')
                tempCuatro.append(tempCinco)
                tempCinco.append('<h4>' + sugerencia.titulo + '</h4>')
                tempCinco.append('<h4>' + sugerencia.respuesta + '</h4>')
                tempSeis = $('<div class="col-4 py-5 d-flex justify-content-center align-items-center"></div>')
                tempCuatro.append(tempSeis)
                tempSiete = $('<div class="box-icons-revision"></div>')
                tempSeis.append(tempSiete)
                tempSiete.append($('<span class="mx-3"><a href="alta.php?preg=' + sugerencia._id + '" class="white"><i class="bi bi-check-square-fill"></i></a></span>'))
                //tempSiete.append($('<span class="mx-3"><a href="php/borrar_pregunta.php?id=' + sugerencia._id + '" class="white"><i class="bi bi-x-square-fill"></i></a></span>'))
                a = $('<span class="mx-3"></span>')
                tempSiete.append(a)
                b =  $('<a href="php/borrar_pregunta.php?id=' + sugerencia._id + '" class="white"><i class="bi bi-x-square-fill"></i></a>').click(confirmacion)
                a.append(b)

                $('#cuerpo').append(tempUno)

                //.click(confirmacion)
            })
        }
    })

    function confirmacion(e) {
        e.preventDefault()

        $('#btnEliminar').val($(this).attr('href'))
        $('#panelConfirmacionEliminar').show()
    }

    $('#btnCancelar').click(function(){
        $('#panelConfirmacionEliminar').hide()
    })

    $('#btnEliminar').click(function(){
        window.location.href = $(this).val();
    })
})