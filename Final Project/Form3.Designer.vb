<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.pctPlayer = New System.Windows.Forms.PictureBox()
        Me.pctPres = New System.Windows.Forms.PictureBox()
        Me.rtbDialogue = New System.Windows.Forms.RichTextBox()
        Me.txtPlayerName = New System.Windows.Forms.TextBox()
        Me.txtPlayerHealth = New System.Windows.Forms.TextBox()
        Me.txtOpponentName = New System.Windows.Forms.TextBox()
        Me.txtOpponentHealth = New System.Windows.Forms.TextBox()
        Me.rtbInfo = New System.Windows.Forms.RichTextBox()
        Me.btnAttack = New System.Windows.Forms.Button()
        Me.grpAttacks = New System.Windows.Forms.GroupBox()
        Me.radAttack4 = New System.Windows.Forms.RadioButton()
        Me.radAttack3 = New System.Windows.Forms.RadioButton()
        Me.radAttack2 = New System.Windows.Forms.RadioButton()
        Me.radAttack1 = New System.Windows.Forms.RadioButton()
        Me.tmrDetailRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.tmrHealthRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.btnNext = New System.Windows.Forms.Button()
        Me.tmrAttack = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pctPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAttacks.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.Transparent
        Me.btnContinue.Font = New System.Drawing.Font("BankGothic Md BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.Location = New System.Drawing.Point(486, 196)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(143, 160)
        Me.btnContinue.TabIndex = 4
        Me.btnContinue.Text = "Next"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'pctPlayer
        '
        Me.pctPlayer.BackColor = System.Drawing.Color.Transparent
        Me.pctPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pctPlayer.Location = New System.Drawing.Point(12, 111)
        Me.pctPlayer.Name = "pctPlayer"
        Me.pctPlayer.Size = New System.Drawing.Size(200, 345)
        Me.pctPlayer.TabIndex = 5
        Me.pctPlayer.TabStop = False
        '
        'pctPres
        '
        Me.pctPres.BackColor = System.Drawing.Color.Transparent
        Me.pctPres.Location = New System.Drawing.Point(829, 68)
        Me.pctPres.Name = "pctPres"
        Me.pctPres.Size = New System.Drawing.Size(420, 300)
        Me.pctPres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pctPres.TabIndex = 6
        Me.pctPres.TabStop = False
        '
        'rtbDialogue
        '
        Me.rtbDialogue.BackColor = System.Drawing.Color.Navy
        Me.rtbDialogue.Font = New System.Drawing.Font("BankGothic Md BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbDialogue.ForeColor = System.Drawing.Color.White
        Me.rtbDialogue.Location = New System.Drawing.Point(298, 30)
        Me.rtbDialogue.Name = "rtbDialogue"
        Me.rtbDialogue.ReadOnly = True
        Me.rtbDialogue.Size = New System.Drawing.Size(518, 160)
        Me.rtbDialogue.TabIndex = 7
        Me.rtbDialogue.Text = ""
        '
        'txtPlayerName
        '
        Me.txtPlayerName.BackColor = System.Drawing.Color.Navy
        Me.txtPlayerName.Font = New System.Drawing.Font("BankGothic Md BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayerName.ForeColor = System.Drawing.Color.White
        Me.txtPlayerName.Location = New System.Drawing.Point(12, 55)
        Me.txtPlayerName.Name = "txtPlayerName"
        Me.txtPlayerName.ReadOnly = True
        Me.txtPlayerName.Size = New System.Drawing.Size(146, 21)
        Me.txtPlayerName.TabIndex = 8
        '
        'txtPlayerHealth
        '
        Me.txtPlayerHealth.BackColor = System.Drawing.Color.Navy
        Me.txtPlayerHealth.Font = New System.Drawing.Font("BankGothic Md BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayerHealth.ForeColor = System.Drawing.Color.White
        Me.txtPlayerHealth.Location = New System.Drawing.Point(12, 83)
        Me.txtPlayerHealth.Name = "txtPlayerHealth"
        Me.txtPlayerHealth.ReadOnly = True
        Me.txtPlayerHealth.Size = New System.Drawing.Size(100, 21)
        Me.txtPlayerHealth.TabIndex = 9
        '
        'txtOpponentName
        '
        Me.txtOpponentName.BackColor = System.Drawing.Color.Navy
        Me.txtOpponentName.Font = New System.Drawing.Font("BankGothic Md BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpponentName.ForeColor = System.Drawing.Color.White
        Me.txtOpponentName.Location = New System.Drawing.Point(872, 12)
        Me.txtOpponentName.Name = "txtOpponentName"
        Me.txtOpponentName.ReadOnly = True
        Me.txtOpponentName.Size = New System.Drawing.Size(230, 21)
        Me.txtOpponentName.TabIndex = 10
        '
        'txtOpponentHealth
        '
        Me.txtOpponentHealth.BackColor = System.Drawing.Color.Navy
        Me.txtOpponentHealth.Font = New System.Drawing.Font("BankGothic Md BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpponentHealth.ForeColor = System.Drawing.Color.White
        Me.txtOpponentHealth.Location = New System.Drawing.Point(872, 40)
        Me.txtOpponentHealth.Name = "txtOpponentHealth"
        Me.txtOpponentHealth.ReadOnly = True
        Me.txtOpponentHealth.Size = New System.Drawing.Size(100, 21)
        Me.txtOpponentHealth.TabIndex = 11
        '
        'rtbInfo
        '
        Me.rtbInfo.BackColor = System.Drawing.Color.Navy
        Me.rtbInfo.Font = New System.Drawing.Font("BankGothic Md BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbInfo.ForeColor = System.Drawing.Color.White
        Me.rtbInfo.Location = New System.Drawing.Point(712, 506)
        Me.rtbInfo.Name = "rtbInfo"
        Me.rtbInfo.ReadOnly = True
        Me.rtbInfo.Size = New System.Drawing.Size(541, 126)
        Me.rtbInfo.TabIndex = 12
        Me.rtbInfo.Text = ""
        '
        'btnAttack
        '
        Me.btnAttack.BackColor = System.Drawing.Color.Transparent
        Me.btnAttack.Font = New System.Drawing.Font("BankGothic Md BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttack.Location = New System.Drawing.Point(580, 506)
        Me.btnAttack.Name = "btnAttack"
        Me.btnAttack.Size = New System.Drawing.Size(126, 126)
        Me.btnAttack.TabIndex = 13
        Me.btnAttack.Text = "Attack"
        Me.btnAttack.UseVisualStyleBackColor = False
        Me.btnAttack.Visible = False
        '
        'grpAttacks
        '
        Me.grpAttacks.BackColor = System.Drawing.Color.Transparent
        Me.grpAttacks.Controls.Add(Me.radAttack4)
        Me.grpAttacks.Controls.Add(Me.radAttack3)
        Me.grpAttacks.Controls.Add(Me.radAttack2)
        Me.grpAttacks.Controls.Add(Me.radAttack1)
        Me.grpAttacks.Font = New System.Drawing.Font("BankGothic Md BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAttacks.ForeColor = System.Drawing.Color.Yellow
        Me.grpAttacks.Location = New System.Drawing.Point(12, 488)
        Me.grpAttacks.Name = "grpAttacks"
        Me.grpAttacks.Size = New System.Drawing.Size(397, 100)
        Me.grpAttacks.TabIndex = 14
        Me.grpAttacks.TabStop = False
        Me.grpAttacks.Text = "Attacks"
        '
        'radAttack4
        '
        Me.radAttack4.AutoSize = True
        Me.radAttack4.Location = New System.Drawing.Point(227, 71)
        Me.radAttack4.Name = "radAttack4"
        Me.radAttack4.Size = New System.Drawing.Size(140, 18)
        Me.radAttack4.TabIndex = 3
        Me.radAttack4.TabStop = True
        Me.radAttack4.Text = "RadioButton4"
        Me.radAttack4.UseVisualStyleBackColor = True
        '
        'radAttack3
        '
        Me.radAttack3.AutoSize = True
        Me.radAttack3.Location = New System.Drawing.Point(6, 71)
        Me.radAttack3.Name = "radAttack3"
        Me.radAttack3.Size = New System.Drawing.Size(140, 18)
        Me.radAttack3.TabIndex = 2
        Me.radAttack3.TabStop = True
        Me.radAttack3.Text = "RadioButton3"
        Me.radAttack3.UseVisualStyleBackColor = True
        '
        'radAttack2
        '
        Me.radAttack2.AutoSize = True
        Me.radAttack2.Location = New System.Drawing.Point(227, 21)
        Me.radAttack2.Name = "radAttack2"
        Me.radAttack2.Size = New System.Drawing.Size(140, 18)
        Me.radAttack2.TabIndex = 1
        Me.radAttack2.TabStop = True
        Me.radAttack2.Text = "RadioButton2"
        Me.radAttack2.UseVisualStyleBackColor = True
        '
        'radAttack1
        '
        Me.radAttack1.AutoSize = True
        Me.radAttack1.Location = New System.Drawing.Point(6, 21)
        Me.radAttack1.Name = "radAttack1"
        Me.radAttack1.Size = New System.Drawing.Size(140, 18)
        Me.radAttack1.TabIndex = 0
        Me.radAttack1.TabStop = True
        Me.radAttack1.Text = "RadioButton1"
        Me.radAttack1.UseVisualStyleBackColor = True
        '
        'tmrDetailRefresh
        '
        Me.tmrDetailRefresh.Enabled = True
        Me.tmrDetailRefresh.Interval = 1
        '
        'tmrHealthRefresh
        '
        Me.tmrHealthRefresh.Interval = 1
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.Font = New System.Drawing.Font("BankGothic Md BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(486, 196)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(143, 160)
        Me.btnNext.TabIndex = 15
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        Me.btnNext.Visible = False
        '
        'tmrAttack
        '
        Me.tmrAttack.Enabled = True
        Me.tmrAttack.Interval = 23
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Final_Project.My.Resources.Resources.Ruined_city
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 645)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.grpAttacks)
        Me.Controls.Add(Me.btnAttack)
        Me.Controls.Add(Me.rtbInfo)
        Me.Controls.Add(Me.txtOpponentHealth)
        Me.Controls.Add(Me.txtOpponentName)
        Me.Controls.Add(Me.txtPlayerHealth)
        Me.Controls.Add(Me.txtPlayerName)
        Me.Controls.Add(Me.rtbDialogue)
        Me.Controls.Add(Me.pctPres)
        Me.Controls.Add(Me.pctPlayer)
        Me.Controls.Add(Me.btnContinue)
        Me.Name = "Form3"
        Me.Text = "Rekt Fest"
        CType(Me.pctPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAttacks.ResumeLayout(False)
        Me.grpAttacks.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents pctPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents pctPres As System.Windows.Forms.PictureBox
    Friend WithEvents rtbDialogue As System.Windows.Forms.RichTextBox
    Friend WithEvents txtPlayerName As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayerHealth As System.Windows.Forms.TextBox
    Friend WithEvents txtOpponentName As System.Windows.Forms.TextBox
    Friend WithEvents txtOpponentHealth As System.Windows.Forms.TextBox
    Friend WithEvents rtbInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents btnAttack As System.Windows.Forms.Button
    Friend WithEvents grpAttacks As System.Windows.Forms.GroupBox
    Friend WithEvents radAttack4 As System.Windows.Forms.RadioButton
    Friend WithEvents radAttack3 As System.Windows.Forms.RadioButton
    Friend WithEvents radAttack2 As System.Windows.Forms.RadioButton
    Friend WithEvents radAttack1 As System.Windows.Forms.RadioButton
    Friend WithEvents tmrDetailRefresh As System.Windows.Forms.Timer
    Friend WithEvents tmrHealthRefresh As System.Windows.Forms.Timer
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents tmrAttack As System.Windows.Forms.Timer
End Class
