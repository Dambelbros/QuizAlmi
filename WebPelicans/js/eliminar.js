$(document).ready(function() {
  $('#myTable').dataTable( {
    "dom":"ftip",
    "ordering": false,
    "drawCallback": function () {
      activeEventEliminar();
    }
  } );

  //metemos todo en una funcion para que en la segunda pagina funcione correcto
  function activeEventEliminar() {
    $('.eliminar-trabajador').off("click")
    $('.eliminar-trabajador').click(function(e) {
      e.preventDefault();
  
      var idTrabajador = $(this).data('id');
  
      console.log(idTrabajador)
  
      $('#panelConfirmacionEliminar').show();
      
      $('#lblPregunta').text("El trabajador será eliminado permanentemente").addClass("white");
  
      $('#btnCancelar').click(function() {
        $('#panelConfirmacionEliminar').hide();
      });
  
      $('#btnEliminar').click(function() {
        $.ajax({
          url: "php/eliminar_trabajador.php",
          method: "POST",
          data: { id: idTrabajador },
          success: function(response) {
            location.reload();
          },
          error: function(xhr, status, error) {
            alert("Error al eliminar el trabajador: " + error);
          }
        });
  
        $('#panelConfirmacionEliminar').hide();
      });
      
    });

  }
  
});
