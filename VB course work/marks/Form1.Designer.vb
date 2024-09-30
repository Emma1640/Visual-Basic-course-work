<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblGradingScaleCalculator = New Label()
        lblMarks = New Label()
        lblGrade = New Label()
        btnEvaluate = New Button()
        txtMarks = New TextBox()
        txtGrade = New TextBox()
        SuspendLayout()
        ' 
        ' lblGradingScaleCalculator
        ' 
        lblGradingScaleCalculator.AutoSize = True
        lblGradingScaleCalculator.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGradingScaleCalculator.Location = New Point(235, 53)
        lblGradingScaleCalculator.Name = "lblGradingScaleCalculator"
        lblGradingScaleCalculator.Size = New Size(265, 24)
        lblGradingScaleCalculator.TabIndex = 0
        lblGradingScaleCalculator.Text = "Grading Scale Calculator"
        ' 
        ' lblMarks
        ' 
        lblMarks.AutoSize = True
        lblMarks.Font = New Font("Arial Rounded MT Bold", 12F)
        lblMarks.Location = New Point(221, 133)
        lblMarks.Name = "lblMarks"
        lblMarks.Size = New Size(56, 18)
        lblMarks.TabIndex = 1
        lblMarks.Text = "Marks"
        ' 
        ' lblGrade
        ' 
        lblGrade.AutoSize = True
        lblGrade.Font = New Font("Arial Rounded MT Bold", 12F)
        lblGrade.Location = New Point(221, 184)
        lblGrade.Name = "lblGrade"
        lblGrade.Size = New Size(58, 18)
        lblGrade.TabIndex = 2
        lblGrade.Text = "Grade"
        ' 
        ' btnEvaluate
        ' 
        btnEvaluate.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEvaluate.Location = New Point(330, 234)
        btnEvaluate.Name = "btnEvaluate"
        btnEvaluate.Size = New Size(127, 43)
        btnEvaluate.TabIndex = 3
        btnEvaluate.Text = "Evaluate"
        btnEvaluate.UseVisualStyleBackColor = True
        ' 
        ' txtMarks
        ' 
        txtMarks.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtMarks.Location = New Point(330, 130)
        txtMarks.Name = "txtMarks"
        txtMarks.Size = New Size(243, 25)
        txtMarks.TabIndex = 4
        ' 
        ' txtGrade
        ' 
        txtGrade.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtGrade.Location = New Point(330, 181)
        txtGrade.Name = "txtGrade"
        txtGrade.Size = New Size(243, 25)
        txtGrade.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtGrade)
        Controls.Add(txtMarks)
        Controls.Add(btnEvaluate)
        Controls.Add(lblGrade)
        Controls.Add(lblMarks)
        Controls.Add(lblGradingScaleCalculator)
        Name = "Form1"
        Text = "Okot Emmanuel Patrick"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblGradingScaleCalculator As Label
    Friend WithEvents lblMarks As Label
    Friend WithEvents lblGrade As Label
    Friend WithEvents btnEvaluate As Button
    Friend WithEvents txtMarks As TextBox
    Friend WithEvents txtGrade As TextBox

End Class
