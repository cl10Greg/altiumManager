<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginCtrl
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
        Me.userTxt = New System.Windows.Forms.TextBox()
        Me.passTxt = New System.Windows.Forms.TextBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.AltiumDatabaseDataSet = New AltiumManager.AltiumDatabaseDataSet()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New AltiumManager.AltiumDatabaseDataSetTableAdapters.UsersTableAdapter()
        Me.TableAdapterManager = New AltiumManager.AltiumDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.forgotBtn = New System.Windows.Forms.Button()
        CType(Me.AltiumDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'userTxt
        '
        Me.userTxt.Location = New System.Drawing.Point(78, 11)
        Me.userTxt.Name = "userTxt"
        Me.userTxt.Size = New System.Drawing.Size(173, 20)
        Me.userTxt.TabIndex = 2
        '
        'passTxt
        '
        Me.passTxt.Location = New System.Drawing.Point(78, 41)
        Me.passTxt.Name = "passTxt"
        Me.passTxt.Size = New System.Drawing.Size(173, 20)
        Me.passTxt.TabIndex = 3
        Me.passTxt.UseSystemPasswordChar = True
        '
        'loginBtn
        '
        Me.loginBtn.Location = New System.Drawing.Point(3, 67)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(75, 23)
        Me.loginBtn.TabIndex = 4
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(84, 67)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(65, 23)
        Me.clearBtn.TabIndex = 5
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
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
        'forgotBtn
        '
        Me.forgotBtn.Location = New System.Drawing.Point(155, 67)
        Me.forgotBtn.Name = "forgotBtn"
        Me.forgotBtn.Size = New System.Drawing.Size(96, 23)
        Me.forgotBtn.TabIndex = 7
        Me.forgotBtn.Text = "Forgot Password"
        Me.forgotBtn.UseVisualStyleBackColor = True
        '
        'loginCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.forgotBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.passTxt)
        Me.Controls.Add(Me.userTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "loginCtrl"
        Me.Size = New System.Drawing.Size(282, 104)
        CType(Me.AltiumDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents userTxt As System.Windows.Forms.TextBox
    Friend WithEvents passTxt As System.Windows.Forms.TextBox
    Friend WithEvents loginBtn As System.Windows.Forms.Button
    Friend WithEvents clearBtn As System.Windows.Forms.Button
    Friend WithEvents AltiumDatabaseDataSet As AltiumManager.AltiumDatabaseDataSet
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsersTableAdapter As AltiumManager.AltiumDatabaseDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents TableAdapterManager As AltiumManager.AltiumDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents forgotBtn As System.Windows.Forms.Button

End Class
