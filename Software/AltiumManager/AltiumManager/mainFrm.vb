
Public Class mainFrm
    Private pUserObj As New activeUserClass

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
        Dim tempControl As New changePassCtrl
        'Show the change password form
        contentPanel.Controls.Clear()
        contentPanel.Controls.Add(tempControl)
        tempControl.Location = getCenter(tempControl)
        tempControl.getActiveUser(pUserObj)
    End Sub

    Private Sub mainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tempControl As New loginCtrl
        defaultControls()

        contentPanel.Controls.Add(tempControl)
        tempControl.Location = getCenter(tempControl)

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim tempControl As New loginCtrl
        defaultControls()
        LoginToolStripMenuItem.Enabled = True
        NewUserToolStripMenuItem.Enabled = True
        Me.Text = "Main Menu"
        pUserObj = Nothing

        contentPanel.Controls.Clear()
        contentPanel.Controls.Add(tempControl)
        tempControl.Location = getCenter(tempControl)

    End Sub

    Private Sub loginTool_Click(sender As Object, e As EventArgs)
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

    Private Sub EditUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditUsersToolStripMenuItem.Click
        Dim tempControl As New adminUserCtrl

        contentPanel.Controls.Clear()
        contentPanel.Controls.Add(tempControl)
        tempControl.Location = getCenter(tempControl)

    End Sub

    Public Sub setUserObj(tempObj As activeUserClass)
        pUserObj = tempObj
        Me.Text = Me.Text & " - Logged in as: " & pUserObj.userName
        updateGUI()
    End Sub

    Private Sub RequestsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestsToolStripMenuItem.Click
        'Review the request

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        'Print the active control data

    End Sub

    Private Sub updateGUI()
        defaultControls()
        LogoutToolStripMenuItem.Enabled = True
        ChangePasswordToolStripMenuItem.Enabled = True
        LoginToolStripMenuItem.Enabled = False
        NewUserToolStripMenuItem.Enabled = False

        Select Case pUserObj.userRole
            Case "Administrator"
                'Enable all controls
                AdminToolStripMenuItem.Enabled = True
                LibrarianToolStripMenuItem.Enabled = True
                RequestToolStripMenuItem.Enabled = True
                DesignToolStripMenuItem.Enabled = True
                ComponentsToolStripMenuItem.Enabled = True

                'Load the admin hub
            Case "Librarian"
                'Enable Librarian controls
                'Load librarian hub
            Case "Designer"
                'Enable designer controls
                'Load designer hub
            Case "Viewer"
                'Enable viewer controls
                'Load viewer hub
            Case "Other"
                'Enable other controls
                'Load other hub
        End Select
    End Sub

    Private Sub defaultControls()
        ComponentsToolStripMenuItem.Enabled = False
        DesignToolStripMenuItem.Enabled = False
        RequestToolStripMenuItem.Enabled = False
        LibrarianToolStripMenuItem.Enabled = False
        AdminToolStripMenuItem.Enabled = False
        LoginToolStripMenuItem.Enabled = True
        NewUserToolStripMenuItem.Enabled = True
        ChangePasswordToolStripMenuItem.Enabled = False
        LogoutToolStripMenuItem.Enabled = False
    End Sub
End Class
