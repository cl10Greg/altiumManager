Imports System.Text.RegularExpressions
Public Class newUserClass
    Private pUserName As String
    Private pUserPass As String
    Private pUserRole As String
    Private pUserEmail As String

    Public Property userName() As String
        Get
            Return pUserName
        End Get
        Set(value As String)
            pUserName = value
        End Set
    End Property

    Public Property userPassword() As String
        Get
            Return pUserPass
        End Get
        Set(value As String)
            pUserPass = value
        End Set
    End Property

    Public Property userRole() As String
        Get
            Return pUserRole
        End Get
        Set(value As String)
            pUserRole = value
        End Set
    End Property

    Public Property userEmail() As String
        Get
            Return pUserEmail
        End Get
        Set(value As String)
            pUserEmail = value
        End Set
    End Property

    Public Function checkAllData() As Boolean
        If pUserName = "" Or pUserPass = "" Or pUserRole = "" Or pUserEmail = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function userAvailable(tempData As AltiumDatabaseDataSet.UsersDataTable) As Boolean
        Dim tempAdapter As New AltiumDatabaseDataSetTableAdapters.UsersTableAdapter
        Dim tempRow() As DataRow

        tempAdapter.Fill(tempData)
        tempRow = tempData.Select("Username = '" & pUserName & "'")
        'tempRow is 0 if the user is not found
        If tempRow.Length = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function checkEmail() As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailMatch As Match = Regex.Match(pUserEmail, pattern)
        If emailMatch.Success Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
