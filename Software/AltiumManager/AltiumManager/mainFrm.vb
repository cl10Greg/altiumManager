Public Class mainFrm

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub
    Public Function getCenter(tempControl As Control) As Point
        Dim centerPanel As New Point((contentPanel.Width \ 2) - (tempControl.Width \ 2), (contentPanel.Height \ 2) - (tempControl.Height \ 2))
        Return centerPanel
    End Function
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Dim tempControl As New loginCtrl
        'Show the login form
        'Enable the logout
        LogoutToolStripMenuItem.Enabled = True
        ChangePasswordToolStripMenuItem.Enabled = True
        RequestToolStripMenuItem.Enabled = True

        contentPanel.Controls.Clear()
        contentPanel.Controls.Add(tempControl)
        tempControl.Location = getCenter(tempControl)


    End Sub

    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem.Click
        Dim tempControl As New newUserCtrl
        'Show the new user form
        contentPanel.Controls.Clear()
        contentPanel.Controls.Add(tempControl)
        tempControl.Location = getCenter(tempControl)

    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        'Show the change password form
    End Sub

    Private Sub mainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tempControl As New loginCtrl
        AdminToolStripMenuItem.Enabled = False
        ChangePasswordToolStripMenuItem.Enabled = False
        LogoutToolStripMenuItem.Enabled = False
        RequestToolStripMenuItem.Enabled = False

        contentPanel.Controls.Add(tempControl)
        tempControl.Location = getCenter(tempControl)

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        ChangePasswordToolStripMenuItem.Enabled = False
        LogoutToolStripMenuItem.Enabled = False

    End Sub

    Private Sub loginTool_Click(sender As Object, e As EventArgs) Handles loginTool.Click
        'Show login form

    End Sub

    Private Sub ReleasedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReleasedToolStripMenuItem.Click
        Dim tempControl As New releaseComponentCtrl
        'get all the released components from the database
        'put them in a gridview for the user
        contentPanel.Controls.Clear()
        contentPanel.Controls.Add(tempControl)
        tempControl.Location = getCenter(tempControl)

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        'Show the help menu

    End Sub
End Class
