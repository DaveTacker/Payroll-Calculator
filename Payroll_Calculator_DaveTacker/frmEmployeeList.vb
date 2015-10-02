' A very simple form to parse the arrEmployeeList when the form loads,
' showing the current list of employees.

Option Explicit On
Option Strict On

Public Class frmEmployeeList
    ' ######################################################
    ' Close the form
    ' ######################################################
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        lbEmployees.Items.Clear() ' Clear the listbox on close
        Me.Close()
    End Sub

    ' ######################################################
    ' When the form loads, show the list of Employees and Job codes
    ' ######################################################
    Private Sub frmEmployees_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            lbEmployees.Items.Add(" Employee ID" & ControlChars.Tab & " Rate" & ControlChars.Tab & " Name")
            For Each person As Employee In EmployeeCollection
                Dim name As String = person._firstName + " " + person._lastName
                Dim code As String = person._JobCode
                Dim id As String = CStr(person._ID)
                lbEmployees.Items.Add(id & ControlChars.Tab & code & ControlChars.Tab & name)
            Next
        Catch ex As Exception
            MsgBox(ex.Message + vbNewLine + "Line: " + ex.ToString.Split(CChar(" ")).Last, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' ######################################################
    ' Delete the currently selected entry in the listbox
    ' ######################################################
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure you want to delete this record? It cannot be undone!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                If lbEmployees.SelectedIndex > 0 Then
                    ' Return the first item, the ID.
                    Dim ID As String = lbEmployees.SelectedItem.ToString
                    ID = ID.Substring(0, ID.IndexOf(ControlChars.Tab))

                    ' Remove the item from the collection
                    EmployeeCollection.Remove(ID)

                    ' Update the XML file
                    UpdateXMLFile()

                    ' Remove the selected item from the list
                    lbEmployees.Items.Remove(lbEmployees.SelectedItem)
                End If
            Catch ex As Exception
                MsgBox(ex.Message + vbNewLine + "Line: " + ex.ToString.Split(CChar(" ")).Last, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    ' ######################################################
    ' When the user double clicks an item in the listbox
    ' propigate frmMain with the relevant information
    ' ######################################################
    Private Sub lbEmployees_DblClick(sender As System.Object, e As System.EventArgs) Handles lbEmployees.DoubleClick
        If lbEmployees.SelectedIndex = 0 Then
            Exit Sub
        End If

        Try
            Dim ID As String = lbEmployees.SelectedItem.ToString
            ID = ID.Substring(0, ID.IndexOf(ControlChars.Tab))

            Dim person As Employee
            person = CType(EmployeeCollection(ID), Employee)

            frmMain.mtxtEmpoyeeID.Text = CStr(person._ID)
            frmMain.txtFirstName.Text = CStr(person._firstName)
            frmMain.txtLastName.Text = CStr(person._lastName)
            frmMain.txtAddress.Text = CStr(person._Address)
            frmMain.txtCity.Text = CStr(person._City)
            frmMain.cbState.SelectedItem = CStr(person._State)
            frmMain.txtZip.Text = CStr(person._ZipCode)
            frmMain.cbRate.SelectedItem = CStr(person._JobCode)
            frmMain.mtxtEmpoyeeID.Enabled = False

            lbEmployees.Items.Clear() ' Clear the listbox on close
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message + vbNewLine + "Line: " + ex.ToString.Split(CChar(" ")).Last, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class