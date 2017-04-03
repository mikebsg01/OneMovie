<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="apple-touch-icon" href="~/assets/images/logo_icons/apple-touch-icon.png">
    <link rel="icon" type="image/png" sizes="192x192" href="~/assets/images/logo_icons/android-chrome-192x192.png">
    <link rel="icon" type="image/png" sizes="256x256" href="~/assets/images/logo_icons/android-chrome-256x256.png">
    <link rel="icon" type="image/png" sizes="32x32" href="~/assets/images/logo_icons/favicon-32x32.png">
    <link rel="shortcut icon" type="image/png" sizes="16x16" href="~/assets/images/logo_icons/favicon-16x16.png">
    <link rel="manifest" href="~/assets/images/logo_icons/manifest.json">
    <meta name="msapplication-TileColor" content="#ffffff">
    <meta name="msapplication-TileImage" content="~/assets/images/logo_icons/mstile-150x150.png">
    <title>@ViewData("Title") - OneMovie</title>
    <link href="https://fonts.googleapis.com/css?family=Roboto:400,500,700,900" rel="stylesheet">
    <link rel="stylesheet" href="~/assets/lib/bootstrap/dist/css/bootstrap.css" />
    <link rel="stylesheet" href="~/assets/lib/bootstrap-material-design/dist/bootstrap-material-design.min.css">
    <link rel="stylesheet" href="~/assets/lib/bootstrap-material-design/dist/ripples.min.css">
    <link rel="stylesheet" href="~/assets/css/site.css" />
</head>
<body>
    <nav class="app-navbar navbar navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a href="/" class="navbar-brand">
                    <img src="~/assets/images/logo_images/OneMovie-logo.png" alt="OneMovie - Logo" title="OneMovie - Logo" class="logo">
                </a>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="/Home/Contact">Contacto</a></li>
                </ul>
            </div>
        </div>
    </nav>
    <div class="body-content">
        <div class="main-content container">
            @RenderBody()
            <div class="col-xs-12">
                <hr />
                <footer>
                    <p>&copy; 2017 - OneMovie</p>
                </footer>
            </div>
        </div>
    </div>
    <script src="~/assets/lib/jquery/dist/jquery.js"></script>
    <script src="~/assets/lib/bootstrap/dist/js/bootstrap.js"></script>
    <script src="~/assets/js/app.js" asp-append-version="true"></script>
</body>
</html>
