Public Class loginCtrl

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        'make a login object
        'Check to make sure data is correct
        'See if the username exists in the database
        'If not, throw error
        'if so, read password and decrypt
        'Check if password is correct
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        passTxt.Clear()
        userTxt.Clear()
    End Sub

    Private Sub newUserBtn_Click(sender As Object, e As EventArgs) Handles newUserBtn.Click
        Dim tempControl As New newUserCtrl
        'Show the new user form
        mainFrm.contentPanel.Controls.Clear()
        mainFrm.contentPanel.Controls.Add(tempControl)
        tempControl.Location = mainFrm.getCenter(tempControl)

    End Sub
End Class
