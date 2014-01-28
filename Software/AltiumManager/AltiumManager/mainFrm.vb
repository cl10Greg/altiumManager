'Name:      MainFrm
'Function:  The starting form for the application.  Houses all controls for the user interface
'Input:     None
'Output:    None

Public Class mainFrm
    'Class variables
    'pUserObj:  object to hold the information of the user that is currently logged in
    Private pUserObj As New activeUserClass

    'Procedure to handle the exit button click in the menu items
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Closes the application
        Me.Dispose()
    End Sub

    'Name:      getCenter
    'Function:  Take the size of the controller and figures out the middle of the panel is
    'Input:     Control
    'Output:    Point
    Public Function getCenter(tempControl As Control) As Point
        Dim centerPanel As New Point((contentPanel.Width \ 2) - (tempControl.Width \ 2), (contentPanel.Height \ 2) - (tempControl.Height \ 2))
        Return centerPanel
    End Function
    'Procedure to handle to login click from the menu
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        'Create new loginControl
        Dim tempControl As New loginCtrl
        'Clear, add control, and set to center
        updatePanel(tempControl)
    End Sub
    'Procedure to handle the change password click from the menu
    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        'Create a new change password control
        Dim tempControl As New changePassCtrl
        'Clear, add control, and set to center
        updatePanel(tempControl)
        'Sends the logged in user information to the control for use
        tempControl.getActiveUser(pUserObj)
    End Sub
    'Procedure that runs when the form loads
    Private Sub mainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Creates a login control
        Dim tempControl As New loginCtrl
        'Sets the default states of the buttons that can be clicked
        defaultControls()
        'Adds the login control to the panel
        contentPanel.Controls.Add(tempControl)
        'Centers the control
        tempControl.Location = getCenter(tempControl)
    End Sub
    'Procedure to handle the logout button click in the menu
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        'Create a new login control
        Dim tempControl As New loginCtrl
        'Sets the default states of the buttons the can be clicked
        defaultControls()
        'Enables the login buttons
        LoginToolStripMenuItem.Enabled = True
        'Change the form text
        Me.Text = "Main Menu"
        'Clear the active user object
        pUserObj = Nothing
        'Clear, add control, and set to center
        updatePanel(tempControl)
    End Sub
    'Procedure to handle the released component button click from the menu
    Private Sub ReleasedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReleasedToolStripMenuItem.Click
        'Create a new release component control
        Dim tempControl As New releaseComponentCtrl
        'Clear, add control, and set to center
        updatePanel(tempControl)
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        'Show the help menu

    End Sub

    Private Sub EditUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditUsersToolStripMenuItem.Click
        'Create a new adminUsercontrol
        Dim tempControl As New adminUserCtrl
        'Clear, add control, and set to center
        updatePanel(tempControl)
    End Sub

    Public Sub setUserObj(tempObj As activeUserClass)
        'Set the current user information object
        pUserObj = tempObj
        'Update the title to who is logged in
        Me.Text = Me.Text & " - Logged in as: " & pUserObj.userName
        'Update the GUI based on who is logged in
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
        Select Case pUserObj.userRole
            Case "Administrator"
                'Enable all controls
                AdminToolStripMenuItem.Enabled = True
                LibrarianToolStripMenuItem.Enabled = True
                RequestToolStripMenuItem.Enabled = True
                DesignToolStripMenuItem.Enabled = True
                ComponentsToolStripMenuItem.Enabled = True
                'Create and show admin hub
                Dim adminObj As New adminHub
                updatePanel(adminObj)
            Case "Librarian"
                'Enable Librarian controls
                LibrarianToolStripMenuItem.Enabled = True
                RequestToolStripMenuItem.Enabled = True
                DesignToolStripMenuItem.Enabled = True
                ComponentsToolStripMenuItem.Enabled = True
                'Create and show librarian hub
                Dim libObj As New librarianHub
                updatePanel(libObj)
            Case "Designer"
                'Enable designer controls
                ComponentsToolStripMenuItem.Enabled = True
                DesignToolStripMenuItem.Enabled = True
                RequestToolStripMenuItem.Enabled = True
                'Create and show designer hub
                Dim designObj As New designerHub
                updatePanel(designObj)
            Case "Viewer"
                'Enable viewer controls
                DesignToolStripMenuItem.Enabled = True
                ComponentsToolStripMenuItem.Enabled = True
                'Create and show the viewer hub
                Dim viewObj As New viewerHub
                updatePanel(viewObj)

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
        ChangePasswordToolStripMenuItem.Enabled = False
        LogoutToolStripMenuItem.Enabled = False
    End Sub

    Public Sub updatePanel(tempControl As Control)
        'Clears the current panel
        contentPanel.Controls.Clear()
        'Adds the login control
        contentPanel.Controls.Add(tempControl)
        'Puts the control in the center
        tempControl.Location = getCenter(tempControl)
    End Sub

    Private Sub CreateUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateUserToolStripMenuItem.Click
        'Create a newUser Control
        Dim tempControl As New newUserCtrl
        'Clear, add control, and set to center
        updatePanel(tempControl)
    End Sub

    Private Sub SandboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SandboxToolStripMenuItem.Click
        'Form to add an item to the sandbox
        Dim tempControl As New sandboxCtrl
        updatePanel(tempControl)
        tempControl.receiveUser(pUserObj)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Select Case pUserObj.userRole
            Case "Administrator"
                Dim adminObj As New adminHub
                updatePanel(adminObj)
            Case "Librarian"
                Dim libObj As New librarianHub
                updatePanel(libObj)
            Case "Designer"
                Dim desObj As New designerHub
                updatePanel(desObj)
            Case "Viewer"
                Dim viewObj As New viewerHub
                updatePanel(viewObj)
            Case "Other"

            Case Nothing
                Dim logObj As New loginCtrl
                updatePanel(logObj)
        End Select
    End Sub
End Class
