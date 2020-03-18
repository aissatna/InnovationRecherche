<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnInitialisation = New System.Windows.Forms.Button()
        Me.tbMax = New System.Windows.Forms.TextBox()
        Me.tbMin = New System.Windows.Forms.TextBox()
        Me.tbTaille = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbRecherche = New System.Windows.Forms.ComboBox()
        Me.btnRecherche = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbRecherche = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblTempsExecution = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbListe = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre d'éléments (1-216)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(568, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Maximum (<1000)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(331, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Minimum (<999)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnInitialisation)
        Me.GroupBox1.Controls.Add(Me.tbMax)
        Me.GroupBox1.Controls.Add(Me.tbMin)
        Me.GroupBox1.Controls.Add(Me.tbTaille)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(956, 57)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Initialisation de la liste"
        '
        'btnInitialisation
        '
        Me.btnInitialisation.Location = New System.Drawing.Point(829, 17)
        Me.btnInitialisation.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInitialisation.Name = "btnInitialisation"
        Me.btnInitialisation.Size = New System.Drawing.Size(119, 28)
        Me.btnInitialisation.TabIndex = 6
        Me.btnInitialisation.Text = "Générer la liste"
        Me.btnInitialisation.UseVisualStyleBackColor = True
        '
        'tbMax
        '
        Me.tbMax.Location = New System.Drawing.Point(683, 20)
        Me.tbMax.Margin = New System.Windows.Forms.Padding(4)
        Me.tbMax.Name = "tbMax"
        Me.tbMax.Size = New System.Drawing.Size(72, 22)
        Me.tbMax.TabIndex = 5
        '
        'tbMin
        '
        Me.tbMin.Location = New System.Drawing.Point(430, 20)
        Me.tbMin.Margin = New System.Windows.Forms.Padding(4)
        Me.tbMin.Name = "tbMin"
        Me.tbMin.Size = New System.Drawing.Size(78, 22)
        Me.tbMin.TabIndex = 4
        '
        'tbTaille
        '
        Me.tbTaille.Location = New System.Drawing.Point(185, 20)
        Me.tbTaille.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTaille.Name = "tbTaille"
        Me.tbTaille.Size = New System.Drawing.Size(80, 22)
        Me.tbTaille.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbRecherche)
        Me.GroupBox3.Controls.Add(Me.btnRecherche)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.tbRecherche)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(16, 470)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(251, 127)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Type de recherche"
        '
        'cbRecherche
        '
        Me.cbRecherche.FormattingEnabled = True
        Me.cbRecherche.Items.AddRange(New Object() {"Recherche séquentielle", "Recherche par dichotomie"})
        Me.cbRecherche.Location = New System.Drawing.Point(11, 27)
        Me.cbRecherche.Name = "cbRecherche"
        Me.cbRecherche.Size = New System.Drawing.Size(224, 24)
        Me.cbRecherche.TabIndex = 9
        '
        'btnRecherche
        '
        Me.btnRecherche.Location = New System.Drawing.Point(11, 90)
        Me.btnRecherche.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRecherche.Name = "btnRecherche"
        Me.btnRecherche.Size = New System.Drawing.Size(225, 28)
        Me.btnRecherche.TabIndex = 8
        Me.btnRecherche.Text = "Exécuter la recherche"
        Me.btnRecherche.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 64)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Élement à rechercher"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbRecherche
        '
        Me.tbRecherche.Location = New System.Drawing.Point(155, 61)
        Me.tbRecherche.Margin = New System.Windows.Forms.Padding(4)
        Me.tbRecherche.Name = "tbRecherche"
        Me.tbRecherche.Size = New System.Drawing.Size(80, 22)
        Me.tbRecherche.TabIndex = 3
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblTempsExecution)
        Me.GroupBox5.Controls.Add(Me.lblMessage)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(288, 470)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(684, 127)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Résultat de la recherche"
        '
        'lblTempsExecution
        '
        Me.lblTempsExecution.AutoSize = True
        Me.lblTempsExecution.Location = New System.Drawing.Point(152, 80)
        Me.lblTempsExecution.Name = "lblTempsExecution"
        Me.lblTempsExecution.Size = New System.Drawing.Size(17, 16)
        Me.lblTempsExecution.TabIndex = 3
        Me.lblTempsExecution.Text = "..."
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(152, 40)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(17, 16)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.Text = "..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Temps d'exécution"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Message"
        '
        'gbListe
        '
        Me.gbListe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbListe.Location = New System.Drawing.Point(16, 80)
        Me.gbListe.Margin = New System.Windows.Forms.Padding(4)
        Me.gbListe.Name = "gbListe"
        Me.gbListe.Padding = New System.Windows.Forms.Padding(4)
        Me.gbListe.Size = New System.Drawing.Size(956, 382)
        Me.gbListe.TabIndex = 8
        Me.gbListe.TabStop = False
        Me.gbListe.Text = "Liste"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 610)
        Me.Controls.Add(Me.gbListe)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Innovation Recherche : Complexité algorithmique"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnInitialisation As Button
    Friend WithEvents tbMax As TextBox
    Friend WithEvents tbMin As TextBox
    Friend WithEvents tbTaille As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnRecherche As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents tbRecherche As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents gbListe As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbRecherche As ComboBox
    Friend WithEvents lblTempsExecution As Label
    Friend WithEvents lblMessage As Label
End Class
