<!-- default file list -->
*Files to look at*:

* [CustomAppointmentForm.ascx](./CS/WebApplication1/CustomControls/CustomAppointmentForm.ascx) (VB: [CustomAppointmentForm.ascx](./VB/WebApplication1/CustomControls/CustomAppointmentForm.ascx))
* [CustomAppointmentForm.ascx.cs](./CS/WebApplication1/CustomControls/CustomAppointmentForm.ascx.cs) (VB: [CustomAppointmentForm.ascx](./VB/WebApplication1/CustomControls/CustomAppointmentForm.ascx))
* [CustomAppointmentFormController.cs](./CS/WebApplication1/CustomControls/CustomAppointmentFormController.cs) (VB: [CustomAppointmentFormController.vb](./VB/WebApplication1/CustomControls/CustomAppointmentFormController.vb))
* [CustomAppointmentFormTemplateContainer .cs](./CS/WebApplication1/CustomControls/CustomAppointmentFormTemplateContainer .cs) (VB: [CustomAppointmentFormTemplateContainer .vb](./VB/WebApplication1/CustomControls/CustomAppointmentFormTemplateContainer .vb))
* [CustomAppointmentSaveCallbackCommand .cs](./CS/WebApplication1/CustomControls/CustomAppointmentSaveCallbackCommand .cs) (VB: [CustomAppointmentSaveCallbackCommand .vb](./VB/WebApplication1/CustomControls/CustomAppointmentSaveCallbackCommand .vb))
* [CustomDataSource.cs](./CS/WebApplication1/CustomDataSource.cs) (VB: [CustomDataSource.vb](./VB/WebApplication1/CustomDataSource.vb))
* [CustomObjects.cs](./CS/WebApplication1/CustomObjects.cs) (VB: [CustomObjects.vb](./VB/WebApplication1/CustomObjects.vb))
* [Default.aspx](./CS/WebApplication1/Default.aspx) (VB: [Default.aspx](./VB/WebApplication1/Default.aspx))
* [Default.aspx.cs](./CS/WebApplication1/Default.aspx.cs) (VB: [Default.aspx](./VB/WebApplication1/Default.aspx))
* [UploadingUtils.cs](./CS/WebApplication1/UploadingUtils.cs) (VB: [UploadingUtils.vb](./VB/WebApplication1/UploadingUtils.vb))
<!-- default file list end -->
# How to use ASPxUploadControl in the Edit Appointment Form


<p>This example demonstrates how to use <a href="https://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxUploadControlASPxUploadControltopic">ASPxUploadControl</a> inside a custom <strong>Appointment</strong> <strong>Editing</strong> <strong>Form</strong> to load an image to a custom appointment field.</p>
<p>To accomplish this task, perform the following steps:</p>
<p>1. Create a custom <strong>Appointment</strong> <strong>Editing</strong> <strong>Form</strong>.<br />2. Create a custom <a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfSchedulerUIAppointmentFormControllertopic">AppointmentFormController</a> class with corresponding additional properties for each custom field.<br />3. Override the <strong>AppointmentFormSaveCallback</strong> command to pass custom editor values to the mentioned <strong>AppointmentFormController</strong> properties.<br />4. Put the <strong>ASPxUploadControl </strong>onto a custom<strong> Appointment Editing Form.<br /></strong>5. Handle the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxUploadControlASPxUploadControl_FileUploadCompletetopic">ASPxUploadControl.FileUploadComplete</a> event. <br /><br />When an end-user have uploaded a file, the <strong>ASPxUploadControl.FileUploadComplete</strong> event is raised.</p>
<p>In this event handler, an uploaded file name (string) or uploaded file content (byte array) are obtain and save the required parameter in the appointment's source object. </p>
<p>The custom form contains the <a href="https://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxEditorsASPxImagetopic">ASPxImage</a> control which shows the uploaded image.</p>

<br/>


