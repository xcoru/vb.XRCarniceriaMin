Public Class I_Config
    Private _id_config As Integer
    Private _impresora As String

    Public Sub New(id_config As Integer, impresora As String)
        Me.Id_config = id_config
        Me.Impresora = impresora
    End Sub

    Public Property Id_config As Integer
        Get
            Return _id_config
        End Get
        Set(value As Integer)
            _id_config = value
        End Set
    End Property

    Public Property Impresora As String
        Get
            Return _impresora
        End Get
        Set(value As String)
            _impresora = value
        End Set
    End Property
End Class
