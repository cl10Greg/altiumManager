Public Class adminHub

    Private Sub adminHub_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub createTxt_Click(sender As Object, e As EventArgs) Handles createTxt.Click
        Dim userObj As New newUserCtrl

        mainFrm.updatePanel(userObj)
    End Sub
End Class
