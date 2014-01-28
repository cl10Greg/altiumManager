<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class designerHub
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
        Me.releasebtn = New System.Windows.Forms.Button()
        Me.sandboxBtn = New System.Windows.Forms.Button()
        Me.revBtn = New System.Windows.Forms.Button()
        Me.designRelBtn = New System.Windows.Forms.Button()
        Me.designRevBtn = New System.Windows.Forms.Button()
        Me.requestBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Designer Hub"
        '
        'releasebtn
        '
        Me.releasebtn.Location = New System.Drawing.Point(19, 51)
        Me.releasebtn.Name = "releasebtn"
        Me.releasebtn.Size = New System.Drawing.Size(136, 23)
        Me.releasebtn.TabIndex = 1
        Me.releasebtn.Text = "Component Release"
        Me.releasebtn.UseVisualStyleBackColor = True
        '
        'sandboxBtn
        '
        Me.sandboxBtn.Location = New System.Drawing.Point(84, 109)
        Me.sandboxBtn.Name = "sandboxBtn"
        Me.sandboxBtn.Size = New System.Drawing.Size(189, 23)
        Me.sandboxBtn.TabIndex = 2
        Me.sandboxBtn.Text = "Sandbox Component Creation"
        Me.sandboxBtn.UseVisualStyleBackColor = True
        '
        'revBtn
        '
        Me.revBtn.Location = New System.Drawing.Point(19, 80)
        Me.revBtn.Name = "revBtn"
        Me.revBtn.Size = New System.Drawing.Size(136, 23)
        Me.revBtn.TabIndex = 3
        Me.revBtn.Text = "Component Revision"
        Me.revBtn.UseVisualStyleBackColor = True
        '
        'designRelBtn
        '
        Me.designRelBtn.Location = New System.Drawing.Point(161, 51)
        Me.designRelBtn.Name = "designRelBtn"
        Me.designRelBtn.Size = New System.Drawing.Size(136, 23)
        Me.designRelBtn.TabIndex = 4
        Me.designRelBtn.Text = "Design Release"
        Me.designRelBtn.UseVisualStyleBackColor = True
        '
        'designRevBtn
        '
        Me.designRevBtn.Location = New System.Drawing.Point(161, 80)
        Me.designRevBtn.Name = "designRevBtn"
        Me.designRevBtn.Size = New System.Drawing.Size(136, 23)
        Me.designRevBtn.TabIndex = 5
        Me.designRevBtn.Text = "Design Revision"
        Me.designRevBtn.UseVisualStyleBackColor = True
        '
        'requestBtn
        '
        Me.requestBtn.Location = New System.Drawing.Point(303, 51)
        Me.requestBtn.Name = "requestBtn"
        Me.requestBtn.Size = New System.Drawing.Size(136, 23)
        Me.requestBtn.TabIndex = 6
        Me.requestBtn.Text = "View Requests"
        Me.requestBtn.UseVisualStyleBackColor = True
        '
        'designerHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.requestBtn)
        Me.Controls.Add(Me.designRevBtn)
        Me.Controls.Add(Me.designRelBtn)
        Me.Controls.Add(Me.revBtn)
        Me.Controls.Add(Me.sandboxBtn)
        Me.Controls.Add(Me.releasebtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "designerHub"
        Me.Size = New System.Drawing.Size(499, 150)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents releasebtn As System.Windows.Forms.Button
    Friend WithEvents sandboxBtn As System.Windows.Forms.Button
    Friend WithEvents revBtn As System.Windows.Forms.Button
    Friend WithEvents designRelBtn As System.Windows.Forms.Button
    Friend WithEvents designRevBtn As System.Windows.Forms.Button
    Friend WithEvents requestBtn As System.Windows.Forms.Button

End Class
