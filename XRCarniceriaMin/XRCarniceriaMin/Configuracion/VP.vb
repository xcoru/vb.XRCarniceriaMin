Module VP
#Region "Conexión DB"
    Public _Server As String = "127.0.0.1"          'Dirección IP Servidor de base de datos
    Public _User As String = "root"                 'Nombre de usuario DB
    Public _Password As String = ""                 'Password DB
    Public _DBName As String = "xrcarniceriamin"    'Nombre base de datos
#End Region
#Region "Usuario"
    Public _usuario_id_usuario As String = ""
    Public _usuario_nombre As String = ""
#End Region
#Region "Negocio"
    Public _negocio_nombre As String = "Carniceria"
    Public _negocio_descripcion As String = ""
    Public _negocio_direccion As String = ""
    Public _negocio_telefono As String = ""
    Public _negocio_logotipo As Image = Nothing
#End Region
#Region "Config"
    Public _config_impresora As String = ""
#End Region

#Region "General"
    Public _MostrarErrores As Boolean = True         'True si se desea mostrar detalles de errores
#End Region

End Module
