Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports Windows.Win32.System

Public Class Form1
    Const prixBurger As Double = 5
    Const prixFrites As Double = 2
    Const prixBoisson As Double = 1.5
    Const prixDessert As Double = 3
    Private Sub cltot_Click(sender As Object, e As EventArgs) Handles cltot.Click
        Dim som As Double = 0
        If cb1.Checked Then
            som += prixBurger
        End If
        If cb2.Checked Then
            som += prixFrites
        End If
        If cb3.Checked Then
            som += prixBoisson
        End If
        If cb4.Checked Then
            som += prixDessert
        End If
        lblTotal.Text = som.ToString() & "DT"





    End Sub

    Private Sub beff_Click(sender As Object, e As EventArgs) Handles beff.Click
        lblTotal.Text = ""
        If cb1.Checked Then
            cb1.Checked = Not (cb1.Checked)
        End If
        If cb2.Checked Then
            cb2.Checked = Not (cb2.Checked)
        End If
        If cb3.Checked Then
            cb3.Checked = Not (cb3.Checked)
        End If
        If cb4.Checked Then
            cb4.Checked = Not (cb4.Checked)
        End If

    End Sub
End Class
