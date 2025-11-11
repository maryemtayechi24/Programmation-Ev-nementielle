Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Bmaj.Click
        resultat.Text() = chaine.Text().ToUpper()
    End Sub

    Private Sub Bmin_Click(sender As Object, e As EventArgs) Handles Bmin.Click
        resultat.Text() = chaine.Text().ToLower()
    End Sub

    Private Sub Blong_Click(sender As Object, e As EventArgs) Handles Blong.Click
        chaine.Text() = chaine.Text().Length()
    End Sub

    Private Sub Bremp_Click(sender As Object, e As EventArgs) Handles Bremp.Click
        Dim ancien As String = InputBox("Entrer le mot à remplacer :")
        Dim nouveau As String = InputBox("Entrer le nouveau mot :")
        resultat.Text = chaine.Text.Replace(ancien, nouveau)

    End Sub

    Private Sub Bdec_Click(sender As Object, e As EventArgs) Handles Bdec.Click
        Dim mots() As String = chaine.Text.Split(" "c)
        resultat.Text = String.Join(vbCrLf, mots)
    End Sub
End Class
