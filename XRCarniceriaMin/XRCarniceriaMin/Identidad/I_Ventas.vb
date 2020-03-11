Public Class I_Ventas
    Private _id_venta As Integer
    Private _folio As String
    Private _id_usuario As String
    Private _id_catalogo As String
    Private _cantidad As Decimal
    Private _peso As Decimal
    Private _precio As Decimal
    Private _total As Decimal
    Private _hora As String
    Private _fecha As String
    Private _estado As Integer

    Public Sub New(id_venta As Integer, folio As String, id_usuario As String, id_catalogo As String, cantidad As Decimal, peso As Decimal, precio As Decimal, total As Decimal, hora As String, fecha As String, estado As Integer)
        Me.Id_venta = id_venta
        Me.Folio = folio
        Me.Id_usuario = id_usuario
        Me.Id_catalogo = id_catalogo
        Me.Cantidad = cantidad
        Me.Peso = peso
        Me.Precio = precio
        Me.Total = total
        Me.Hora = hora
        Me.Fecha = fecha
        Me.Estado = estado
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

    Public Property Id_catalogo As String
        Get
            Return _id_catalogo
        End Get
        Set(value As String)
            _id_catalogo = value
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

    Public Property Peso As Decimal
        Get
            Return _peso
        End Get
        Set(value As Decimal)
            _peso = value
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

    Public Property Total As Decimal
        Get
            Return _total
        End Get
        Set(value As Decimal)
            _total = value
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

    Public Property Fecha As String
        Get
            Return _fecha
        End Get
        Set(value As String)
            _fecha = value
        End Set
    End Property

    Public Property Estado As Integer
        Get
            Return _estado
        End Get
        Set(value As Integer)
            _estado = value
        End Set
    End Property
End Class
