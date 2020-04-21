Public Class I_Ventas
    Private _id_venta As Integer
    Private _folio As String
    Private _id_usuario As String
    Private _id_articulo As String
    Private _precio As Decimal
    Private _cantidad As Decimal
    Private _subtotal As Decimal
    Private _hora As String
    Private _fecha As Date

    Public Sub New()

    End Sub

    Public Sub New(id_venta As Integer, folio As String, id_usuario As String, id_articulo As String, precio As Decimal, cantidad As Decimal, subtotal As Decimal, hora As String, fecha As Date)
        _id_venta = id_venta
        _folio = folio
        _id_usuario = id_usuario
        _id_articulo = id_articulo
        _precio = precio
        _cantidad = cantidad
        _subtotal = subtotal
        _hora = hora
        _fecha = fecha
    End Sub

    Public Property Id_venta As Integer
        Get
            Return _id_venta
        End Get
        Set(value As Integer)
            _id_venta = value
        End Set
    End Property

    Public Property Folio As String
        Get
            Return _folio
        End Get
        Set(value As String)
            _folio = value
        End Set
    End Property

    Public Property Id_usuario As String
        Get
            Return _id_usuario
        End Get
        Set(value As String)
            _id_usuario = value
        End Set
    End Property

    Public Property Id_articulo As String
        Get
            Return _id_articulo
        End Get
        Set(value As String)
            _id_articulo = value
        End Set
    End Property

    Public Property Precio As Decimal
        Get
            Return _precio
        End Get
        Set(value As Decimal)
            _precio = value
        End Set
    End Property

    Public Property Cantidad As Decimal
        Get
            Return _cantidad
        End Get
        Set(value As Decimal)
            _cantidad = value
        End Set
    End Property

    Public Property Subtotal As Decimal
        Get
            Return _subtotal
        End Get
        Set(value As Decimal)
            _subtotal = value
        End Set
    End Property

    Public Property Hora As String
        Get
            Return _hora
        End Get
        Set(value As String)
            _hora = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
End Class
