Imports System.Web.Script.Serialization

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Public Function Index() As ActionResult
        'default data
        Dim model As OrdersModel = New OrdersModel With { _
            .StartDate = New DateTime(1996, 8, 1), _
            .EndDate = New DateTime(1996, 8, 30) _
        }

        Return View(model)
    End Function

    <HttpPost()> _
    Public Function GridViewPartial() As ActionResult
        ' http://msdn.microsoft.com/en-us/library/bb299886.aspx 
        Dim serializer As New JavaScriptSerializer()

        Dim model As OrdersModel = New OrdersModel With { _
            .StartDate = serializer.Deserialize(Of DateTime)(Request.Params("StartDate")).ToLocalTime(), _
            .EndDate = serializer.Deserialize(Of DateTime)(Request.Params("EndDate")).ToLocalTime() _
        }

        Return PartialView("_GridView", model.Data)
    End Function
End Class
