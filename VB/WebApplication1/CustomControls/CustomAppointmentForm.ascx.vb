Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.XtraScheduler
Imports DevExpress.Web.ASPxUploadControl
Imports DevExpress.Web.ASPxClasses.Internal
Imports System.IO

Namespace WebApplication1.CustomControls
    Partial Public Class CustomAppointmentForm
        Inherits System.Web.UI.UserControl

        Private Const UploadDirectory As String = "~/Images/"
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Public Overrides Sub DataBind()
            MyBase.DataBind()
            Dim container As CustomAppointmentFormTemplateContainer = CType(Parent, CustomAppointmentFormTemplateContainer)
            ASPxTextBoxSubject.Text = container.Subject
            ASPxDateEditStart.Value = container.Start
            ASPxDateEditEnd.Value = container.End
            ASPxMemoDescription.Text = container.Description
            ASPxTextBoxCustomInfo.Text = container.CustomInfoField
            If container.CustomAttachmentFileName <> "" Then
                ASPxImage1.ImageUrl = "~/" & container.CustomAttachmentFileName
            End If
            ASPxLabelFileName.Text = container.CustomAttachmentFileName

            ASPxButtonOk.ClientSideEvents.Click = container.CancelHandler
            ASPxButtonCancel.ClientSideEvents.Click = container.CancelHandler
            ASPxButtonDelete.ClientSideEvents.Click = container.DeleteHandler
        End Sub

        Protected Sub ASPxUploadControl1_FileUploadComplete(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxUploadControl.FileUploadCompleteEventArgs)
            Dim control As ASPxUploadControl = TryCast(sender, ASPxUploadControl)
            Dim container As CustomAppointmentFormTemplateContainer = CType(Parent, CustomAppointmentFormTemplateContainer)
            Dim callback As String = SavePostedFiles(e.UploadedFile)
            container.Appointment.CustomFields("AppointmentAttachment") = e.UploadedFile.FileBytes
            container.Appointment.CustomFields("AppointmentAttachmentFileName") = callback
            e.CallbackData = callback

        End Sub

        Private Function SavePostedFiles(ByVal uploadedFile As UploadedFile) As String
            If Not uploadedFile.IsValid Then
                Return String.Empty
            End If

            Dim fileInfo As New FileInfo(uploadedFile.FileName)
            Dim resFileName As String = MapPath(UploadDirectory) & fileInfo.Name
            uploadedFile.SaveAs(resFileName)
            resFileName = "Images/" & fileInfo.Name
            UploadingUtils.RemoveFileWithDelay(uploadedFile.FileName, resFileName, 5)
            Return resFileName
        End Function
    End Class
End Namespace