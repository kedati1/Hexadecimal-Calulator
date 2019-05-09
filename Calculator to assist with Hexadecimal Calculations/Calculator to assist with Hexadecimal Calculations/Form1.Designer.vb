<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModCalculator
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
        Me.TxtInput = New System.Windows.Forms.TextBox()
        Me.TxtMod = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.LblInput = New System.Windows.Forms.Label()
        Me.lblMod = New System.Windows.Forms.Label()
        Me.LblAns = New System.Windows.Forms.Label()
        Me.txtAns = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxtInput
        '
        Me.TxtInput.Location = New System.Drawing.Point(88, 50)
        Me.TxtInput.Name = "TxtInput"
        Me.TxtInput.Size = New System.Drawing.Size(100, 20)
        Me.TxtInput.TabIndex = 0
        '
        'TxtMod
        '
        Me.TxtMod.Location = New System.Drawing.Point(172, 183)
        Me.TxtMod.Name = "TxtMod"
        Me.TxtMod.Size = New System.Drawing.Size(100, 20)
        Me.TxtMod.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(88, 106)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate Mod"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(209, 216)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(63, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'LblInput
        '
        Me.LblInput.AutoSize = True
        Me.LblInput.Location = New System.Drawing.Point(56, 22)
        Me.LblInput.Name = "LblInput"
        Me.LblInput.Size = New System.Drawing.Size(162, 13)
        Me.LblInput.TabIndex = 4
        Me.LblInput.Text = "Input a value to be divided by 16"
        '
        'lblMod
        '
        Me.lblMod.AutoSize = True
        Me.lblMod.Location = New System.Drawing.Point(192, 163)
        Me.lblMod.Name = "lblMod"
        Me.lblMod.Size = New System.Drawing.Size(58, 13)
        Me.lblMod.TabIndex = 5
        Me.lblMod.Text = "Remainder"
        '
        'LblAns
        '
        Me.LblAns.AutoSize = True
        Me.LblAns.Location = New System.Drawing.Point(10, 160)
        Me.LblAns.Name = "LblAns"
        Me.LblAns.Size = New System.Drawing.Size(110, 13)
        Me.LblAns.TabIndex = 6
        Me.LblAns.Text = "Answer Divided by 16"
        '
        'txtAns
        '
        Me.txtAns.Location = New System.Drawing.Point(12, 181)
        Me.txtAns.Name = "txtAns"
        Me.txtAns.Size = New System.Drawing.Size(100, 20)
        Me.txtAns.TabIndex = 7
        '
        'ModCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtAns)
        Me.Controls.Add(Me.LblAns)
        Me.Controls.Add(Me.lblMod)
        Me.Controls.Add(Me.LblInput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.TxtMod)
        Me.Controls.Add(Me.TxtInput)
        Me.Name = "ModCalculator"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtInput As System.Windows.Forms.TextBox
    Friend WithEvents TxtMod As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents LblInput As System.Windows.Forms.Label
    Friend WithEvents lblMod As System.Windows.Forms.Label
    Friend WithEvents LblAns As System.Windows.Forms.Label
    Friend WithEvents txtAns As System.Windows.Forms.TextBox

End Class
