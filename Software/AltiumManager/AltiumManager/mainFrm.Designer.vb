<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainFrm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComponentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReleasedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SandboxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReleasedToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SandboxToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComponentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RevisionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesignToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RevisionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditRolesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.loginTool = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.contentPanel = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.UsersToolStripMenuItem, Me.ComponentsToolStripMenuItem, Me.DesignToolStripMenuItem, Me.RequestToolStripMenuItem, Me.AdminToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(736, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.NewUserToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'NewUserToolStripMenuItem
        '
        Me.NewUserToolStripMenuItem.Name = "NewUserToolStripMenuItem"
        Me.NewUserToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.NewUserToolStripMenuItem.Text = "New User"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ComponentsToolStripMenuItem
        '
        Me.ComponentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReleasedToolStripMenuItem, Me.SandboxToolStripMenuItem})
        Me.ComponentsToolStripMenuItem.Name = "ComponentsToolStripMenuItem"
        Me.ComponentsToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.ComponentsToolStripMenuItem.Text = "Components"
        '
        'ReleasedToolStripMenuItem
        '
        Me.ReleasedToolStripMenuItem.Name = "ReleasedToolStripMenuItem"
        Me.ReleasedToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReleasedToolStripMenuItem.Text = "Released"
        '
        'SandboxToolStripMenuItem
        '
        Me.SandboxToolStripMenuItem.Name = "SandboxToolStripMenuItem"
        Me.SandboxToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SandboxToolStripMenuItem.Text = "Sandbox"
        '
        'DesignToolStripMenuItem
        '
        Me.DesignToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReleasedToolStripMenuItem1, Me.SandboxToolStripMenuItem1})
        Me.DesignToolStripMenuItem.Name = "DesignToolStripMenuItem"
        Me.DesignToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.DesignToolStripMenuItem.Text = "Design"
        '
        'ReleasedToolStripMenuItem1
        '
        Me.ReleasedToolStripMenuItem1.Name = "ReleasedToolStripMenuItem1"
        Me.ReleasedToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ReleasedToolStripMenuItem1.Text = "Released"
        '
        'SandboxToolStripMenuItem1
        '
        Me.SandboxToolStripMenuItem1.Name = "SandboxToolStripMenuItem1"
        Me.SandboxToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.SandboxToolStripMenuItem1.Text = "Sandbox"
        '
        'RequestToolStripMenuItem
        '
        Me.RequestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComponentToolStripMenuItem, Me.DesignToolStripMenuItem1})
        Me.RequestToolStripMenuItem.Name = "RequestToolStripMenuItem"
        Me.RequestToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.RequestToolStripMenuItem.Text = "Request"
        '
        'ComponentToolStripMenuItem
        '
        Me.ComponentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.RevisionToolStripMenuItem})
        Me.ComponentToolStripMenuItem.Name = "ComponentToolStripMenuItem"
        Me.ComponentToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ComponentToolStripMenuItem.Text = "Component"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'RevisionToolStripMenuItem
        '
        Me.RevisionToolStripMenuItem.Name = "RevisionToolStripMenuItem"
        Me.RevisionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RevisionToolStripMenuItem.Text = "Revision"
        '
        'DesignToolStripMenuItem1
        '
        Me.DesignToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem1, Me.RevisionToolStripMenuItem1})
        Me.DesignToolStripMenuItem1.Name = "DesignToolStripMenuItem1"
        Me.DesignToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.DesignToolStripMenuItem1.Text = "Design"
        '
        'NewToolStripMenuItem1
        '
        Me.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
        Me.NewToolStripMenuItem1.Size = New System.Drawing.Size(118, 22)
        Me.NewToolStripMenuItem1.Text = "New"
        '
        'RevisionToolStripMenuItem1
        '
        Me.RevisionToolStripMenuItem1.Name = "RevisionToolStripMenuItem1"
        Me.RevisionToolStripMenuItem1.Size = New System.Drawing.Size(118, 22)
        Me.RevisionToolStripMenuItem1.Text = "Revision"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditUsersToolStripMenuItem, Me.EditRolesToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'EditUsersToolStripMenuItem
        '
        Me.EditUsersToolStripMenuItem.Name = "EditUsersToolStripMenuItem"
        Me.EditUsersToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditUsersToolStripMenuItem.Text = "Edit Users"
        '
        'EditRolesToolStripMenuItem
        '
        Me.EditRolesToolStripMenuItem.Name = "EditRolesToolStripMenuItem"
        Me.EditRolesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditRolesToolStripMenuItem.Text = "Edit Roles"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.loginTool})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(736, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'loginTool
        '
        Me.loginTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.loginTool.Image = CType(resources.GetObject("loginTool.Image"), System.Drawing.Image)
        Me.loginTool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.loginTool.Name = "loginTool"
        Me.loginTool.Size = New System.Drawing.Size(23, 22)
        Me.loginTool.Text = "ToolStripButton1"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'contentPanel
        '
        Me.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentPanel.Location = New System.Drawing.Point(0, 49)
        Me.contentPanel.Name = "contentPanel"
        Me.contentPanel.Size = New System.Drawing.Size(736, 282)
        Me.contentPanel.TabIndex = 2
        '
        'mainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 331)
        Me.Controls.Add(Me.contentPanel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "mainFrm"
        Me.Text = "Main Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComponentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReleasedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SandboxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesignToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReleasedToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SandboxToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RequestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComponentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesignToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditRolesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RevisionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RevisionToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents loginTool As System.Windows.Forms.ToolStripButton
    Friend WithEvents contentPanel As System.Windows.Forms.Panel

End Class
