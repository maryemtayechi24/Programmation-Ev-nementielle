Public Class frmcommande
    Dim prix As Integer
    Private Sub lstboisson_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstboisson.SelectedIndexChanged

    End Sub

    Private Sub frmcommande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstboisson.Items.Add("cafe")
        lstboisson.Items.Add("jus d'orange")
        lstboisson.Items.Add("eau minirale")
        lstboisson.Items.Add("citronade")

    End Sub

    Private Sub btcommande_Click(sender As Object, e As EventArgs) Handles btcommande.Click
        Dim commande As String
        If rdpizza.Checked Then
            commande = "pizza"
            prix = 10
        ElseIf rdburger.Checked Then
            commande = "burger"
            prix = 8
        Else
            commande = "pates"
            prix = 15
        End If
        For Each ctrl In grsupplement.Controls
            If ctrl.checked Then
                commande = commande + "   " + ctrl.text
                If ctrl.text = "Formage" Then
                    prix = prix + 2
                ElseIf ctrl.text = "frite" Then
                    prix = prix + 2
                ElseIf ctrl.text = "dessert" Then
                    prix = prix + 4
                End If
            End If
        Next
        commande = commande & " " & lstboisson.SelectedItem
        prix = prix + 10
        lblafficher.Text = commande & "totale: " & prix
    End Sub
End Class
