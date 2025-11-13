<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcommande
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
        grplat = New GroupBox()
        rdpates = New RadioButton()
        rdburger = New RadioButton()
        rdpizza = New RadioButton()
        grsupplement = New GroupBox()
        chkdessert = New CheckBox()
        chkfrite = New CheckBox()
        chkformage = New CheckBox()
        Label2 = New Label()
        lstboisson = New ListBox()
        Label3 = New Label()
        lblafficher = New Label()
        btcommande = New Button()
        btnannule = New Button()
        grplat.SuspendLayout()
        grsupplement.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(445, 190)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 0
        ' 
        ' grplat
        ' 
        grplat.Controls.Add(rdpates)
        grplat.Controls.Add(rdburger)
        grplat.Controls.Add(rdpizza)
        grplat.Location = New Point(31, 26)
        grplat.Name = "grplat"
        grplat.Size = New Size(188, 204)
        grplat.TabIndex = 2
        grplat.TabStop = False
        grplat.Text = "choix du plat"
        ' 
        ' rdpates
        ' 
        rdpates.AutoSize = True
        rdpates.Location = New Point(40, 150)
        rdpates.Name = "rdpates"
        rdpates.Size = New Size(66, 24)
        rdpates.TabIndex = 2
        rdpates.TabStop = True
        rdpates.Text = "pates"
        rdpates.UseVisualStyleBackColor = True
        ' 
        ' rdburger
        ' 
        rdburger.AutoSize = True
        rdburger.Location = New Point(40, 103)
        rdburger.Name = "rdburger"
        rdburger.Size = New Size(74, 24)
        rdburger.TabIndex = 1
        rdburger.TabStop = True
        rdburger.Text = "burger"
        rdburger.UseVisualStyleBackColor = True
        ' 
        ' rdpizza
        ' 
        rdpizza.AutoSize = True
        rdpizza.Location = New Point(40, 51)
        rdpizza.Name = "rdpizza"
        rdpizza.Size = New Size(65, 24)
        rdpizza.TabIndex = 0
        rdpizza.TabStop = True
        rdpizza.Text = "pizza"
        rdpizza.UseVisualStyleBackColor = True
        ' 
        ' grsupplement
        ' 
        grsupplement.Controls.Add(chkdessert)
        grsupplement.Controls.Add(chkfrite)
        grsupplement.Controls.Add(chkformage)
        grsupplement.Location = New Point(31, 308)
        grsupplement.Name = "grsupplement"
        grsupplement.Size = New Size(168, 244)
        grsupplement.TabIndex = 3
        grsupplement.TabStop = False
        grsupplement.Text = "supplement"
        ' 
        ' chkdessert
        ' 
        chkdessert.AutoSize = True
        chkdessert.Location = New Point(16, 168)
        chkdessert.Name = "chkdessert"
        chkdessert.Size = New Size(78, 24)
        chkdessert.TabIndex = 2
        chkdessert.Text = "dessert"
        chkdessert.UseVisualStyleBackColor = True
        ' 
        ' chkfrite
        ' 
        chkfrite.AutoSize = True
        chkfrite.Location = New Point(18, 104)
        chkfrite.Name = "chkfrite"
        chkfrite.Size = New Size(58, 24)
        chkfrite.TabIndex = 1
        chkfrite.Text = "frite"
        chkfrite.UseVisualStyleBackColor = True
        ' 
        ' chkformage
        ' 
        chkformage.AutoSize = True
        chkformage.Location = New Point(17, 48)
        chkformage.Name = "chkformage"
        chkformage.Size = New Size(90, 24)
        chkformage.TabIndex = 0
        chkformage.Text = "Formage"
        chkformage.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(272, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 4
        Label2.Text = "boisson"
        ' 
        ' lstboisson
        ' 
        lstboisson.FormattingEnabled = True
        lstboisson.Location = New Point(338, 26)
        lstboisson.Name = "lstboisson"
        lstboisson.Size = New Size(272, 124)
        lstboisson.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 6
        Label3.Text = "Label3"
        ' 
        ' lblafficher
        ' 
        lblafficher.AutoSize = True
        lblafficher.Location = New Point(277, 176)
        lblafficher.Name = "lblafficher"
        lblafficher.Size = New Size(55, 20)
        lblafficher.TabIndex = 7
        lblafficher.Text = "facture"
        ' 
        ' btcommande
        ' 
        btcommande.Location = New Point(293, 402)
        btcommande.Name = "btcommande"
        btcommande.Size = New Size(94, 29)
        btcommande.TabIndex = 8
        btcommande.Text = "commande"
        btcommande.UseVisualStyleBackColor = True
        ' 
        ' btnannule
        ' 
        btnannule.Location = New Point(482, 402)
        btnannule.Name = "btnannule"
        btnannule.Size = New Size(94, 29)
        btnannule.TabIndex = 9
        btnannule.Text = "annuler"
        btnannule.UseVisualStyleBackColor = True
        ' 
        ' frmcommande
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(649, 620)
        Controls.Add(btnannule)
        Controls.Add(btcommande)
        Controls.Add(lblafficher)
        Controls.Add(Label3)
        Controls.Add(lstboisson)
        Controls.Add(Label2)
        Controls.Add(grsupplement)
        Controls.Add(grplat)
        Controls.Add(Label1)
        Name = "frmcommande"
        Text = "commande"
        grplat.ResumeLayout(False)
        grplat.PerformLayout()
        grsupplement.ResumeLayout(False)
        grsupplement.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grplat As GroupBox
    Friend WithEvents rdburger As RadioButton
    Friend WithEvents rdpizza As RadioButton
    Friend WithEvents rdpates As RadioButton
    Friend WithEvents grsupplement As GroupBox
    Friend WithEvents chkdessert As CheckBox
    Friend WithEvents chkfrite As CheckBox
    Friend WithEvents chkformage As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstboisson As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblafficher As Label
    Friend WithEvents btcommande As Button
    Friend WithEvents btnannule As Button

End Class
