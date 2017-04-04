@Code
    ViewData("Title") = ViewData("NombrePelicula")
End Code

<div class="col-xs-12 top-padding">
    <div class="col-md-8 col-md-offset-2">
        <div class="panel panel-primary padding-1">
            <div class="panel-heading">
                <span class="panel-title">Detalles</span>
            </div>
            <div class="panel-body">
                <div class="col-md-4">
                    <a href="#" class="thumbnail">
                        @Select Case ViewData("NombrePelicula")
                            Case "50 Sombras Oscuras"
                            @<img src="~/assets/images/movie-50SombrasOscuras.jpg">
                            Case "Lego Batman"
                            @<img src="~/assets/images/movie-legoBatman.jpg">
                            Case "Power Rangers"
                            @<img src="~/assets/images/movie-PowerRangers.jpg">
                            Case "Un Jefe En Pañales"
                            @<img src="~/assets/images/movie-UnJefeEnPañales.jpg">
                            Case "La Vigilante del Futuro"
                            @<img src="~/assets/images/movie-LaVigilanteDelFuturo.jpg">
                            Case "La Bella Y La Bestia"
                            @<img src="~/assets/images/movie-LaBellaYLaBestia.jpg">
                            Case "3 Idiotas"
                            @<img src="~/assets/images/movie-3Idiotas.jpg">
                            Case "El Origen del Terror en Amityville"
                            @<img src="~/assets/images/movie-ElOrigenDelTerrorEnAmityville.jpg">
                        End Select
                    </a>
                </div>
                <div class="col-md-8">
                    <header>
                        <h1>
                            @ViewData("NombrePelicula")
                        </h1>
                    </header>                   
                    <div class="col-xs-12">
                        @Select Case ViewData("NombrePelicula")
                            Case "50 Sombras Oscuras"
                            @<div class="col-xs-12" style="padding-left: 0 !important;">
                                <div class="col-md-4" style="padding-left: 0 !important;">
                                    <header>
                                        <h2 class="h5">Clasificación</h2>
                                    </header>
                                    <span class="label label-default h2">B</span>
                                </div>
                                <div class="col-md-4">
                                    <header>
                                        <h2 class="h5">Duración</h2>
                                    </header>
                                    <span>98min</span>
                                </div>
                            </div>
                            Case "Lego Batman"
                            @<span class="label label-default h2">AA</span>
                            Case "Power Rangers"
                            @<span class="label label-default h2">A</span>
                            Case "Un Jefe En Pañales"
                            @<span class="label label-default h2">AA</span>
                            Case "La Vigilante del Futuro"
                            @<span class="label label-default h2">B</span>
                            Case "La Bella Y La Bestia"
                            @<span class="label label-default h2">AA</span>
                            Case "3 Idiotas"
                            @<span class="label label-default h2">B</span>
                            Case "El Origen del Terror en Amityville"
                            @<span class="label label-default h2">C</span>
                        End Select
                    </div>
                    <div class="col-xs-12">
                        <header>
                            <h2 class="h5">Sinopsis</h2>
                        </header>
                        @Select Case ViewData("NombrePelicula")
                            Case "50 Sombras Oscuras"
                            @<p>Cincuenta sombras más oscuras es una película dramática, romántica y erótica dirigida por James Foley, secuela de Cincuenta sombras de Grey.</p>
                            Case "Lego Batman"
                            @<p>The Lego Batman Movie es una comedia de aventuras animada por computadora producida en Estados Unidos para estrenarse el 9 de febrero del 2017, spin-off de The Lego Movie.</p>
                            Case "Power Rangers"
                            @<p>Power Rangers es una película de superhéroes estadounidense de 2017 dirigida por Dean Israelite y escrita por John Gatins, Kieran Mulroney, Michele Mulroney, Matt Sazama y Burk Sharpless.</p>
                            Case "Un Jefe En Pañales"
                            @<p>Un peculiar bebé, que viste traje y corbata y lleva maletín, y su hermano Tim, de 7 años, tratarán de detener los malvados planes del director de la empresa Puppy Corporation.</p>
                            Case "La Vigilante del Futuro"
                            @<p>Ghost in the Shell es una película estadounidense de acción y ciencia ficción dirigida por Rupert Sanders y escrita por Jamie Moss y Ehren Kruger, basada en el manga japonés homónimo de Masamune Shirow.</p>
                            Case "La Bella Y La Bestia"
                            @<p>LA BELLA Y LA BESTIA, de Disney, es una adaptación de acción real de la película animada, que revive a los queridos personajes del clásico cuento de Disney para una audiencia contemporánea, manteniendo la música original e incorporando varias nuevas canciones.</p>
                            Case "3 Idiotas"
                            @<p>Un grupo de amigos se embarca en una aventura llena de diversión, decididos a encontrar a un compañero de la universidad que desapareció sin dejar rastro un día antes de la graduación. 5 años después de graduarse de la universidad, Felipe y Beto deciden buscar a Pancho, amigo entrañable y líder del grupo. Los tres amigos, todos estudiantes de Ingeniería, viven experiencias inolvidables durante sus años estudiantiles, creando un lazo de amistad y complicidad que logra superar hasta los obstáculos más inesperados.</p>
                            Case "El Origen del Terror en Amityville"
                            @<p>En 1997 la familia Anderson desapareció, sus cuerpos nunca fueron encontrados. Durante 17 años la casa se había mantenido intacta...hasta ahora. El mal siempre estuvo ahí</p>
                        End Select
                    </div>
                    <div class="col-xs-12">
                        <header>
                            <h2 class="h5">Horarios</h2>
                        </header>
                        <span class="label label-danger">11:00AM</span>
                        <span class="label label-danger">13:30PM</span>
                        <span class="label label-danger">15:00PM</span>
                        <span class="label label-danger">16:30PM</span>
                        <span class="label label-danger">18:00PM</span>
                        <span class="label label-danger">19:30PM</span>
                    </div>
                    <div class="col-xs-12 text-center top-margin">
                        <a href="#" class="btn btn-success">Comprar Boletos</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

     
