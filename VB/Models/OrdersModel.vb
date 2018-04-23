Imports Microsoft.VisualBasic
Imports System
Imports Example.NorthwindTableAdapters

Public Class OrdersModel

    Private ReadOnly _data As OrdersTableAdapter = New OrdersTableAdapter()

    Private privateStartDate As DateTime
    Public Property StartDate() As DateTime
        Get
            Return privateStartDate
        End Get
        Set(ByVal value As DateTime)
            privateStartDate = value
        End Set
    End Property
    Private privateEndDate As DateTime
    Public Property EndDate() As DateTime
        Get
            Return privateEndDate
        End Get
        Set(ByVal value As DateTime)
            privateEndDate = value
        End Set
    End Property
    Public ReadOnly Property Data() As Northwind.OrdersDataTable
        Get
            Return _data.GetDataByDate(StartDate, EndDate)
        End Get
    End Property

    Public ReadOnly Property MinDate() As DateTime
        Get
            Return If(CType(_data.MinOrderDate(), Nullable(Of DateTime)).HasValue, CType(_data.MinOrderDate(), Nullable(Of DateTime)).Value, New DateTime(1990, 1, 1))
        End Get
    End Property

    Public ReadOnly Property MaxDate() As DateTime
        Get
            Return If(CType(_data.MaxOrderDate(), Nullable(Of DateTime)).HasValue, CType(_data.MaxOrderDate(), Nullable(Of DateTime)).Value, New DateTime(2011, 1, 1))
        End Get
    End Property
End Class
