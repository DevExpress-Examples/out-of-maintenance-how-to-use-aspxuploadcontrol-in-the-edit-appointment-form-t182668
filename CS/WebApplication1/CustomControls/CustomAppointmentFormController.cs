using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.ASPxScheduler.Internal;
using DevExpress.XtraScheduler;

namespace WebApplication1.CustomControls {
    public class CustomAppointmentFormController : AppointmentFormController {
        public CustomAppointmentFormController(ASPxScheduler control, Appointment apt) : base(control, apt) {
        
        }

        public string CustomInfoField {
            get { return (string)EditedAppointmentCopy.CustomFields["AppointmentInfo"]; }
            set { EditedAppointmentCopy.CustomFields["AppointmentInfo"] = value; }
        }
        string SourceCustomInfoField {
            get { return (string)SourceAppointment.CustomFields["AppointmentInfo"]; }
            set { SourceAppointment.CustomFields["AppointmentInfo"] = value; }
        }

        public byte[] CustomAttachment {
            get { return (byte[])EditedAppointmentCopy.CustomFields["AppointmentAttachment"]; }
            set { EditedAppointmentCopy.CustomFields["AppointmentAttachment"] = value; }
        }

        byte[] SourceCustomAttachment {
            get { return (byte[])SourceAppointment.CustomFields["AppointmentAttachment"]; }
            set { SourceAppointment.CustomFields["AppointmentAttachment"] = value; }
        }

        public byte[] CustomAttachmentFileName {
            get { return (byte[])EditedAppointmentCopy.CustomFields["AppointmentAttachmentFileName"]; }
            set { EditedAppointmentCopy.CustomFields["AppointmentAttachmentFileName"] = value; }
        }

        byte[] SourceCustomAttachmentFileName {
            get { return (byte[])SourceAppointment.CustomFields["AppointmentAttachmentFileName"]; }
            set { SourceAppointment.CustomFields["AppointmentAttachmentFileName"] = value; }
        }
    }
}