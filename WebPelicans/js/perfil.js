$(document).ready(function() {
    //ocultar formulario
    $('#formulario2').hide();

    //Boton Siguiente
    $('#siguientePerfil').click(function() {
        $('#formulario1').fadeOut(500, function() {
            $('#formulario2').fadeIn(500);
        });
    });

    //Boton Anterior
    $('#anteriorPerfil').click(function() {
        $('#formulario2').fadeOut(500, function() {
        $('#formulario1').fadeIn(500);
        });
    });

    $('#myFormAlta').submit(function(e){
        $('#avisos').empty()

        comprobacion = true
        respuestasIncorrectas = false

        if ($('#txtNombre').val().length == 0) {
            $('#avisos').append($('<p>Tienes que introducir un nombre</p>'))
            $("#txtNombre").css('border', '1px solid red');
            comprobacion = false
        } else {
            $("#txtNombre").css('border', '1px solid #ced4da');
        }

        if ($('#txtApellido').val().length == 0) {
            $('#avisos').append($('<p>Tienes que introducir un apellido</p>'))
            $("#txtApellido").css('border', '1px solid red')
            comprobacion = false
        } else {
            $("#txtApellido").css('border', '1px solid #ced4da');
        }

        if ($('#txtCon').val() != $('#txtReCon').val()) {
            $('#avisos').append($('<p>Tienes que introducir correctamente las contraseñas</p>'))
            $("#txtCon").css('border', '1px solid red')
            $("#txtReCon").css('border', '1px solid red')
            comprobacion = false
        } else {
            $("#txtCon").css('border', '1px solid #ced4da');
            $("#txtReCon").css('border', '1px solid #ced4da');
        }

        console.log($('#txtCon').val() == $('#txtReCon').val())

        if (!comprobacion) {
            e.preventDefault()
        }
    })
});
