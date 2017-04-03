Public Class HomeController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /Home

    Function Index() As ActionResult
        Return View()
    End Function

    Function Contact() As ActionResult
        Return Content("Contacto")
    End Function

End Class