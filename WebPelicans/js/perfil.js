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
});
