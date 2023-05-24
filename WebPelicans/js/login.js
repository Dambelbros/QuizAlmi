$(document).ready(function() {

    $("#login").click(function(event){
        $('#avisos').empty()
        
        event.preventDefault()

        fallo = false

        if ($('#txtNombre').val().length == 0) {
            fallo = true
            $('#txtNombre').css('border', '1px solid red')
            $('#avisos').append('<p>Debes introducir un usuario</p>')
        } else {
            $('#txtNombre').css('border', '1px solid #ced4da')
        }

        if ($('#txtContrasena').val().length == 0) {
            fallo = true
            $('#txtContrasena').css('border', '1px solid red')
            $('#avisos').append('<p>Debes introducir una contraseña</p>')
        } else {
            $('#txtContrasena').css('border', '1px solid #ced4da')
        }

        if (!fallo) {
            $.ajax({
                url: 'php/login.php',
                method: 'POST',
                data: $("#myFormAlta").serialize(),
                success: function(response){
    
                    if(response=="1") {
                        window.location.href = "/pelicans/index.php"
                    } else {
                        $('#avisos').append('<p>Fallo al iniciar sesion</p>')
                    }
                }
            })
        }
    })
})