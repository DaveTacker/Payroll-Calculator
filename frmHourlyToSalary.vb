Public Class frmHourlyToSalary
  
    Private Sub OnlyDigitsOnKeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalary.KeyPress, txtHourly.KeyPress
        Try
            If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblHourly.Text = FormatCurrency(txtSalary.Text / 2087.1)
        lblSalary.Text = FormatCurrency(txtHourly.Text * 2087.1)
    End Sub
    Private Sub txtCurrencyFocusLeave(sender As Object, e As EventArgs) Handles txtSalary.Leave, txtHourly.Leave
        If sender.Text = "" Then
            sender.Text = 0
        End If
        sender.Text = FormatCurrency(sender.Text)
    End Sub

End Class