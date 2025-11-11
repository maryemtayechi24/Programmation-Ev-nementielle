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
        cb1 = New CheckBox()
        cb2 = New CheckBox()
        cb3 = New CheckBox()
        cb4 = New CheckBox()
        cltot = New Button()
        beff = New Button()
        lblTotal = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(269, 20)
        Label1.TabIndex = 0
        Label1.Text = "Choisissez les éléments de votre menu :"
        ' 
        ' cb1
        ' 
        cb1.AutoSize = True
        cb1.Location = New Point(287, 107)
        cb1.Name = "cb1"
        cb1.Size = New Size(115, 24)
        cb1.TabIndex = 1
        cb1.Text = "Burger (5 dt)"
        cb1.UseVisualStyleBackColor = True
        ' 
        ' cb2
        ' 
        cb2.AutoSize = True
        cb2.Location = New Point(415, 106)
        cb2.Name = "cb2"
        cb2.Size = New Size(106, 24)
        cb2.TabIndex = 2
        cb2.Text = "Frites (2 dt)"
        cb2.UseVisualStyleBackColor = True
        ' 
        ' cb3
        ' 
        cb3.AutoSize = True
        cb3.Location = New Point(524, 106)
        cb3.Name = "cb3"
        cb3.Size = New Size(133, 24)
        cb3.TabIndex = 3
        cb3.Text = "Boisson (1.5 dt)"
        cb3.UseVisualStyleBackColor = True
        ' 
        ' cb4
        ' 
        cb4.AutoSize = True
        cb4.Location = New Point(659, 106)
        cb4.Name = "cb4"
        cb4.Size = New Size(120, 24)
        cb4.TabIndex = 4
        cb4.Text = "Dessert (3 dt)"
        cb4.UseVisualStyleBackColor = True
        ' 
        ' cltot
        ' 
        cltot.Location = New Point(147, 163)
        cltot.Name = "cltot"
        cltot.Size = New Size(134, 29)
        cltot.TabIndex = 5
        cltot.Text = "calculer le totale"
        cltot.UseVisualStyleBackColor = True
        ' 
        ' beff
        ' 
        beff.Location = New Point(296, 163)
        beff.Name = "beff"
        beff.Size = New Size(94, 29)
        beff.TabIndex = 6
        beff.Text = "Effacer"
        beff.UseVisualStyleBackColor = True
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(614, 239)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(0, 20)
        lblTotal.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblTotal)
        Controls.Add(beff)
        Controls.Add(cltot)
        Controls.Add(cb4)
        Controls.Add(cb3)
        Controls.Add(cb2)
        Controls.Add(cb1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb3 As CheckBox
    Friend WithEvents cb4 As CheckBox
    Friend WithEvents cltot As Button
    Friend WithEvents beff As Button
    Friend WithEvents lblTotal As Label

End Class
