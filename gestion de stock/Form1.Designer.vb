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
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        tcode = New TextBox()
        tdes = New TextBox()
        tprix = New TextBox()
        tquantt = New TextBox()
        bajout = New Button()
        baffichetot = New Button()
        bcher = New Button()
        result = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(72, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(231, 38)
        Label1.TabIndex = 0
        Label1.Text = "gestion de stock"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label2.Location = New Point(72, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 28)
        Label2.TabIndex = 1
        Label2.Text = "code"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.Location = New Point(72, 202)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 28)
        Label3.TabIndex = 2
        Label3.Text = "designaition"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label4.Location = New Point(72, 279)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 28)
        Label4.TabIndex = 3
        Label4.Text = "prix"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label5.Location = New Point(72, 361)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 28)
        Label5.TabIndex = 4
        Label5.Text = "quantite"
        ' 
        ' tcode
        ' 
        tcode.Location = New Point(202, 142)
        tcode.Multiline = True
        tcode.Name = "tcode"
        tcode.Size = New Size(195, 39)
        tcode.TabIndex = 5
        ' 
        ' tdes
        ' 
        tdes.Location = New Point(202, 203)
        tdes.Multiline = True
        tdes.Name = "tdes"
        tdes.Size = New Size(195, 34)
        tdes.TabIndex = 6
        ' 
        ' tprix
        ' 
        tprix.Location = New Point(202, 279)
        tprix.Multiline = True
        tprix.Name = "tprix"
        tprix.Size = New Size(195, 49)
        tprix.TabIndex = 7
        ' 
        ' tquantt
        ' 
        tquantt.Location = New Point(202, 361)
        tquantt.Multiline = True
        tquantt.Name = "tquantt"
        tquantt.Size = New Size(195, 52)
        tquantt.TabIndex = 8
        ' 
        ' bajout
        ' 
        bajout.Location = New Point(614, 119)
        bajout.Name = "bajout"
        bajout.Size = New Size(94, 29)
        bajout.TabIndex = 9
        bajout.Text = "ajouter"
        bajout.UseVisualStyleBackColor = True
        ' 
        ' baffichetot
        ' 
        baffichetot.Location = New Point(614, 221)
        baffichetot.Name = "baffichetot"
        baffichetot.Size = New Size(94, 29)
        baffichetot.TabIndex = 10
        baffichetot.Text = "afficher tot"
        baffichetot.UseVisualStyleBackColor = True
        ' 
        ' bcher
        ' 
        bcher.Location = New Point(614, 326)
        bcher.Name = "bcher"
        bcher.Size = New Size(94, 29)
        bcher.TabIndex = 11
        bcher.Text = "affichecher"
        bcher.UseVisualStyleBackColor = True
        ' 
        ' result
        ' 
        result.Location = New Point(499, 398)
        result.Multiline = True
        result.Name = "result"
        result.Size = New Size(311, 180)
        result.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(871, 601)
        Controls.Add(result)
        Controls.Add(bcher)
        Controls.Add(baffichetot)
        Controls.Add(bajout)
        Controls.Add(tquantt)
        Controls.Add(tprix)
        Controls.Add(tdes)
        Controls.Add(tcode)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "stock"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tcode As TextBox
    Friend WithEvents tdes As TextBox
    Friend WithEvents tprix As TextBox
    Friend WithEvents tquantt As TextBox
    Friend WithEvents bajout As Button
    Friend WithEvents baffichetot As Button
    Friend WithEvents bcher As Button
    Friend WithEvents result As TextBox

End Class
