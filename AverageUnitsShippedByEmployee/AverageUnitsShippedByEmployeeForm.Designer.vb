<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AverageUnitsShippedByEmployeeForm
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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblCurrentDay = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblEmployeeOne = New System.Windows.Forms.Label()
        Me.lblEmployeeTwo = New System.Windows.Forms.Label()
        Me.lblEmployeeThree = New System.Windows.Forms.Label()
        Me.txtEmployeeOne = New System.Windows.Forms.TextBox()
        Me.txtEmployeeTwo = New System.Windows.Forms.TextBox()
        Me.txtEmployeeThree = New System.Windows.Forms.TextBox()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.lblEmployeeOneOutput = New System.Windows.Forms.Label()
        Me.lblEmployeeTwoOutput = New System.Windows.Forms.Label()
        Me.lblEmployeeThreeOutput = New System.Windows.Forms.Label()
        Me.lblDailyAverageOutput = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(11, 307)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(127, 23)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.ToolTips.SetToolTip(Me.btnEnter, "Enters the units typed into the current employee's shipping records for the liste" &
        "d day.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblCurrentDay
        '
        Me.lblCurrentDay.Location = New System.Drawing.Point(13, 13)
        Me.lblCurrentDay.Name = "lblCurrentDay"
        Me.lblCurrentDay.Size = New System.Drawing.Size(35, 23)
        Me.lblCurrentDay.TabIndex = 0
        Me.lblCurrentDay.Text = "Day 1"
        Me.lblCurrentDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(13, 45)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(35, 23)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "&Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployeeOne
        '
        Me.lblEmployeeOne.Location = New System.Drawing.Point(34, 83)
        Me.lblEmployeeOne.Name = "lblEmployeeOne"
        Me.lblEmployeeOne.Size = New System.Drawing.Size(77, 23)
        Me.lblEmployeeOne.TabIndex = 3
        Me.lblEmployeeOne.Text = "Employee 1"
        Me.lblEmployeeOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployeeTwo
        '
        Me.lblEmployeeTwo.Location = New System.Drawing.Point(171, 83)
        Me.lblEmployeeTwo.Name = "lblEmployeeTwo"
        Me.lblEmployeeTwo.Size = New System.Drawing.Size(77, 23)
        Me.lblEmployeeTwo.TabIndex = 6
        Me.lblEmployeeTwo.Text = "Employee 2"
        Me.lblEmployeeTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployeeThree
        '
        Me.lblEmployeeThree.Location = New System.Drawing.Point(305, 83)
        Me.lblEmployeeThree.Name = "lblEmployeeThree"
        Me.lblEmployeeThree.Size = New System.Drawing.Size(77, 23)
        Me.lblEmployeeThree.TabIndex = 9
        Me.lblEmployeeThree.Text = "Employee 3"
        Me.lblEmployeeThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmployeeOne
        '
        Me.txtEmployeeOne.Location = New System.Drawing.Point(11, 109)
        Me.txtEmployeeOne.Multiline = True
        Me.txtEmployeeOne.Name = "txtEmployeeOne"
        Me.txtEmployeeOne.Size = New System.Drawing.Size(127, 128)
        Me.txtEmployeeOne.TabIndex = 4
        Me.ToolTips.SetToolTip(Me.txtEmployeeOne, "This is a list of the first employee's shipped units.")
        '
        'txtEmployeeTwo
        '
        Me.txtEmployeeTwo.Location = New System.Drawing.Point(144, 109)
        Me.txtEmployeeTwo.Multiline = True
        Me.txtEmployeeTwo.Name = "txtEmployeeTwo"
        Me.txtEmployeeTwo.Size = New System.Drawing.Size(127, 128)
        Me.txtEmployeeTwo.TabIndex = 7
        Me.ToolTips.SetToolTip(Me.txtEmployeeTwo, "This is a list of the second employee's shipped units.")
        '
        'txtEmployeeThree
        '
        Me.txtEmployeeThree.Location = New System.Drawing.Point(277, 109)
        Me.txtEmployeeThree.Multiline = True
        Me.txtEmployeeThree.Name = "txtEmployeeThree"
        Me.txtEmployeeThree.Size = New System.Drawing.Size(127, 128)
        Me.txtEmployeeThree.TabIndex = 10
        Me.ToolTips.SetToolTip(Me.txtEmployeeThree, "This is a list of the third employee's shipped units.")
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(54, 47)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(84, 20)
        Me.txtUnits.TabIndex = 2
        Me.ToolTips.SetToolTip(Me.txtUnits, "Enter the daily units shipped here.")
        '
        'lblEmployeeOneOutput
        '
        Me.lblEmployeeOneOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeOneOutput.Location = New System.Drawing.Point(11, 240)
        Me.lblEmployeeOneOutput.Name = "lblEmployeeOneOutput"
        Me.lblEmployeeOneOutput.Size = New System.Drawing.Size(127, 23)
        Me.lblEmployeeOneOutput.TabIndex = 5
        Me.lblEmployeeOneOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblEmployeeOneOutput, "This will display the average daily shipped units for the first employee.")
        '
        'lblEmployeeTwoOutput
        '
        Me.lblEmployeeTwoOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeTwoOutput.Location = New System.Drawing.Point(144, 240)
        Me.lblEmployeeTwoOutput.Name = "lblEmployeeTwoOutput"
        Me.lblEmployeeTwoOutput.Size = New System.Drawing.Size(127, 23)
        Me.lblEmployeeTwoOutput.TabIndex = 8
        Me.lblEmployeeTwoOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblEmployeeTwoOutput, "This will display the average daily sales for the second employee.")
        '
        'lblEmployeeThreeOutput
        '
        Me.lblEmployeeThreeOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeThreeOutput.Location = New System.Drawing.Point(277, 240)
        Me.lblEmployeeThreeOutput.Name = "lblEmployeeThreeOutput"
        Me.lblEmployeeThreeOutput.Size = New System.Drawing.Size(127, 23)
        Me.lblEmployeeThreeOutput.TabIndex = 11
        Me.lblEmployeeThreeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblEmployeeThreeOutput, "This will display the average daily sales for the third employee.")
        '
        'lblDailyAverageOutput
        '
        Me.lblDailyAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDailyAverageOutput.Location = New System.Drawing.Point(11, 274)
        Me.lblDailyAverageOutput.Name = "lblDailyAverageOutput"
        Me.lblDailyAverageOutput.Size = New System.Drawing.Size(393, 23)
        Me.lblDailyAverageOutput.TabIndex = 12
        Me.lblDailyAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblDailyAverageOutput, "This will display the daily average shipped units for the company as a whole.")
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(144, 307)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(127, 23)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.ToolTips.SetToolTip(Me.btnReset, "Resets the form and all entered information.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(275, 307)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(127, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.ToolTips.SetToolTip(Me.btnExit, "Exits the form.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'AverageUnitsShippedByEmployeeForm
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(415, 345)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblDailyAverageOutput)
        Me.Controls.Add(Me.lblEmployeeThreeOutput)
        Me.Controls.Add(Me.lblEmployeeTwoOutput)
        Me.Controls.Add(Me.lblEmployeeOneOutput)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.txtEmployeeThree)
        Me.Controls.Add(Me.txtEmployeeTwo)
        Me.Controls.Add(Me.txtEmployeeOne)
        Me.Controls.Add(Me.lblEmployeeThree)
        Me.Controls.Add(Me.lblEmployeeTwo)
        Me.Controls.Add(Me.lblEmployeeOne)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblCurrentDay)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AverageUnitsShippedByEmployeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents lblCurrentDay As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblEmployeeOne As Label
    Friend WithEvents lblEmployeeTwo As Label
    Friend WithEvents lblEmployeeThree As Label
    Friend WithEvents txtEmployeeOne As TextBox
    Friend WithEvents txtEmployeeTwo As TextBox
    Friend WithEvents txtEmployeeThree As TextBox
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents lblEmployeeOneOutput As Label
    Friend WithEvents lblEmployeeTwoOutput As Label
    Friend WithEvents lblEmployeeThreeOutput As Label
    Friend WithEvents lblDailyAverageOutput As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTips As ToolTip
End Class
