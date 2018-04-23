Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.ASPxScheduler.Internal
Imports DevExpress.XtraScheduler

Namespace WebApplication1.CustomControls
    Public Class CustomAppointmentFormController
        Inherits AppointmentFormController

        Public Sub New(ByVal control As ASPxScheduler, ByVal apt As Appointment)
            MyBase.New(control, apt)

        End Sub

        Public Property CustomInfoField() As String
            Get
                Return CStr(EditedAppointmentCopy.CustomFields("AppointmentInfo"))
            End Get
            Set(ByVal value As String)
                EditedAppointmentCopy.CustomFields("AppointmentInfo") = value
            End Set
        End Property
        Private Property SourceCustomInfoField() As String
            Get
                Return CStr(SourceAppointment.CustomFields("AppointmentInfo"))
            End Get
            Set(ByVal value As String)
                SourceAppointment.CustomFields("AppointmentInfo") = value
            End Set
        End Property

        Public Property CustomAttachment() As Byte()
            Get
                Return CType(EditedAppointmentCopy.CustomFields("AppointmentAttachment"), Byte())
            End Get
            Set(ByVal value As Byte())
                EditedAppointmentCopy.CustomFields("AppointmentAttachment") = value
            End Set
        End Property

        Private Property SourceCustomAttachment() As Byte()
            Get
                Return CType(SourceAppointment.CustomFields("AppointmentAttachment"), Byte())
            End Get
            Set(ByVal value As Byte())
                SourceAppointment.CustomFields("AppointmentAttachment") = value
            End Set
        End Property

        Public Property CustomAttachmentFileName() As Byte()
            Get
                Return CType(EditedAppointmentCopy.CustomFields("AppointmentAttachmentFileName"), Byte())
            End Get
            Set(ByVal value As Byte())
                EditedAppointmentCopy.CustomFields("AppointmentAttachmentFileName") = value
            End Set
        End Property

        Private Property SourceCustomAttachmentFileName() As Byte()
            Get
                Return CType(SourceAppointment.CustomFields("AppointmentAttachmentFileName"), Byte())
            End Get
            Set(ByVal value As Byte())
                SourceAppointment.CustomFields("AppointmentAttachmentFileName") = value
            End Set
        End Property
    End Class
End Namespace