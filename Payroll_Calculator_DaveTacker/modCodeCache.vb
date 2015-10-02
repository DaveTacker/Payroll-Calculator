Module modCodeCache
    ' ######################################################
    ' An event watch to detect when the user enters text into
    ' the ID Combo Box, if there is already an ID within the Structure
    ' Auto-fill the remainder of the ID and higlight it.
    ' ######################################################
    Private Sub cbEmployee_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles cbEmployee.KeyUp
        Dim index As Integer
        Dim actual As String
        Dim found As String

        ' Do nothing for some keys such as navigation keys.
        If ((e.KeyCode = Keys.Back) Or _
            (e.KeyCode = Keys.Left) Or _
            (e.KeyCode = Keys.Right) Or _
            (e.KeyCode = Keys.Up) Or _
            (e.KeyCode = Keys.Delete) Or _
            (e.KeyCode = Keys.Down) Or _
            (e.KeyCode = Keys.PageUp) Or _
            (e.KeyCode = Keys.PageDown) Or _
            (e.KeyCode = Keys.Home) Or _
            (e.KeyCode = Keys.End)) Then
            Return
        ElseIf e.KeyCode = Keys.Enter Then
            ' If the user presses the Enter key, populate the textboxes with the relivant information
            For Each person As Employee In arrEmployeeList
                ' Compare the textbox string to the .ID field to find a match.
                Dim txtBox As String = CStr(Me.cbEmployee.SelectedItem)
                Dim arrayID As String = CStr(person._ID)

                If txtBox = arrayID Then
                    txtFirstName.Text = CStr(person._firstName)
                    txtLastName.Text = CStr(person._lastName)
                    txtAddress.Text = CStr(person._Address)
                    txtCity.Text = CStr(person._City)
                    cbState.SelectedItem = CStr(person._State)
                    txtZip.Text = CStr(person._ZipCode)
                    cbRate.SelectedItem = CStr(person._JobCode)
                End If
            Next person
        End If

        ' Store the actual text that has been typed.
        actual = Me.cbEmployee.Text

        ' Find the first match for the typed value.
        index = Me.cbEmployee.FindString(actual)

        ' Get the text of the first match.
        If (index > -1) Then ' making sure the .text length isn't nil.
            found = Me.cbEmployee.Items(index).ToString()

            ' Select this item from the list.
            Me.cbEmployee.SelectedIndex = index

            ' Select the portion of the text that was automatically
            ' added so that additional typing will replace it.
            Me.cbEmployee.SelectionStart = actual.Length
            Me.cbEmployee.SelectionLength = found.Length

        End If
    End Sub

    ' ######################################################
    ' Populate the form when the user selects an item from the combobox
    ' ######################################################
    Private Sub cbEmployee_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cbEmployee.SelectionChangeCommitted
        For Each person As Employee In arrEmployeeList
            ' Compare the textbox string to the .ID field to find a match.
            Dim txtBox As String = CStr(Me.cbEmployee.SelectedItem)
            Dim arrayID As String = CStr(person._ID)

            If txtBox Is Nothing Or arrayID Is Nothing Then
                Exit Sub
            End If

            If txtBox = arrayID Then
                txtFirstName.Text = CStr(person._firstName)
                txtLastName.Text = CStr(person._lastName)
                txtAddress.Text = CStr(person._Address)
                txtCity.Text = CStr(person._City)
                cbState.SelectedItem = CStr(person._State)
                txtZip.Text = CStr(person._ZipCode)
                cbRate.SelectedItem = CStr(person._JobCode)
            End If
        Next person
    End Sub
End Module
