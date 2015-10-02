Option Strict On
Option Explicit On
Imports System.Xml
Imports System.IO
Module modFunctions
    ' ######################################################
    ' A commonly used function to write to the EmployeeCollection
    ' ######################################################
    Public Function UpdateCollection() As Action

        If DoubleCheckForm() = True Then
            Exit Function
        End If

        Try
            ' Add the information entered into the form to the Structure Array
            EmployeeCollection.Add(New Employee(frmMain.mtxtEmpoyeeID.Text, _
                                             frmMain.txtFirstName.Text, _
                                             frmMain.txtLastName.Text, _
                                             frmMain.txtAddress.Text, _
                                             frmMain.txtCity.Text, _
                                             frmMain.cbState.Text, _
                                             CInt(frmMain.txtZip.Text), _
                                             frmMain.cbRate.Text), frmMain.mtxtEmpoyeeID.Text)



        Catch ex As InvalidCastException
            MsgBox("There was an error adding the person to the Collection. " & vbNewLine & vbNewLine & ex.Message + vbNewLine + "Line: " + ex.ToString.Split(CChar(" ")).Last, MsgBoxStyle.Critical)
            Exit Function
        Catch ex As Exception
            MsgBox(ex.Message + vbNewLine + "Line: " + ex.ToString.Split(CChar(" ")).Last, MsgBoxStyle.Critical)
            Exit Function
        End Try

        ' Update the XML file
        UpdateXMLFile()
    End Function

    ' ######################################################
    ' Update the XML file to reflect the latest information within the array
    ' ######################################################
    Public Function UpdateXMLFile() As Action
        ' Creating a file writing handle so the array persists between sessions
        Dim Scribe As XmlWriterSettings = New XmlWriterSettings()

        ' Write to the XML file
        Scribe.Indent = True ' Auto-indents the hierchy of the XML file

        Using writer As XmlWriter = XmlWriter.Create("Employees.xml", Scribe)
            writer.WriteStartDocument() ' defines the version of XML to use, defaults to 1.0
            writer.WriteStartElement("Employees") ' the root of the XML heirchy

            For Each employee As Employee In EmployeeCollection
                writer.WriteStartElement("Employee") ' Opens the Employee entry
                writer.WriteElementString("ID", employee._ID.ToString)
                writer.WriteElementString("firstName", employee._firstName.ToString)
                writer.WriteElementString("lastName", employee._lastName.ToString)
                writer.WriteElementString("Address", employee._Address.ToString)
                writer.WriteElementString("City", employee._City.ToString)
                writer.WriteElementString("State", employee._State.ToString)
                writer.WriteElementString("ZipCode", employee._ZipCode.ToString)
                writer.WriteElementString("JobCode", employee._JobCode.ToString)
                writer.WriteEndElement() ' Closes the Employees entry
            Next

            writer.WriteEndElement() ' Closes the Employees hierchy
            writer.WriteEndDocument() ' Closes the xml tag

            writer.Close() ' shuts down the writer
        End Using

        MsgBox("Record saved successfully!", MsgBoxStyle.OkOnly)
    End Function

    Public Function updateDatFile() As Action
        Try
            Dim file As New StreamWriter("JobRates.dat")

            For Each item As PayRates In arrPayRates
                file.WriteLine(item.Job)
                file.WriteLine(item.PayRate)
            Next item

            file.Close()

        Catch ex As FileNotFoundException
            MsgBox("JobRates.dat was not found, a new file will be created for you.", MsgBoxStyle.Information)
            Exit Function
        Catch ex As Exception
            MsgBox(ex.Message + vbNewLine + "Line: " + ex.ToString.Split(CChar(" ")).Last, MsgBoxStyle.Critical)
        End Try
    End Function

    ' ######################################################
    ' This function written by Rick
    ' This function checks each character of the string parameter for one that is not alphabetic.
    ' If it finds one, it returns "False". If not, it returns a "True".
    ' ######################################################
    Public Function Alphabetic(ByVal strInput As String) As Boolean
        Dim i As Integer

        strInput = strInput.ToUpper

        For i = 0 To strInput.Length - 1

            'If it's a blank, skip it
            If strInput(i) = " " Then Continue For
            If Not strInput(i) >= "A" And strInput(i) <= "Z" Then ' Then Is it alphabetic?
                Return False    'No, so return "False"
            End If

        Next i

        Return True 'Every character passed, so return "True"
    End Function

    ' ######################################################
    ' Returns the payrate for the passed argument
    ' ######################################################
    Public Function GetPayRate(ByVal strJob As String) As Double
        For Each job As PayRates In arrPayRates
            If job.Job = strJob Then
                Return job.PayRate
                Exit Function
            End If
        Next job
    End Function

    Public Function DoubleCheckJob(ByRef strJob As String) As String
        'Dim strText As String = strJob

Start:
        ' Does the inputbox have text?
        If strJob <> "" Then
            For Each item As PayRates In arrPayRates
                If item.Job = strJob Then
                    strJob = InputBox("Sorry, but the rate already exists!")

                    GoTo Start ' The inputbox item already exists, return to Start and ask again.
                End If
            Next item

            Return strJob
        Else
            ' No text or user cancelled.
            Return ""
            Exit Function
        End If

    End Function

    Public Function DoubleCheckForm() As Boolean
        ' Make sure no fields are blank
        For Each ctrl As Control In frmMain.gbPersonalInformation.Controls
            If TypeOf ctrl Is MaskedTextBox Then
                If Not DirectCast(ctrl, MaskedTextBox).MaskCompleted Then
                    MsgBox("Please enter a valid Employee ID.", MsgBoxStyle.Information)
                    DirectCast(ctrl, MaskedTextBox).Focus()
                    Return True ' Bad Data.
                End If
            ElseIf TypeOf ctrl Is ComboBox Then
                If DirectCast(ctrl, ComboBox).Text = "" Then
                    MsgBox("Please select an item from the dropdown.", MsgBoxStyle.Information)
                    DirectCast(ctrl, ComboBox).DroppedDown = True
                    Return True ' Bad Data.
                End If
            ElseIf TypeOf ctrl Is TextBox Then
                If DirectCast(ctrl, TextBox).Text = "" Then
                    MsgBox("Please enter the correct " + ctrl.Name.Substring(3, ctrl.Name.Length - 3) + " in the TextBox provided.", MsgBoxStyle.Information)
                    DirectCast(ctrl, TextBox).Focus()
                    Return True ' Bad Data.
                End If
            End If
        Next

        ' Make sure Last, First, and City are alphabetic only.
        If Not Alphabetic(frmMain.txtLastName.Text) Then
            MsgBox("The Last Name may only contain alphabetic characters.", MsgBoxStyle.Exclamation)
            frmMain.txtLastName.Focus()
            Return True ' Bad Data.
        End If

        If Not Alphabetic(frmMain.txtFirstName.Text) Then
            MsgBox("The First Name may only contain alphabetic characters.", MsgBoxStyle.Exclamation)
            frmMain.txtFirstName.Focus()
            Return True ' Bad Data.
        End If

        If Not Alphabetic(frmMain.txtCity.Text) Then
            MsgBox("The City may only contain alphabetic characters.", MsgBoxStyle.Exclamation)
            frmMain.txtCity.Focus()
            Return True ' Bad Data.
        End If

        ' Is the length of the Zipcode less than 5?
        If frmMain.txtZip.TextLength < 5 Then
            MsgBox("Your Zipcode must be at least 5 characters", MsgBoxStyle.Exclamation)
            frmMain.txtZip.Focus()
            Return True ' Bad Data.
        End If

        Return False
    End Function
End Module
