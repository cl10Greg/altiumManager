<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewerHub
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
        Me.compBtn = New System.Windows.Forms.Button()
        Me.designBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Viewer Hub"
        '
        'compBtn
        '
        Me.compBtn.Location = New System.Drawing.Point(82, 51)
        Me.compBtn.Name = "compBtn"
        Me.compBtn.Size = New System.Drawing.Size(105, 23)
        Me.compBtn.TabIndex = 2
        Me.compBtn.Text = "View Components"
        Me.compBtn.UseVisualStyleBackColor = True
        '
        'designBtn
        '
        Me.designBtn.Location = New System.Drawing.Point(82, 80)
        Me.designBtn.Name = "designBtn"
        Me.designBtn.Size = New System.Drawing.Size(105, 23)
        Me.designBtn.TabIndex = 3
        Me.designBtn.Text = "View Design"
        Me.designBtn.UseVisualStyleBackColor = True
        '
        'viewerHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.designBtn)
        Me.Controls.Add(Me.compBtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "viewerHub"
        Me.Size = New System.Drawing.Size(254, 124)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents compBtn As System.Windows.Forms.Button
    Friend WithEvents designBtn As System.Windows.Forms.Button

End Class
