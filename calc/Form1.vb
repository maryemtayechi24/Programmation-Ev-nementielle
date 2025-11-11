Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nb.Text = nb.Text + "1"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nb.Text = nb.Text + "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        nb.Text = nb.Text + "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        nb.Text = nb.Text + "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        nb.Text = nb.Text + "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        nb.Text = nb.Text + "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        nb.Text = nb.Text + "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        nb.Text = nb.Text + "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        nb.Text = nb.Text + "9"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        zone1.Text = nb.Text
        zone2.Text = "+"
        nb.Text = ""

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        zone1.Text = nb.Text
        zone2.Text = "-"
        nb.Text = ""
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        zone1.Text = nb.Text
        zone2.Text = "*"
        nb.Text = ""
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        zone1.Text = nb.Text
        zone2.Text = "/"
        nb.Text = ""
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If zone2.Text = "+" Then
            nb.Text = Val(zone1.Text) + Val(nb.Text)
            zone1.Text = ""
            zone2.Text = "="
        End If
        If zone2.Text = "-" Then
            nb.Text = Val(zone1.Text) - Val(nb.Text)
            zone1.Text = ""
            zone2.Text = "="
        End If
        If zone2.Text = "*" Then
            nb.Text = Val(zone1.Text) * Val(nb.Text)
            zone1.Text = ""
            zone2.Text = "="
        End If
        If zone2.Text = "/" Then
            nb.Text = Val(zone1.Text) / Val(nb.Text)
            zone1.Text = ""
            zone2.Text = "="
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        nb.Text = ""
        zone1.Text = ""
        zone2.Text = ""
    End Sub
End Class
