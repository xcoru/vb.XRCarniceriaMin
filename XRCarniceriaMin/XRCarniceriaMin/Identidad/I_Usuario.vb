Public Class I_Usuario
    Private _id_usuario As String
    Private _nombre As String
    Private _password As String
    Private _estado As Integer

    Public Sub New(id_usuario As String, nombre As String, password As String, estado As Integer)
        Me.Id_usuario = id_usuario
        Me.Nombre = nombre
        Me.Password = password
        Me.Estado = estado
    End Sub

    Public Property Id_usuario As String
        Get
            Return _id_usuario
        End Get
        Set(value As String)
            _id_usuario = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
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
