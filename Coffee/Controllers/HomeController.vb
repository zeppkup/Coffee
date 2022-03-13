Imports System.Web.Mvc
Imports System.Web.Script.Serialization

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function GETMENU(ByVal FUNC As String, ByVal data As String) As JsonResult
        Dim core As New CORE_FUNC
        Dim model As New MODEL
        Dim jss As New JavaScriptSerializer
        model = If(data IsNot Nothing, jss.Deserialize(data, GetType(MODEL)), model)
        If FUNC = 1 Then
            model = core.LOAD()
        ElseIf FUNC = 2 Then
            core.SAVE_MENU(model)
            model = core.LOAD()
        ElseIf FUNC = 3 Then
            core.SAVE_ORDER_MAIN(model)
            model = core.LOAD()
        ElseIf FUNC = 4 Then
            core.SAVE_ORDER(model)
            model = core.LOAD()
        End If
        Dim json_model = Json(model, JsonRequestBehavior.AllowGet)
        If json_model.Data Is Nothing Then
            Throw New Exception
        End If
        json_model.MaxJsonLength = Integer.MaxValue
        Return json_model
    End Function

End Class
