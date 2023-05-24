<script src="js/eliminar.js"></script>
<?php
include_once "php/bbdd.php";

$trabajadores = get_all_trabajadores();
?>
<div id="cuerpo" class="row mx-0 py-5 flex-column justify-content-center align-items-center position-relative background-secundary-color"> 
<div class="col-6 my-4">
        <h3 class="white">Revisores que ganan mas que la media</h3>   
        <div class="row mx-0 border" style="border: 60px;">
            <div class="col-4 white font-weight-bold" style="font-size: 18px;">DNI</div>
            <div class="col-4 white font-weight-bold" style="font-size: 18px;">Nombre Completo</div>
            <div class="col-4 white font-weight-bold" style="font-size: 18px;">Salario</div>
        </div>

        <?php
        $bloquesTrabajadores = generarBloquesTrabajadores();
        echo $bloquesTrabajadores;
        ?>
    </div>
    <div class="col-6 my-4">
        <h3 class="col-6 my-1 white">Todos los empleados</h3>   
    </div>
    <!-- Hacemos un div para encapsular todos los elementos de la tabla-->
    <div style="padding-top: 25px;padding-bottom: 25px;color: #fff;">
    <!-- Agregamos el numero de paginas que queremos que tenga-->
    <table id="myTable" data-page-length='2'>
        <thead>
        <tr>
            <th></th>
        </tr>
        </thead>
        <tbody>
    
    <!--Dentro de los echo hacemos un tr y un td por cada uno de los elementos-->
    <?php
        if ($trabajadores) {
            foreach ($trabajadores as $trabajador) {
                echo "<tr><td><div class='row mx-0 justify-content-center'>";
                echo '<div class="col-7 my-4">';
                echo '<div class="row mx-0 border" style="border-radius: 35px;">';
                echo '<div class="col-12">';
                echo '<div class="row mx-0 justify-content-center">';
                echo '<div class="col-8 py-5 border-primary white d-flex flex-column justify-content-between">';
                echo 'DNI: ' . $trabajador['dni'] . '<br>';
                echo 'Nombre: ' . $trabajador['nombre'] . '<br>';
                echo 'Apellido: ' . $trabajador['apellido'] . '<br>';
                echo 'Fecha de nacimiento: ' . $trabajador['fecha_nacimiento'] . '<br>';
                echo 'Fecha de inicio de contrato: ' . $trabajador['inicio_contrato'] . '<br>';
                echo 'Fecha de fin de contrato: ' . $trabajador['fin_contrato'] . '<br>';
                echo '</div>';
                echo '<div class="col-4 py-5 d-flex justify-content-center align-items-center">';
                echo '<div class="box-icons-revision">';
                echo '<span class="mx-2"><a href="editTrabajador.php?trab=' . $trabajador['id'] . '" class="white"><i class="bi bi-pencil-square"></i></a></span>';
                echo '<span class="mx-2"><a href="' . $trabajador['id'] . '" class="white eliminar-trabajador" data-id="' . $trabajador['id'] . '"><i class="bi bi-trash-fill"></i></a></span>';
                echo '</div>';
                echo '</div>';
                echo '</div>';
                echo '</div>';
                echo '</div>';
                echo '</div>';
                echo "</div></td></tr>";
            }
        } else {
            echo "No se encontraron trabajadores.";
        }
        ?>
        </tbody>
    </table>
    <!-- fin de la tabla-->

    </div>
    <div id="panelConfirmacionEliminar">
        <h4>¿Estás seguro de que deseas eliminar a este trabajador?</h4>
        <p id="lblPregunta"></p>
        <button id="btnCancelar">Cancelar</button>
        <button id="btnEliminar">Eliminar</button>
    </div>

    </div>