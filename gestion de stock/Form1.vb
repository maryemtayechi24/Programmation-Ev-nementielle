Public Class Form1
    Private Sub bajout_Click(sender As Object, e As EventArgs) Handles bajout.Click
        Dim Ar As article
        Dim code As Integer
        Dim desi As String
        Dim prix As Double
        Dim quant As Integer
        code = Val(tcode.Text)
        prix = CDbl(tprix.Text)
        desi = tdes.Text
        quant = Val(tquantt.Text)
        If prix < 0 Then
            MessageBox.Show("prix est positive", "erreur")
            Return
        End If
        Ar.code = code
        Ar.desination = desi
        Ar.prix = prix
        Ar.qte = quant
        ajoutarticle(Ar)




    End Sub

    Private Sub baffichetot_Click(sender As Object, e As EventArgs) Handles baffichetot.Click
        result.Text = Val(tprix.Text * tquantt.Text)
    End Sub

    Private Sub bcher_Click(sender As Object, e As EventArgs) Handles bcher.Click
        Dim Ar As article = pluscher()
        result.Text = MessageBox.Show("Le produit le plus cher est : " & Ar.desination & " (" & Ar.prix & " DT)")
    End Sub
End Class
