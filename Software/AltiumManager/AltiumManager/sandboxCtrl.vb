Public Class sandboxCtrl
    Private pUser As activeUserClass
    Public Sub receiveUser(tempUser As activeUserClass)
        pUser = tempUser
        designerTxt.Text = pUser.userName
    End Sub
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim sandObj As New sandBoxPart

        sandObj.checkNumber = checkTxt.Text
        sandObj.Manufacturer = mfgTxt.Text
        sandObj.ManufacturerPartNumber = mfgPNTxt.Text
        sandObj.componentType = typeCmb.Text
        sandObj.description = desTxt.Text
        sandObj.designer = designerTxt.Text
        sandObj.designDate = designDateTxt.Text
        sandObj.status = statusCmb.Text
        sandObj.location = locTxt.Text
        sandObj.notes = notesTxt.Text

        Dim tempRow As AltiumDatabaseDataSet.SandboxComponentsRow
        tempRow = Me.AltiumDatabaseDataSet.SandboxComponents.NewSandboxComponentsRow

        tempRow.CheckPN = sandObj.checkNumber
        tempRow.MFG = sandObj.Manufacturer
        tempRow.MFGPN = sandObj.ManufacturerPartNumber
        tempRow.Type = sandObj.componentType
        tempRow.Description = sandObj.description
        tempRow.Designer = sandObj.designer
        tempRow.DesignDate = sandObj.designDate
        tempRow.Status = sandObj.status
        tempRow.Location = sandObj.location
        tempRow.Notes = sandObj.notes

        Try
            Me.AltiumDatabaseDataSet.SandboxComponents.AddSandboxComponentsRow(tempRow)
            Me.SandboxComponentsTableAdapter.Update(Me.AltiumDatabaseDataSet.SandboxComponents)
            MsgBox("Component added")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        Dim sandObj As New sandBoxPart
        sandObj.clearData(Me)
    End Sub

    Private Sub locBtn_Click(sender As Object, e As EventArgs) Handles locBtn.Click
        'Get the file location prompt

    End Sub

    Private Sub sandboxCtrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
