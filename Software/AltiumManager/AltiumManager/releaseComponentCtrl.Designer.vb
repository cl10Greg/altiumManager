<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class releaseComponentCtrl
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
        Me.releaseGrid = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchTxt = New System.Windows.Forms.TextBox()
        Me.searchBtn = New System.Windows.Forms.Button()
        CType(Me.releaseGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'releaseGrid
        '
        Me.releaseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.releaseGrid.Location = New System.Drawing.Point(15, 19)
        Me.releaseGrid.Name = "releaseGrid"
        Me.releaseGrid.Size = New System.Drawing.Size(1048, 331)
        Me.releaseGrid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 368)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search:"
        '
        'searchTxt
        '
        Me.searchTxt.Location = New System.Drawing.Point(62, 365)
        Me.searchTxt.Name = "searchTxt"
        Me.searchTxt.Size = New System.Drawing.Size(219, 20)
        Me.searchTxt.TabIndex = 2
        '
        'searchBtn
        '
        Me.searchBtn.Location = New System.Drawing.Point(287, 365)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(75, 23)
        Me.searchBtn.TabIndex = 3
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = True
        '
        'releaseComponentCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.searchTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.releaseGrid)
        Me.Name = "releaseComponentCtrl"
        Me.Size = New System.Drawing.Size(1092, 621)
        CType(Me.releaseGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents releaseGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents searchTxt As System.Windows.Forms.TextBox
    Friend WithEvents searchBtn As System.Windows.Forms.Button

End Class
