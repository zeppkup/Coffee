﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="test")>  _
Partial Public Class LINQDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub Insertcoffee_detail(instance As coffee_detail)
    End Sub
  Partial Private Sub Updatecoffee_detail(instance As coffee_detail)
    End Sub
  Partial Private Sub Deletecoffee_detail(instance As coffee_detail)
    End Sub
  Partial Private Sub Insertcoffee_order_main_detail_option(instance As coffee_order_main_detail_option)
    End Sub
  Partial Private Sub Updatecoffee_order_main_detail_option(instance As coffee_order_main_detail_option)
    End Sub
  Partial Private Sub Deletecoffee_order_main_detail_option(instance As coffee_order_main_detail_option)
    End Sub
  Partial Private Sub Insertcoffee_menu(instance As coffee_menu)
    End Sub
  Partial Private Sub Updatecoffee_menu(instance As coffee_menu)
    End Sub
  Partial Private Sub Deletecoffee_menu(instance As coffee_menu)
    End Sub
  Partial Private Sub Insertcoffee_order(instance As coffee_order)
    End Sub
  Partial Private Sub Updatecoffee_order(instance As coffee_order)
    End Sub
  Partial Private Sub Deletecoffee_order(instance As coffee_order)
    End Sub
  Partial Private Sub Insertcoffee_order_main(instance As coffee_order_main)
    End Sub
  Partial Private Sub Updatecoffee_order_main(instance As coffee_order_main)
    End Sub
  Partial Private Sub Deletecoffee_order_main(instance As coffee_order_main)
    End Sub
  Partial Private Sub Insertcoffee_order_main_detail(instance As coffee_order_main_detail)
    End Sub
  Partial Private Sub Updatecoffee_order_main_detail(instance As coffee_order_main_detail)
    End Sub
  Partial Private Sub Deletecoffee_order_main_detail(instance As coffee_order_main_detail)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("testConnectionString").ConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property coffee_details() As System.Data.Linq.Table(Of coffee_detail)
		Get
			Return Me.GetTable(Of coffee_detail)
		End Get
	End Property
	
	Public ReadOnly Property coffee_order_main_detail_options() As System.Data.Linq.Table(Of coffee_order_main_detail_option)
		Get
			Return Me.GetTable(Of coffee_order_main_detail_option)
		End Get
	End Property
	
	Public ReadOnly Property coffee_menus() As System.Data.Linq.Table(Of coffee_menu)
		Get
			Return Me.GetTable(Of coffee_menu)
		End Get
	End Property
	
	Public ReadOnly Property coffee_orders() As System.Data.Linq.Table(Of coffee_order)
		Get
			Return Me.GetTable(Of coffee_order)
		End Get
	End Property
	
	Public ReadOnly Property coffee_order_mains() As System.Data.Linq.Table(Of coffee_order_main)
		Get
			Return Me.GetTable(Of coffee_order_main)
		End Get
	End Property
	
	Public ReadOnly Property coffee_order_main_details() As System.Data.Linq.Table(Of coffee_order_main_detail)
		Get
			Return Me.GetTable(Of coffee_order_main_detail)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.coffee_detail")>  _
Partial Public Class coffee_detail
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As Integer
	
	Private _FK_ID As System.Nullable(Of Integer)
	
	Private _OPTION_DETAIL As String
	
	Private _OPTION_PRICE As System.Nullable(Of Integer)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnFK_IDChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnFK_IDChanged()
    End Sub
    Partial Private Sub OnOPTION_DETAILChanging(value As String)
    End Sub
    Partial Private Sub OnOPTION_DETAILChanged()
    End Sub
    Partial Private Sub OnOPTION_PRICEChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnOPTION_PRICEChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID() As Integer
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FK_ID", DbType:="Int")>  _
	Public Property FK_ID() As System.Nullable(Of Integer)
		Get
			Return Me._FK_ID
		End Get
		Set
			If (Me._FK_ID.Equals(value) = false) Then
				Me.OnFK_IDChanging(value)
				Me.SendPropertyChanging
				Me._FK_ID = value
				Me.SendPropertyChanged("FK_ID")
				Me.OnFK_IDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OPTION_DETAIL", DbType:="NVarChar(50)")>  _
	Public Property OPTION_DETAIL() As String
		Get
			Return Me._OPTION_DETAIL
		End Get
		Set
			If (String.Equals(Me._OPTION_DETAIL, value) = false) Then
				Me.OnOPTION_DETAILChanging(value)
				Me.SendPropertyChanging
				Me._OPTION_DETAIL = value
				Me.SendPropertyChanged("OPTION_DETAIL")
				Me.OnOPTION_DETAILChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OPTION_PRICE", DbType:="Int")>  _
	Public Property OPTION_PRICE() As System.Nullable(Of Integer)
		Get
			Return Me._OPTION_PRICE
		End Get
		Set
			If (Me._OPTION_PRICE.Equals(value) = false) Then
				Me.OnOPTION_PRICEChanging(value)
				Me.SendPropertyChanging
				Me._OPTION_PRICE = value
				Me.SendPropertyChanged("OPTION_PRICE")
				Me.OnOPTION_PRICEChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.coffee_order_main_detail_option")>  _
Partial Public Class coffee_order_main_detail_option
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As Integer
	
	Private _NAME_OPTION As String
	
	Private _PRICE_OPTION As String
	
	Private _FK_MAIN_ID As System.Nullable(Of Integer)
	
	Private _FK_ID As System.Nullable(Of Integer)
	
	Private _NUMBER As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnNAME_OPTIONChanging(value As String)
    End Sub
    Partial Private Sub OnNAME_OPTIONChanged()
    End Sub
    Partial Private Sub OnPRICE_OPTIONChanging(value As String)
    End Sub
    Partial Private Sub OnPRICE_OPTIONChanged()
    End Sub
    Partial Private Sub OnFK_MAIN_IDChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnFK_MAIN_IDChanged()
    End Sub
    Partial Private Sub OnFK_IDChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnFK_IDChanged()
    End Sub
    Partial Private Sub OnNUMBERChanging(value As String)
    End Sub
    Partial Private Sub OnNUMBERChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID() As Integer
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NAME_OPTION", DbType:="NVarChar(50)")>  _
	Public Property NAME_OPTION() As String
		Get
			Return Me._NAME_OPTION
		End Get
		Set
			If (String.Equals(Me._NAME_OPTION, value) = false) Then
				Me.OnNAME_OPTIONChanging(value)
				Me.SendPropertyChanging
				Me._NAME_OPTION = value
				Me.SendPropertyChanged("NAME_OPTION")
				Me.OnNAME_OPTIONChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PRICE_OPTION", DbType:="NVarChar(50)")>  _
	Public Property PRICE_OPTION() As String
		Get
			Return Me._PRICE_OPTION
		End Get
		Set
			If (String.Equals(Me._PRICE_OPTION, value) = false) Then
				Me.OnPRICE_OPTIONChanging(value)
				Me.SendPropertyChanging
				Me._PRICE_OPTION = value
				Me.SendPropertyChanged("PRICE_OPTION")
				Me.OnPRICE_OPTIONChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FK_MAIN_ID", DbType:="Int")>  _
	Public Property FK_MAIN_ID() As System.Nullable(Of Integer)
		Get
			Return Me._FK_MAIN_ID
		End Get
		Set
			If (Me._FK_MAIN_ID.Equals(value) = false) Then
				Me.OnFK_MAIN_IDChanging(value)
				Me.SendPropertyChanging
				Me._FK_MAIN_ID = value
				Me.SendPropertyChanged("FK_MAIN_ID")
				Me.OnFK_MAIN_IDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FK_ID", DbType:="Int")>  _
	Public Property FK_ID() As System.Nullable(Of Integer)
		Get
			Return Me._FK_ID
		End Get
		Set
			If (Me._FK_ID.Equals(value) = false) Then
				Me.OnFK_IDChanging(value)
				Me.SendPropertyChanging
				Me._FK_ID = value
				Me.SendPropertyChanged("FK_ID")
				Me.OnFK_IDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NUMBER", DbType:="NChar(10)")>  _
	Public Property NUMBER() As String
		Get
			Return Me._NUMBER
		End Get
		Set
			If (String.Equals(Me._NUMBER, value) = false) Then
				Me.OnNUMBERChanging(value)
				Me.SendPropertyChanging
				Me._NUMBER = value
				Me.SendPropertyChanged("NUMBER")
				Me.OnNUMBERChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.coffee_menu")>  _
Partial Public Class coffee_menu
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As Integer
	
	Private _NAME_COFFEE As String
	
	Private _PREICE_COFFEE_HOT As System.Nullable(Of Integer)
	
	Private _PREICE_COFFEE_COOL As System.Nullable(Of Integer)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnNAME_COFFEEChanging(value As String)
    End Sub
    Partial Private Sub OnNAME_COFFEEChanged()
    End Sub
    Partial Private Sub OnPREICE_COFFEE_HOTChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnPREICE_COFFEE_HOTChanged()
    End Sub
    Partial Private Sub OnPREICE_COFFEE_COOLChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnPREICE_COFFEE_COOLChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID() As Integer
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NAME_COFFEE", DbType:="NVarChar(50)")>  _
	Public Property NAME_COFFEE() As String
		Get
			Return Me._NAME_COFFEE
		End Get
		Set
			If (String.Equals(Me._NAME_COFFEE, value) = false) Then
				Me.OnNAME_COFFEEChanging(value)
				Me.SendPropertyChanging
				Me._NAME_COFFEE = value
				Me.SendPropertyChanged("NAME_COFFEE")
				Me.OnNAME_COFFEEChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PREICE_COFFEE_HOT", DbType:="Int")>  _
	Public Property PREICE_COFFEE_HOT() As System.Nullable(Of Integer)
		Get
			Return Me._PREICE_COFFEE_HOT
		End Get
		Set
			If (Me._PREICE_COFFEE_HOT.Equals(value) = false) Then
				Me.OnPREICE_COFFEE_HOTChanging(value)
				Me.SendPropertyChanging
				Me._PREICE_COFFEE_HOT = value
				Me.SendPropertyChanged("PREICE_COFFEE_HOT")
				Me.OnPREICE_COFFEE_HOTChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PREICE_COFFEE_COOL", DbType:="Int")>  _
	Public Property PREICE_COFFEE_COOL() As System.Nullable(Of Integer)
		Get
			Return Me._PREICE_COFFEE_COOL
		End Get
		Set
			If (Me._PREICE_COFFEE_COOL.Equals(value) = false) Then
				Me.OnPREICE_COFFEE_COOLChanging(value)
				Me.SendPropertyChanging
				Me._PREICE_COFFEE_COOL = value
				Me.SendPropertyChanged("PREICE_COFFEE_COOL")
				Me.OnPREICE_COFFEE_COOLChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.coffee_order")>  _
Partial Public Class coffee_order
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As Integer
	
	Private _NAME_COFFEE As String
	
	Private _NAME_DETAIL As String
	
	Private _PRICE As System.Nullable(Of Integer)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnNAME_COFFEEChanging(value As String)
    End Sub
    Partial Private Sub OnNAME_COFFEEChanged()
    End Sub
    Partial Private Sub OnNAME_DETAILChanging(value As String)
    End Sub
    Partial Private Sub OnNAME_DETAILChanged()
    End Sub
    Partial Private Sub OnPRICEChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnPRICEChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID() As Integer
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NAME_COFFEE", DbType:="NVarChar(50)")>  _
	Public Property NAME_COFFEE() As String
		Get
			Return Me._NAME_COFFEE
		End Get
		Set
			If (String.Equals(Me._NAME_COFFEE, value) = false) Then
				Me.OnNAME_COFFEEChanging(value)
				Me.SendPropertyChanging
				Me._NAME_COFFEE = value
				Me.SendPropertyChanged("NAME_COFFEE")
				Me.OnNAME_COFFEEChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NAME_DETAIL", DbType:="NVarChar(50)")>  _
	Public Property NAME_DETAIL() As String
		Get
			Return Me._NAME_DETAIL
		End Get
		Set
			If (String.Equals(Me._NAME_DETAIL, value) = false) Then
				Me.OnNAME_DETAILChanging(value)
				Me.SendPropertyChanging
				Me._NAME_DETAIL = value
				Me.SendPropertyChanged("NAME_DETAIL")
				Me.OnNAME_DETAILChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PRICE", DbType:="Int")>  _
	Public Property PRICE() As System.Nullable(Of Integer)
		Get
			Return Me._PRICE
		End Get
		Set
			If (Me._PRICE.Equals(value) = false) Then
				Me.OnPRICEChanging(value)
				Me.SendPropertyChanging
				Me._PRICE = value
				Me.SendPropertyChanged("PRICE")
				Me.OnPRICEChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.coffee_order_main")>  _
Partial Public Class coffee_order_main
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As Integer
	
	Private _NAME_MENU As String
	
	Private _DATE_ORDER As System.Nullable(Of Date)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnNAME_MENUChanging(value As String)
    End Sub
    Partial Private Sub OnNAME_MENUChanged()
    End Sub
    Partial Private Sub OnDATE_ORDERChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnDATE_ORDERChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID() As Integer
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NAME_MENU", DbType:="VarChar(MAX)")>  _
	Public Property NAME_MENU() As String
		Get
			Return Me._NAME_MENU
		End Get
		Set
			If (String.Equals(Me._NAME_MENU, value) = false) Then
				Me.OnNAME_MENUChanging(value)
				Me.SendPropertyChanging
				Me._NAME_MENU = value
				Me.SendPropertyChanged("NAME_MENU")
				Me.OnNAME_MENUChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DATE_ORDER", DbType:="Date")>  _
	Public Property DATE_ORDER() As System.Nullable(Of Date)
		Get
			Return Me._DATE_ORDER
		End Get
		Set
			If (Me._DATE_ORDER.Equals(value) = false) Then
				Me.OnDATE_ORDERChanging(value)
				Me.SendPropertyChanging
				Me._DATE_ORDER = value
				Me.SendPropertyChanged("DATE_ORDER")
				Me.OnDATE_ORDERChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.coffee_order_main_detail")>  _
Partial Public Class coffee_order_main_detail
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As Integer
	
	Private _NAME_COFFEE As String
	
	Private _NAME_DETAIL As String
	
	Private _PRICE As System.Nullable(Of Integer)
	
	Private _NUMBER As String
	
	Private _FK_ID As System.Nullable(Of Integer)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnNAME_COFFEEChanging(value As String)
    End Sub
    Partial Private Sub OnNAME_COFFEEChanged()
    End Sub
    Partial Private Sub OnNAME_DETAILChanging(value As String)
    End Sub
    Partial Private Sub OnNAME_DETAILChanged()
    End Sub
    Partial Private Sub OnPRICEChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnPRICEChanged()
    End Sub
    Partial Private Sub OnNUMBERChanging(value As String)
    End Sub
    Partial Private Sub OnNUMBERChanged()
    End Sub
    Partial Private Sub OnFK_IDChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnFK_IDChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID() As Integer
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NAME_COFFEE", DbType:="NVarChar(50)")>  _
	Public Property NAME_COFFEE() As String
		Get
			Return Me._NAME_COFFEE
		End Get
		Set
			If (String.Equals(Me._NAME_COFFEE, value) = false) Then
				Me.OnNAME_COFFEEChanging(value)
				Me.SendPropertyChanging
				Me._NAME_COFFEE = value
				Me.SendPropertyChanged("NAME_COFFEE")
				Me.OnNAME_COFFEEChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NAME_DETAIL", DbType:="NVarChar(50)")>  _
	Public Property NAME_DETAIL() As String
		Get
			Return Me._NAME_DETAIL
		End Get
		Set
			If (String.Equals(Me._NAME_DETAIL, value) = false) Then
				Me.OnNAME_DETAILChanging(value)
				Me.SendPropertyChanging
				Me._NAME_DETAIL = value
				Me.SendPropertyChanged("NAME_DETAIL")
				Me.OnNAME_DETAILChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PRICE", DbType:="Int")>  _
	Public Property PRICE() As System.Nullable(Of Integer)
		Get
			Return Me._PRICE
		End Get
		Set
			If (Me._PRICE.Equals(value) = false) Then
				Me.OnPRICEChanging(value)
				Me.SendPropertyChanging
				Me._PRICE = value
				Me.SendPropertyChanged("PRICE")
				Me.OnPRICEChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NUMBER", DbType:="NChar(10)")>  _
	Public Property NUMBER() As String
		Get
			Return Me._NUMBER
		End Get
		Set
			If (String.Equals(Me._NUMBER, value) = false) Then
				Me.OnNUMBERChanging(value)
				Me.SendPropertyChanging
				Me._NUMBER = value
				Me.SendPropertyChanged("NUMBER")
				Me.OnNUMBERChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FK_ID", DbType:="Int")>  _
	Public Property FK_ID() As System.Nullable(Of Integer)
		Get
			Return Me._FK_ID
		End Get
		Set
			If (Me._FK_ID.Equals(value) = false) Then
				Me.OnFK_IDChanging(value)
				Me.SendPropertyChanging
				Me._FK_ID = value
				Me.SendPropertyChanged("FK_ID")
				Me.OnFK_IDChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class