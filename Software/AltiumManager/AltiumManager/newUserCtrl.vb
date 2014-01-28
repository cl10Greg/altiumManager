Public Class newUserCtrl

    Private Sub createBtn_Click(sender As Object, e As EventArgs) Handles createBtn.Click
        Dim tempUser As New newUserClass
        Dim temprow As AltiumDatabaseDataSet.UsersRow



        'Add all data to object
        tempUser.userName = userTxt.Text
        tempUser.userPassword = passTxt.Text
        tempUser.userRole = roleCmb.Text
        tempUser.userEmail = emailTxt.Text

        

        'Check to make sure all the data is filled out
        If tempUser.checkAllData Then
            'Check to see if the user is available
            If tempUser.userAvailable(Me.AltiumDatabaseDataSet.Users) Then

                'Check to see if the email format is correct
                If tempUser.checkEmail Then

                    'Create encryption item
                    Dim wrapper As New Simple3Des(tempUser.userPassword)
                    Dim encPass As String = wrapper.encryptData("text")

                    'Get the newest data from the database
                    Me.UsersTableAdapter.Fill(Me.AltiumDatabaseDataSet.Users)

                    'Create a new row
                    temprow = Me.AltiumDatabaseDataSet.Users.NewUsersRow

                    'Add values to the new row
                    temprow.UserName = LCase(tempUser.userName)
                    temprow.UserPass = encPass
                    temprow.UserRole = tempUser.userRole
                    temprow.UserEmail = tempUser.userEmail

                    'Add new row to the table
                    Me.AltiumDatabaseDataSet.Users.AddUsersRow(temprow)

                    'Push the table to the database
                    Me.UsersTableAdapter.Update(Me.AltiumDatabaseDataSet.Users)

                    MsgBox("User created")

                Else
                    MsgBox("Email is not in the correct format")
                End If

            Else
                MsgBox("User Taken")
            End If

        Else
            MsgBox("Information is missing.  Please fill out all the information.")

        End If
        'Create a newUserObject
        'Check Data
        'Check to see if username exist
        'Add to database
        'If anything above designer, get approval
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        userTxt.Clear()
        passTxt.Clear()
        roleCmb.Text = ""
        emailTxt.Clear()

    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AltiumDatabaseDataSet)

    End Sub

    Private Sub newUserCtrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userTxt.Focus()
        roleCmb.SelectedIndex = 2
    End Sub
End Class
