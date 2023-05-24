<body>
<nav class="navbar navbar-expand-lg navbar-light background-primary-color">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">
      <img src="img/logo_pelicano.png" alt="" width="100" height="" class="d-inline-block">
      <span class="h4 align-middle white">The Pelicans</span>
    </a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse justify-content-end px-5 mx-4" id="navbarNavDropdown">
      <ul class="navbar-nav">
        <li class="nav-item">
          <a class="nav-link active white" aria-current="page" href="index.php">Inicio</a>
        </li>
        <?php
        if(isset($_SESSION['nombre_usuario']) && ($_SESSION['rol']=="gerente" || $_SESSION['rol']=="revisor")) {
        ?>
        <li class="nav-item">
          <a class="nav-link white" href="revision.php">Revisión</a>
        </li>
        <?php
        }
        ?>
        <?php
          if(isset($_SESSION['nombre_usuario']) && $_SESSION['rol']=="gerente") {
          ?>
          <li class="nav-item">
            <a class="nav-link white" href="registro.php">Registrar</a>
          </li>
          <li class="nav-item">
            <a class="nav-link white" href="listadoTrabajadores.php">Trabajadores</a>
          </li>
        <?php
        }
        ?>
        <?php
        if(isset($_SESSION['nombre_usuario']) && ($_SESSION['rol']=="gerente" || $_SESSION['rol']=="revisor")) {
        ?>
        <li class="nav-item dropdown">
          <a class="nav-link dropdown-toggle white" href="#" id="navbarDropdownMenuLink" role="button" data-bs-toggle="dropdown" aria-expanded="false">
           Preguntas
          </a>
          <ul class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
            <li><a class="dropdown-item" href="alta.php">Alta</a></li>
            <li><a class="dropdown-item" href="listado.php">Mis preguntas</a></li>
            <?php
                if ($_SESSION['rol'] == "gerente") {
                ?>
                <li><a class="dropdown-item" href="todasPreguntas.php">Listado Todas</a></li>
                <?php
                }
                ?>
        </ul>
        </li>
        <?php
        }
        ?>
        <?php
          if(!isset($_SESSION['nombre_usuario'])) {
          ?>
          <li class="nav-item">
              <a class="nav-link white" href="login.php"><i class="bi bi-person-circle"></i>Login</a>
          </li>
          <?php
          } else {
          ?>
          <li class="nav-item dropdown">
              <a class="nav-link dropdown-toggle white" href="#" id="navbarDropdownMenuLink" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                  <i class="bi bi-person-circle"></i><?php echo $_SESSION['nombre_usuario']; ?>
              </a>
              <ul class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
              <li><a class="dropdown-item" href="editperfil.php">Perfil</a></li>
                  <li><a class="dropdown-item" href="php/close_session.php"><i class="bi bi-box-arrow-in-left"></i>Cerrar Sesión</a></li>
              </ul>
          </li>
          <?php
          }
          ?>

      </ul>
    </div>
  </div>
</nav>