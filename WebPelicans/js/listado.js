$(document).ready(function(){
    $.ajax({
        url: 'http://192.168.0.120:8080/api/preguntas/autor/' + $('#nombreUsu').text(),
        method: 'get',
        data: {},
        success: function(response){
            response.data.forEach(function(pregunta){
                tempUno = $('<div class="col-6 my-4"></div>')
                $('#cuerpo').append(tempUno)
                tempDos = $('<div class="row mx-0 border background-primary-color" style="border-radius: 35px;"></div>')
                tempUno.append(tempDos)
                tempTres = $('<div class="col-8"></div>')
                tempDos.append(tempTres)
                tempCuatro = $('<div class="row mx-0 justify-content-center align-items-center"></div>')
                tempTres.append(tempCuatro)
                tempCinco = $('<div class="col-12 border-primary white d-flex justify-content-between" style="margin-top: 10px; margin-bottom: 10px;"></div>')
                tempCuatro.append(tempCinco)
                tempCinco.append('<h4>' + pregunta.titulo + '</h4>')
                tempSeis = $('<div class="box-icons "></div>')
                tempCinco.append(tempSeis)
                tempSeis.append('<span class="mx-2"><a href="editpregunta.php?preg=' + pregunta._id + '" class="white"><i class="bi bi-pencil-square"></a></i></span>')
                a = $('<span class="mx-2"></span>')
                b = $('<a href="back_eliminar_pregunta.php?preg=' + pregunta._id + '"  class="white"><i class="bi bi-trash-fill"></i></a>').click(confirmacion)
                tempSeis.append(a)
                a.append(b)
                tempSiete = $('<div class="col-12 d-flex flex-column border-secundary white" style="margin-top: 10px; margin-bottom: 10px;"></div>')
                tempCuatro.append(tempSiete)
                tempDiv = $('<div></div>')
                tempSiete.append(tempDiv)
                tempDiv.append('<span>Tema: </span>')
                tempDiv.append('<span>' + pregunta.tema + '</span>')
                tempDiv = $('<div></div>')
                tempSiete.append(tempDiv)
                tempDiv.append('<span>Dificultad: </span>')
                tempDiv.append('<span>' + pregunta.dificultad + '</span>')
                tempDiv = $('<div></div>')
                tempSiete.append(tempDiv)
                tempDiv.append('<span>Autor: </span>')
                tempDiv.append('<span>' + pregunta.autor + '</span>')
                tempOcho = $('<div class="col-4 d-flex justify-content-center align-items-center"></div>')
                tempDos.append(tempOcho)
                tempOcho.append('<div class="element-image"><img class="img-fluid" src="' + pregunta.foto + '"></div>');
            });
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

