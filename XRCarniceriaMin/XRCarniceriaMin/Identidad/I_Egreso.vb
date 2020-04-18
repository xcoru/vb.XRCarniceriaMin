Public Class I_Egreso
    Private _id_egreso As Integer
    Private _id_usuario As String
    Private _concepto As String
    Private _monto As Decimal
    Private _hora As String
    Private _fecha As String

    Public Sub New()

    End Sub

    Public Sub New(id_egreso As Integer, id_usuario As String, concepto As String, monto As Decimal, hora As String, fecha As String)
        _id_egreso = id_egreso
        _id_usuario = id_usuario
        _concepto = concepto
        _monto = monto
        _hora = hora
        _fecha = fecha
    End Sub

    Public Property Id_egreso As Integer
        Get
            Return _id_egreso
        End Get
        Set(value As Integer)
            _id_egreso = value
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

    Public Property Concepto As String
        Get
            Return _concepto
        End Get
        Set(value As String)
            _concepto = value
        End Set
    End Property

    Public Property Monto As Decimal
        Get
            Return _monto
        End Get
        Set(value As Decimal)
            _monto = value
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
End Class
