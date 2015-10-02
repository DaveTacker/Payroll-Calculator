<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblWeeklyHours = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.lblIncomeTax = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblSocialSecurity = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblMedicare = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbState = New System.Windows.Forms.ComboBox()
        Me.cbRate = New System.Windows.Forms.ComboBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.gbResults = New System.Windows.Forms.GroupBox()
        Me.gbPersonalInformation = New System.Windows.Forms.GroupBox()
        Me.llJobsAndRates = New System.Windows.Forms.LinkLabel()
        Me.mtxtEmpoyeeID = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddJobCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuJobsAndRates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEmployeeList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.tsbCalculate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbClear = New System.Windows.Forms.ToolStripButton()
        Me.tsbDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRandomForm = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbResults.SuspendLayout()
        Me.gbPersonalInformation.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLastName
        '
        Me.txtLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(86, 50)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(235, 23)
        Me.txtLastName.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.txtLastName, "Please enter your last name in the text box provided.")
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(86, 79)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(235, 23)
        Me.txtFirstName.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.txtFirstName, """Please enter your first name in the text box provided.")
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(86, 108)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(235, 23)
        Me.txtAddress.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.txtAddress, "Please enter your address in the text box provided.")
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(86, 137)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(235, 23)
        Me.txtCity.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.txtCity, "Please enter your city address in the text box provided.")
        '
        'txtZip
        '
        Me.txtZip.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZip.Location = New System.Drawing.Point(212, 166)
        Me.txtZip.MaxLength = 5
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(53, 23)
        Me.txtZip.TabIndex = 5
        Me.ToolTip.SetToolTip(Me.txtZip, "Please enter your zipcode in the text box provided.")
        '
        'txtHours
        '
        Me.txtHours.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHours.Location = New System.Drawing.Point(98, 16)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(106, 23)
        Me.txtHours.TabIndex = 0
        Me.txtHours.Text = "0"
        Me.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip.SetToolTip(Me.txtHours, "Please enter your hours in the text box provided.")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "&Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "&First Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "&Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "&City:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(44, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "&State:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(179, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "&Zip:"
        '
        'lblWeeklyHours
        '
        Me.lblWeeklyHours.AutoSize = True
        Me.lblWeeklyHours.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeeklyHours.Location = New System.Drawing.Point(8, 19)
        Me.lblWeeklyHours.Name = "lblWeeklyHours"
        Me.lblWeeklyHours.Size = New System.Drawing.Size(84, 15)
        Me.lblWeeklyHours.TabIndex = 15
        Me.lblWeeklyHours.Text = "&Hours worked:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Gross Pay:"
        '
        'lblGrossPay
        '
        Me.lblGrossPay.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrossPay.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPay.Location = New System.Drawing.Point(98, 45)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(106, 23)
        Me.lblGrossPay.TabIndex = 18
        Me.lblGrossPay.Text = "$0.00"
        Me.lblGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip.SetToolTip(Me.lblGrossPay, "Your total income before any taxes are removed.")
        '
        'lblIncomeTax
        '
        Me.lblIncomeTax.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblIncomeTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIncomeTax.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncomeTax.Location = New System.Drawing.Point(98, 74)
        Me.lblIncomeTax.Name = "lblIncomeTax"
        Me.lblIncomeTax.Size = New System.Drawing.Size(106, 23)
        Me.lblIncomeTax.TabIndex = 20
        Me.lblIncomeTax.Text = "$0.00"
        Me.lblIncomeTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip.SetToolTip(Me.lblIncomeTax, "Your states income tax (18%).")
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 15)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Income Tax:"
        '
        'lblSocialSecurity
        '
        Me.lblSocialSecurity.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSocialSecurity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSocialSecurity.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSocialSecurity.Location = New System.Drawing.Point(98, 103)
        Me.lblSocialSecurity.Name = "lblSocialSecurity"
        Me.lblSocialSecurity.Size = New System.Drawing.Size(106, 23)
        Me.lblSocialSecurity.TabIndex = 22
        Me.lblSocialSecurity.Text = "$0.00"
        Me.lblSocialSecurity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip.SetToolTip(Me.lblSocialSecurity, "Your states social security witholding (6.2%).")
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 107)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 15)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Social Security:"
        '
        'lblMedicare
        '
        Me.lblMedicare.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMedicare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMedicare.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedicare.Location = New System.Drawing.Point(98, 132)
        Me.lblMedicare.Name = "lblMedicare"
        Me.lblMedicare.Size = New System.Drawing.Size(106, 23)
        Me.lblMedicare.TabIndex = 24
        Me.lblMedicare.Text = "$0.00"
        Me.lblMedicare.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip.SetToolTip(Me.lblMedicare, "Your states medicare witholding (1.45%).")
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(33, 136)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 15)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Medicare:"
        '
        'lblNetPay
        '
        Me.lblNetPay.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNetPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNetPay.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPay.Location = New System.Drawing.Point(98, 161)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(106, 23)
        Me.lblNetPay.TabIndex = 26
        Me.lblNetPay.Text = "$0.00"
        Me.lblNetPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip.SetToolTip(Me.lblNetPay, "What you take home after all deductions.")
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(41, 165)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 15)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Net Pay:"
        '
        'cbState
        '
        Me.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbState.FormattingEnabled = True
        Me.cbState.Items.AddRange(New Object() {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.cbState.Location = New System.Drawing.Point(86, 166)
        Me.cbState.Name = "cbState"
        Me.cbState.Size = New System.Drawing.Size(87, 23)
        Me.cbState.TabIndex = 4
        Me.ToolTip.SetToolTip(Me.cbState, "Please choose your state in the list provided.")
        '
        'cbRate
        '
        Me.cbRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRate.FormattingEnabled = True
        Me.cbRate.Location = New System.Drawing.Point(203, 19)
        Me.cbRate.Name = "cbRate"
        Me.cbRate.Size = New System.Drawing.Size(62, 23)
        Me.cbRate.Sorted = True
        Me.cbRate.TabIndex = 8
        Me.ToolTip.SetToolTip(Me.cbRate, "Please choose your rate in the list provided.")
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(387, -3)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblDate.Size = New System.Drawing.Size(188, 27)
        Me.lblDate.TabIndex = 33
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbResults
        '
        Me.gbResults.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbResults.Controls.Add(Me.lblWeeklyHours)
        Me.gbResults.Controls.Add(Me.Label10)
        Me.gbResults.Controls.Add(Me.txtHours)
        Me.gbResults.Controls.Add(Me.lblGrossPay)
        Me.gbResults.Controls.Add(Me.lblSocialSecurity)
        Me.gbResults.Controls.Add(Me.Label13)
        Me.gbResults.Controls.Add(Me.lblIncomeTax)
        Me.gbResults.Controls.Add(Me.Label15)
        Me.gbResults.Controls.Add(Me.Label17)
        Me.gbResults.Controls.Add(Me.lblNetPay)
        Me.gbResults.Controls.Add(Me.Label19)
        Me.gbResults.Controls.Add(Me.lblMedicare)
        Me.gbResults.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbResults.Location = New System.Drawing.Point(355, 52)
        Me.gbResults.Name = "gbResults"
        Me.gbResults.Size = New System.Drawing.Size(217, 201)
        Me.gbResults.TabIndex = 35
        Me.gbResults.TabStop = False
        Me.gbResults.Text = "Results"
        '
        'gbPersonalInformation
        '
        Me.gbPersonalInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbPersonalInformation.Controls.Add(Me.cbRate)
        Me.gbPersonalInformation.Controls.Add(Me.llJobsAndRates)
        Me.gbPersonalInformation.Controls.Add(Me.mtxtEmpoyeeID)
        Me.gbPersonalInformation.Controls.Add(Me.Label8)
        Me.gbPersonalInformation.Controls.Add(Me.txtLastName)
        Me.gbPersonalInformation.Controls.Add(Me.cbState)
        Me.gbPersonalInformation.Controls.Add(Me.txtFirstName)
        Me.gbPersonalInformation.Controls.Add(Me.Label7)
        Me.gbPersonalInformation.Controls.Add(Me.txtAddress)
        Me.gbPersonalInformation.Controls.Add(Me.Label6)
        Me.gbPersonalInformation.Controls.Add(Me.txtCity)
        Me.gbPersonalInformation.Controls.Add(Me.Label5)
        Me.gbPersonalInformation.Controls.Add(Me.txtZip)
        Me.gbPersonalInformation.Controls.Add(Me.Label4)
        Me.gbPersonalInformation.Controls.Add(Me.Label2)
        Me.gbPersonalInformation.Controls.Add(Me.Label3)
        Me.gbPersonalInformation.Location = New System.Drawing.Point(12, 52)
        Me.gbPersonalInformation.Name = "gbPersonalInformation"
        Me.gbPersonalInformation.Size = New System.Drawing.Size(337, 201)
        Me.gbPersonalInformation.TabIndex = 37
        Me.gbPersonalInformation.TabStop = False
        Me.gbPersonalInformation.Text = "Personal Information"
        '
        'llJobsAndRates
        '
        Me.llJobsAndRates.AutoSize = True
        Me.llJobsAndRates.Location = New System.Drawing.Point(164, 24)
        Me.llJobsAndRates.Name = "llJobsAndRates"
        Me.llJobsAndRates.Size = New System.Drawing.Size(33, 15)
        Me.llJobsAndRates.TabIndex = 17
        Me.llJobsAndRates.TabStop = True
        Me.llJobsAndRates.Text = "Rate:"
        '
        'mtxtEmpoyeeID
        '
        Me.mtxtEmpoyeeID.Location = New System.Drawing.Point(86, 19)
        Me.mtxtEmpoyeeID.Mask = "000-00-0000"
        Me.mtxtEmpoyeeID.Name = "mtxtEmpoyeeID"
        Me.mtxtEmpoyeeID.ResetOnSpace = False
        Me.mtxtEmpoyeeID.Size = New System.Drawing.Size(72, 23)
        Me.mtxtEmpoyeeID.TabIndex = 6
        Me.ToolTip.SetToolTip(Me.mtxtEmpoyeeID, "A unique identifier for each employee.")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(59, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 15)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "ID:"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuView, Me.mnuHelp})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(577, 24)
        Me.MenuStrip.TabIndex = 38
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.ToolStripSeparator5, Me.AddJobCodeToolStripMenuItem, Me.ToolStripSeparator6, Me.SaveToolStripMenuItem, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.CalculateToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CalculateToolStripMenuItem.Text = "Calculate"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(170, 6)
        '
        'AddJobCodeToolStripMenuItem
        '
        Me.AddJobCodeToolStripMenuItem.Name = "AddJobCodeToolStripMenuItem"
        Me.AddJobCodeToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AddJobCodeToolStripMenuItem.Text = "Add Job Code"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(170, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.SaveToolStripMenuItem.Text = "Save to File"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeyDisplayString = ""
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(173, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.ToolStripSeparator2, Me.mnuJobsAndRates, Me.mnuEmployeeList})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(44, 20)
        Me.mnuView.Text = "&View"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(147, 22)
        Me.mnuClear.Text = "C&lear"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(144, 6)
        '
        'mnuJobsAndRates
        '
        Me.mnuJobsAndRates.Name = "mnuJobsAndRates"
        Me.mnuJobsAndRates.Size = New System.Drawing.Size(147, 22)
        Me.mnuJobsAndRates.Text = "Job Codes"
        '
        'mnuEmployeeList
        '
        Me.mnuEmployeeList.Name = "mnuEmployeeList"
        Me.mnuEmployeeList.Size = New System.Drawing.Size(147, 22)
        Me.mnuEmployeeList.Text = "Employee List"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuAbout.Size = New System.Drawing.Size(126, 22)
        Me.mnuAbout.Text = "About"
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCalculate, Me.ToolStripSeparator1, Me.tsbClear, Me.tsbDelete, Me.ToolStripSeparator4, Me.tsbExit, Me.ToolStripSeparator3, Me.tsbRandomForm})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(577, 25)
        Me.ToolStrip.TabIndex = 40
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'tsbCalculate
        '
        Me.tsbCalculate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbCalculate.Image = CType(resources.GetObject("tsbCalculate.Image"), System.Drawing.Image)
        Me.tsbCalculate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCalculate.Name = "tsbCalculate"
        Me.tsbCalculate.Size = New System.Drawing.Size(60, 22)
        Me.tsbCalculate.Text = "Calculate"
        Me.tsbCalculate.ToolTipText = "Check all fields and perform calculations"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbClear
        '
        Me.tsbClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbClear.Image = CType(resources.GetObject("tsbClear.Image"), System.Drawing.Image)
        Me.tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbClear.Name = "tsbClear"
        Me.tsbClear.Size = New System.Drawing.Size(38, 22)
        Me.tsbClear.Text = "Clear"
        Me.tsbClear.ToolTipText = "Clears all form data"
        '
        'tsbDelete
        '
        Me.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbDelete.Image = CType(resources.GetObject("tsbDelete.Image"), System.Drawing.Image)
        Me.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDelete.Name = "tsbDelete"
        Me.tsbDelete.Size = New System.Drawing.Size(44, 22)
        Me.tsbDelete.Text = "Delete"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tsbExit
        '
        Me.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbExit.Image = CType(resources.GetObject("tsbExit.Image"), System.Drawing.Image)
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Size = New System.Drawing.Size(29, 22)
        Me.tsbExit.Text = "Exit"
        Me.tsbExit.ToolTipText = "Exit the application"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tsbRandomForm
        '
        Me.tsbRandomForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbRandomForm.Image = CType(resources.GetObject("tsbRandomForm.Image"), System.Drawing.Image)
        Me.tsbRandomForm.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRandomForm.Name = "tsbRandomForm"
        Me.tsbRandomForm.Size = New System.Drawing.Size(81, 22)
        Me.tsbRandomForm.Text = "Autofill Form"
        Me.tsbRandomForm.ToolTipText = "This is for testing purposes."
        '
        'ToolTip
        '
        Me.ToolTip.AutomaticDelay = 50
        Me.ToolTip.AutoPopDelay = 50000
        Me.ToolTip.InitialDelay = 50
        Me.ToolTip.ReshowDelay = 10
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 260)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.gbResults)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.gbPersonalInformation)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weekly Payroll"
        Me.gbResults.ResumeLayout(False)
        Me.gbResults.PerformLayout()
        Me.gbPersonalInformation.ResumeLayout(False)
        Me.gbPersonalInformation.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblWeeklyHours As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblGrossPay As System.Windows.Forms.Label
    Friend WithEvents lblIncomeTax As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblSocialSecurity As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblMedicare As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblNetPay As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cbState As System.Windows.Forms.ComboBox
    Friend WithEvents cbRate As System.Windows.Forms.ComboBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents gbResults As System.Windows.Forms.GroupBox
    Friend WithEvents gbPersonalInformation As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbCalculate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuJobsAndRates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents llJobsAndRates As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbRandomForm As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuEmployeeList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents CalculateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mtxtEmpoyeeID As System.Windows.Forms.MaskedTextBox
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddJobCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator

End Class
