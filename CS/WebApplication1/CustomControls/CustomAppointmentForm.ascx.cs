using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.XtraScheduler;
using DevExpress.Web;
using DevExpress.Web.Internal;
using System.IO;

namespace WebApplication1.CustomControls {
    public partial class CustomAppointmentForm : System.Web.UI.UserControl {
        const string UploadDirectory = "~/Images/";
        protected void Page_Load(object sender, EventArgs e) {

        }

        public override void DataBind() {
            base.DataBind();
            CustomAppointmentFormTemplateContainer container = (CustomAppointmentFormTemplateContainer)Parent;
            ASPxTextBoxSubject.Text = container.Subject;
            ASPxDateEditStart.Value  = container.Start;
            ASPxDateEditEnd.Value = container.End;
            ASPxMemoDescription.Text = container.Description;
            ASPxTextBoxCustomInfo.Text = container.CustomInfoField;
            if(container.CustomAttachmentFileName != "")
                ASPxImage1.ImageUrl = "~/" + container.CustomAttachmentFileName;
            ASPxLabelFileName.Text = container.CustomAttachmentFileName;

            ASPxButtonOk.ClientSideEvents.Click = container.CancelHandler;
            ASPxButtonCancel.ClientSideEvents.Click = container.CancelHandler;
            ASPxButtonDelete.ClientSideEvents.Click = container.DeleteHandler;
        }

        protected void ASPxUploadControl1_FileUploadComplete(object sender, DevExpress.Web.FileUploadCompleteEventArgs e) {
            ASPxUploadControl control = sender as ASPxUploadControl;
            CustomAppointmentFormTemplateContainer container = (CustomAppointmentFormTemplateContainer)Parent;
            string callback = SavePostedFiles(e.UploadedFile);
            container.Appointment.CustomFields["AppointmentAttachment"] = e.UploadedFile.FileBytes;
            container.Appointment.CustomFields["AppointmentAttachmentFileName"] = callback;
            e.CallbackData = callback;

        }

        string SavePostedFiles(UploadedFile uploadedFile) {
            if(!uploadedFile.IsValid)
                return string.Empty;

            FileInfo fileInfo = new FileInfo(uploadedFile.FileName);
            string resFileName = MapPath(UploadDirectory) + fileInfo.Name;
            uploadedFile.SaveAs(resFileName);
            resFileName = "Images/" + fileInfo.Name;
            UploadingUtils.RemoveFileWithDelay(uploadedFile.FileName, resFileName, 5);
            return resFileName;
        }
    }
}