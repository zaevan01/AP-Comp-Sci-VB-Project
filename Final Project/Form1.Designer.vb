<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.pctIntro = New System.Windows.Forms.PictureBox()
        Me.tmrIntro = New System.Windows.Forms.Timer(Me.components)
        Me.rtxtIntro = New System.Windows.Forms.RichTextBox()
        Me.btnAdvance = New System.Windows.Forms.Button()
        CType(Me.pctIntro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctIntro
        '
        Me.pctIntro.Location = New System.Drawing.Point(-1, 0)
        Me.pctIntro.Name = "pctIntro"
        Me.pctIntro.Size = New System.Drawing.Size(720, 594)
        Me.pctIntro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctIntro.TabIndex = 0
        Me.pctIntro.TabStop = False
        '
        'tmrIntro
        '
        Me.tmrIntro.Interval = 3000
        '
        'rtxtIntro
        '
        Me.rtxtIntro.BackColor = System.Drawing.Color.White
        Me.rtxtIntro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxtIntro.Location = New System.Drawing.Point(12, 486)
        Me.rtxtIntro.Name = "rtxtIntro"
        Me.rtxtIntro.ReadOnly = True
        Me.rtxtIntro.Size = New System.Drawing.Size(283, 96)
        Me.rtxtIntro.TabIndex = 2
        Me.rtxtIntro.Text = ""
        '
        'btnAdvance
        '
        Me.btnAdvance.Location = New System.Drawing.Point(567, 538)
        Me.btnAdvance.Name = "btnAdvance"
        Me.btnAdvance.Size = New System.Drawing.Size(140, 44)
        Me.btnAdvance.TabIndex = 3
        Me.btnAdvance.Text = "Continu&e"
        Me.btnAdvance.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 594)
        Me.Controls.Add(Me.btnAdvance)
        Me.Controls.Add(Me.rtxtIntro)
        Me.Controls.Add(Me.pctIntro)
        Me.Name = "Form1"
        Me.Text = "Definately not a pokemon rip-off"
        CType(Me.pctIntro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pctIntro As System.Windows.Forms.PictureBox
    Friend WithEvents tmrIntro As System.Windows.Forms.Timer
    Friend WithEvents rtxtIntro As System.Windows.Forms.RichTextBox
    Friend WithEvents btnAdvance As System.Windows.Forms.Button

End Class
