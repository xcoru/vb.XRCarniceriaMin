Imports System.IO

Public Class I_Negocio
    Private _id_negocio As Integer
    Private _nombre As String
    Private _descripcion As String
    Private _direccion As String
    Private _telefono As String
    Private _logotipo As Byte()

    Public Sub New(id_negocio As Integer, nombre As String, descripcion As String, direccion As String, telefono As String, logotipo As Bitmap)
        Me.Id_negocio = id_negocio
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Direccion = direccion
        Me.Telefono = telefono
        Me.Logotipo = logotipo
    End Sub

    Private Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function

    'Funcion para convertir de Bytes a Imagen
    Private Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

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

    Public Property Logotipo As Image
        Get
            Return Bytes_Imagen(_logotipo)
        End Get
        Set(value As Image)
            _logotipo = Imagen_Bytes(value)
        End Set
    End Property

    Public ReadOnly Property Logotipo_Bytes As Byte()
        Get
            Return _logotipo
        End Get
    End Property
End Class
