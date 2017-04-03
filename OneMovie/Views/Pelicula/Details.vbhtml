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
                        End Select
                    </a>
                </div>
                <div>
                    <header>
                        <h1>
                            @ViewData("NombrePelicula")
                        </h1>
                    </header>
                </div>
            </div>
        </div>
    </div>
</div>

     
