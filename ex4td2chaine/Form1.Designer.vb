<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        chaine = New TextBox()
        resultat = New TextBox()
        Bmaj = New Button()
        Bmin = New Button()
        Blong = New Button()
        Bremp = New Button()
        Bdec = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(105, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(294, 38)
        Label1.TabIndex = 0
        Label1.Text = "Analyse d'une chaine"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(105, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(176, 28)
        Label2.TabIndex = 1
        Label2.Text = "Entrez une phrase"
        ' 
        ' chaine
        ' 
        chaine.Location = New Point(306, 125)
        chaine.Multiline = True
        chaine.Name = "chaine"
        chaine.Size = New Size(294, 45)
        chaine.TabIndex = 2
        ' 
        ' resultat
        ' 
        resultat.Location = New Point(128, 360)
        resultat.Multiline = True
        resultat.Name = "resultat"
        resultat.Size = New Size(389, 70)
        resultat.TabIndex = 3
        resultat.Text = "resulta"
        ' 
        ' Bmaj
        ' 
        Bmaj.Location = New Point(128, 226)
        Bmaj.Name = "Bmaj"
        Bmaj.Size = New Size(172, 37)
        Bmaj.TabIndex = 4
        Bmaj.Text = "Majuscule"
        Bmaj.UseVisualStyleBackColor = True
        ' 
        ' Bmin
        ' 
        Bmin.Location = New Point(306, 226)
        Bmin.Name = "Bmin"
        Bmin.Size = New Size(172, 37)
        Bmin.TabIndex = 5
        Bmin.Text = "Minuscule"
        Bmin.UseVisualStyleBackColor = True
        ' 
        ' Blong
        ' 
        Blong.Location = New Point(500, 226)
        Blong.Name = "Blong"
        Blong.Size = New Size(172, 37)
        Blong.TabIndex = 6
        Blong.Text = "longeur"
        Blong.UseVisualStyleBackColor = True
        ' 
        ' Bremp
        ' 
        Bremp.Location = New Point(128, 288)
        Bremp.Name = "Bremp"
        Bremp.Size = New Size(172, 37)
        Bremp.TabIndex = 7
        Bremp.Text = "remplacer"
        Bremp.UseVisualStyleBackColor = True
        ' 
        ' Bdec
        ' 
        Bdec.Location = New Point(306, 288)
        Bdec.Name = "Bdec"
        Bdec.Size = New Size(172, 37)
        Bdec.TabIndex = 8
        Bdec.Text = "decouper"
        Bdec.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(897, 540)
        Controls.Add(Bdec)
        Controls.Add(Bremp)
        Controls.Add(Blong)
        Controls.Add(Bmin)
        Controls.Add(Bmaj)
        Controls.Add(resultat)
        Controls.Add(chaine)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "chaine"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chaine As TextBox
    Friend WithEvents resultat As TextBox
    Friend WithEvents Bmaj As Button
    Friend WithEvents Bmin As Button
    Friend WithEvents Blong As Button
    Friend WithEvents Bremp As Button
    Friend WithEvents Bdec As Button

End Class
