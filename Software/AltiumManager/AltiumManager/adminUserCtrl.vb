Public Class adminUserCtrl

    Private Sub adminUserCtrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UsersTableAdapter.Fill(Me.AltiumDatabaseDataSet.Users)
        UsersDataGridView.DataSource = Me.AltiumDatabaseDataSet.Users
    End Sub

    Private Sub UsersDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersDataGridView.CellContentClick
        nameTxt.Text = Trim(UsersDataGridView.Rows(e.RowIndex).Cells(1).Value)
        passTxt.Text = Trim(UsersDataGridView.Rows(e.RowIndex).Cells(2).Value)
        roleTxt.Text = Trim(UsersDataGridView.Rows(e.RowIndex).Cells(3).Value)
        emailTxt.Text = Trim(UsersDataGridView.Rows(e.RowIndex).Cells(4).Value)
    End Sub

    Private Sub updateTxt_Click(sender As Object, e As EventArgs) Handles updateTxt.Click
        'Find row

        'Update row

        'if password changed, encrypt
        MsgBox("Changes saved")

    End Sub
End Class
