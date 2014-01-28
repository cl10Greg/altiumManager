<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminHub
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.createTxt = New System.Windows.Forms.Button()
        Me.editBtn = New System.Windows.Forms.Button()
        Me.revDesBtn = New System.Windows.Forms.Button()
        Me.relDesBtn = New System.Windows.Forms.Button()
        Me.revCompBtn = New System.Windows.Forms.Button()
        Me.designBtn = New System.Windows.Forms.Button()
        Me.compBtn = New System.Windows.Forms.Button()
        Me.relCompBtn = New System.Windows.Forms.Button()
        Me.requestBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin Hub"
        '
        'createTxt
        '
        Me.createTxt.Location = New System.Drawing.Point(384, 88)
        Me.createTxt.Name = "createTxt"
        Me.createTxt.Size = New System.Drawing.Size(75, 23)
        Me.createTxt.TabIndex = 1
        Me.createTxt.Text = "Create User"
        Me.createTxt.UseVisualStyleBackColor = True
        '
        'editBtn
        '
        Me.editBtn.Location = New System.Drawing.Point(384, 117)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Size = New System.Drawing.Size(75, 23)
        Me.editBtn.TabIndex = 2
        Me.editBtn.Text = "Edit User"
        Me.editBtn.UseVisualStyleBackColor = True
        '
        'revDesBtn
        '
        Me.revDesBtn.Location = New System.Drawing.Point(257, 117)
        Me.revDesBtn.Name = "revDesBtn"
        Me.revDesBtn.Size = New System.Drawing.Size(121, 23)
        Me.revDesBtn.TabIndex = 17
        Me.revDesBtn.Text = "Revise Designs"
        Me.revDesBtn.UseVisualStyleBackColor = True
        '
        'relDesBtn
        '
        Me.relDesBtn.Location = New System.Drawing.Point(257, 88)
        Me.relDesBtn.Name = "relDesBtn"
        Me.relDesBtn.Size = New System.Drawing.Size(121, 23)
        Me.relDesBtn.TabIndex = 16
        Me.relDesBtn.Text = "Release Designs"
        Me.relDesBtn.UseVisualStyleBackColor = True
        '
        'revCompBtn
        '
        Me.revCompBtn.Location = New System.Drawing.Point(130, 117)
        Me.revCompBtn.Name = "revCompBtn"
        Me.revCompBtn.Size = New System.Drawing.Size(121, 23)
        Me.revCompBtn.TabIndex = 15
        Me.revCompBtn.Text = "Revise Components"
        Me.revCompBtn.UseVisualStyleBackColor = True
        '
        'designBtn
        '
        Me.designBtn.Location = New System.Drawing.Point(14, 146)
        Me.designBtn.Name = "designBtn"
        Me.designBtn.Size = New System.Drawing.Size(110, 23)
        Me.designBtn.TabIndex = 14
        Me.designBtn.Text = "View Designs"
        Me.designBtn.UseVisualStyleBackColor = True
        '
        'compBtn
        '
        Me.compBtn.Location = New System.Drawing.Point(14, 117)
        Me.compBtn.Name = "compBtn"
        Me.compBtn.Size = New System.Drawing.Size(110, 23)
        Me.compBtn.TabIndex = 13
        Me.compBtn.Text = "View Components"
        Me.compBtn.UseVisualStyleBackColor = True
        '
        'relCompBtn
        '
        Me.relCompBtn.Location = New System.Drawing.Point(130, 88)
        Me.relCompBtn.Name = "relCompBtn"
        Me.relCompBtn.Size = New System.Drawing.Size(121, 23)
        Me.relCompBtn.TabIndex = 12
        Me.relCompBtn.Text = "Release Components"
        Me.relCompBtn.UseVisualStyleBackColor = True
        '
        'requestBtn
        '
        Me.requestBtn.Location = New System.Drawing.Point(14, 88)
        Me.requestBtn.Name = "requestBtn"
        Me.requestBtn.Size = New System.Drawing.Size(110, 23)
        Me.requestBtn.TabIndex = 11
        Me.requestBtn.Text = "View Request"
        Me.requestBtn.UseVisualStyleBackColor = True
        '
        'adminHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.revDesBtn)
        Me.Controls.Add(Me.relDesBtn)
        Me.Controls.Add(Me.revCompBtn)
        Me.Controls.Add(Me.designBtn)
        Me.Controls.Add(Me.compBtn)
        Me.Controls.Add(Me.relCompBtn)
        Me.Controls.Add(Me.requestBtn)
        Me.Controls.Add(Me.editBtn)
        Me.Controls.Add(Me.createTxt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "adminHub"
        Me.Size = New System.Drawing.Size(472, 193)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents createTxt As System.Windows.Forms.Button
    Friend WithEvents editBtn As System.Windows.Forms.Button
    Friend WithEvents revDesBtn As System.Windows.Forms.Button
    Friend WithEvents relDesBtn As System.Windows.Forms.Button
    Friend WithEvents revCompBtn As System.Windows.Forms.Button
    Friend WithEvents designBtn As System.Windows.Forms.Button
    Friend WithEvents compBtn As System.Windows.Forms.Button
    Friend WithEvents relCompBtn As System.Windows.Forms.Button
    Friend WithEvents requestBtn As System.Windows.Forms.Button

End Class
