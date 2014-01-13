Imports System.Data.SqlServerCe
Public Class checkLogin



    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim connStr As New SqlCeConnection("Data Source=C:\Users\ggirard\Desktop\GitHub\altiumManager\Software\Altium Manager\Database\altiumCheck.sdf; Password=L2glub75!")
        Dim allData As New SqlCeCommand("SELECT * From USERS", connStr)
        Dim reader As SqlCeDataReader
        Dim curItem As String

        connStr.Open()

        reader = allData.ExecuteReader

        While reader.Read
            curItem = reader.Item("userName".ToString)
            MsgBox(curItem)

        End While

        connStr.Close()


        'Check for valid input
        'Check if valid
        'Send back to main form
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        'Clear all data

        Me.Close()
    End Sub

End Class
