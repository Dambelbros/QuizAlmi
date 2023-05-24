comprobacionDni = false
comprobacionUsuario = false
comprobacionEmail = false

$(document).ready(function(){
    $('#txtSa').keypress(function (e) {    
    
        var charCode = (e.which) ? e.which : event.keyCode    

        if (String.fromCharCode(charCode).match(/[^0-9]/g))    

            return false;                        

    });    

    $('#myFormAlta').submit(function(e){
        e.preventDefault()
        $('#avisos').empty()
        fallo = false

        falloDni = false
        
        if ($('#txtDni').val().length == 0) {
            falloDni = true
            $('#avisos').append('<p>Debes introducir un DNI</p>')
        } else if (!comprobacionDni){
            falloDni = true
            $('#avisos').append('<p>El DNI existe</p>')
        }

        if (falloDni) {
            fallo = true
            $('#txtDni').css('border', '1px solid red')
        } else {
            $('#txtDni').css('border', '2px solid black')
        }

        falloUsuario = false

        if ($('#txtUsuario').val().length > 20 || $('#txtUsuario').val().length < 3) {
            falloUsuario = true
            $('#avisos').append('<p>Debes introducir un usuario entre 3 y 20 caracteres</p>')
        } else if (!comprobacionUsuario){
            falloUsuario = true
            $('#avisos').append('<p>El Usuario existe</p>')
        }

        if (falloUsuario) {
            fallo = true
            $('#txtUsuario').css('border', '1px solid red')
        } else {
            $('#txtUsuario').css('border', '2px solid black')
        }

        falloEmail = false

        if ($('#txtEmail').val().length == 0) {
            falloEmail = true
            $('#avisos').append('<p>Debes introducir un email</p>')
        } else if (!comprobacionEmail){
            falloEmail = true
            $('#avisos').append('<p>El email existe</p>')
        }

        if (falloEmail) {
            fallo = true
            $('#txtEmail').css('border', '1px solid red')
        } else {
            $('#txtEmail').css('border', '2px solid black')
        }

        if ($('#txtNombre').val().length == 0) {
            fallo = true
            $('#avisos').append('<p>El nombre no puede estar vacio</p>')
            $('#txtNombre').css('border', '1px solid red')
        } else {
            $('#txtNombre').css('border', '2px solid black')
        }

        if ($('#txtApellido').val().length == 0) {
            fallo = true
            $('#avisos').append('<p>El apellido no puede estar vacio</p>')
            $('#txtApellido').css('border', '1px solid red')
        } else {
            $('#txtApellido').css('border', '2px solid black')
        }

        if ($('#txtFechaNac').val() == "") {
            fallo = true
            $('#avisos').append('<p>Debes introducir una fecha valida</p>')
            $('#txtFechaNac').css('border', '1px solid red')
        } else {
            $('#txtFechaNac').css('border', '2px solid black')
        }

        falloCon = false

        if ($('#txtCon').val() == "") {
            falloCon = true
            $('#avisos').append('<p>La contraseña no puede estar vacia</p>')
        }

        if ($('#txtCon').val() != $('#txtReCon').val()) {
            falloCon = true
            $('#avisos').append('<p>Las contraseñas deben ser iguales</p>')
            $('#txtReCon').css('border', '1px solid red')
        } else {
            $('#txtReCon').css('border', '2px solid black')
        }

        if (falloCon) {
            fallo = true
            $('#txtCon').css('border', '1px solid red')
        } else {
            $('#txtCon').css('border', '2px solid black')
        }

        if ($('#txtSa').val() == "") {
            $('#txtSa').css('border', '1px solid red')
            fallo = true
            $('#avisos').append('<p>Debes introducir Salario</p>')
        } else {
            $('#txtSa').css('border', '2px solid black')
        }

        falloFeCon = false
        falloFeDes = false

        if ($('#txtIniCon').val() == "") {
            falloFeCon = true
            fallo = true
            $('#avisos').append('<p>Fecha contraracion incorrecta</p>')
        }

        if ($('#txtFinCon').val() == "") {
            falloFeDes = true
            fallo = true
            $('#avisos').append('<p>Fecha despido incorrecta</p>')
        }

        dateIni = new Date($('#txtIniCon').val())
        dateFin = new Date($('#txtFinCon').val())

        if (dateFin < dateIni) {
            falloFeCon = true
            falloFeDes = true
        }

        if (falloFeCon) {
            $('#txtIniCon').css('border', '1px solid red')
        } else {
            $('#txtIniCon').css('border', '2px solid black')
        }

        if (falloFeDes) {
            $('#txtFinCon').css('border', '1px solid red')
        } else {
            $('#txtFinCon').css('border', '2px solid black')
        }

        if (!fallo) {
            let myFormData = $("#myFormAlta").serialize();

            $.ajax({
                url: "php/alta.php",
                type: "POST",
                data: myFormData,
                success: function(result) {
                  console.log(result);
      
                  $("#myFormAlta")[0].reset();
      
                  window.location.href = "/pelicans/index.php"
                },
                error: function() {
                  
                }
              });
        }
    })

    $('#txtDni').keyup(function(){ 
        $.ajax({
            url: 'http://192.168.0.120/pelicans/servicios.php',
            method: 'post',
            data: { funcion: 'comprobardni', dni: $('#txtDni').val()},
            success: function(response){
                if (response > 0) {
                    comprobacionDni = false
                } else {
                    comprobacionDni = true
                }
            }
        })
    })

    $('#txtUsuario').keyup(function(){ 
        $.ajax({
            url: 'http://192.168.0.120/pelicans/servicios.php',
            method: 'post',
            data: { funcion: 'comprobarUsuario', usuario: $('#txtUsuario').val()},
            success: function(response){
                if (response > 0) {
                    comprobacionUsuario = false
                } else {
                    comprobacionUsuario = true
                }
            }
        })
    })

    $('#txtEmail').keyup(function(){ 
        $.ajax({
            url: 'http://192.168.0.120/pelicans/servicios.php',
            method: 'post',
            data: { funcion: 'comprobarEmail', email: $('#txtEmail').val()},
            success: function(response){
                if (response > 0) {
                    comprobacionEmail = false
                } else {
                    comprobacionEmail = true
                }

                console.log(comprobacionEmail)
            }
        })
    })
})