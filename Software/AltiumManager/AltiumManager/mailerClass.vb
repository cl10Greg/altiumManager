Imports System.Net.Mail
Public Class mailerClass
    Dim mail As New MailMessage

    Public Sub sendPassword(tempAddress As String, tempSubject As String, tempBody As String)
        Dim smtpServer As New SmtpClient
        smtpServer.Credentials = New Net.NetworkCredential("checkcorpaltiummanager@gmail.com", "checkPass00")
        smtpServer.Port = 587
        smtpServer.Host = "smtp.gmail.com"
        smtpServer.EnableSsl = True

        mail = New MailMessage

        Try
            mail.From = New MailAddress("checkcorpaltiummanager@gmail.com", "Altium Admin", System.Text.Encoding.UTF8)
            mail.To.Add(tempAddress)
            mail.Subject = tempSubject
            mail.Body = tempBody
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
            mail.ReplyToList.Add(tempAddress)
            smtpServer.Send(mail)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
End Class
