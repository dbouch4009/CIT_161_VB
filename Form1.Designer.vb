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
        Me.lblCals = New System.Windows.Forms.Label()
        Me.lblFat = New System.Windows.Forms.Label()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.txtCals = New System.Windows.Forms.TextBox()
        Me.txtFat = New System.Windows.Forms.TextBox()
        Me.txtPercentage = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCals
        '
        Me.lblCals.AutoSize = True
        Me.lblCals.Location = New System.Drawing.Point(90, 42)
        Me.lblCals.Name = "lblCals"
        Me.lblCals.Size = New System.Drawing.Size(139, 13)
        Me.lblCals.TabIndex = 0
        Me.lblCals.Text = "Enter the number of calories"
        '
        'lblFat
        '
        Me.lblFat.AutoSize = True
        Me.lblFat.Location = New System.Drawing.Point(90, 74)
        Me.lblFat.Name = "lblFat"
        Me.lblFat.Size = New System.Drawing.Size(146, 13)
        Me.lblFat.TabIndex = 1
        Me.lblFat.Text = "Enter the number of fat grams"
        '
        'lblPercentage
        '
        Me.lblPercentage.AutoSize = True
        Me.lblPercentage.Location = New System.Drawing.Point(90, 141)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(201, 13)
        Me.lblPercentage.TabIndex = 2
        Me.lblPercentage.Text = "Percentage of calories that come from fat"
        '
        'txtCals
        '
        Me.txtCals.Location = New System.Drawing.Point(368, 42)
        Me.txtCals.Name = "txtCals"
        Me.txtCals.Size = New System.Drawing.Size(100, 20)
        Me.txtCals.TabIndex = 3
        '
        'txtFat
        '
        Me.txtFat.Location = New System.Drawing.Point(368, 74)
        Me.txtFat.Name = "txtFat"
        Me.txtFat.Size = New System.Drawing.Size(100, 20)
        Me.txtFat.TabIndex = 4
        '
        'txtPercentage
        '
        Me.txtPercentage.Enabled = False
        Me.txtPercentage.Location = New System.Drawing.Point(368, 141)
        Me.txtPercentage.Name = "txtPercentage"
        Me.txtPercentage.Size = New System.Drawing.Size(100, 20)
        Me.txtPercentage.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.LightSalmon
        Me.btnCalculate.Location = New System.Drawing.Point(93, 199)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(89, 32)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSalmon
        Me.btnClear.Location = New System.Drawing.Point(245, 199)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(89, 32)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightSalmon
        Me.btnExit.Location = New System.Drawing.Point(379, 199)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 32)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtPercentage)
        Me.Controls.Add(Me.txtFat)
        Me.Controls.Add(Me.txtCals)
        Me.Controls.Add(Me.lblPercentage)
        Me.Controls.Add(Me.lblFat)
        Me.Controls.Add(Me.lblCals)
        Me.Name = "Form1"
        Me.Text = "Fat Percentage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCals As Label
    Friend WithEvents lblFat As Label
    Friend WithEvents lblPercentage As Label
    Friend WithEvents txtCals As TextBox
    Friend WithEvents txtFat As TextBox
    Friend WithEvents txtPercentage As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
