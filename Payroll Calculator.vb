' Written by Dave Tacker
' July 1st, 2014
' A payroll calculator which displays the weekly, bi-weekly, monthly, quartly, and annual income for an individual after taxes have been deducted.

Public Class Fancy_Form
    ' Assign global variables for use
    Dim GrossPay As Decimal = 0

    Dim PreTaxDeductions As Decimal = 0
    Dim IncomeTaxDeductions As Decimal = 0
    Dim MedicareDeduction As Decimal = 0
    Dim SocialSecurityDeduction As Decimal = 0

    Dim NoModifyGrossPay As Decimal = 0
    Dim IncomeTaxRate As Decimal = 0

    Dim FilingStatus As Integer = 0
    Dim Dependants As Decimal = 0
    Dim SOCIALSECURITY As Decimal = My.Settings.SocialSecurity
    Dim MedicareRate As Decimal = My.Settings.Medicare

    ' Functions built as strings so I can easily use them in tooltips and calculations.
    Dim strGrossPay As String = "(Work * Wage) + (Overtime * OTRate) + Bonuses - Pre-Tax Deductions = GrossPay"
    Dim strGrossPaySalary As String = "Annual Salary + Annaul Bonuses = GrossPay"
    Dim strIncomeTax As String = "GrossPay * Filing Status = Income Tax"
    Dim strMedicare As String = "GrossPay * MedicareRate"
    Dim strSocialSecurity As String = "GrossPay * SocialSecurity"
    Dim strPreTaxDeductions As String = "(GrossPay * 401K) + (Garnishment + Flex + Withholdings + Insurance) = Pre-Tax Deductions"
    Dim strNetPay As String = "(GrossPay - Pre-Tax Deductions) - Income Tax - Social Security - Medicare = Net Pay"

    ' #######################################################
    ' This simply replaces keywords within a string with actual values.
    ' Used to explain math in tooltips
    ' #######################################################
    Private Function ReplaceEvalString(ByVal strFormula As String)
        Try
            GrossPay = FormatCurrency(GrossPay)
            PreTaxDeductions = FormatCurrency(PreTaxDeductions)
            SocialSecurityDeduction = FormatCurrency(SocialSecurityDeduction)
            MedicareDeduction = FormatCurrency(MedicareDeduction)
            IncomeTaxDeductions = FormatCurrency(IncomeTaxDeductions)
            'Dim Garnishment As Decimal = FormatCurrency(txtGarnishment.Text)
            'Dim FourOhOneK As Decimal = txtFourOhOne.Text
            'Dim Flex As Decimal = FormatCurrency(txtFlex.Text)

            strFormula = strFormula.Replace("GrossPay", GrossPay)
            strFormula = strFormula.Replace("MedicareRate", MedicareRate)
            strFormula = strFormula.Replace("SOCIALSECURITY", SOCIALSECURITY)
            strFormula = strFormula.Replace("401K", txtFourOhOne.Text)
            strFormula = strFormula.Replace("Garnishment", txtGarnishment.Text)
            strFormula = strFormula.Replace("Flex", txtFlex.Text)
            strFormula = strFormula.Replace("Withholdings", txtWithholdings.Text)
            strFormula = strFormula.Replace("Insurance", txtInsurance.Text)
            strFormula = strFormula.Replace("Dependants", txtDependants.Text)
            strFormula = strFormula.Replace("Pre-Tax Deductions", PreTaxDeductions)
            strFormula = strFormula.Replace("Income Tax", IncomeTaxDeductions)
            strFormula = strFormula.Replace("Social Security", SocialSecurityDeduction)
            strFormula = strFormula.Replace("Medicare", MedicareDeduction)
            strFormula = strFormula.Replace("Net Pay", lblNetPay.Text)
            strFormula = strFormula.Replace("Work", (CInt(txtRegularHours.Text) * CDec(txtRegularRate.Text)) + (CInt(txtRegularMinutes.Text) * (CDec(txtRegularRate.Text / 60))))
            strFormula = strFormula.Replace("Overtime", (CInt(txtOTHours.Text) * CDec(txtOTRate.Text)) + (CInt(txtOTMinutes.Text) * (CDec(txtOTRate.Text / 60))))
            strFormula = strFormula.Replace("Wage", txtRegularRate.Text)
            strFormula = strFormula.Replace("OTRate", txtOTRate.Text)
            strFormula = strFormula.Replace("Filing Status", cbFilingStatus.SelectedItem.ToString)
            strFormula = strFormula.Replace("Tax Rate", IncomeTaxRate)
            strFormula = strFormula.Replace("Bonuses", txtSalaryBonuses.Text)

            Return strFormula
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    ' #######################################################
    ' Perform a calulation on a string
    ' Ea: EvalString("2+2") would return 4
    ' #######################################################
    Private Function EvalString(ByVal strFormula As String)
        Dim SC As New MSScriptControl.ScriptControl
        SC.Language = "VBSCRIPT"
        Try
            strFormula = strFormula.Replace("GrossPay", GrossPay)
            strFormula = strFormula.Replace("MedicareRate", MedicareRate)
            strFormula = strFormula.Replace("SOCIALSECURITY", SOCIALSECURITY)

            Return Convert.ToDecimal(SC.Eval(strFormula))
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    ' #######################################################
    ' Calculate the gross pay for one week.
    ' Hours + OT Hours = Gross Pay
    ' or
    ' Salary + Bonuses = Gross Pay
    ' #######################################################
    Private Function CalculateGrossPay()
        If rbHourly.Checked Then
            ' ######## REGULAR PAY
            ' Minutes worked * (Rate / 60 minutes in an hour) = Dollar value per minute
            Dim MinutePay As Decimal = CInt(txtRegularMinutes.Text) * (CDec(txtRegularRate.Text / 60))
            ' (Hours worked * Rate) + Minute Pay 
            Dim RegularPay As Decimal = (CInt(txtRegularHours.Text) * CDec(txtRegularRate.Text)) + MinutePay

            ' ######## OVERTIME PAY
            ' Minutes worked * (Rate / 60 minutes in an hour) = Dollar value per minute
            MinutePay = CInt(txtOTMinutes.Text) * (CDec(txtOTRate.Text / 60))
            ' (Hours worked * Rate) + Minute Pay 
            Dim OTPay As Decimal = (CInt(txtOTHours.Text) * CDec(txtOTRate.Text)) + MinutePay

            ' ######## GROSS PAY
            GrossPay = ((RegularPay + OTPay) * 52.17) + CDec(txtSalaryBonuses.Text) ' One years worth of pay
        Else
            GrossPay = CDec(txtSalary.Text) + CDec(txtSalaryBonuses.Text) ' Total up the users salary
        End If

        Return GrossPay
    End Function

    ' #######################################################
    ' Calculate the pre-tax deductions
    ' #######################################################
    Private Function CalculatePreTaxDeductions(ByVal GrossPay As Decimal)
        ' Remove the % sign from the textbox.text
        Dim percent As String = txtFourOhOne.Text.Substring(0, txtFourOhOne.Text.Length - 1)

        ' If the number is a single digit, make sure to add a 0 before it, other wise 5% turns to 50%
        If percent.Length = 1 Then
            percent = "0" + percent
        End If

        Return (GrossPay * CDec("." + percent)) + CDec(txtGarnishment.Text) + CDec(txtInsurance.Text) + CDec(txtWithholdings.Text) + CDec(txtFlex.Text)
    End Function

    ' #######################################################
    ' Calculate the incometax from a yearly gross pay
    ' Gross Pay * Filing status = Income Tax
    ' #######################################################
    Private Function CalculateIncomeTax(ByVal GrossPay As Decimal)
        Dim IncomeTaxRate As Decimal
        Dim FilingStatus As Integer
        ' Arrays which hold the income ranges and rates for each filing status
        ' low end gross, high end gross, rate for that range (percent)
        Dim FilingSingle = {{0, 9075, 0.1}, {9075, 36900, 0.15}, {36900, 89350, 0.25}, {89350, 186350, 0.28}, {186350, 405100, 0.33}, {405100, 406750, 0.35}, {406750, 1000000, 0.396}} ' 10, 15, 25, 28, 33, 35, 39.6
        Dim FilingMarriedJointly = {{0, 18150, 0.1}, {18150, 73800, 0.15}, {73800, 148850, 0.25}, {148850, 226850, 0.28}, {226850, 405100, 0.33}, {405100, 406750, 0.35}, {406750, 1000000, 0.396}} ' 10, 15, 25, 28, 33, 35, 39.6
        Dim FilingMarriedSingle = {{0, 9075, 0.1}, {9075, 36900, 0.15}, {36900, 74425, 0.25}, {74425, 113425, 0.28}, {113425, 202550, 0.33}, {202550, 228800, 0.35}, {228800, 1000000, 0.396}} ' 10, 15, 25, 28, 33, 35, 39.6
        Dim FilingHeadOfHousehold = {{0, 12950, 0.1}, {12950, 49400, 0.15}, {49400, 127550, 0.25}, {127550, 206600, 0.28}, {206600, 405100, 0.33}, {405100, 432200, 0.35}, {432200, 1000000, 0.396}} ' 10, 15, 25, 28, 33, 35, 39.6

        Dim ArrayToUse As Array
        If cbFilingStatus.SelectedIndex = 0 Then
            ArrayToUse = FilingSingle
            FilingStatus = 0
        ElseIf cbFilingStatus.SelectedIndex = 1 Then
            ArrayToUse = FilingMarriedJointly
            FilingStatus = 1
        ElseIf cbFilingStatus.SelectedIndex = 2 Then
            ArrayToUse = FilingMarriedSingle
            FilingStatus = 2
        Else
            ArrayToUse = FilingHeadOfHousehold
            FilingStatus = 3
        End If

        For i As Integer = 0 To 6
            If GrossPay > ArrayToUse(i, 0) And GrossPay < ArrayToUse(i, 1) Then
                IncomeTaxRate = ArrayToUse(i, 2)
            End If
        Next i

        Return {IncomeTaxRate, FilingStatus}
    End Function

    ' #######################################################
    ' The calculate buttons, this intilizes the calculations
    ' #######################################################
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Const INCOMETAX = 0.28 ' http://www.irs.gov/pub/irs-prior/p15--2014.pdf and http://taxes.about.com/od/Federal-Income-Taxes/fl/Federal-Income-Tax-Rates-for-the-Year-2014.htm
        Try
            ' ######################
            ' Calculate GROSS PAY
            ' ######################
            GrossPay = CalculateGrossPay()
            NoModifyGrossPay = GrossPay
            Console.WriteLine("GrossPay: " + FormatCurrency(GrossPay))

            ' Deduct all Pre-Tax money from Gross Pay
            PreTaxDeductions = CalculatePreTaxDeductions(GrossPay)
            GrossPay -= PreTaxDeductions
            Console.WriteLine("Pre-Tax Deductions: " + FormatCurrency(PreTaxDeductions))
            Console.WriteLine("-------------------------" + vbNewLine + _
                              "Running SubTotal: " + FormatCurrency(GrossPay))


            ' Income tax
            IncomeTaxDeductions = CalculateIncomeTaxDeductions()
            Console.WriteLine("Income Tax: " + CStr(IncomeTaxRate) + "%, " + FormatCurrency(IncomeTaxDeductions))

            ' Medicare Tax
            MedicareDeduction = CalculateMedicare()
            Console.WriteLine("Annual Medicare: " + CStr(MedicareRate) + "%, " + FormatCurrency(MedicareDeduction))

            ' Social Security
            SocialSecurityDeduction = CalculateSocialSecurity()
            Console.WriteLine("Annual Social Security: " + CStr(SOCIALSECURITY) + "%, " + FormatCurrency(SocialSecurityDeduction))

            ' Breakdown the taxes and gross pay to the frequency specified by the user
            Dim Output = BreakdownByFrequency(GrossPay, IncomeTaxDeductions, SocialSecurityDeduction, MedicareDeduction)
            GrossPay = Output(0)
            IncomeTaxDeductions = Output(1)
            SocialSecurityDeduction = Output(2)
            MedicareDeduction = Output(3)

            ' Write the Gross Pay down in the label
            lblGrossPay.Text = FormatCurrency(GrossPay)
            lblIncomeTax.Text = FormatCurrency(IncomeTaxDeductions)
            lblSocialSecurity.Text = FormatCurrency(SocialSecurityDeduction)
            lblMedicare.Text = FormatCurrency(MedicareDeduction)

            ' Deduct the taxes from Gross Pay
            GrossPay -= IncomeTaxDeductions
            GrossPay -= MedicareDeduction
            GrossPay -= SocialSecurityDeduction

            lblNetPay.Text = FormatCurrency(GrossPay) ' This is now a net pay...
            Console.WriteLine("-------------------------" + vbNewLine + "Net Pay: " + FormatCurrency(GrossPay))

            ' Update the tooltips
            GenerateTooltips()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    ' #######################################################
    ' Calculates Social Security, adjusts to 12.4% if the user
    ' makes more than $127,000 annually.
    ' ########################################################
    Private Function CalculateSocialSecurity()
        If cbSocialSecurity.CheckState = False Then
            If GrossPay >= 127000 Then
                SOCIALSECURITY = 0.124
            End If
            Return FormatCurrency(GrossPay * SOCIALSECURITY)
        End If
    End Function


    ' #######################################################
    ' Calculates Medicare, considers Gross Pay and adjusts
    ' Medicare +9% if the threshold is reached.
    ' ########################################################
    Private Function CalculateMedicare()
        If cbMedicare.CheckState = False Then
            ' If they make more than 200k a year, it's an additional 9%...
            If GrossPay >= 200000 And (FilingStatus = 0 Or FilingStatus = 3) Then ' single or head of household
                MedicareRate += 0.09
            ElseIf GrossPay >= 250000 And FilingStatus = 1 Then ' married filing joinly
                MedicareRate += 0.09
            ElseIf GrossPay >= 125000 And FilingStatus = 2 Then ' married filing seperately
                MedicareRate += 0.09
            End If

            'MedicareDeduction = FormatCurrency(GrossPay * MedicareRate)
            Return EvalString(strMedicare)
        End If
    End Function


    ' #######################################################
    ' Calculate income tax. This function also considers
    ' dependants (allowances).
    ' ########################################################
    Private Function CalculateIncomeTaxDeductions()
        Dim IncomeOutput = CalculateIncomeTax(GrossPay)
        IncomeTaxRate = IncomeOutput(0)
        FilingStatus = IncomeOutput(1)

        If cbIncomeTax.CheckState = False Then
            IncomeTaxDeductions = FormatCurrency(GrossPay * IncomeTaxRate)

            ' Calculate Dependant allowance (claiming more than 0 on your W2 or W4...)
            Dependants = 3650 * CInt(txtDependants.Text) ' Each dependant is $3,650 deducted from your income tax
            If Dependants > IncomeTaxDeductions Then
                'IncomeTaxDeductions = 0
                Return 0
            Else
                IncomeTaxDeductions -= Dependants
                Console.WriteLine("Dependants: " + CStr(txtDependants.Text) + ", " + FormatCurrency(Dependants))
            End If

            Return IncomeTaxDeductions
        End If

    End Function


    ' #######################################################
    ' Breaks down the GrossPay, Income Tax, Medicare, 
    ' and Social Security to the desired pay frequency.
    ' Gather the data through an array.
    ' ########################################################
    Private Function BreakdownByFrequency(ByVal GrossPay As Decimal, ByVal IncomeTaxDeductions As Decimal, ByVal SocialSecurityDeductions As Decimal, ByVal MedicareDeductions As Decimal)
        ' Reduce down to a weeks salary for ease of calculating
        ' Item / 52.17 weeks in a year
        GrossPay /= 52.17
        PreTaxDeductions /= 52.17
        IncomeTaxDeductions /= 52.17
        SocialSecurityDeductions /= 52.17
        MedicareDeductions /= 52.17

        If cbFrequency.SelectedIndex = 1 Then ' Bi-Weekly
            GrossPay *= 2
            PreTaxDeductions *= 2
            IncomeTaxDeductions *= 2
            SocialSecurityDeductions *= 2
            MedicareDeductions *= 2
        ElseIf cbFrequency.SelectedIndex = 2 Then ' Monthly
            GrossPay *= 4.33
            PreTaxDeductions *= 4.33
            IncomeTaxDeductions *= 4.33
            SocialSecurityDeductions *= 4.33
            MedicareDeductions *= 4.33
        ElseIf cbFrequency.SelectedIndex = 3 Then ' Quartly
            GrossPay *= 17.32
            PreTaxDeductions *= 17.32
            IncomeTaxDeductions *= 17.32
            SocialSecurityDeductions *= 17.32
            MedicareDeductions *= 17.32
        ElseIf cbFrequency.SelectedIndex = 4 Then ' Yearly
            GrossPay *= 52.17
            PreTaxDeductions *= 52.17
            IncomeTaxDeductions *= 52.17
            SocialSecurityDeductions *= 52.17
            MedicareDeductions *= 52.17
        End If

        Return {GrossPay, IncomeTaxDeductions, SocialSecurityDeductions, MedicareDeductions}
    End Function


    ' #######################################################
    ' Generate the tooltips to explain what it is I'm doing
    ' #######################################################
    Private Function GenerateTooltips()
        ToolTip.SetToolTip(lblGrossPay, strGrossPay + vbNewLine + vbNewLine + "Pre-Tax Deductions:" + vbNewLine + strPreTaxDeductions)

        ToolTip.SetToolTip(lblIncomeTax, strIncomeTax + vbNewLine + vbNewLine + "Income Tax will vary from 0 to 49% depending upon your annual income.")

        ToolTip.SetToolTip(lblSocialSecurity, strSocialSecurity + vbNewLine + vbNewLine + "Social Security will vary from 6.2% to 12.4% depending upon your annual income.")

        ToolTip.SetToolTip(lblMedicare, strMedicare + vbNewLine + vbNewLine + "Medicare will vary from 1.4% to 10.04% depending upon your annual income.")

        ToolTip.SetToolTip(lblNetPay, strNetPay)
    End Function

    ' #######################################################
    ' HOURLY OR SALARY RADIO BUTTONS
    ' #######################################################
    Private Sub rbSalary_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbSalary.CheckedChanged
        txtRegularHours.Enabled = False
        txtRegularMinutes.Enabled = False
        txtRegularRate.Enabled = False
        txtOTHours.Enabled = False
        txtOTMinutes.Enabled = False
        txtOTRate.Enabled = False
        txtSalary.Enabled = True
    End Sub

    Private Sub rbHourly_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbHourly.CheckedChanged
        txtRegularHours.Enabled = True
        txtRegularMinutes.Enabled = True
        txtRegularRate.Enabled = True
        txtOTHours.Enabled = True
        txtOTMinutes.Enabled = True
        txtOTRate.Enabled = True
        txtSalary.Enabled = False
    End Sub

    Private Sub rbHourlyClick(sender As System.Object, e As System.EventArgs) Handles rbHourly.Click
        ' Is the salary button clicked?
        If rbSalary.Checked = True Then
            rbSalary.Checked = False
        End If
    End Sub

    Private Sub rbSalaryClick(sender As System.Object, e As System.EventArgs) Handles rbSalary.Click
        ' Is the hourly button clicked?
        If rbHourly.Checked = True Then
            rbHourly.Checked = False
        End If
    End Sub

    ' #######################################################
    ' Automatically add a % to the 401k textbox when
    ' the focus leaves the box after typing.
    ' These functions also restict the user to ONLY typing
    ' Digits and decimals, as well as making sure that
    ' /something/ is entered into the box upon focus leave.
    ' #######################################################
    Private Sub FourOhOneFocusLeave(sender As System.Object, e As System.EventArgs) Handles txtFourOhOne.Leave
        Dim txt As String = DirectCast(sender, TextBox).Text.Replace("%", "")
        DirectCast(sender, TextBox).Text = txt + "%"
    End Sub

    Private Sub OnlyDigitsOnKeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWithholdings.KeyPress, txtSalaryBonuses.KeyPress, txtSalary.KeyPress, txtRegularRate.KeyPress, txtRegularMinutes.KeyPress, txtRegularHours.KeyPress, txtOTRate.KeyPress, txtOTMinutes.KeyPress, txtOTHours.KeyPress, txtInsurance.KeyPress, txtGarnishment.KeyPress, txtFourOhOne.KeyPress, txtFlex.KeyPress, txtDependants.KeyPress
        Try
            If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtBoxFocusLeave(sender As Object, e As EventArgs) Handles txtRegularMinutes.Leave, txtRegularHours.Leave, txtOTMinutes.Leave, txtOTHours.Leave, txtFourOhOne.Leave, txtDependants.Leave
        If sender.Text = "" Then
            sender.Text = 0
        End If
    End Sub

    Private Sub txtBoxFocusEnter(sender As Object, e As EventArgs) Handles txtWithholdings.Enter, txtSalaryBonuses.Enter, txtSalary.Enter, txtRegularRate.Enter, txtRegularMinutes.Enter, txtRegularHours.Enter, txtOTRate.Enter, txtOTMinutes.Enter, txtOTHours.Enter, txtInsurance.Enter, txtGarnishment.Enter, txtFourOhOne.Enter, txtFlex.Enter, txtDependants.Enter, txtWithholdings.Click, txtSalaryBonuses.Click, txtSalary.Click, txtRegularRate.Click, txtRegularMinutes.Click, txtRegularHours.Click, txtOTRate.Click, txtOTMinutes.Click, txtOTHours.Click, txtInsurance.Click, txtGarnishment.Click, txtFourOhOne.Click, txtFlex.Click, txtDependants.Click
        sender.SelectAll()
    End Sub

    Private Sub txtCurrencyFocusLeave(sender As Object, e As EventArgs) Handles txtWithholdings.Leave, txtSalaryBonuses.Leave, txtSalary.Leave, txtRegularRate.Leave, txtOTRate.Leave, txtInsurance.Leave, txtGarnishment.Leave, txtFlex.Leave
        If sender.Text = "" Then
            sender.Text = 0
        End If
        sender.Text = FormatCurrency(sender.Text)
    End Sub

    ' #######################################################
    ' Launches other application windows
    ' #######################################################
    Private Sub LaunchUpcomingFeatures(sender As Object, e As EventArgs) Handles UpcomingFeaturesToolStripMenuItem.Click
        To_Do.Show()
    End Sub

    Private Sub WhatIsItToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://www.irs.gov/Individuals/IRS-Withholding-Calculator")
    End Sub

    Private Sub LaunchToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://apps.irs.gov/app/withholdingcalculator/")
    End Sub

    Private Sub AboutPayrollCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutPayrollCalculatorToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ' #######################################################
    ' Purely for testing, this autofills the form with random
    ' data
    ' #######################################################
    Private Sub AutoFill_Click(sender As Object, e As EventArgs) Handles AutofillFormdebugToolStripMenuItem.Click
        Dim randomID As New Random
        txtRegularHours.Text = CStr(randomID.Next(5, 80))
        txtRegularMinutes.Text = CStr(randomID.Next(1, 60))
        txtRegularRate.Text = FormatCurrency(CStr(randomID.Next(10, 50)))
        txtOTHours.Text = CStr(randomID.Next(5, 80))
        txtOTMinutes.Text = CStr(randomID.Next(1, 60))
        txtOTRate.Text = FormatCurrency(CStr(randomID.Next(10, 50)))
        txtSalary.Text = FormatCurrency(CStr(randomID.Next(1500, 600000)))
        txtSalaryBonuses.Text = FormatCurrency(CStr(randomID.Next(0, 10000)))
        txtFourOhOne.Text = CStr(randomID.Next(0, 5)) + "%"
        txtGarnishment.Text = FormatCurrency(CStr(randomID.Next(0, 300)))
        txtInsurance.Text = FormatCurrency(CStr(randomID.Next(0, 300)))
        txtWithholdings.Text = FormatCurrency(CStr(randomID.Next(0, 300)))
        txtFlex.Text = FormatCurrency(CStr(randomID.Next(0, 300)))
    End Sub

    ' #######################################################
    ' Make sure the combo boxes and radio buttons are checked
    ' when the form loads
    ' #######################################################
    Private Sub Fancy_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set dropdown defaults
        cbFrequency.SelectedIndex = 1
        cbFilingStatus.SelectedIndex = 0

        ' Set Radio Buttons and grey out unused options
        rbHourly.Checked = True
        txtSalary.Enabled = False
    End Sub

    ' #######################################################
    ' Clear the form
    ' #######################################################
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        resetAllControls(Me)
        lblGrossPay.Text = FormatCurrency(0)
        lblIncomeTax.Text = FormatCurrency(0)
        lblMedicare.Text = FormatCurrency(0)
        lblNetPay.Text = FormatCurrency(0)
        lblSocialSecurity.Text = FormatCurrency(0)
        txtDependants.Text = 0
        txtFourOhOne.Text = "0%"
        txtOTHours.Text = 0
        txtOTMinutes.Text = 0
        txtRegularHours.Text = 0
        txtRegularMinutes.Text = 0
    End Sub

    ' #######################################################
    ' Used with clearing the form, this scans the entire form
    ' and zeroes out the form input data
    ' #######################################################
    Private Sub resetAllControls(ByVal container As Control)
        For Each ctrl As Control In container.Controls
            'If TypeOf ctrl Is RadioButton Then
            '    DirectCast(ctrl, RadioButton).Checked = False
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Text = FormatCurrency(0)
            ElseIf TypeOf ctrl Is CheckBox Then
                DirectCast(ctrl, CheckBox).Checked = False
            End If
            If ctrl.Controls.Count > 0 Then
                resetAllControls(ctrl)
            End If
        Next
    End Sub

    Private Sub ShowSalaryComaprison(sender As Object, e As EventArgs) Handles IndustrySalaryComparisonToolStripMenuItem.Click
        Salary_Comparison.Show()
    End Sub

    Private Sub ShowTaxationForm(sender As Object, e As EventArgs) Handles AdjustTaxationRatesToolStripMenuItem.Click
        frmRates.ShowDialog()
    End Sub

    Private Sub WageConversionTool_Click(sender As Object, e As EventArgs) Handles WageConversionToolToolStripMenuItem.Click
        frmHourlyToSalary.Show()
    End Sub
End Class
