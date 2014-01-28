Public Class changePassCtrl
    Private pUserObj As activeUserClass
    Private Sub changeBtn_Click(sender As Object, e As EventArgs) Handles changeBtn.Click
        'Create a new login object to check to see if the user exit
        Dim loginObj As New loginClass
        'Set the login name to the active user name
        loginObj.userName = pUserObj.userName
        'Check to make sure all fields are filled out
        If currPassTxt.Text = "" Or newPassTxt.Text = "" Then
            MsgBox("Please fill out the boxes")
        Else
            'Find the user
            If Not loginObj.userAvailable(Me.AltiumDatabaseDataSet.Users, Me.UsersTableAdapter) Then
                Dim foundRow() As AltiumDatabaseDataSet.UsersRow
                'Gets the row number where the username was found
                foundRow = Me.AltiumDatabaseDataSet.Users.Select("Username = '" & loginObj.userName & "'")

                'Get the password
                Dim encPass As String = foundRow(0).UserPass
                'make a new object to decrypt the password
                Dim wrapper As New Simple3Des(currPassTxt.Text)

                'Check to see if password is right after decryption
                Try
                    'Decrypt the password
                    Dim decPass As String = wrapper.decryptData(encPass)

                    'Make the new password and encrypt
                    Dim tempWrapper As New Simple3Des(newPassTxt.Text)
                    Dim newEncPass As String = tempWrapper.encryptData("text")

                    'Write the new password
                    foundRow(0).UserPass = newEncPass
                    Me.UsersTableAdapter.Update(Me.AltiumDatabaseDataSet.Users)

                    MsgBox("Password has been changed. Logging out")
                    mainFrm.LogoutToolStripMenuItem.PerformClick()
                Catch ex As System.Security.Cryptography.CryptographicException
                    MsgBox("Incorrect password")
                End Try
            Else
                MsgBox("User not found")
            End If

        End If
    End Sub

    Public Sub getActiveUser(tempUser As activeUserClass)
        pUserObj = tempUser
    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AltiumDatabaseDataSet)

    End Sub
End Class
