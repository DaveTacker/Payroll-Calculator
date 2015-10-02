' Written by Dave Tacker, Jedi knight and truthseeker.
' July 06 2014
' A simple application to calculate pay.
' I'm not entirely sure why we're using the last name as the UNIQUE identifier for each Employee, but it should be fairly straitforward to update at a later date.

Option Explicit On
Option Strict On
Imports System.Xml
Imports System.IO

Public Class frmMain
    ' ######################################################
    ' The Sub where all the magic happens:
    ' Check all textboxes and dropdowns, perform calculations, 
    ' add Employee to Structured array if they don't already exist.
    ' ######################################################
    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles tsbCalculate.Click, CalculateToolStripMenuItem.Click

        If DoubleCheckForm() = True Then
            Exit Sub
        End If

        ' Did the user enter Hours?
        If txtHours.Text = "" Or txtHours.Text = vbNullString Then
            MsgBox("Please enter the hours worked.", MsgBoxStyle.Exclamation)
            txtHours.Focus()
            Exit Sub
        End If

        ' Well, all the text boxes and dropdowns are correctly filled in, let's try to calculate!

        Try
            ' And calculate gross pay. Hours * Rate
            Dim decGrossPay As Decimal = CDec(txtHours.Text) * CDec(GetPayRate(cbRate.SelectedItem.ToString))

            lblGrossPay.Text = FormatCurrency(decGrossPay) ' Hours * Rate
            lblIncomeTax.Text = FormatCurrency(decGrossPay * INCOME_TAX)
            lblMedicare.Text = FormatCurrency(decGrossPay * MEDICARE)
            lblSocialSecurity.Text = FormatCurrency(decGrossPay * SOCIAL_SECURITY)
            lblNetPay.Text = FormatCurrency(decGrossPay - CDec(lblIncomeTax.Text) - CDec(lblMedicare.Text) - CDec(lblSocialSecurity.Text))

            ' Attempting to save the Employee... Does the collection already have entries?
            If EmployeeCollection.Count > 1 Then
                ' If so, ...
                ' Check if the ID exists, if not, prompt the user to Save
                For Each person As Employee In EmployeeCollection
                    If CBool(person._ID = mtxtEmpoyeeID.Text) Then

                        ' Check each field, is there a change?
                        If CBool(String.Compare(person._lastName, txtLastName.Text) Or _
                            String.Compare(person._firstName, txtFirstName.Text) Or _
                            String.Compare(person._Address, txtAddress.Text) Or _
                            String.Compare(person._City, txtCity.Text) Or _
                            String.Compare(CStr(person._ZipCode), txtZip.Text) Or _
                            String.Compare(person._JobCode, cbRate.Text) Or _
                            String.Compare(person._State, cbState.Text)) Then

                            ' Yep, something has changed! Prompt the user to save the record
                            If MsgBox(CStr(person._firstName) + " " + CStr(person._lastName) + " has updated information, would you like to save?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                ' Remove the old entry
                                EmployeeCollection.Remove(mtxtEmpoyeeID.Text)

                                ' Add the information entered into the form to the Structure Array
                                UpdateCollection()
                            End If
                            Exit Sub ' exit the sub
                        End If
                    End If
                Next person
            Else
                ' If the collection does not have any entries, add it.
                UpdateCollection()
            End If

            If MsgBox("Would you like to save this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                ' Add the information entered into the form to the Structure Array
                UpdateCollection()
            End If

        Catch ex As Exception
            ' Damn... It broke!.
            MsgBox(ex.Message + vbNewLine + "Line: " + ex.ToString.Split(CChar(" ")).Last, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' ######################################################
    ' Monitor the keypresses within the ZIPCODE textbox.
    ' Make sure it's numbers only.
    ' ######################################################
    Private Sub NumericOnly_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtZip.KeyPress, txtHours.KeyPress
        ' Is the keypress a NUMBER in the ASCII index?
        ' http://www.theasciicode.com.ar/ascii-control-characters/backspace-ascii-code-8.html
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        ' Is the keypress a BACKSPACE?
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    ' ######################################################
    ' Show the Jobs and Rates window.
    ' ######################################################
    Private Sub btnJobsAndRates_Click(sender As Object, e As EventArgs) Handles mnuJobsAndRates.Click, llJobsAndRates.Click
        Jobs_and_Rates.Show()
    End Sub

    ' ######################################################
    ' Show the About window
    ' ######################################################
    Private Sub mnuAbout_Click(sender As System.Object, e As System.EventArgs) Handles mnuAbout.Click
        frmAbout.ShowDialog()
    End Sub

    ' ######################################################
    ' Clear all the form data.
    ' ######################################################
    Private Sub ClearForm() Handles mnuClear.Click, tsbClear.Click
        For Each ctrl As Control In gbPersonalInformation.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Text = ""
            ElseIf TypeOf ctrl Is MaskedTextBox Then
                DirectCast(ctrl, MaskedTextBox).Clear()
            ElseIf TypeOf ctrl Is ComboBox Then
                If ctrl Is mtxtEmpoyeeID Then
                    DirectCast(ctrl, ComboBox).Text = ""
                Else
                    DirectCast(ctrl, ComboBox).SelectedIndex = 0
                End If
            End If
        Next ctrl

        For Each ctrl As Control In gbResults.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Text = ""
            End If
        Next ctrl
        lblGrossPay.Text = "$0.00"
        lblIncomeTax.Text = "$0.00"
        lblMedicare.Text = "$0.00"
        lblNetPay.Text = "$0.00"
        lblSocialSecurity.Text = "$0.00"
        mtxtEmpoyeeID.Enabled = True
    End Sub

    ' ######################################################
    ' A close button with confirmation
    ' ######################################################
    Private Sub frmMain_Exit(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        For Each person As Employee In EmployeeCollection
            ' Found a match
            If CBool(person._ID = mtxtEmpoyeeID.Text) Then
                ' Compare fields, if the fields do not match, flag as a change
                If CBool(String.Compare(person._lastName, txtLastName.Text) Or _
                    String.Compare(person._firstName, txtFirstName.Text) Or _
                    String.Compare(person._Address, txtAddress.Text) Or _
                    String.Compare(person._City, txtCity.Text) Or _
                    String.Compare(CStr(person._ZipCode), txtZip.Text) Or _
                    String.Compare(person._JobCode, cbRate.Text) Or _
                    String.Compare(person._State, cbState.Text)) Then
                    If MsgBox("Personal information has been changed and is not currently saved, would you like to save before closing?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
                        Try
                            UpdateCollection()
                            'MsgBox("Record Saved successfully!", MsgBoxStyle.OkOnly)
                        Catch ex As ArgumentException
                            ' This error is thrown when the collection key (the ID) already exists. *i think*
                            ' So, Remove the old entry
                            EmployeeCollection.Remove(mtxtEmpoyeeID.Text)

                            ' Update the collection
                            UpdateCollection()

                        Catch ex As Exception
                            MsgBox(ex.Message + vbNewLine + "Line: " + ex.ToString.Split(CChar(" ")).Last, MsgBoxStyle.Critical)
                        End Try
                    End If
                End If
            End If
        Next person

        ' The person has been updated, exit?
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
            e.Cancel = True
        End If
    End Sub

    ' ######################################################
    ' Select all the text if the user clicks a textbox
    ' ######################################################
    'Private Sub Textbox_Focus(sender As System.Object, e As System.EventArgs) Handles txtZip.Enter, txtLastName.Enter, txtHours.Enter, txtFirstName.Enter, txtCity.Enter, txtAddress.Enter, txtZip.Click, txtLastName.Click, txtHours.Click, txtFirstName.Click, txtCity.Click, txtAddress.Click
    '    DirectCast(sender, TextBox).SelectAll()
    'End Sub


    ' ######################################################
    ' Automagically assign the dropdown defaults, & date when the form opens.
    ' ######################################################
    Private Sub frmMain_OnShow(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDate.Text = CStr(Date.Today.ToLongDateString) ' Set the date

        PropigateJobRateCombobox()

        Try
            ' Create an XML document in the memoryspace to parse through
            Dim xmlDocument As New XmlDocument()

            ' Load the XML file into memoryspace
            xmlDocument.Load("Employees.xml")

            ' Generate a list of nodes
            Dim nodeList As XmlNodeList
            nodeList = xmlDocument.SelectNodes("Employees/Employee")

            ' For each node in the list
            Dim node As XmlNode

            For Each node In nodeList
                EmployeeCollection.Add(New Employee(node.ChildNodes.Item(0).InnerText, _
                                                  node.ChildNodes.Item(1).InnerText, _
                                                  node.ChildNodes.Item(2).InnerText, _
                                                  node.ChildNodes.Item(3).InnerText, _
                                                  node.ChildNodes.Item(4).InnerText, _
                                                  node.ChildNodes.Item(5).InnerText, _
                                                  CInt(node.ChildNodes.Item(6).InnerText), _
                                                  node.ChildNodes.Item(7).InnerText), node.ChildNodes.Item(0).InnerText)

                ' Add the last name to the auto-complete feature of txtLastName
                txtLastName.AutoCompleteCustomSource.Add(node.ChildNodes.Item(2).InnerText)

            Next

            txtLastName.Focus()

        Catch ex As FileNotFoundException
            MsgBox("Employees.xml was not found, a new file will be created for you.", MsgBoxStyle.Information)
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message + vbNewLine + "Line: " + ex.ToString.Split(CChar(" ")).Last, MsgBoxStyle.Critical)
        End Try

    End Sub

    ' ######################################################
    ' Auto-fill the form, this is for debugging purposes
    ' ######################################################
    Private Sub RandomForm_Click(sender As Object, e As EventArgs) Handles tsbRandomForm.Click
        ' A simple collection of strings for random data propigation
        Dim firstName() As String = {"Michaele", "Bethanie", "Merry", "Nora", "Elyse", "Dominick", "Karmen", "Denisse", "Seth", "Hildegard", "Matilda", "Estelle", "Herbert", "Caryl", "Rashida", "Ellsworth", "Aleta", "Shawanda", "Thomasina", "Marcell", "Dovie", "Roger", "Victorina", "Veta", "Karan", "Shandra", "Ross", "Shea", "Leslee", "Ileana", "Florentina", "Johna", "Marg", "Numbers", "Nancey", "Hazel", "Todd", "Aline", "Tabatha", "Oma", "Keisha", "Marylou", "Boris", "Emilie", "Lawanna", "Amalia", "Rita", "Jeramy", "Tennie", "Melony"}
        Dim lastName() As String = {"Parrish", "Raine", "Buckman", "Rath", "Trigg", "Depaolo", "Ureno", "Schnur", "Pattison", "Mayoral", "Deitz", "Lenderman", "Lamberti", "Biro", "Pech", "Folden", "Ali", "Copland", "Pigg", "Abshire", "Avera", "Harkleroad", "Gumbs", "Arizmendi", "Rusnak", "Brose", "Passman", "Reno", "Flemons", "Schwabe", "Andrew", "Fahey", "Brin", "Sanluis", "Drew", "Farnum", "Wafford", "Layne", "Crowder", "Oliveira", "Hardage", "Eubank", "Norden", "Irion", "Etienne", "Byard", "Vivian", "Halliburton", "Orman", "Burrill"}
        Dim City() As String = {"cebï¿¥", "unwatered", "abia", "kalahari", "sï¿¥ï¾¾rmising", "cipherer", "literalizing", "toughish", "commenter", "clithral", "androclinium", "dissociableness", "heartthrob", "preagitation", "going", "pettifogger", "gliddery", "tantalum", "undershoring", "unfractured", "propunishment", "caulonia", "brentwood", "realised", "cuttle", "waff", "unexcrescent", "undercutting", "catacumba", "optics", "suspensor", "stradivarius", "malate", "langton", "acetophenetidin", "giacomuzzo", "taurine", "candlebeam", "asiatically", "swayable", "sceptre", "haemangiomata", "anhalt", "gluttonize", "coss", "sixth", "nonrepellence", "edgewood", "ultima", "interagglutinated"}
        Dim Address() As String = {" 247 Railroad Avenue ", " 796 Cherry Street ", " 696 6th Street North ", " 928 Evergreen Lane ", " 580 West Avenue ", " 807 York Street ", " 753 Grove Street ", " 327 School Street ", " 320 Inverness Drive ", " 692 Windsor Court ", " 636 Park Street ", " 697 Grove Avenue ", " 736 Mulberry Court ", " 947 Oxford Road ", " 140 Spring Street ", " 974 7th Avenue ", " 693 Warren Street ", " 904 Ashley Court ", " 46 Lexington Drive ", " 735 9th Street West ", " 65 New Street ", " 467 Delaware Avenue ", " 414 Ridge Street ", " 718 B Street ", " 529 Primrose Lane ", " 967 Essex Court ", " 687 Hamilton Street ", " 670 Garden Street ", " 396 Brandywine Drive ", " 379 Redwood Drive ", " 682 Lexington Court ", " 562 Hamilton Road ", " 774 Maiden Lane ", " 199 Glenwood Drive ", " 618 Devon Road ", " 173 Country Lane ", " 354 Lawrence Street ", " 282 Franklin Street ", " 774 Church Road ", " 25 Willow Drive ", " 989 Street Road ", " 967 Lexington Court ", " 979 Garfield Avenue ", " 782 Lincoln Avenue ", " 880 Jackson Street ", " 875 Franklin Court ", " 295 Mill Street ", " 429 Surrey Lane ", " 148 Morris Street ", " 20 Laurel Lane "}

        Dim randomID As New Random
        mtxtEmpoyeeID.Text = CStr(randomID.Next(100000000, 999999999))
        txtLastName.Text = lastName(randomID.Next(0, 49))
        txtFirstName.Text = firstName(randomID.Next(0, 49))
        txtAddress.Text = Address(randomID.Next(0, 49))
        txtCity.Text = City(randomID.Next(0, 49))
        cbState.SelectedIndex = CInt(randomID.Next(1, 50))
        txtZip.Text = CStr(randomID.Next(10000, 99999))
        cbRate.SelectedIndex = CInt(randomID.Next(1, 15))
        txtHours.Text = CStr(randomID.Next(1, 40))
    End Sub

    ' ######################################################
    ' Show the Employee List form
    ' ######################################################
    Private Sub tsmEmployeeList_Click(sender As System.Object, e As System.EventArgs) Handles mnuEmployeeList.Click
        frmEmployeeList.ShowDialog()
    End Sub

    ' ######################################################
    ' Deleting a record from the saved entries
    ' ######################################################
    Private Sub tsbDelete_Click(sender As System.Object, e As System.EventArgs) Handles tsbDelete.Click
        If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ' Try to write the entry to the collection
            Try
                ' Remove the entry from the collection using the key
                EmployeeCollection.Remove(mtxtEmpoyeeID.Text)

                ' Clear the form
                ClearForm()

                ' Update the XML file
                UpdateXMLFile()

                ' And then exit
                Exit Sub
            Catch ex As Exception
                MsgBox(ex.Message + vbNewLine + "Line: " + ex.ToString.Split(CChar(" ")).Last, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    ' ######################################################
    ' Just a close button on the button bar
    ' ######################################################
    Private Sub tsbExit_Click(sender As System.Object, e As System.EventArgs) Handles tsbExit.Click, mnuExit.Click
        Me.Close()
    End Sub

    ' ######################################################
    ' Populate the remaining form if the user types a name that already exists in the database
    ' ######################################################
    Private Sub txtLastName_FocusLeave(sender As System.Object, e As System.EventArgs) Handles txtLastName.Leave
        For Each person As Employee In EmployeeCollection
            ' Compare the textbox string to the ._lastName of each record until we find a match.
            ' If a match is found, propigate the remaining fields auto-magically.
            Dim txtBox As String = Me.txtLastName.Text
            Dim arrayID As String = person._lastName

            If txtBox = arrayID Then
                mtxtEmpoyeeID.Text = CStr(person._ID)
                txtFirstName.Text = CStr(person._firstName)
                'txtLastName.Text = CStr(person._lastName)
                txtAddress.Text = CStr(person._Address)
                txtCity.Text = CStr(person._City)
                cbState.SelectedItem = CStr(person._State)
                txtZip.Text = CStr(person._ZipCode)
                cbRate.SelectedItem = CStr(person._JobCode)
                mtxtEmpoyeeID.Enabled = False
            End If
        Next person
    End Sub

    ' ######################################################
    ' Manually save the entry to the collection
    ' ######################################################
    Private Sub ManualSave(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        ' Try to write the entry to the collection
        Try
            UpdateCollection()
        Catch ex As ArgumentException
            ' This error is thrown when the collection key (the ID) already exists. *i think*
            ' So, Remove the old entry
            EmployeeCollection.Remove(mtxtEmpoyeeID.Text)

            ' Update the collection
            UpdateCollection()
        Catch ex As Exception
            MsgBox(ex.Message + vbNewLine + "Line: " + ex.ToString.Split(CChar(" ")).Last, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' ######################################################
    ' When the user enters text into the last name box, check if that user already exists.
    ' If they do, DISABLE the ID because I'm using that as a unique id for each entry.
    ' ######################################################
    Private Sub txtLastName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtLastName.KeyUp
        For Each person As Employee In EmployeeCollection
            If CBool(person._ID = mtxtEmpoyeeID.Text) Then
                mtxtEmpoyeeID.Enabled = False
            Else
                mtxtEmpoyeeID.Enabled = True
            End If
        Next person
    End Sub


    Private Sub AddJobCode(sender As System.Object, e As System.EventArgs) Handles AddJobCodeToolStripMenuItem.Click
        ' Create a new Payrate object
        Dim NewJob As New PayRatesDuece

        NewJob.Job = InputBox("Enter a job code") ' Gather Job title and check it against the array

        If NewJob.GoodData = False Then
            Console.WriteLine("Bad Job data, stopping.")
            Exit Sub
        End If

        NewJob.PayRate = InputBox("And the pay rate for " + NewJob.Job + "?") ' Gather payrate

        If NewJob.GoodData = False Then
            Console.WriteLine("Bad PayRate data, stopping.")
            Exit Sub
        End If

        ' Extend and preserve the array by one
        ReDim Preserve arrPayRates(arrPayRates.Length)

        ' write the data to the array in the last entry
        arrPayRates(UBound(arrPayRates)).Job = NewJob.Job
        arrPayRates(UBound(arrPayRates)).PayRate = CDbl(NewJob.PayRate)

        MsgBox(NewJob.Job + " has been saved at " + FormatCurrency(NewJob.PayRate))

        ' write to a .dat file
        updateDatFile()

        ' Also update the cbRate combobox.
        PropigateJobRateCombobox()
    End Sub

    ' ######################################################
    ' Simply updates the cbRate combobox from the JobRates.dat file
    ' ######################################################
    Public Function PropigateJobRateCombobox() As Action
        Try
            Dim sr As New StreamReader("JobRates.dat")
            cbRate.Items.Clear() ' Clear the existing items from the combobox

            Do
                If arrPayRates Is Nothing Then
                    ReDim arrPayRates(0)    ' sets the array to 1 item initially
                Else
                    ReDim Preserve arrPayRates(arrPayRates.Length) ' expands the array to include the new entry
                End If

                arrPayRates(UBound(arrPayRates)).Job = sr.ReadLine              ' Add the Job Title to the array
                arrPayRates(UBound(arrPayRates)).PayRate = CDbl(sr.ReadLine)    ' Add the Job Rate to the array
                cbRate.Items.Add(arrPayRates(UBound(arrPayRates)).Job)          ' Add the Job Title to the combobox
            Loop While sr.Peek > -1

            sr.Close()

        Catch ex As FileNotFoundException
            MsgBox("JobRates.dat was not found, a new file will be created for you.", MsgBoxStyle.Information)

            ReDim arrPayRates(15)

            arrPayRates(1).Job = "DVR1"
            arrPayRates(1).PayRate = 9.5
            arrPayRates(2).Job = "DVR2"
            arrPayRates(2).PayRate = 11
            arrPayRates(3).Job = "DVR3"
            arrPayRates(3).PayRate = 13
            arrPayRates(4).Job = "OFF1"
            arrPayRates(4).PayRate = 9
            arrPayRates(5).Job = "OFF2"
            arrPayRates(5).PayRate = 10.5
            arrPayRates(6).Job = "OFF3"
            arrPayRates(6).PayRate = 12
            arrPayRates(7).Job = "SHP1"
            arrPayRates(7).PayRate = 10
            arrPayRates(8).Job = "SHP2"
            arrPayRates(8).PayRate = 11.5
            arrPayRates(9).Job = "SHP3"
            arrPayRates(9).PayRate = 13
            arrPayRates(10).Job = "SUP1"
            arrPayRates(10).PayRate = 12
            arrPayRates(11).Job = "SUP2"
            arrPayRates(11).PayRate = 14
            arrPayRates(12).Job = "SUP3"
            arrPayRates(12).PayRate = 17
            arrPayRates(13).Job = "WH1"
            arrPayRates(13).PayRate = 9
            arrPayRates(14).Job = "WH2"
            arrPayRates(14).PayRate = 10.5
            arrPayRates(15).Job = "WH3"
            arrPayRates(15).PayRate = 12

            updateDatFile()

            ' Add the items to the cbRate combobox.
            For Each job As PayRates In arrPayRates
                cbRate.Items.Add(job.Job)
            Next job

            Exit Function
        Catch ex As Exception
            MsgBox(ex.Message + vbNewLine + "Line: " + ex.ToString.Split(CChar(" ")).Last, MsgBoxStyle.Critical)
        End Try

    End Function
End Class

