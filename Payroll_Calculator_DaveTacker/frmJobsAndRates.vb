' A very simple form parsing arrPayRates, and shows the list of Job Rates

Option Explicit On
Option Strict On

Public Class Jobs_and_Rates

    ' When this form shows, iterate through the PayRate array to populate the list.
    Private Sub OnShow(sender As Object, e As EventArgs) Handles MyBase.Shown
        For Each item As PayRates In arrPayRates
            lbJobsList.Items.Add(item.Job & ControlChars.Tab & FormatCurrency(item.PayRate))
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class