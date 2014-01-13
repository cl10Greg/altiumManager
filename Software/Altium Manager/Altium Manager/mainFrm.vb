Public Class mainFrm

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        'Prompt the user what to search for

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub mainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminToolStripMenuItem.Enabled = False
        ActionsToolStripMenuItem.Enabled = False
        ChangePasswordToolStripMenuItem.Enabled = False

    End Sub

    Private Sub LoginToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem1.Click
        'Show login form
        checkLogin.Show()
        ChangePasswordToolStripMenuItem.Enabled = True
        'If user, show request data that they have done
        'if admin, show all request

    End Sub

    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem.Click
        'Send to form to get information

    End Sub

    Private Sub BrowseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrowseToolStripMenuItem.Click
        'Give the user a form where they can select categories

    End Sub

    Private Sub NewPartRequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewPartRequestToolStripMenuItem.Click
        'Show the new request form

    End Sub

    Private Sub DeletePartRequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeletePartRequestToolStripMenuItem.Click
        'Show the request they have access to delete

    End Sub
End Class
