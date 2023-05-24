$(document).ready(function(){
    $('#myFormAlta').submit(function(e){
        //e.preventDefault()
        $('#avisos').empty()
        fallo = false

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

        if (fallo) {
            e.preventDefault()
        }
    })
})