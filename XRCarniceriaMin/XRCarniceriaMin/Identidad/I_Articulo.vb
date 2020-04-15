Public Class I_Articulo
    Private _id_articulo As String
    Private _descripcion As String
    Private _tipo As String
    Private _precio As Decimal
    Private _imagen As String
    Private _estado As Integer

    Public Sub New(id_articulo As String, descripcion As String, tipo As String, precio As Decimal, imagen As String, estado As Integer)
        _id_articulo = id_articulo
        _descripcion = descripcion
        _tipo = tipo
        _precio = precio
        _imagen = imagen
        _estado = estado
    End Sub

    Public Property Id_articulo As String
        Get
            Return _id_articulo
        End Get
        Set(value As String)
            _id_articulo = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
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

    Public Property Estado As Integer
        Get
            Return _estado
        End Get
        Set(value As Integer)
            _estado = value
        End Set
    End Property

    Public Property Imagen As String
        Get
            Return _imagen
        End Get
        Set(value As String)
            _imagen = value
        End Set
    End Property
End Class
