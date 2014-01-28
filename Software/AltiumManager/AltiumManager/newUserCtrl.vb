Public Class newUserCtrl

    Private Sub createBtn_Click(sender As Object, e As EventArgs) Handles createBtn.Click
        'Create a newUserObject
        'Check Data
        'Check to see if username exist
        'Add to database
        'If anything above designer, get approval
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        userTxt.Clear()
        passTxt.Clear()
        roleCmb.Text = ""
        emailTxt.Clear()

    End Sub
End Class
