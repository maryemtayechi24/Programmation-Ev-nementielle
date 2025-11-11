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
        txtEuros = New TextBox()
        btnconvertir = New Button()
        btninit = New Button()
        Label2 = New Label()
        lblresultat = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(58, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 25)
        Label1.TabIndex = 0
        Label1.Text = "montant en euro"
        ' 
        ' txtEuros
        ' 
        txtEuros.Location = New Point(219, 135)
        txtEuros.Name = "txtEuros"
        txtEuros.Size = New Size(234, 27)
        txtEuros.TabIndex = 1
        ' 
        ' btnconvertir
        ' 
        btnconvertir.Location = New Point(537, 140)
        btnconvertir.Name = "btnconvertir"
        btnconvertir.Size = New Size(94, 29)
        btnconvertir.TabIndex = 2
        btnconvertir.Text = "convertir"
        btnconvertir.UseVisualStyleBackColor = True
        ' 
        ' btninit
        ' 
        btninit.Location = New Point(537, 219)
        btninit.Name = "btninit"
        btninit.Size = New Size(94, 29)
        btninit.TabIndex = 3
        btninit.Text = "reset"
        btninit.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(36, 240)
        Label2.Name = "Label2"
        Label2.Size = New Size(177, 28)
        Label2.TabIndex = 4
        Label2.Text = "montant en dinar"
        ' 
        ' lblresultat
        ' 
        lblresultat.AutoSize = True
        lblresultat.Location = New Point(274, 247)
        lblresultat.Name = "lblresultat"
        lblresultat.Size = New Size(0, 20)
        lblresultat.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.MenuHighlight
        Label4.Location = New Point(252, 38)
        Label4.Name = "Label4"
        Label4.Size = New Size(308, 38)
        Label4.TabIndex = 6
        Label4.Text = "convertisseur en dinar"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(873, 538)
        Controls.Add(Label4)
        Controls.Add(lblresultat)
        Controls.Add(Label2)
        Controls.Add(btninit)
        Controls.Add(btnconvertir)
        Controls.Add(txtEuros)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "convertion"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtEuros As TextBox
    Friend WithEvents btnconvertir As Button
    Friend WithEvents btninit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblresultat As Label
    Friend WithEvents Label4 As Label

End Class
