<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.link = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gatto = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(75, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(197, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Scarica .mp4"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'link
        '
        Me.link.Location = New System.Drawing.Point(31, 64)
        Me.link.Name = "link"
        Me.link.Size = New System.Drawing.Size(399, 20)
        Me.link.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("CRYSTAL", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CaliPanni's Youtube Converter"
        '
        'gatto
        '
        Me.gatto.AutoSize = True
        Me.gatto.Location = New System.Drawing.Point(278, 94)
        Me.gatto.Name = "gatto"
        Me.gatto.Size = New System.Drawing.Size(101, 17)
        Me.gatto.TabIndex = 5
        Me.gatto.Text = "converti in .mp3"
        Me.gatto.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(212, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Link:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 126)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gatto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.link)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "CaliPanni's Youtube Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents link As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gatto As CheckBox
    Friend WithEvents Label2 As Label
End Class
