@Code
    ViewData("Title") = "Inicio"
End Code

<div id="main-carousel" class="carousel slide" data-ride="carousel" data-interval="6000">
    <ol class="carousel-indicators">
        <li data-target="#main-carousel" data-slide-to="0" class="active"></li>
        <li data-target="#main-carousel" data-slide-to="1"></li>
        <li data-target="#main-carousel" data-slide-to="2"></li>
        <li data-target="#main-carousel" data-slide-to="3"></li>
    </ol>
    <div class="carousel-inner" role="listbox">
        <div class="item active">
            <img src="~/assets/images/carousel/1-FastFurious.jpg" alt="ASP.NET" class="img-responsive" />
            <div class="carousel-caption" role="option">
                <p>
                    Proximamente
                    <br>
                    <a class="btn btn-raised btn-warning" href="https://go.microsoft.com/fwlink/?LinkID=525028&clcid=0x409">
                        Ver más
                    </a>
                </p>
            </div>
        </div>
        <div class="item">
            <img src="~/assets/images/carousel/1-FastFurious.jpg" alt="Visual Studio" class="img-responsive" />
            <div class="carousel-caption" role="option">
                <p>
                    There are powerful new features in Visual Studio for building modern web apps.
                    <a class="btn btn-warning" href="https://go.microsoft.com/fwlink/?LinkID=525030&clcid=0x409">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
        <div class="item">
            <img src="~/assets/images/carousel/1-FastFurious.jpg" alt="Package Management" class="img-responsive" />
            <div class="carousel-caption" role="option">
                <p>
                    Bring in libraries from NuGet, Bower, and npm, and automate tasks using Grunt or Gulp.
                    <a class="btn btn-warning" href="https://go.microsoft.com/fwlink/?LinkID=525029&clcid=0x409">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
        <div class="item">
            <img src="~/assets/images/carousel/1-FastFurious.jpg" alt="Microsoft Azure" class="img-responsive" />
            <div class="carousel-caption" role="option">
                <p>
                    Learn how Microsoft's Azure cloud platform allows you to build, deploy, and scale web apps.
                    <a class="btn btn-warning" href="https://go.microsoft.com/fwlink/?LinkID=525027&clcid=0x409">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
    </div>
    <a class="left carousel-control" href="#main-carousel" role="button" data-slide="prev">
        <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
        <span class="sr-only">Previous</span>
    </a>
    <a class="right carousel-control" href="#main-carousel" role="button" data-slide="next">
        <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
        <span class="sr-only">Next</span>
    </a>
</div>
<div class="app-list-of-movies col-xs-12 top-padding">
    <div class="col-md-3">
        <div class="panel panel-primary">
            <div class="panel-heading">
                <h3 class="panel-title">
                    50 Sombras Oscuras
                    <span class="label label-warning pull-right">
                        DOB
                    </span>
                </h3>
            </div>
            <div class="panel-body">
                <a href="/Pelicula/50 Sombras Oscuras" class="thumbnail">
                    <img src="~/assets/images/movie-50SombrasOscuras.jpg">
                </a>
                <div class="description">
                    <p>Cincuenta sombras más oscuras es una película dramática, romántica y erótica dirigida por James Foley, secuela de Cincuenta sombras de Grey.</p>
                </div>
                <span class="label label-danger">11:00AM</span>
                <span class="label label-danger">13:30PM</span>
                <span class="label label-danger">15:00PM</span>
                <span class="label label-danger">16:30PM</span>
                <span class="label label-danger">18:00PM</span>
                <span class="label label-danger">19:30PM</span>
            </div>
        </div>
    </div>
    <div class="col-md-3">
        <div class="panel panel-primary">
            <div class="panel-heading">
                <h3 class="panel-title">
                    Lego Batman
                    <span class="label label-warning pull-right">
                        DOB
                    </span>
                </h3>
            </div>
            <div class="panel-body">
                <a href="/Pelicula/Lego Batman" class="thumbnail">
                    <img src="~/assets/images/movie-legoBatman.jpg">
                </a>
                <div class="description">
                    <p>The Lego Batman Movie es una comedia de aventuras animada por computadora producida en Estados Unidos para estrenarse el 9 de febrero del 2017, spin-off de The Lego Movie.</p>
                </div>
                <span class="label label-danger">11:00AM</span>
                <span class="label label-danger">13:30PM</span>
                <span class="label label-danger">15:00PM</span>
                <span class="label label-danger">16:30PM</span>
                <span class="label label-danger">18:00PM</span>
                <span class="label label-danger">19:30PM</span>
            </div>
        </div>
    </div>
    <div class="col-md-3">
        <div class="panel panel-primary">
            <div class="panel-heading">
                <h3 class="panel-title">
                    Power Rangers
                    <span class="label label-warning pull-right">
                        DOB
                    </span>
                </h3>
            </div>
            <div class="panel-body">
                <a href="#" class="thumbnail">
                    <img src="~/assets/images/movie-PowerRangers.jpg">
                </a>
                <div class="description">
                    <p>Power Rangers es una película de superhéroes estadounidense de 2017 dirigida por Dean Israelite y escrita por John Gatins, Kieran Mulroney, Michele Mulroney, Matt Sazama y Burk Sharpless.</p>
                </div>
                <span class="label label-danger">11:00AM</span>
                <span class="label label-danger">13:30PM</span>
                <span class="label label-danger">15:00PM</span>
                <span class="label label-danger">16:30PM</span>
                <span class="label label-danger">18:00PM</span>
                <span class="label label-danger">19:30PM</span>
            </div>
        </div>
    </div>
    <div class="col-md-3">
        <div class="panel panel-primary">
            <div class="panel-heading">
                <h3 class="panel-title">
                    Un Jefe En Pañales
                    <span class="label label-warning pull-right">
                        SUB
                    </span>
                </h3>
            </div>
            <div class="panel-body">
                <a href="#" class="thumbnail">
                    <img src="~/assets/images/movie-UnJefeEnPañales.jpg">
                </a>
                <div class="description">
                    <p>Un peculiar bebé, que viste traje y corbata y lleva maletín, y su hermano Tim, de 7 años, tratarán de detener los malvados planes del director de la empresa Puppy Corporation.</p>
                </div>
                <span class="label label-danger">11:00AM</span>
                <span class="label label-danger">13:30PM</span>
                <span class="label label-danger">15:00PM</span>
                <span class="label label-danger">16:30PM</span>
                <span class="label label-danger">18:00PM</span>
                <span class="label label-danger">19:30PM</span>
            </div>
        </div>
    </div>
    <div class="col-md-3">
        <div class="panel panel-primary">
            <div class="panel-heading">
                <h3 class="panel-title">
                    La Vigilante del Futuro
                    <span class="label label-warning pull-right">
                        SUB
                    </span>
                </h3>
            </div>
            <div class="panel-body">
                <a href="#" class="thumbnail">
                    <img src="~/assets/images/movie-LaVigilanteDelFuturo.jpg">
                </a>
                <div class="description">
                    <p>Ghost in the Shell es una película estadounidense de acción y ciencia ficción dirigida por Rupert Sanders y escrita por Jamie Moss y Ehren Kruger, basada en el manga japonés homónimo de Masamune Shirow.</p>
                </div>
                <span class="label label-danger">11:00AM</span>
                <span class="label label-danger">13:30PM</span>
                <span class="label label-danger">15:00PM</span>
                <span class="label label-danger">16:30PM</span>
                <span class="label label-danger">18:00PM</span>
                <span class="label label-danger">19:30PM</span>
            </div>
        </div>
    </div>
    <div class="col-md-3">
        <div class="panel panel-primary">
            <div class="panel-heading">
                <h3 class="panel-title">
                    La Bella Y La Bestia
                    <span class="label label-warning pull-right">
                        DOB
                    </span>
                </h3>
            </div>
            <div class="panel-body">
                <a href="#" class="thumbnail">
                    <img src="~/assets/images/movie-LaBellaYLaBestia.jpg">
                </a>
                <div class="description">
                    <p>LA BELLA Y LA BESTIA, de Disney, es una adaptación de acción real de la película animada, que revive a los queridos personajes del clásico cuento de Disney para una audiencia contemporánea, manteniendo la música original e incorporando varias nuevas canciones.</p>
                </div>
                <span class="label label-danger">11:00AM</span>
                <span class="label label-danger">13:30PM</span>
                <span class="label label-danger">15:00PM</span>
                <span class="label label-danger">16:30PM</span>
                <span class="label label-danger">18:00PM</span>
                <span class="label label-danger">19:30PM</span>
            </div>
        </div>
    </div>
    <div class="col-md-3">
        <div class="panel panel-primary">
            <div class="panel-heading">
                <h3 class="panel-title">
                    3 Idiotas
                    <span class="label label-warning pull-right">
                        DOB
                    </span>
                </h3>
            </div>
            <div class="panel-body">
                <a href="#" class="thumbnail">
                    <img src="~/assets/images/movie-3Idiotas.jpg">
                </a>
                <div class="description">
                    <p>Un grupo de amigos se embarca en una aventura llena de diversión, decididos a encontrar a un compañero de la universidad que desapareció sin dejar rastro un día antes de la graduación. 5 años después de graduarse de la universidad, Felipe y Beto deciden buscar a Pancho, amigo entrañable y líder del grupo. Los tres amigos, todos estudiantes de Ingeniería, viven experiencias inolvidables durante sus años estudiantiles, creando un lazo de amistad y complicidad que logra superar hasta los obstáculos más inesperados.</p>
                </div>
                <span class="label label-danger">11:00AM</span>
                <span class="label label-danger">13:30PM</span>
                <span class="label label-danger">15:00PM</span>
                <span class="label label-danger">16:30PM</span>
                <span class="label label-danger">18:00PM</span>
                <span class="label label-danger">19:30PM</span>
            </div>
        </div>
    </div>
    <div class="col-md-3">
        <div class="panel panel-primary">
            <div class="panel-heading">
                <h3 class="panel-title">
                    El Origen del Terror en...
                    <span class="label label-warning pull-right">
                        SUB
                    </span>
                </h3>
            </div>
            <div class="panel-body">
                <a href="#" class="thumbnail">
                    <img src="~/assets/images/movie-ElOrigenDelTerrorEnAmityville.jpg">
                </a>
                <div class="description">
                    <p>En 1997 la familia Anderson desapareció, sus cuerpos nunca fueron encontrados. Durante 17 años la casa se había mantenido intacta...hasta ahora. El mal siempre estuvo ahí</p>
                </div>
                <span class="label label-danger">11:00AM</span>
                <span class="label label-danger">13:30PM</span>
                <span class="label label-danger">15:00PM</span>
                <span class="label label-danger">16:30PM</span>
                <span class="label label-danger">18:00PM</span>
                <span class="label label-danger">19:30PM</span>
            </div>
        </div>
    </div>
</div>