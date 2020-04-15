Imports System.IO

Public Class I_Negocio
    Private _id_negocio As Integer
    Private _nombre As String
    Private _descripcion As String
    Private _direccion As String
    Private _telefono As String
    Private _logotipo As String

    Public Sub New()

    End Sub
    Public Sub New(id_negocio As Integer, nombre As String, descripcion As String, direccion As String, telefono As String, logotipo As String)
        Me.Id_negocio = id_negocio
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Direccion = direccion
        Me.Telefono = telefono
        Me.Logotipo = logotipo
    End Sub

    Public Property Id_negocio As Integer
        Get
            Return _id_negocio
        End Get
        Set(value As Integer)
            _id_negocio = value
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

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property Logotipo As String
        Get
            Return _logotipo
        End Get
        Set(value As String)
            _logotipo = value
        End Set
    End Property

End Class
