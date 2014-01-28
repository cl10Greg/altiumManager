<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newUserCtrl
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.userTxt = New System.Windows.Forms.TextBox()
        Me.passTxt = New System.Windows.Forms.TextBox()
        Me.emailTxt = New System.Windows.Forms.TextBox()
        Me.roleCmb = New System.Windows.Forms.ComboBox()
        Me.createBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
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
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Role:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email:"
        '
        'userTxt
        '
        Me.userTxt.Location = New System.Drawing.Point(76, 7)
        Me.userTxt.Name = "userTxt"
        Me.userTxt.Size = New System.Drawing.Size(202, 20)
        Me.userTxt.TabIndex = 4
        '
        'passTxt
        '
        Me.passTxt.Location = New System.Drawing.Point(76, 41)
        Me.passTxt.Name = "passTxt"
        Me.passTxt.Size = New System.Drawing.Size(202, 20)
        Me.passTxt.TabIndex = 5
        Me.passTxt.UseSystemPasswordChar = True
        '
        'emailTxt
        '
        Me.emailTxt.Location = New System.Drawing.Point(76, 110)
        Me.emailTxt.Name = "emailTxt"
        Me.emailTxt.Size = New System.Drawing.Size(202, 20)
        Me.emailTxt.TabIndex = 7
        '
        'roleCmb
        '
        Me.roleCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.roleCmb.FormattingEnabled = True
        Me.roleCmb.Items.AddRange(New Object() {"Administrator", "Librarian", "Designer", "Viewer", "Other"})
        Me.roleCmb.Location = New System.Drawing.Point(76, 73)
        Me.roleCmb.Name = "roleCmb"
        Me.roleCmb.Size = New System.Drawing.Size(202, 21)
        Me.roleCmb.TabIndex = 6
        '
        'createBtn
        '
        Me.createBtn.Location = New System.Drawing.Point(76, 149)
        Me.createBtn.Name = "createBtn"
        Me.createBtn.Size = New System.Drawing.Size(75, 23)
        Me.createBtn.TabIndex = 8
        Me.createBtn.Text = "Create"
        Me.createBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(157, 149)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(75, 23)
        Me.clearBtn.TabIndex = 9
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
        'newUserCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.createBtn)
        Me.Controls.Add(Me.roleCmb)
        Me.Controls.Add(Me.emailTxt)
        Me.Controls.Add(Me.passTxt)
        Me.Controls.Add(Me.userTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "newUserCtrl"
        Me.Size = New System.Drawing.Size(299, 179)
        CType(Me.AltiumDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents userTxt As System.Windows.Forms.TextBox
    Friend WithEvents passTxt As System.Windows.Forms.TextBox
    Friend WithEvents emailTxt As System.Windows.Forms.TextBox
    Friend WithEvents roleCmb As System.Windows.Forms.ComboBox
    Friend WithEvents createBtn As System.Windows.Forms.Button
    Friend WithEvents clearBtn As System.Windows.Forms.Button
    Friend WithEvents AltiumDatabaseDataSet As AltiumManager.AltiumDatabaseDataSet
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsersTableAdapter As AltiumManager.AltiumDatabaseDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents TableAdapterManager As AltiumManager.AltiumDatabaseDataSetTableAdapters.TableAdapterManager

End Class
