Public Class loginCtrl

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim loginObj As New loginClass
        Dim userObj As New activeUserClass

        loginObj.userName = LCase(userTxt.Text)
        loginObj.userPass = passTxt.Text

        'Check to make sure all the data is filled in
        If loginObj.checkData Then
            'Check the username exist
            'Get the newest data from the database
            If Not loginObj.userAvailable(Me.AltiumDatabaseDataSet.Users, Me.UsersTableAdapter) Then
                Dim foundRow() As AltiumDatabaseDataSet.UsersRow
                foundRow = Me.AltiumDatabaseDataSet.Users.Select("Username = '" & loginObj.userName & "'")

                Dim encPass As String = foundRow(0).UserPass
                Dim wrapper As New Simple3Des(loginObj.userPass)

                Try
                    Dim decPass As String = wrapper.decryptData(encPass)

                    Dim tempRole As String = foundRow(0).UserRole
                    MsgBox("Logged in as " & Trim(tempRole))

                    'Clear controls
                    mainFrm.contentPanel.Controls.Clear()

                    'Set user attributes
                    userObj.userName = loginObj.userName
                    userObj.userRole = Trim(tempRole)
                    userObj.userEmail = foundRow(0).UserEmail

                    mainFrm.setUserObj(userObj)
                Catch ex As System.Security.Cryptography.CryptographicException
                    MsgBox("Incorrect password")
                End Try
            Else
                MsgBox("User not found")
            End If

        End If

    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        passTxt.Clear()
        userTxt.Clear()
    End Sub

    Private Sub forgotBtn_Click(sender As Object, e As EventArgs) Handles forgotBtn.Click
        Dim loginObj As New loginClass
        Dim tempMail As New mailerClass
        Dim newPass As String


        loginObj.userName = userTxt.Text
        'Check that the username is filled out and exist
        If loginObj.userName = "" Then
            MsgBox("Please enter the username")
        Else
            If Not loginObj.userAvailable(Me.AltiumDatabaseDataSet.Users, Me.UsersTableAdapter) Then
                'Create the new password
                newPass = loginObj.randomPass

                'Find the userrow
                Dim foundRow() As AltiumDatabaseDataSet.UsersRow
                foundRow = Me.AltiumDatabaseDataSet.Users.Select("Username = '" & loginObj.userName & "'")

                'Write the new password to the database (encrypted)
                Dim wrapper As New Simple3Des(newPass)
                Dim encPass As String = wrapper.encryptData("text")

                foundRow(0).UserPass = encPass
                Me.UsersTableAdapter.Update(Me.AltiumDatabaseDataSet.Users)
                'find the user email

                'email to the user
                tempMail.sendPassword(Trim(foundRow(0).UserEmail), "Password Reset", newPass)

                MsgBox("A new password has been sent to the email on file.  Please login and with the new password and use the change password action under user.")

            Else
                MsgBox("User doesn't exist")
            End If

        End If

    End Sub

    Private Sub passTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles passTxt.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            loginBtn.PerformClick()
        End If
    End Sub
End Class
