<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BotonGenerar = New MetroFramework.Controls.MetroButton()
        Me.LabelCodigo = New MetroFramework.Controls.MetroLabel()
        Me.TextoCodigo = New MetroFramework.Controls.MetroTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BotonCaptura = New MetroFramework.Controls.MetroButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BotonGenerar
        '
        Me.BotonGenerar.Location = New System.Drawing.Point(204, 235)
        Me.BotonGenerar.Name = "BotonGenerar"
        Me.BotonGenerar.Size = New System.Drawing.Size(60, 23)
        Me.BotonGenerar.TabIndex = 0
        Me.BotonGenerar.Text = "Generar"
        '
        'LabelCodigo
        '
        Me.LabelCodigo.AutoSize = True
        Me.LabelCodigo.Location = New System.Drawing.Point(36, 194)
        Me.LabelCodigo.Name = "LabelCodigo"
        Me.LabelCodigo.Size = New System.Drawing.Size(56, 19)
        Me.LabelCodigo.TabIndex = 1
        Me.LabelCodigo.Text = "Codigo:"
        '
        'TextoCodigo
        '
        Me.TextoCodigo.Location = New System.Drawing.Point(98, 194)
        Me.TextoCodigo.Name = "TextoCodigo"
        Me.TextoCodigo.Size = New System.Drawing.Size(166, 23)
        Me.TextoCodigo.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(98, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 107)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'BotonCaptura
        '
        Me.BotonCaptura.Location = New System.Drawing.Point(98, 234)
        Me.BotonCaptura.Name = "BotonCaptura"
        Me.BotonCaptura.Size = New System.Drawing.Size(75, 23)
        Me.BotonCaptura.TabIndex = 4
        Me.BotonCaptura.Text = "Capturar"
        '
        'FormQR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 276)
        Me.Controls.Add(Me.BotonCaptura)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextoCodigo)
        Me.Controls.Add(Me.LabelCodigo)
        Me.Controls.Add(Me.BotonGenerar)
        Me.Name = "FormQR"
        Me.Text = "FormQR"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BotonGenerar As MetroFramework.Controls.MetroButton
    Friend WithEvents LabelCodigo As MetroFramework.Controls.MetroLabel
    Friend WithEvents TextoCodigo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BotonCaptura As MetroFramework.Controls.MetroButton
End Class
