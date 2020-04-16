Module ObjArticulo

    Public Function getArticulo() As Panel
        Dim P_Main As New Panel

        With P_Main
            .Width = 150
            .Height = 180
            .BackColor = Color.Coral
        End With

        Return P_Main
    End Function

End Module
