<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fancy_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fancy_Form))
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblMedicare = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblSocialSecurity = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblIncomeTax = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDependants = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbFilingStatus = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbIncomeTax = New System.Windows.Forms.CheckBox()
        Me.cbMedicare = New System.Windows.Forms.CheckBox()
        Me.cbSocialSecurity = New System.Windows.Forms.CheckBox()
        Me.rbHourly = New System.Windows.Forms.RadioButton()
        Me.rbSalary = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRegularHours = New System.Windows.Forms.TextBox()
        Me.txtRegularMinutes = New System.Windows.Forms.TextBox()
        Me.txtRegularRate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOTRate = New System.Windows.Forms.TextBox()
        Me.txtOTMinutes = New System.Windows.Forms.TextBox()
        Me.txtOTHours = New System.Windows.Forms.TextBox()
        Me.gbHourly = New System.Windows.Forms.GroupBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.cbFrequency = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSalaryBonuses = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtInsurance = New System.Windows.Forms.TextBox()
        Me.txtWithholdings = New System.Windows.Forms.TextBox()
        Me.txtFlex = New System.Windows.Forms.TextBox()
        Me.txtFourOhOne = New System.Windows.Forms.TextBox()
        Me.txtGarnishment = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WageConversionToolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndustrySalaryComparisonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdjustTaxationRatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AutofillFormdebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutPayrollCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpcomingFeaturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IRSWithholdingCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhatIsItToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaunchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNetPay
        '
        Me.lblNetPay.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNetPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNetPay.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPay.Location = New System.Drawing.Point(541, 344)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(119, 22)
        Me.lblNetPay.TabIndex = 45
        Me.lblNetPay.Text = "$0.00"
        Me.lblNetPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(440, 346)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(95, 19)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Net Pay:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMedicare
        '
        Me.lblMedicare.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMedicare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMedicare.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedicare.Location = New System.Drawing.Point(541, 317)
        Me.lblMedicare.Name = "lblMedicare"
        Me.lblMedicare.Size = New System.Drawing.Size(119, 22)
        Me.lblMedicare.TabIndex = 43
        Me.lblMedicare.Text = "$0.00"
        Me.lblMedicare.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(440, 319)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(95, 19)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Medicare:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSocialSecurity
        '
        Me.lblSocialSecurity.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSocialSecurity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSocialSecurity.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSocialSecurity.Location = New System.Drawing.Point(541, 290)
        Me.lblSocialSecurity.Name = "lblSocialSecurity"
        Me.lblSocialSecurity.Size = New System.Drawing.Size(119, 22)
        Me.lblSocialSecurity.TabIndex = 41
        Me.lblSocialSecurity.Text = "$0.00"
        Me.lblSocialSecurity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(440, 292)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(95, 19)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Social Security:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIncomeTax
        '
        Me.lblIncomeTax.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblIncomeTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIncomeTax.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncomeTax.Location = New System.Drawing.Point(541, 263)
        Me.lblIncomeTax.Name = "lblIncomeTax"
        Me.lblIncomeTax.Size = New System.Drawing.Size(119, 22)
        Me.lblIncomeTax.TabIndex = 39
        Me.lblIncomeTax.Text = "$0.00"
        Me.lblIncomeTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(440, 265)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(95, 19)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Income Tax:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGrossPay
        '
        Me.lblGrossPay.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrossPay.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPay.Location = New System.Drawing.Point(541, 236)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(119, 22)
        Me.lblGrossPay.TabIndex = 37
        Me.lblGrossPay.Text = "$0.00"
        Me.lblGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(440, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(95, 19)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Gross Pay:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(580, 381)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 28)
        Me.btnExit.TabIndex = 50
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(499, 381)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 28)
        Me.btnClear.TabIndex = 49
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(418, 381)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(80, 28)
        Me.btnCalculate.TabIndex = 48
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDependants)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbFilingStatus)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 81)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Federal Witholding"
        '
        'txtDependants
        '
        Me.txtDependants.Location = New System.Drawing.Point(87, 49)
        Me.txtDependants.Name = "txtDependants"
        Me.txtDependants.Size = New System.Drawing.Size(107, 23)
        Me.txtDependants.TabIndex = 85
        Me.txtDependants.Text = "0"
        Me.txtDependants.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 15)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "Dependants:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 15)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Filing as:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbFilingStatus
        '
        Me.cbFilingStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFilingStatus.FormattingEnabled = True
        Me.cbFilingStatus.Items.AddRange(New Object() {"Single", "Married Filing Jointly", "Married Filing Single", "Head of Household"})
        Me.cbFilingStatus.Location = New System.Drawing.Point(87, 22)
        Me.cbFilingStatus.Name = "cbFilingStatus"
        Me.cbFilingStatus.Size = New System.Drawing.Size(107, 23)
        Me.cbFilingStatus.TabIndex = 85
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbIncomeTax)
        Me.GroupBox2.Controls.Add(Me.cbMedicare)
        Me.GroupBox2.Controls.Add(Me.cbSocialSecurity)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 273)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Exemptions"
        '
        'cbIncomeTax
        '
        Me.cbIncomeTax.AutoSize = True
        Me.cbIncomeTax.Location = New System.Drawing.Point(7, 22)
        Me.cbIncomeTax.Name = "cbIncomeTax"
        Me.cbIncomeTax.Size = New System.Drawing.Size(87, 19)
        Me.cbIncomeTax.TabIndex = 3
        Me.cbIncomeTax.Text = "Income Tax"
        Me.cbIncomeTax.UseVisualStyleBackColor = True
        '
        'cbMedicare
        '
        Me.cbMedicare.AutoSize = True
        Me.cbMedicare.Location = New System.Drawing.Point(7, 71)
        Me.cbMedicare.Name = "cbMedicare"
        Me.cbMedicare.Size = New System.Drawing.Size(75, 19)
        Me.cbMedicare.TabIndex = 1
        Me.cbMedicare.Text = "Medicare"
        Me.cbMedicare.UseVisualStyleBackColor = True
        '
        'cbSocialSecurity
        '
        Me.cbSocialSecurity.AutoSize = True
        Me.cbSocialSecurity.Location = New System.Drawing.Point(7, 46)
        Me.cbSocialSecurity.Name = "cbSocialSecurity"
        Me.cbSocialSecurity.Size = New System.Drawing.Size(102, 19)
        Me.cbSocialSecurity.TabIndex = 0
        Me.cbSocialSecurity.Text = "Social Security"
        Me.cbSocialSecurity.UseVisualStyleBackColor = True
        '
        'rbHourly
        '
        Me.rbHourly.AutoSize = True
        Me.rbHourly.Location = New System.Drawing.Point(17, 78)
        Me.rbHourly.Name = "rbHourly"
        Me.rbHourly.Size = New System.Drawing.Size(61, 19)
        Me.rbHourly.TabIndex = 53
        Me.rbHourly.TabStop = True
        Me.rbHourly.Text = "Hourly"
        Me.rbHourly.UseVisualStyleBackColor = True
        '
        'rbSalary
        '
        Me.rbSalary.AutoSize = True
        Me.rbSalary.Location = New System.Drawing.Point(17, 151)
        Me.rbSalary.Name = "rbSalary"
        Me.rbSalary.Size = New System.Drawing.Size(97, 19)
        Me.rbSalary.TabIndex = 54
        Me.rbSalary.TabStop = True
        Me.rbSalary.Text = "Annual Salary"
        Me.rbSalary.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Regular"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Overtime"
        '
        'txtRegularHours
        '
        Me.txtRegularHours.Location = New System.Drawing.Point(162, 71)
        Me.txtRegularHours.Name = "txtRegularHours"
        Me.txtRegularHours.Size = New System.Drawing.Size(53, 23)
        Me.txtRegularHours.TabIndex = 57
        Me.txtRegularHours.Text = "0"
        Me.txtRegularHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRegularMinutes
        '
        Me.txtRegularMinutes.Location = New System.Drawing.Point(221, 71)
        Me.txtRegularMinutes.MaxLength = 2
        Me.txtRegularMinutes.Name = "txtRegularMinutes"
        Me.txtRegularMinutes.Size = New System.Drawing.Size(53, 23)
        Me.txtRegularMinutes.TabIndex = 58
        Me.txtRegularMinutes.Text = "0"
        Me.txtRegularMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRegularRate
        '
        Me.txtRegularRate.Location = New System.Drawing.Point(280, 71)
        Me.txtRegularRate.Name = "txtRegularRate"
        Me.txtRegularRate.Size = New System.Drawing.Size(53, 23)
        Me.txtRegularRate.TabIndex = 59
        Me.txtRegularRate.Text = "$0.00"
        Me.txtRegularRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(169, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Hours"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(222, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Minutes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(291, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 15)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Rate"
        '
        'txtOTRate
        '
        Me.txtOTRate.Location = New System.Drawing.Point(280, 100)
        Me.txtOTRate.Name = "txtOTRate"
        Me.txtOTRate.Size = New System.Drawing.Size(53, 23)
        Me.txtOTRate.TabIndex = 65
        Me.txtOTRate.Text = "$0.00"
        Me.txtOTRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOTMinutes
        '
        Me.txtOTMinutes.Location = New System.Drawing.Point(221, 100)
        Me.txtOTMinutes.MaxLength = 2
        Me.txtOTMinutes.Name = "txtOTMinutes"
        Me.txtOTMinutes.Size = New System.Drawing.Size(53, 23)
        Me.txtOTMinutes.TabIndex = 64
        Me.txtOTMinutes.Text = "0"
        Me.txtOTMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOTHours
        '
        Me.txtOTHours.Location = New System.Drawing.Point(162, 100)
        Me.txtOTHours.Name = "txtOTHours"
        Me.txtOTHours.Size = New System.Drawing.Size(53, 23)
        Me.txtOTHours.TabIndex = 63
        Me.txtOTHours.Text = "0"
        Me.txtOTHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbHourly
        '
        Me.gbHourly.Location = New System.Drawing.Point(99, 40)
        Me.gbHourly.Name = "gbHourly"
        Me.gbHourly.Size = New System.Drawing.Size(245, 94)
        Me.gbHourly.TabIndex = 66
        Me.gbHourly.TabStop = False
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(102, 120)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(118, 23)
        Me.txtSalary.TabIndex = 67
        Me.txtSalary.Text = "$0.00"
        Me.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbFrequency
        '
        Me.cbFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFrequency.FormattingEnabled = True
        Me.cbFrequency.Items.AddRange(New Object() {"Weekly", "Bi-Weekly", "Monthly", "Quartly", "Yearly"})
        Me.cbFrequency.Location = New System.Drawing.Point(541, 206)
        Me.cbFrequency.Name = "cbFrequency"
        Me.cbFrequency.Size = New System.Drawing.Size(121, 23)
        Me.cbFrequency.TabIndex = 68
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtSalaryBonuses)
        Me.GroupBox4.Controls.Add(Me.txtSalary)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(340, 150)
        Me.GroupBox4.TabIndex = 69
        Me.GroupBox4.TabStop = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(225, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Total Bonuses"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSalaryBonuses
        '
        Me.txtSalaryBonuses.Location = New System.Drawing.Point(225, 120)
        Me.txtSalaryBonuses.Name = "txtSalaryBonuses"
        Me.txtSalaryBonuses.Size = New System.Drawing.Size(100, 23)
        Me.txtSalaryBonuses.TabIndex = 68
        Me.txtSalaryBonuses.Text = "$0.00"
        Me.txtSalaryBonuses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(228, 341)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 15)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Insurance:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(228, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 15)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Withholdings:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(228, 275)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 15)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Flex Account:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(228, 242)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 15)
        Me.Label16.TabIndex = 72
        Me.Label16.Text = "401(k): (%)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(228, 209)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 15)
        Me.Label20.TabIndex = 70
        Me.Label20.Text = "Garnishment:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtInsurance)
        Me.GroupBox5.Controls.Add(Me.txtWithholdings)
        Me.GroupBox5.Controls.Add(Me.txtFlex)
        Me.GroupBox5.Controls.Add(Me.txtFourOhOne)
        Me.GroupBox5.Controls.Add(Me.txtGarnishment)
        Me.GroupBox5.Location = New System.Drawing.Point(219, 187)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(212, 186)
        Me.GroupBox5.TabIndex = 80
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Pre-tax Deductions"
        '
        'txtInsurance
        '
        Me.txtInsurance.Location = New System.Drawing.Point(98, 151)
        Me.txtInsurance.Name = "txtInsurance"
        Me.txtInsurance.Size = New System.Drawing.Size(102, 23)
        Me.txtInsurance.TabIndex = 86
        Me.txtInsurance.Text = "$0.00"
        Me.txtInsurance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWithholdings
        '
        Me.txtWithholdings.Location = New System.Drawing.Point(98, 119)
        Me.txtWithholdings.Name = "txtWithholdings"
        Me.txtWithholdings.Size = New System.Drawing.Size(102, 23)
        Me.txtWithholdings.TabIndex = 85
        Me.txtWithholdings.Text = "$0.00"
        Me.txtWithholdings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFlex
        '
        Me.txtFlex.Location = New System.Drawing.Point(98, 85)
        Me.txtFlex.Name = "txtFlex"
        Me.txtFlex.Size = New System.Drawing.Size(102, 23)
        Me.txtFlex.TabIndex = 84
        Me.txtFlex.Text = "$0.00"
        Me.txtFlex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFourOhOne
        '
        Me.txtFourOhOne.Location = New System.Drawing.Point(98, 52)
        Me.txtFourOhOne.Name = "txtFourOhOne"
        Me.txtFourOhOne.Size = New System.Drawing.Size(102, 23)
        Me.txtFourOhOne.TabIndex = 83
        Me.txtFourOhOne.Text = "0%"
        Me.txtFourOhOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGarnishment
        '
        Me.txtGarnishment.Location = New System.Drawing.Point(98, 19)
        Me.txtGarnishment.Name = "txtGarnishment"
        Me.txtGarnishment.Size = New System.Drawing.Size(102, 23)
        Me.txtGarnishment.TabIndex = 82
        Me.txtGarnishment.Text = "$0.00"
        Me.txtGarnishment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(669, 24)
        Me.MenuStrip1.TabIndex = 81
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdjustTaxationRatesToolStripMenuItem, Me.WageConversionToolToolStripMenuItem, Me.IndustrySalaryComparisonToolStripMenuItem, Me.ToolStripSeparator3, Me.AutofillFormdebugToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'WageConversionToolToolStripMenuItem
        '
        Me.WageConversionToolToolStripMenuItem.Name = "WageConversionToolToolStripMenuItem"
        Me.WageConversionToolToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.WageConversionToolToolStripMenuItem.Text = "Wage Conversion Tool"
        '
        'IndustrySalaryComparisonToolStripMenuItem
        '
        Me.IndustrySalaryComparisonToolStripMenuItem.Name = "IndustrySalaryComparisonToolStripMenuItem"
        Me.IndustrySalaryComparisonToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.IndustrySalaryComparisonToolStripMenuItem.Text = "Industry Salary Comparison"
        '
        'AdjustTaxationRatesToolStripMenuItem
        '
        Me.AdjustTaxationRatesToolStripMenuItem.Name = "AdjustTaxationRatesToolStripMenuItem"
        Me.AdjustTaxationRatesToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.AdjustTaxationRatesToolStripMenuItem.Text = "Adjust &Taxation Rates"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(216, 6)
        '
        'AutofillFormdebugToolStripMenuItem
        '
        Me.AutofillFormdebugToolStripMenuItem.Name = "AutofillFormdebugToolStripMenuItem"
        Me.AutofillFormdebugToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.AutofillFormdebugToolStripMenuItem.Text = "Autofill form (debug)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutPayrollCalculatorToolStripMenuItem, Me.ToolStripSeparator1, Me.UpcomingFeaturesToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(52, 20)
        Me.ToolStripMenuItem1.Text = "About"
        '
        'AboutPayrollCalculatorToolStripMenuItem
        '
        Me.AboutPayrollCalculatorToolStripMenuItem.Name = "AboutPayrollCalculatorToolStripMenuItem"
        Me.AboutPayrollCalculatorToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.AboutPayrollCalculatorToolStripMenuItem.Text = "About Payroll Calculator"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(200, 6)
        Me.ToolStripSeparator1.Visible = False
        '
        'UpcomingFeaturesToolStripMenuItem
        '
        Me.UpcomingFeaturesToolStripMenuItem.Name = "UpcomingFeaturesToolStripMenuItem"
        Me.UpcomingFeaturesToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.UpcomingFeaturesToolStripMenuItem.Text = "Upcoming Features"
        Me.UpcomingFeaturesToolStripMenuItem.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(440, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(95, 19)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Pay Frequency:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.Payroll_Calculator.My.Resources.Resources._11
        Me.PictureBox1.Location = New System.Drawing.Point(358, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(302, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'ToolTip
        '
        Me.ToolTip.AutoPopDelay = 50000
        Me.ToolTip.InitialDelay = 50
        Me.ToolTip.ReshowDelay = 100
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IRSWithholdingCalculatorToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        Me.HelpToolStripMenuItem.Visible = False
        '
        'IRSWithholdingCalculatorToolStripMenuItem
        '
        Me.IRSWithholdingCalculatorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WhatIsItToolStripMenuItem, Me.LaunchToolStripMenuItem})
        Me.IRSWithholdingCalculatorToolStripMenuItem.Name = "IRSWithholdingCalculatorToolStripMenuItem"
        Me.IRSWithholdingCalculatorToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.IRSWithholdingCalculatorToolStripMenuItem.Text = "IRS Withholding Calculator"
        '
        'WhatIsItToolStripMenuItem
        '
        Me.WhatIsItToolStripMenuItem.Name = "WhatIsItToolStripMenuItem"
        Me.WhatIsItToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.WhatIsItToolStripMenuItem.Text = "What is it?"
        '
        'LaunchToolStripMenuItem
        '
        Me.LaunchToolStripMenuItem.Name = "LaunchToolStripMenuItem"
        Me.LaunchToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LaunchToolStripMenuItem.Text = "Launch"
        '
        'Fancy_Form
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(669, 416)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cbFrequency)
        Me.Controls.Add(Me.txtOTRate)
        Me.Controls.Add(Me.txtOTMinutes)
        Me.Controls.Add(Me.txtOTHours)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRegularRate)
        Me.Controls.Add(Me.txtRegularMinutes)
        Me.Controls.Add(Me.txtRegularHours)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbSalary)
        Me.Controls.Add(Me.rbHourly)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblMedicare)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblSocialSecurity)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblIncomeTax)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.gbHourly)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Fancy_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNetPay As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblMedicare As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblSocialSecurity As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblIncomeTax As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblGrossPay As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbMedicare As System.Windows.Forms.CheckBox
    Friend WithEvents cbSocialSecurity As System.Windows.Forms.CheckBox
    Friend WithEvents rbHourly As System.Windows.Forms.RadioButton
    Friend WithEvents rbSalary As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRegularHours As System.Windows.Forms.TextBox
    Friend WithEvents txtRegularMinutes As System.Windows.Forms.TextBox
    Friend WithEvents txtRegularRate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOTRate As System.Windows.Forms.TextBox
    Friend WithEvents txtOTMinutes As System.Windows.Forms.TextBox
    Friend WithEvents txtOTHours As System.Windows.Forms.TextBox
    Friend WithEvents gbHourly As System.Windows.Forms.GroupBox
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents cbFrequency As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutPayrollCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtInsurance As System.Windows.Forms.TextBox
    Friend WithEvents txtWithholdings As System.Windows.Forms.TextBox
    Friend WithEvents txtFlex As System.Windows.Forms.TextBox
    Friend WithEvents txtFourOhOne As System.Windows.Forms.TextBox
    Friend WithEvents txtGarnishment As System.Windows.Forms.TextBox
    Friend WithEvents cbIncomeTax As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSalaryBonuses As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbFilingStatus As System.Windows.Forms.ComboBox
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpcomingFeaturesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtDependants As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents AutofillFormdebugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndustrySalaryComparisonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdjustTaxationRatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents WageConversionToolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IRSWithholdingCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WhatIsItToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaunchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
