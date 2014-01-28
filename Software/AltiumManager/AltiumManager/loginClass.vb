Imports System.Text

Public Class loginClass
    Private pUserName As String
    Private pUserPass As String

    Public Property userName() As String
        Get
            Return pUserName
        End Get
        Set(value As String)
            pUserName = value
        End Set
    End Property

    Public Property userPass() As String
        Get
            Return pUserPass
        End Get
        Set(value As String)
            pUserPass = value
        End Set
    End Property

    Public Function checkData() As Boolean
        If pUserName = "" Or pUserPass = "" Then
            MsgBox("Data is missing")
            Return False
        Else
            Return True
        End If
    End Function

    Public Function userAvailable(tempData As AltiumDatabaseDataSet.UsersDataTable, tempAdapter As AltiumDatabaseDataSetTableAdapters.UsersTableAdapter) As Boolean
        'Dim tempAdapter As New AltiumDatabaseDataSetTableAdapters.UsersTableAdapter
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

    Public Function randomPass() As String
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 8
            Dim idx As Int16 = r.Next(0, s.Length())
            sb.Append(s.Substring(idx, 1))
        Next

        Return sb.ToString
    End Function
End Class
