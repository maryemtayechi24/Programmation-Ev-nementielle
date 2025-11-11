Public Class Form1
    Private Sub btnconvertir_Click(sender As Object, e As EventArgs) Handles btnconvertir.Click
        If txtEuros.Text = "" Then
            MessageBox.Show("entrez une valeur", "Erreur")
        End If
        lblresultat.Text = Val(txtEuros.Text) * 3.35 & "TND"
    End Sub

    Private Sub btninit_Click(sender As Object, e As EventArgs) Handles btninit.Click
        txtEuros.Text = ""
        lblresultat.Text = ""

    End Sub
End Class
