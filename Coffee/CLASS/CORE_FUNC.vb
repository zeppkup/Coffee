Imports System.Data.SqlClient
Public MustInherit Class MAINCONTEXT
    Public dbpage As New LINQDataContext

    Public datas

    Public Interface MAIN
        Sub insert()
        Sub delete()
        Sub update()
    End Interface
End Class


Public Class CORE_FUNC
    Inherits Controller
    Public Function LOAD() As MODEL
        Dim model As New MODEL
        Dim cfm As New TB_coffee_menu
        Dim cfd As New TB_coffee_detail
        Dim cfo As New TB_coffee_order_main
        Dim cfod As New TB_coffee_order_main_detail
        Dim cfodo As New TB_coffee_order_main_detail_option
        Dim cf As New TB_coffee_order
        cfm.GETDATA_ALL()
        cfd.GETDATA_ALL()
        cfo.GETDATA_DATE(Date.Now)
        cfod.GETDATA_ALL()
        cfodo.GETDATA_ALL()
        cf.GETDATA_ALL()
        model.L_coffee_detail = cfd.Details
        model.L_coffee_menu = cfm.Details
        model.L_coffee_order_main = cfo.Details
        model.L_coffee_order_main_detail = cfod.Details
        model.L_coffee_order_main_detail_option = cfodo.Details
        model.L_coffee_order = cf.Details
        Return model
    End Function
    Public Sub SAVE_MENU(ByVal model As MODEL)

        Dim cfm As New TB_coffee_menu
        If model.coffee_menu.ID > 0 And model.coffee_menu.NAME_COFFEE IsNot Nothing Then
            cfm.GETDATA_ID(model.coffee_menu.ID)
            cfm.fields.NAME_COFFEE = model.coffee_menu.NAME_COFFEE
            cfm.fields.PREICE_COFFEE_HOT = model.coffee_menu.PREICE_COFFEE_HOT
            cfm.fields.PREICE_COFFEE_COOL = model.coffee_menu.PREICE_COFFEE_COOL
            cfm.update()
        ElseIf model.coffee_menu.NAME_COFFEE Is Nothing Then
            cfm.GETDATA_ID(model.coffee_menu.ID)
            cfm.delete()
        Else
            cfm.fields.NAME_COFFEE = model.coffee_menu.NAME_COFFEE
            cfm.fields.PREICE_COFFEE_HOT = model.coffee_menu.PREICE_COFFEE_HOT
            cfm.fields.PREICE_COFFEE_COOL = model.coffee_menu.PREICE_COFFEE_COOL
            cfm.insert()
        End If
    End Sub
    Public Sub SAVE_ORDER(ByVal model As MODEL)
        Dim cfo As New TB_coffee_order
        If model.coffee_order.ID > 0 And model.coffee_order.NAME_COFFEE IsNot Nothing Then
            cfo.GETDATA_ID(model.coffee_order.ID)
            cfo.fields.NAME_COFFEE = model.coffee_order.NAME_COFFEE
            cfo.fields.NAME_DETAIL = model.coffee_order.NAME_DETAIL
            cfo.fields.PRICE = model.coffee_order.PRICE
            cfo.update()
        ElseIf model.coffee_order.ID > 0 And model.coffee_order.NAME_COFFEE Is Nothing Then
            cfo.GETDATA_ID(model.coffee_order.ID)
            cfo.delete()
        Else
            cfo.fields.NAME_COFFEE = model.coffee_order.NAME_COFFEE
            cfo.fields.NAME_DETAIL = model.coffee_order.NAME_DETAIL
            cfo.fields.PRICE = model.coffee_order.PRICE
            cfo.insert()
        End If

    End Sub
    Public Sub SAVE_ORDER_MAIN(ByVal model As MODEL)

        Dim com As New TB_coffee_order_main
        Dim cmd As New TB_coffee_order_main_detail
        Dim total As New Integer
        'If model.coffee_order_main.ID > 0 And model.coffee_order_main.NAME_MENU IsNot Nothing Then
        '    com.GETDATA_ID(model.coffee_order_main.ID)
        '    com.fields = model.coffee_order_main

        '    com.update()

        '    cmd.GETDATA_FK(model.coffee_order_main.ID)

        '    For Each item In cmd.Details
        '        Dim cmd1 As New TB_coffee_order_main_detail
        '        cmd1.GETDATA_ID(item.ID)
        '        Dim cdo As New TB_coffee_order_main_detail_option
        '        cdo.GETDATA_FK(item.ID)
        '        For Each item2 In cdo.Details
        '            Dim cdo2 As New TB_coffee_order_main_detail_option
        '            cdo2.GETDATA_ID(item2.ID)
        '            cdo2.delete()
        '        Next
        '        cmd1.delete()
        '    Next
        '    For Each item In model.L_coffee_order_main_detail
        '        Dim cmd1 As New TB_coffee_order_main_detail
        '        cmd1.fields = item
        '        cmd1.fields.FK_ID = com.fields.ID
        '        cmd1.insert()
        '        For Each item2 In model.L_coffee_order_main_detail_option

        '            Dim cdo2 As New TB_coffee_order_main_detail_option
        '            cdo2.fields.NAME_OPTION = item2.NAME_OPTION
        '            cdo2.fields.PRICE_OPTION = item2.PRICE_OPTION
        '            cdo2.fields.NUMBER = item2.NUMBER
        '            cdo2.fields.FK_ID = cmd1.fields.ID
        '            cdo2.fields.FK_MAIN_ID = com.fields.ID
        '            cdo2.insert()


        '        Next

        '    Next
        'Else
        If model.coffee_order_main.ID > 0 And model.coffee_order_main.NAME_MENU Is Nothing Then
            com.GETDATA_ID(model.coffee_order_main.ID)
            cmd.GETDATA_FK(model.coffee_order_main.ID)
            For Each item In cmd.Details
                Dim cmd1 As New TB_coffee_order_main_detail
                cmd1.GETDATA_ID(item.ID)
                Dim cdo As New TB_coffee_order_main_detail_option
                cdo.GETDATA_FK(item.ID)
                For Each item2 In cdo.Details
                    Dim cdo2 As New TB_coffee_order_main_detail_option
                    cdo2.GETDATA_ID(item2.ID)
                    cdo2.delete()
                Next
                cmd1.delete()
            Next
            com.delete()
        Else
            com.fields = model.coffee_order_main
            com.fields.DATE_ORDER = Date.Now
            com.insert()
            Dim index = 0
            For Each item In model.L_coffee_order_main_detail
                Dim cmd1 As New TB_coffee_order_main_detail
                cmd1.fields = item
                cmd1.fields.FK_ID = com.fields.ID

                cmd1.insert()
                total += item.PRICE
                For Each item2 In model.L_coffee_order_main_detail_option
                    Dim cdo2 As New TB_coffee_order_main_detail_option
                    If index = item2.FK_ID Then
                        cdo2.fields.NAME_OPTION = item2.NAME_OPTION
                        cdo2.fields.PRICE_OPTION = item2.PRICE_OPTION
                        cdo2.fields.NUMBER = item2.NUMBER
                        cdo2.fields.FK_ID = cmd1.fields.ID
                        cdo2.fields.FK_MAIN_ID = com.fields.ID
                        cdo2.insert()
                        total += item2.PRICE_OPTION
                    End If
                Next
                index += 1
            Next
            com.fields.TOTAL_PRICE = total
            com.update()
        End If
    End Sub
    Public Class TB_coffee_detail
        Inherits MAINCONTEXT
        Public fields As New coffee_detail

        Private _Details As New List(Of coffee_detail)
        Public Property Details() As List(Of coffee_detail)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of coffee_detail))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New coffee_detail
        End Sub


        Public Sub GETDATA_ALL()
            datas = (From p In dbpage.coffee_details Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
    End Class
    Public Class TB_coffee_menu
        Inherits MAINCONTEXT
        Public fields As New coffee_menu

        Private _Details As New List(Of coffee_menu)
        Public Property Details() As List(Of coffee_menu)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of coffee_menu))
                _Details = value
            End Set
        End Property
        Public Sub insert()
            dbpage.coffee_menus.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub
        Public Sub delete()
            dbpage.coffee_menus.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Private Sub AddDetails()
            Details.Add(fields)
            fields = New coffee_menu
        End Sub


        Public Sub GETDATA_ALL()
            datas = (From p In dbpage.coffee_menus Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
        Public Sub GETDATA_ID(ByVal id As String)
            datas = (From p In dbpage.coffee_menus Where p.ID = id Select p)
            For Each Me.fields In datas

            Next
        End Sub
    End Class
    Public Class TB_coffee_order
        Inherits MAINCONTEXT
        Public fields As New coffee_order

        Private _Details As New List(Of coffee_order)
        Public Property Details() As List(Of coffee_order)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of coffee_order))
                _Details = value
            End Set
        End Property
        Public Sub insert()
            dbpage.coffee_orders.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub
        Public Sub delete()
            dbpage.coffee_orders.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Private Sub AddDetails()
            Details.Add(fields)
            fields = New coffee_order
        End Sub


        Public Sub GETDATA_ALL()
            datas = (From p In dbpage.coffee_orders Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
        Public Sub GETDATA_ID(ByVal id As String)
            datas = (From p In dbpage.coffee_orders Where p.ID = id Select p)
            For Each Me.fields In datas

            Next
        End Sub
    End Class
    Public Class TB_coffee_order_main
        Inherits MAINCONTEXT
        Public fields As New coffee_order_main

        Private _Details As New List(Of coffee_order_main)
        Public Property Details() As List(Of coffee_order_main)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of coffee_order_main))
                _Details = value
            End Set
        End Property
        Public Sub insert()
            dbpage.coffee_order_mains.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub
        Public Sub delete()
            dbpage.coffee_order_mains.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Private Sub AddDetails()
            Details.Add(fields)
            fields = New coffee_order_main
        End Sub


        Public Sub GETDATA_ALL()
            datas = (From p In dbpage.coffee_order_mains Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
        Public Sub GETDATA_DATE(ByVal datev As Date)
            datas = (From p In dbpage.coffee_order_mains Where p.DATE_ORDER = datev Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
        Public Sub GETDATA_ID(ByVal id As String)
            datas = (From p In dbpage.coffee_order_mains Where p.ID = id Select p)
            For Each Me.fields In datas

            Next
        End Sub
    End Class
    Public Class TB_coffee_order_main_detail
        Inherits MAINCONTEXT
        Public fields As New coffee_order_main_detail

        Private _Details As New List(Of coffee_order_main_detail)
        Public Property Details() As List(Of coffee_order_main_detail)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of coffee_order_main_detail))
                _Details = value
            End Set
        End Property
        Public Sub insert()
            dbpage.coffee_order_main_details.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub
        Public Sub delete()
            dbpage.coffee_order_main_details.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Private Sub AddDetails()
            Details.Add(fields)
            fields = New coffee_order_main_detail
        End Sub


        Public Sub GETDATA_ALL()
            datas = (From p In dbpage.coffee_order_main_details Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
        Public Sub GETDATA_ID(ByVal id As String)
            datas = (From p In dbpage.coffee_order_main_details Where p.ID = id Select p)
            For Each Me.fields In datas

            Next
        End Sub
        Public Sub GETDATA_FK(ByVal FK As String)
            datas = (From p In dbpage.coffee_order_main_details Where p.FK_ID = FK Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
    End Class
    Public Class TB_coffee_order_main_detail_option
        Inherits MAINCONTEXT
        Public fields As New coffee_order_main_detail_option

        Private _Details As New List(Of coffee_order_main_detail_option)
        Public Property Details() As List(Of coffee_order_main_detail_option)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of coffee_order_main_detail_option))
                _Details = value
            End Set
        End Property
        Public Sub insert()
            dbpage.coffee_order_main_detail_options.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub
        Public Sub delete()
            dbpage.coffee_order_main_detail_options.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Private Sub AddDetails()
            Details.Add(fields)
            fields = New coffee_order_main_detail_option
        End Sub


        Public Sub GETDATA_ALL()
            datas = (From p In dbpage.coffee_order_main_detail_options Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
        Public Sub GETDATA_ID(ByVal id As String)
            datas = (From p In dbpage.coffee_order_main_detail_options Where p.ID = id Select p)
            For Each Me.fields In datas
            Next
        End Sub
        Public Sub GETDATA_FK(ByVal FK As String)
            datas = (From p In dbpage.coffee_order_main_detail_options Where p.FK_ID = FK Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
    End Class
End Class
