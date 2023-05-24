function validarFormulario() {
    /*
    let inputsVacios = $("input[type='text']").filter(function() {
        return !this.value.trim();
    });
    
    if (inputsVacios.length > 0) {
        inputsVacios.css('border', '1px solid red');
        $("#avisos").text("Hay campos vacíos").show();
        return false;
    }
    */

    fallo = false

    falloEmail = false

    let email = $("#email").val();
    if (email == "") {
        $("#avisos").append('<p>Tienes que introducir un email</p>')
        falloEmail = true
    }

    if (!email.includes('@')) {
        //$("#avisos").text("El email no es correcto")
        falloEmail = true
    }

    if (falloEmail) {
        $("#email").css('border', '1px solid red');
        console.log($("#email"))
        fallo = true
        console.log('Entra Error')
    }

    let password = $("#password").val();
    let rePassword = $("#re_password").val();
    if (password !== rePassword) {
        $("#password, #re_password").css('border', '5px solid red');
        $("#avisos").text("Las contraseñas no coinciden").show();
        return false;
    }

    // Restaurar el borde original de los input
    $("input[type='text'], #usuario, #email, #password, #re_password").css('border', '1px solid black');
    $("#avisos").hide();

    let fechaActual = new Date();
    let fechaNacimiento = new Date($("#fecha_nacimiento").val());

    if (fechaNacimiento > fechaActual) {
        $("#fecha_nacimiento").css('border', '1px solid red');
        $("#avisos").text("La fecha de nacimiento no puede ser posterior a la fecha actual").show();
        return false;
    }


    let fechaInicioContrato = new Date($("#fecha_inicio_contrato").val());
    let fechaFinContrato = new Date($("#fecha_fin_contrato").val());

    if (fechaInicioContrato === "Invalid Date" || fechaInicioContrato === null) {
        $("#fecha_inicio_contrato").css('border', '1px solid red');
        $("#avisos").text("La fecha de inicio de contrato no puede ser nula").show();
        return false;
    }

    if (fechaFinContrato === "Invalid Date" || fechaFinContrato === null) {
        $("#fecha_fin_contrato").css('border', '1px solid red');
        $("#avisos").text("La fecha de fin de contrato no puede ser nula").show();
        return false;
    }


    if (fallo) {
        return false
    }

    let usuario = $("#usuario").val();

    $.ajax({
        url: "php/verificar_usuario.php",
        type: "POST",
        data: { usuario: usuario },
        success: function(result) {
            if (result === 'existe') {
                $("#usuario").css('border', '1px solid red');
                $("#usuario-error").text("El usuario ya existe").addClass("error-text");
                $("#usuario-error").show();
                $("#avisos").text("El usuario ya existe").show();
            } else {
                $("#usuario").css('border', '1px solid black');
                $("input[type='text'], #usuario, #email, #password, #re_password").css('border', '1px solid black');
                $("#avisos").hide();
            }
        },
        error: function(jqXHR, textStatus, errorThrown) {
            console.log("Error en la solicitud AJAX: " + textStatus + " - " + errorThrown);
        }
    });

    return true;
}

$(document).ready(function() {
    $("#enviarAlta").click(function(event) {
        event.preventDefault();
    
        if (validarFormulario()) {
          let myFormData = $("#myFormAlta").serialize();
    
          $("#panelConfirmacionEliminar").show();
    
          $("#btnCancelar").click(function() {
            $("#panelConfirmacionEliminar").hide();
          });
    
          $("#btnEliminar").click(function() {
            $("#panelConfirmacionEliminar").hide();
    
            $.ajax({
              url: "php/alta.php",
              type: "POST",
              data: myFormData,
              success: function(result) {
                console.log(result);
    
                $("#myFormAlta")[0].reset();
    
                alert('Se ha registrado correctamente');
              },
              error: function() {
                alert('Ha ocurrido un error. No se ha podido registrar.');
              }
            });
          });
        }
    });
});