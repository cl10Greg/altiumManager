<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changePassCtrl
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.currPassTxt = New System.Windows.Forms.TextBox()
        Me.newPassTxt = New System.Windows.Forms.TextBox()
        Me.changeBtn = New System.Windows.Forms.Button()
        Me.AltiumDatabaseDataSet = New AltiumManager.AltiumDatabaseDataSet()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New AltiumManager.AltiumDatabaseDataSetTableAdapters.UsersTableAdapter()
        Me.TableAdapterManager = New AltiumManager.AltiumDatabaseDataSetTableAdapters.TableAdapterManager()
        CType(Me.AltiumDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New Password:"
        '
        'currPassTxt
        '
        Me.currPassTxt.Location = New System.Drawing.Point(113, 6)
        Me.currPassTxt.Name = "currPassTxt"
        Me.currPassTxt.Size = New System.Drawing.Size(135, 20)
        Me.currPassTxt.TabIndex = 2
        Me.currPassTxt.UseSystemPasswordChar = True
        '
        'newPassTxt
        '
        Me.newPassTxt.Location = New System.Drawing.Point(113, 31)
        Me.newPassTxt.Name = "newPassTxt"
        Me.newPassTxt.Size = New System.Drawing.Size(135, 20)
        Me.newPassTxt.TabIndex = 3
        Me.newPassTxt.UseSystemPasswordChar = True
        '
        'changeBtn
        '
        Me.changeBtn.Location = New System.Drawing.Point(97, 57)
        Me.changeBtn.Name = "changeBtn"
        Me.changeBtn.Size = New System.Drawing.Size(75, 23)
        Me.changeBtn.TabIndex = 4
        Me.changeBtn.Text = "Change"
        Me.changeBtn.UseVisualStyleBackColor = True
        '
        'AltiumDatabaseDataSet
        '
        Me.AltiumDatabaseDataSet.DataSetName = "AltiumDatabaseDataSet"
        Me.AltiumDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.AltiumDatabaseDataSet
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = AltiumManager.AltiumDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Me.UsersTableAdapter
        '
        'changePassCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.changeBtn)
        Me.Controls.Add(Me.newPassTxt)
        Me.Controls.Add(Me.currPassTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "changePassCtrl"
        Me.Size = New System.Drawing.Size(265, 89)
        CType(Me.AltiumDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents currPassTxt As System.Windows.Forms.TextBox
    Friend WithEvents newPassTxt As System.Windows.Forms.TextBox
    Friend WithEvents changeBtn As System.Windows.Forms.Button
    Friend WithEvents AltiumDatabaseDataSet As AltiumManager.AltiumDatabaseDataSet
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsersTableAdapter As AltiumManager.AltiumDatabaseDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents TableAdapterManager As AltiumManager.AltiumDatabaseDataSetTableAdapters.TableAdapterManager

End Class
