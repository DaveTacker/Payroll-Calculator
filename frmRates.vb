Option Strict On
Option Explicit On

Public Class frmRates
    ' #######################################################
    ' Upon form load, propigate the textboxes with relevant rates
    ' #######################################################
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtIncomeTax.Text = FormatPercent(My.Settings.IncomeTax)
        txtMedicare.Text = FormatPercent(My.Settings.Medicare)
        txtSocialSecurity.Text = FormatPercent(My.Settings.SocialSecurity)
    End Sub

    ' #######################################################
    ' When the user closes the form, save the information to the applications settings
    ' #######################################################
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' My.Settings.IncomeTax = ToDecimal(txtIncomeTax.Text)
        My.Settings.Medicare = ToDecimal(txtMedicare.Text)
        My.Settings.SocialSecurity = ToDecimal(txtSocialSecurity.Text)

        My.Settings.Save()
        Me.Close()
    End Sub

    ' #######################################################
    ' Convert the textbox text to a decimal from a percentage
    ' #######################################################
    Function ToDecimal(Percentage As String) As Decimal
        Percentage = Percentage.Replace("%", "")   'removes percentage sign'
        Return CDec(Val(Percentage) / 100)
    End Function

    ' #######################################################
    ' Automatically add a % to the textbox when
    ' the focus leaves the box after typing.
    ' These functions also restict the user to ONLY typing
    ' Digits and decimals, as well as making sure that
    ' /something/ is entered into the box upon focus leave.
    ' #######################################################
    Public Sub AddPercentToTxt_FocusLeave(sender As System.Object, e As System.EventArgs) Handles txtMedicare.Leave, txtSocialSecurity.Leave
        Dim txt As String = DirectCast(sender, TextBox).Text.Replace("%", "")
        DirectCast(sender, TextBox).Text = txt + "%"
    End Sub

    Private Sub OnlyDigitsOnKeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMedicare.KeyPress, txtSocialSecurity.KeyPress
        Try
            If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(DirectCast(sender, TextBox).Text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' #######################################################
    ' Restore the taxes back to their defaults.
    ' http://taxes.about.com/od/Federal-Income-Taxes/fl/Federal-Income-Tax-Rates-for-the-Year-2014.htm
    ' #######################################################
    Private Sub btnRestoreDefaults_Click(sender As Object, e As EventArgs) Handles btnRestoreDefaults.Click
        '  txtIncomeTax.Text = "18%"
        txtMedicare.Text = "2.9%"
        txtSocialSecurity.Text = "6.2%"
    End Sub
End Class