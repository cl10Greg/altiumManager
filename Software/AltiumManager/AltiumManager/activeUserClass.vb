Public Class activeUserClass
    Private pUserName As String
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
End Class
