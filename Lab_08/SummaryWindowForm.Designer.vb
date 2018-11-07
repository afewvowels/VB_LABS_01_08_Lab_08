<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryWindowForm
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
        Me.SalesTotalLabel = New System.Windows.Forms.Label()
        Me.SalesTotalTextBox = New System.Windows.Forms.TextBox()
        Me.SalesCountTextBox = New System.Windows.Forms.TextBox()
        Me.SalesCountLabel = New System.Windows.Forms.Label()
        Me.TotalStudentDiscountTextBox = New System.Windows.Forms.TextBox()
        Me.TotalStudentDiscountLabel = New System.Windows.Forms.Label()
        Me.CloseWindowButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SalesTotalLabel
        '
        Me.SalesTotalLabel.AutoSize = True
        Me.SalesTotalLabel.Location = New System.Drawing.Point(88, 24)
        Me.SalesTotalLabel.Name = "SalesTotalLabel"
        Me.SalesTotalLabel.Size = New System.Drawing.Size(63, 13)
        Me.SalesTotalLabel.TabIndex = 0
        Me.SalesTotalLabel.Text = "Sales Total:"
        '
        'SalesTotalTextBox
        '
        Me.SalesTotalTextBox.Location = New System.Drawing.Point(157, 21)
        Me.SalesTotalTextBox.Name = "SalesTotalTextBox"
        Me.SalesTotalTextBox.ReadOnly = True
        Me.SalesTotalTextBox.Size = New System.Drawing.Size(120, 20)
        Me.SalesTotalTextBox.TabIndex = 1
        '
        'SalesCountTextBox
        '
        Me.SalesCountTextBox.Location = New System.Drawing.Point(157, 47)
        Me.SalesCountTextBox.Name = "SalesCountTextBox"
        Me.SalesCountTextBox.ReadOnly = True
        Me.SalesCountTextBox.Size = New System.Drawing.Size(120, 20)
        Me.SalesCountTextBox.TabIndex = 3
        '
        'SalesCountLabel
        '
        Me.SalesCountLabel.AutoSize = True
        Me.SalesCountLabel.Location = New System.Drawing.Point(83, 50)
        Me.SalesCountLabel.Name = "SalesCountLabel"
        Me.SalesCountLabel.Size = New System.Drawing.Size(67, 13)
        Me.SalesCountLabel.TabIndex = 2
        Me.SalesCountLabel.Text = "Sales Count:"
        '
        'TotalStudentDiscountTextBox
        '
        Me.TotalStudentDiscountTextBox.Location = New System.Drawing.Point(157, 73)
        Me.TotalStudentDiscountTextBox.Name = "TotalStudentDiscountTextBox"
        Me.TotalStudentDiscountTextBox.ReadOnly = True
        Me.TotalStudentDiscountTextBox.Size = New System.Drawing.Size(120, 20)
        Me.TotalStudentDiscountTextBox.TabIndex = 5
        '
        'TotalStudentDiscountLabel
        '
        Me.TotalStudentDiscountLabel.AutoSize = True
        Me.TotalStudentDiscountLabel.Location = New System.Drawing.Point(31, 73)
        Me.TotalStudentDiscountLabel.Name = "TotalStudentDiscountLabel"
        Me.TotalStudentDiscountLabel.Size = New System.Drawing.Size(119, 13)
        Me.TotalStudentDiscountLabel.TabIndex = 4
        Me.TotalStudentDiscountLabel.Text = "Total Student Discount:"
        '
        'CloseWindowButton
        '
        Me.CloseWindowButton.Location = New System.Drawing.Point(196, 108)
        Me.CloseWindowButton.Name = "CloseWindowButton"
        Me.CloseWindowButton.Size = New System.Drawing.Size(119, 34)
        Me.CloseWindowButton.TabIndex = 6
        Me.CloseWindowButton.Text = "OK"
        Me.CloseWindowButton.UseVisualStyleBackColor = True
        '
        'SummaryWindowForm
        '
        Me.AcceptButton = Me.CloseWindowButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 154)
        Me.Controls.Add(Me.CloseWindowButton)
        Me.Controls.Add(Me.TotalStudentDiscountTextBox)
        Me.Controls.Add(Me.TotalStudentDiscountLabel)
        Me.Controls.Add(Me.SalesCountTextBox)
        Me.Controls.Add(Me.SalesCountLabel)
        Me.Controls.Add(Me.SalesTotalTextBox)
        Me.Controls.Add(Me.SalesTotalLabel)
        Me.Name = "SummaryWindowForm"
        Me.Text = "Summary Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SalesTotalLabel As System.Windows.Forms.Label
    Friend WithEvents SalesTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalesCountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalesCountLabel As System.Windows.Forms.Label
    Friend WithEvents TotalStudentDiscountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalStudentDiscountLabel As System.Windows.Forms.Label
    Friend WithEvents CloseWindowButton As System.Windows.Forms.Button
End Class
