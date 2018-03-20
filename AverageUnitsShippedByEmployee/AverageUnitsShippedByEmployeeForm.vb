Option Strict On

''' <HEADER>
''' 
''' Student Name: Spence McComb
''' Student ID: 100426427
''' Date: March 6, 2018
''' 
''' Filename: AverageUnitsShippedByEmployeeForm.vb
''' Project Name: AverageUnitsShippedByEmployee
''' Description: This form allows three users to enter seven days' worth of shipping
'''              statistics. Afterward, their daily averages, as well as the company's, 
'''              are calculated and displayed. Should the final user wish to begin anew, 
'''              the form must be reset.
''' 
''' </HEADER>

Public Class AverageUnitsShippedByEmployeeForm

    'Declare and initialize the range constants.
    Const MaxEmployees As Integer = 3
    Const MaxDays As Integer = 7

    'Declare the array and its indexing variables.
    Dim arrayDaysByEmployees((MaxEmployees - 1), (MaxDays - 1)) As Integer
    Dim employeeCounter As Integer = 0
    Dim dayCounter As Integer = 0

    Sub FormReset()

        'Resets the various aspects of the form, as though it were freshly loaded.

        'Resets the tools.
        lblCurrentDay.Text = "Day 1"
        txtUnits.Text = ""
        txtEmployeeOne.Text = ""
        txtEmployeeTwo.Text = ""
        txtEmployeeThree.Text = ""
        lblEmployeeOneOutput.Text = ""
        lblEmployeeTwoOutput.Text = ""
        lblEmployeeThreeOutput.Text = ""
        lblDailyAverageOutput.Text = ""
        txtUnits.ReadOnly = False
        btnEnter.Enabled = True

        'Resets any previously made "highlights".
        lblEmployeeOne.Font = New Font(lblEmployeeOne.Font, FontStyle.Bold)
        lblEmployeeTwo.Font = New Font(lblEmployeeTwo.Font, FontStyle.Regular)
        lblEmployeeThree.Font = New Font(lblEmployeeThree.Font, FontStyle.Regular)

        'Resets the variables.
        dayCounter = 0
        employeeCounter = 0

        'Resets the focus.
        txtUnits.Focus()

    End Sub

    Sub FormLock()

        'Prevents the user from entering any more data.
        'To be used after the program has finished accepting data from the final user.
        txtUnits.ReadOnly = True
        btnEnter.Enabled = False
        btnReset.Focus()

    End Sub

    Function EmployeeAverage(employeeNumber As Integer) As Double

        'Calculates an employee average by cycling through the arrayDaysByEmployees array.
        'MaxDays is used instead of a counter since it would be easier to adjust later on.
        Dim mySum As Integer
        Dim myAverage As Double

        For indexColumn = 0 To (MaxDays - 1)
            mySum += arrayDaysByEmployees(employeeNumber, indexColumn)
        Next

        myAverage = (mySum / MaxDays)

        Return myAverage
    End Function

    Function CompanyAverage() As Double

        'Calculates an overall company average by cycling through the arrayDaysByEmployees array.
        'MaxDays is used instead of a counter since it would be easier to adjust later on.
        Dim mySum As Integer
        Dim myAverage As Double

        For indexEmployee = 0 To (MaxEmployees - 1)
            For indexDay = 0 To (MaxDays - 1)
                mySum += arrayDaysByEmployees(indexEmployee, indexDay)
            Next
        Next

        myAverage = mySum / (MaxDays * MaxEmployees)

        Return myAverage
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Exit the form.
        Application.Exit()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'Call the reset function.
        FormReset()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'Input validation.
        If (txtUnits.Text = "") Then 'Nothing entered into the textbox
            MessageBox.Show("Nothing entered. Please enter a number between 0 and 1000, inclusive!")
            txtUnits.SelectAll()

        ElseIf (CInt(txtUnits.Text) < 0 Or CInt(txtUnits.Text) > 1000) Then 'Number entered out of range
            MessageBox.Show("Entry out of range. Please enter a number between 0 and 1000, inclusive!")
            txtUnits.SelectAll()

        ElseIf ((CDbl(txtUnits.Text) Mod 1.0) <> (CInt(txtUnits.Text) Mod 1.0)) Then 'Number is a decimal
            MessageBox.Show("Entry is not a whole number. Please enter a number between 0 and 1000, inclusive!")
            txtUnits.SelectAll()

        Else 'Data is sound.

            'Beginning of array appending.
            If employeeCounter = 0 Then 'Dealing with the first employee.
                If dayCounter < 6 Then 'Days 1-7.
                    arrayDaysByEmployees(employeeCounter, dayCounter) = CInt(txtUnits.Text)
                    txtEmployeeOne.Text += txtUnits.Text + vbCrLf
                    dayCounter += 1
                Else 'Reset days and increment the employee number.
                    arrayDaysByEmployees(employeeCounter, dayCounter) = CInt(txtUnits.Text)
                    txtEmployeeOne.Text += txtUnits.Text
                    lblEmployeeOneOutput.Text = "Average: " + (EmployeeAverage(employeeCounter)).ToString("N2")
                    dayCounter = 0
                    employeeCounter += 1
                    lblEmployeeOne.Font = New Font(lblEmployeeOne.Font, FontStyle.Regular)
                    lblEmployeeTwo.Font = New Font(lblEmployeeTwo.Font, FontStyle.Bold)
                End If

            ElseIf employeeCounter = 1 Then 'Dealing with the second employee.
                If dayCounter < 6 Then 'Days 1-7.
                    arrayDaysByEmployees(employeeCounter, dayCounter) = CInt(txtUnits.Text)
                    txtEmployeeTwo.Text += txtUnits.Text + vbCrLf
                    dayCounter += 1
                Else 'Reset days and increment the employee number.
                    arrayDaysByEmployees(employeeCounter, dayCounter) = CInt(txtUnits.Text)
                    txtEmployeeTwo.Text += txtUnits.Text
                    lblEmployeeTwoOutput.Text = "Average: " + (EmployeeAverage(employeeCounter)).ToString("N2")
                    dayCounter = 0
                    employeeCounter += 1
                    lblEmployeeTwo.Font = New Font(lblEmployeeTwo.Font, FontStyle.Regular)
                    lblEmployeeThree.Font = New Font(lblEmployeeThree.Font, FontStyle.Bold)
                End If

            Else 'Dealing with the third employee.
                If dayCounter < 6 Then 'Days 1-7.
                    arrayDaysByEmployees(employeeCounter, dayCounter) = CInt(txtUnits.Text)
                    txtEmployeeThree.Text += txtUnits.Text + vbCrLf
                    dayCounter += 1
                Else
                    arrayDaysByEmployees(employeeCounter, dayCounter) = CInt(txtUnits.Text)
                    txtEmployeeThree.Text += txtUnits.Text
                    lblEmployeeThreeOutput.Text = "Average: " + (EmployeeAverage(employeeCounter)).ToString("N2")

                    'Calculate the company average and lock the form.
                    lblDailyAverageOutput.Text = "Average per day: " + (CompanyAverage()).ToString("N2")
                    FormLock()
                End If

            End If

            'Update the Day label and clear the units textbox.
            lblCurrentDay.Text = "Day " + CStr(dayCounter + 1)
            txtUnits.Text = ""
            txtUnits.Focus()
        End If
    End Sub

    Private Sub frmAverageUnitsShippedByEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Bolds the first employee label.
        lblEmployeeOne.Font = New Font(lblEmployeeOne.Font, FontStyle.Bold)
    End Sub

End Class
