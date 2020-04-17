Option Explicit On
Public Class ObjArticulo
    Private pnlArticulo As Panel

    'Detalles del panel
    Private ancho As Integer = 150
    Private alto As Integer = 180


    Public Sub New()
    End Sub

    Public Function Crear(ByVal articulo As I_Articulo) As Panel
        Try
            pnlArticulo = New Panel
            With pnlArticulo
                .Height = alto
                .Width = ancho
                .Name = articulo.Id_articulo
                .BackColor = Color.Coral
                .BackgroundImage = generarPanel(articulo)
                .BackgroundImageLayout = ImageLayout.Zoom
            End With

            AddHandler pnlArticulo.MouseHover, AddressOf evArticulo_Hover
            AddHandler pnlArticulo.MouseLeave, AddressOf evArticulo_Leave
            AddHandler pnlArticulo.MouseClick, AddressOf evArticulo_Click
        Catch ex As Exception
            X(ex)
            Return Nothing
        End Try
        Return pnlArticulo
    End Function

    Public Function Editar(ByVal articulo As I_Articulo) As Bitmap
        Try
            Return generarPanel(articulo)
        Catch ex As Exception
            X(ex)
            Return Nothing
        End Try
    End Function

    Private Function generarPanel(ByVal articulo As I_Articulo) As Bitmap
        Try
            Dim Contenedor As Panel
            Dim Panel As New Bitmap(ancho, alto)

            ' CONTENEDOR -------------------------------------
            Contenedor = New Panel
            With Contenedor
                .Height = alto
                .Width = ancho
                .BackColor = Color.Coral
            End With
            Dim PictureB1 As New PictureBox

            With PictureB1
                .Width = ancho
                .Height = ancho
                .Location = New Point(0, 0)
                .BackgroundImageLayout = ImageLayout.Zoom
                .BackColor = Color.AliceBlue
                'On Error Resume Next
                .BackgroundImage = Image.FromFile(articulo.Imagen)
            End With

            Dim Etiqueta As New Label

            With Etiqueta
                .Name = "txtDescripcion"
                .Height = 30
                .Dock = DockStyle.Bottom
                .BackColor = Color.CornflowerBlue
                .ForeColor = Color.White
                .Text = articulo.Descripcion
                .TextAlign = ContentAlignment.MiddleCenter
                .Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
            End With

            'AGREGANDO LOS CONTROLES CREADOS -----------------
            With Contenedor.Controls
                .Add(PictureB1)
                .Add(Etiqueta)
            End With

            Contenedor.DrawToBitmap(Panel, New Rectangle(0, 0, Contenedor.Width, Contenedor.Height))

            Return Panel
        Catch ex As Exception
            X(ex)
            Return Nothing
        End Try
    End Function

End Class
