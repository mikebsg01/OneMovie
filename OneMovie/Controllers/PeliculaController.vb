Public Class PeliculaController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /Pelicula

    Function Details(ByVal NombrePelicula As String) As ActionResult
        ViewData("NombrePelicula") = NombrePelicula
        Return View()
    End Function

End Class