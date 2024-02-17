<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="./public/css/style.css">
    <title>MVC</title>
</head>

<body>
    <div class="dashboard">
        <div class="dashboard_nav">
            <h2><a href="./">PROYECTO MVC</a></h2>
            <hr>
            <a href="main">Main</a>
            <a href="categoria">Categoria</a>
            <a href="errores">Errores</a>
            <a href="user">Usuario</a>
        </div>
        <div class="dashboard_body">
            <div class="dashboard_body_header"><?php require_once "./views/header.php"?></div>
            <div class="dashboard_body_content">
            <?php 
            require_once "libs/app.php";
            require_once "libs/controller.php";
            require_once "libs/model.php";
            require_once "libs/view.php";
            $app = new App();
            ; ?>
            </div>
            <div class="dashboard_body_footer"><?php require_once "./views/footer.php"?></div>
        </div>
    </div>
</body>

</html>

</html>