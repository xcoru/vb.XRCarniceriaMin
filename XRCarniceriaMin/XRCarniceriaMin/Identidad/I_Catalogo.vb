Public Class I_Catalogo
    Private _id_catalogo As String
    Private _descripcion As String
    Private _tipo As String
    Private _precio As Decimal
    Private _estado As Integer

    Public Sub New(id_catalogo As String, descripcion As String, tipo As String, precio As Decimal, estado As Integer)
        _id_catalogo = id_catalogo
        _descripcion = descripcion
        _tipo = tipo
        _precio = precio
        _estado = estado
    End Sub

    Public Property Id_catalogo As String
        Get
            Return _id_catalogo
        End Get
        Set(value As String)
            _id_catalogo = value
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
End Class
