<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminUserCtrl
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
        Me.AltiumDatabaseDataSet = New AltiumManager.AltiumDatabaseDataSet()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New AltiumManager.AltiumDatabaseDataSetTableAdapters.UsersTableAdapter()
        Me.TableAdapterManager = New AltiumManager.AltiumDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.UsersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nameTxt = New System.Windows.Forms.TextBox()
        Me.passTxt = New System.Windows.Forms.TextBox()
        Me.roleTxt = New System.Windows.Forms.TextBox()
        Me.emailTxt = New System.Windows.Forms.TextBox()
        Me.updateTxt = New System.Windows.Forms.Button()
        CType(Me.AltiumDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'UsersDataGridView
        '
        Me.UsersDataGridView.AutoGenerateColumns = False
        Me.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.UsersDataGridView.DataSource = Me.UsersBindingSource
        Me.UsersDataGridView.Location = New System.Drawing.Point(19, 12)
        Me.UsersDataGridView.Name = "UsersDataGridView"
        Me.UsersDataGridView.Size = New System.Drawing.Size(562, 220)
        Me.UsersDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "UserId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "UserId"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "UserName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "UserName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "UserPass"
        Me.DataGridViewTextBoxColumn3.HeaderText = "UserPass"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UserRole"
        Me.DataGridViewTextBoxColumn4.HeaderText = "UserRole"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UserEmail"
        Me.DataGridViewTextBoxColumn5.HeaderText = "UserEmail"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "UserName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "UserPass:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "UserRole:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "UserEmail:"
        '
        'nameTxt
        '
        Me.nameTxt.Location = New System.Drawing.Point(97, 243)
        Me.nameTxt.Name = "nameTxt"
        Me.nameTxt.Size = New System.Drawing.Size(184, 20)
        Me.nameTxt.TabIndex = 6
        '
        'passTxt
        '
        Me.passTxt.Location = New System.Drawing.Point(97, 270)
        Me.passTxt.Name = "passTxt"
        Me.passTxt.Size = New System.Drawing.Size(184, 20)
        Me.passTxt.TabIndex = 7
        '
        'roleTxt
        '
        Me.roleTxt.Location = New System.Drawing.Point(97, 294)
        Me.roleTxt.Name = "roleTxt"
        Me.roleTxt.Size = New System.Drawing.Size(184, 20)
        Me.roleTxt.TabIndex = 8
        '
        'emailTxt
        '
        Me.emailTxt.Location = New System.Drawing.Point(97, 320)
        Me.emailTxt.Name = "emailTxt"
        Me.emailTxt.Size = New System.Drawing.Size(184, 20)
        Me.emailTxt.TabIndex = 9
        '
        'updateTxt
        '
        Me.updateTxt.Location = New System.Drawing.Point(303, 287)
        Me.updateTxt.Name = "updateTxt"
        Me.updateTxt.Size = New System.Drawing.Size(75, 23)
        Me.updateTxt.TabIndex = 10
        Me.updateTxt.Text = "Update"
        Me.updateTxt.UseVisualStyleBackColor = True
        '
        'adminUserCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.updateTxt)
        Me.Controls.Add(Me.emailTxt)
        Me.Controls.Add(Me.roleTxt)
        Me.Controls.Add(Me.passTxt)
        Me.Controls.Add(Me.nameTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UsersDataGridView)
        Me.Name = "adminUserCtrl"
        Me.Size = New System.Drawing.Size(599, 351)
        CType(Me.AltiumDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AltiumDatabaseDataSet As AltiumManager.AltiumDatabaseDataSet
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsersTableAdapter As AltiumManager.AltiumDatabaseDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents TableAdapterManager As AltiumManager.AltiumDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nameTxt As System.Windows.Forms.TextBox
    Friend WithEvents passTxt As System.Windows.Forms.TextBox
    Friend WithEvents roleTxt As System.Windows.Forms.TextBox
    Friend WithEvents emailTxt As System.Windows.Forms.TextBox
    Friend WithEvents updateTxt As System.Windows.Forms.Button

End Class
