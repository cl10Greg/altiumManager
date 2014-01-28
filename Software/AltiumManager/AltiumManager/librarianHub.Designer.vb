<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class librarianHub
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
        Me.requestBtn = New System.Windows.Forms.Button()
        Me.relCompBtn = New System.Windows.Forms.Button()
        Me.compBtn = New System.Windows.Forms.Button()
        Me.designBtn = New System.Windows.Forms.Button()
        Me.revCompBtn = New System.Windows.Forms.Button()
        Me.relDesBtn = New System.Windows.Forms.Button()
        Me.revDesBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Librarian Hub"
        '
        'requestBtn
        '
        Me.requestBtn.Location = New System.Drawing.Point(24, 52)
        Me.requestBtn.Name = "requestBtn"
        Me.requestBtn.Size = New System.Drawing.Size(110, 23)
        Me.requestBtn.TabIndex = 3
        Me.requestBtn.Text = "View Request"
        Me.requestBtn.UseVisualStyleBackColor = True
        '
        'relCompBtn
        '
        Me.relCompBtn.Location = New System.Drawing.Point(140, 52)
        Me.relCompBtn.Name = "relCompBtn"
        Me.relCompBtn.Size = New System.Drawing.Size(121, 23)
        Me.relCompBtn.TabIndex = 4
        Me.relCompBtn.Text = "Release Components"
        Me.relCompBtn.UseVisualStyleBackColor = True
        '
        'compBtn
        '
        Me.compBtn.Location = New System.Drawing.Point(24, 81)
        Me.compBtn.Name = "compBtn"
        Me.compBtn.Size = New System.Drawing.Size(110, 23)
        Me.compBtn.TabIndex = 5
        Me.compBtn.Text = "View Components"
        Me.compBtn.UseVisualStyleBackColor = True
        '
        'designBtn
        '
        Me.designBtn.Location = New System.Drawing.Point(24, 110)
        Me.designBtn.Name = "designBtn"
        Me.designBtn.Size = New System.Drawing.Size(110, 23)
        Me.designBtn.TabIndex = 6
        Me.designBtn.Text = "View Designs"
        Me.designBtn.UseVisualStyleBackColor = True
        '
        'revCompBtn
        '
        Me.revCompBtn.Location = New System.Drawing.Point(140, 81)
        Me.revCompBtn.Name = "revCompBtn"
        Me.revCompBtn.Size = New System.Drawing.Size(121, 23)
        Me.revCompBtn.TabIndex = 7
        Me.revCompBtn.Text = "Revise Components"
        Me.revCompBtn.UseVisualStyleBackColor = True
        '
        'relDesBtn
        '
        Me.relDesBtn.Location = New System.Drawing.Point(267, 52)
        Me.relDesBtn.Name = "relDesBtn"
        Me.relDesBtn.Size = New System.Drawing.Size(121, 23)
        Me.relDesBtn.TabIndex = 8
        Me.relDesBtn.Text = "Release Designs"
        Me.relDesBtn.UseVisualStyleBackColor = True
        '
        'revDesBtn
        '
        Me.revDesBtn.Location = New System.Drawing.Point(267, 81)
        Me.revDesBtn.Name = "revDesBtn"
        Me.revDesBtn.Size = New System.Drawing.Size(121, 23)
        Me.revDesBtn.TabIndex = 9
        Me.revDesBtn.Text = "Revise Designs"
        Me.revDesBtn.UseVisualStyleBackColor = True
        '
        'librarianHub
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
        Me.Controls.Add(Me.Label1)
        Me.Name = "librarianHub"
        Me.Size = New System.Drawing.Size(408, 158)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents requestBtn As System.Windows.Forms.Button
    Friend WithEvents relCompBtn As System.Windows.Forms.Button
    Friend WithEvents compBtn As System.Windows.Forms.Button
    Friend WithEvents designBtn As System.Windows.Forms.Button
    Friend WithEvents revCompBtn As System.Windows.Forms.Button
    Friend WithEvents relDesBtn As System.Windows.Forms.Button
    Friend WithEvents revDesBtn As System.Windows.Forms.Button

End Class
