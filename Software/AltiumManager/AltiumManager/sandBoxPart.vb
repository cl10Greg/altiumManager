Public Class sandBoxPart
    Private pCheck As String
    Private pMFG As String
    Private pMPN As String
    Private pType As String
    Private pDescription As String
    Private pDesigner As String
    Private pDesDate As String
    Private pStatus As String
    Private pLoc As String
    Private pNotes As String

    Public Property checkNumber() As String
        Get
            Return pCheck
        End Get
        Set(value As String)
            pCheck = value
        End Set
    End Property

    Public Property Manufacturer() As String
        Get
            Return pMFG
        End Get
        Set(value As String)
            pMFG = value
        End Set
    End Property

    Public Property ManufacturerPartNumber() As String
        Get
            Return pMPN
        End Get
        Set(value As String)
            pMPN = value
        End Set
    End Property

    Public Property componentType() As String
        Get
            Return pType
        End Get
        Set(value As String)
            pType = value
        End Set
    End Property

    Public Property description() As String
        Get
            Return pDescription
        End Get
        Set(value As String)
            pDescription = value
        End Set
    End Property

    Public Property designer() As String
        Get
            Return pDesigner
        End Get
        Set(value As String)
            pDesigner = value
        End Set
    End Property

    Public Property designDate() As String
        Get
            Return pDesDate
        End Get
        Set(value As String)
            pDesDate = value
        End Set
    End Property

    Public Property status() As String
        Get
            Return pStatus
        End Get
        Set(value As String)
            pStatus = value
        End Set
    End Property

    Public Property location() As String
        Get
            Return pLoc
        End Get
        Set(value As String)
            pLoc = value
        End Set
    End Property

    Public Property notes() As String
        Get
            Return pNotes
        End Get
        Set(value As String)
            pNotes = value
        End Set
    End Property

    Public Function checkData(tempSand As sandboxCtrl) As Boolean
        Dim tempControl As Control

        For Each tempControl In tempSand.Controls
            If (tempControl.GetType() Is GetType(TextBox)) Or (tempControl.GetType() Is GetType(ComboBox)) Or (tempControl.GetType() Is GetType(DateTimePicker)) Then
                Dim tempText As String = tempControl.Text
                If tempText = "" Then
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    Public Sub clearData(tempSand As sandboxCtrl)
        Dim tempControl As Control

        For Each tempControl In tempSand.Controls
            If (tempControl.GetType() Is GetType(TextBox)) Or (tempControl.GetType() Is GetType(ComboBox)) Or (tempControl.GetType() Is GetType(DateTimePicker)) Then
                tempControl.Text = ""
            End If
        Next
    End Sub

End Class
