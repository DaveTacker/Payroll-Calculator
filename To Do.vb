Public Class To_Do

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        sender.LinkVisited = True
        System.Diagnostics.Process.Start("http://www.irs.gov/pub/irs-pdf/f6251.pdf")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        sender.LinkVisited = True
        System.Diagnostics.Process.Start("http://www.irs.gov/instructions/i6251/index.html")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class