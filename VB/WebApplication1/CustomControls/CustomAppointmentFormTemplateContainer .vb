Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DevExpress.Web.ASPxScheduler

Namespace WebApplication1.CustomControls
    Public Class CustomAppointmentFormTemplateContainer
        Inherits AppointmentFormTemplateContainer

        Public Sub New(ByVal control As ASPxScheduler)
            MyBase.New(control)

        End Sub

        Public ReadOnly Property CustomInfoField() As String
            Get
                Return System.Convert.ToString(Appointment.CustomFields("AppointmentInfo"))
            End Get
        End Property

        Public ReadOnly Property CustomAttachment() As Byte()
            Get
                Return TryCast(Appointment.CustomFields("AppointmentAttachment"), Byte())
            End Get
        End Property

        Public ReadOnly Property CustomAttachmentFileName() As String
            Get
                If Appointment.CustomFields("AppointmentAttachmentFileName") Is Nothing Then
                    Return ""
                Else
                    Return System.Convert.ToString(Appointment.CustomFields("AppointmentAttachmentFileName"))
                End If
            End Get
        End Property


        Public ReadOnly Property Description() As String
            Get
                Return Appointment.Description
            End Get
        End Property
    End Class
End Namespace