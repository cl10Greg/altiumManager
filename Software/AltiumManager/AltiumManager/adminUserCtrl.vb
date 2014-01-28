Public Class adminUserCtrl
    Private pCurrRow As Integer

    Private Sub adminUserCtrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UsersTableAdapter.Fill(Me.AltiumDatabaseDataSet.Users)
        UsersDataGridView.DataSource = Me.AltiumDatabaseDataSet.Users
    End Sub

    Private Sub UsersDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersDataGridView.CellContentClick
        nameTxt.Text = Trim(UsersDataGridView.Rows(e.RowIndex).Cells(1).Value)
        passTxt.Text = Trim(UsersDataGridView.Rows(e.RowIndex).Cells(2).Value)
        roleTxt.Text = Trim(UsersDataGridView.Rows(e.RowIndex).Cells(3).Value)
        emailTxt.Text = Trim(UsersDataGridView.Rows(e.RowIndex).Cells(4).Value)
        pCurrRow = e.RowIndex
    End Sub

    Private Sub updateTxt_Click(sender As Object, e As EventArgs) Handles updateTxt.Click
        Dim tempRow As AltiumDatabaseDataSet.UsersRow
        tempRow = Me.AltiumDatabaseDataSet.Users.Rows(pCurrRow)

        If nameTxt.Text = "" Or passTxt.Text = "" Or roleTxt.Text = "" Or emailTxt.Text = "" Then
            MsgBox("Missing information for update (can't have any empty spaces)")
        Else
            tempRow.UserName = nameTxt.Text

            tempRow.UserRole = roleTxt.Text
            tempRow.UserEmail = emailTxt.Text

            Me.UsersTableAdapter.Update(Me.AltiumDatabaseDataSet)

            'Find row

            'Update row

            'if password changed, encrypt
            Me.UsersTableAdapter.Fill(Me.AltiumDatabaseDataSet.Users)
            UsersDataGridView.DataSource = Me.AltiumDatabaseDataSet.Users
            MsgBox("Changes saved")
        End If
        

    End Sub
End Class
