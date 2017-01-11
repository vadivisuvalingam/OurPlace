using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace OUR_PLACE
{
	/// <summary>
	/// Summary description for ctlPage4.
	/// </summary>
	public class ctlPage4 : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.GroupBox grpNonAdmission;
		private System.Windows.Forms.CheckBox chkNotAdmitted;
		private System.Windows.Forms.CheckBox chkIntakeCompleted;
		private System.Windows.Forms.CheckBox chkLeftVoluntarily;
		private OUR_PLACE.ctlFreeText txtReason;
		private System.Windows.Forms.Label lblReferredTo;
		private System.Windows.Forms.TextBox txtReferredTo;
		private System.Windows.Forms.TextBox txtAdmittingStaff;
		private System.Windows.Forms.Label lblAdmittingStaff;
		private System.Windows.Forms.Label lblAdmitDateTime;
		private System.Windows.Forms.DateTimePicker dtmAdmitDateTime;
		private System.Windows.Forms.TextBox txtPrimaryWorker;
		private System.Windows.Forms.Label lblPrimaryWorker;
		private System.Windows.Forms.GroupBox grpDischarge;
		private System.Windows.Forms.TextBox txtReadmissionCriteria;
		private System.Windows.Forms.Label lblReadmissionCriteria;
		private System.Windows.Forms.TextBox txtNoOfDays;
		private System.Windows.Forms.Label lblNoOfDays;
		private System.Windows.Forms.TextBox txtDischargedTo;
		private System.Windows.Forms.Label lblDischargedTo;
		private OUR_PLACE.ctlFreeText txtReasonDischarge;
		private System.Windows.Forms.DateTimePicker dtmDischargeDate;
		private System.Windows.Forms.Label lblDischargeDate;
		private OUR_PLACE.ctlFreeText txtRemarksReadmission;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ctlPage4()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call

		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.grpNonAdmission = new System.Windows.Forms.GroupBox();
			this.txtPrimaryWorker = new System.Windows.Forms.TextBox();
			this.lblPrimaryWorker = new System.Windows.Forms.Label();
			this.dtmAdmitDateTime = new System.Windows.Forms.DateTimePicker();
			this.lblAdmitDateTime = new System.Windows.Forms.Label();
			this.txtAdmittingStaff = new System.Windows.Forms.TextBox();
			this.lblAdmittingStaff = new System.Windows.Forms.Label();
			this.txtReferredTo = new System.Windows.Forms.TextBox();
			this.lblReferredTo = new System.Windows.Forms.Label();
			this.txtReason = new OUR_PLACE.ctlFreeText();
			this.chkLeftVoluntarily = new System.Windows.Forms.CheckBox();
			this.chkNotAdmitted = new System.Windows.Forms.CheckBox();
			this.chkIntakeCompleted = new System.Windows.Forms.CheckBox();
			this.grpDischarge = new System.Windows.Forms.GroupBox();
			this.txtRemarksReadmission = new OUR_PLACE.ctlFreeText();
			this.dtmDischargeDate = new System.Windows.Forms.DateTimePicker();
			this.lblDischargeDate = new System.Windows.Forms.Label();
			this.txtReadmissionCriteria = new System.Windows.Forms.TextBox();
			this.lblReadmissionCriteria = new System.Windows.Forms.Label();
			this.txtNoOfDays = new System.Windows.Forms.TextBox();
			this.lblNoOfDays = new System.Windows.Forms.Label();
			this.txtDischargedTo = new System.Windows.Forms.TextBox();
			this.lblDischargedTo = new System.Windows.Forms.Label();
			this.txtReasonDischarge = new OUR_PLACE.ctlFreeText();
			this.grpNonAdmission.SuspendLayout();
			this.grpDischarge.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpNonAdmission
			// 
			this.grpNonAdmission.Controls.Add(this.txtPrimaryWorker);
			this.grpNonAdmission.Controls.Add(this.lblPrimaryWorker);
			this.grpNonAdmission.Controls.Add(this.dtmAdmitDateTime);
			this.grpNonAdmission.Controls.Add(this.lblAdmitDateTime);
			this.grpNonAdmission.Controls.Add(this.txtAdmittingStaff);
			this.grpNonAdmission.Controls.Add(this.lblAdmittingStaff);
			this.grpNonAdmission.Controls.Add(this.txtReferredTo);
			this.grpNonAdmission.Controls.Add(this.lblReferredTo);
			this.grpNonAdmission.Controls.Add(this.txtReason);
			this.grpNonAdmission.Controls.Add(this.chkLeftVoluntarily);
			this.grpNonAdmission.Controls.Add(this.chkNotAdmitted);
			this.grpNonAdmission.Controls.Add(this.chkIntakeCompleted);
			this.grpNonAdmission.Location = new System.Drawing.Point(8, 8);
			this.grpNonAdmission.Name = "grpNonAdmission";
			this.grpNonAdmission.Size = new System.Drawing.Size(632, 296);
			this.grpNonAdmission.TabIndex = 0;
			this.grpNonAdmission.TabStop = false;
			this.grpNonAdmission.Text = "Non-Admission";
			// 
			// txtPrimaryWorker
			// 
			this.txtPrimaryWorker.Location = new System.Drawing.Point(208, 264);
			this.txtPrimaryWorker.Name = "txtPrimaryWorker";
			this.txtPrimaryWorker.TabIndex = 11;
			this.txtPrimaryWorker.Text = "";
			// 
			// lblPrimaryWorker
			// 
			this.lblPrimaryWorker.Location = new System.Drawing.Point(8, 264);
			this.lblPrimaryWorker.Name = "lblPrimaryWorker";
			this.lblPrimaryWorker.Size = new System.Drawing.Size(176, 23);
			this.lblPrimaryWorker.TabIndex = 10;
			this.lblPrimaryWorker.Text = "Assigned Primary Worker\'s Name";
			// 
			// dtmAdmitDateTime
			// 
			this.dtmAdmitDateTime.Location = new System.Drawing.Point(208, 240);
			this.dtmAdmitDateTime.Name = "dtmAdmitDateTime";
			this.dtmAdmitDateTime.TabIndex = 9;
			// 
			// lblAdmitDateTime
			// 
			this.lblAdmitDateTime.Location = new System.Drawing.Point(8, 240);
			this.lblAdmitDateTime.Name = "lblAdmitDateTime";
			this.lblAdmitDateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblAdmitDateTime.Size = new System.Drawing.Size(136, 23);
			this.lblAdmitDateTime.TabIndex = 8;
			this.lblAdmitDateTime.Text = "Date and Time";
			// 
			// txtAdmittingStaff
			// 
			this.txtAdmittingStaff.Location = new System.Drawing.Point(208, 216);
			this.txtAdmittingStaff.Name = "txtAdmittingStaff";
			this.txtAdmittingStaff.TabIndex = 7;
			this.txtAdmittingStaff.Text = "";
			// 
			// lblAdmittingStaff
			// 
			this.lblAdmittingStaff.Location = new System.Drawing.Point(8, 216);
			this.lblAdmittingStaff.Name = "lblAdmittingStaff";
			this.lblAdmittingStaff.Size = new System.Drawing.Size(136, 23);
			this.lblAdmittingStaff.TabIndex = 6;
			this.lblAdmittingStaff.Text = "Name of Admitting Staff";
			// 
			// txtReferredTo
			// 
			this.txtReferredTo.Location = new System.Drawing.Point(208, 192);
			this.txtReferredTo.Name = "txtReferredTo";
			this.txtReferredTo.TabIndex = 5;
			this.txtReferredTo.Text = "";
			// 
			// lblReferredTo
			// 
			this.lblReferredTo.Location = new System.Drawing.Point(8, 192);
			this.lblReferredTo.Name = "lblReferredTo";
			this.lblReferredTo.Size = new System.Drawing.Size(80, 23);
			this.lblReferredTo.TabIndex = 4;
			this.lblReferredTo.Text = "Referred To";
			// 
			// txtReason
			// 
			this.txtReason.FreeText = "";
			this.txtReason.FreeTextSize = 400;
			this.txtReason.Label = "Reason:";
			this.txtReason.Location = new System.Drawing.Point(8, 56);
			this.txtReason.Name = "txtReason";
			this.txtReason.Size = new System.Drawing.Size(592, 128);
			this.txtReason.TabIndex = 3;
			// 
			// chkLeftVoluntarily
			// 
			this.chkLeftVoluntarily.Location = new System.Drawing.Point(376, 24);
			this.chkLeftVoluntarily.Name = "chkLeftVoluntarily";
			this.chkLeftVoluntarily.TabIndex = 2;
			this.chkLeftVoluntarily.Text = "Left Voluntarily.";
			// 
			// chkNotAdmitted
			// 
			this.chkNotAdmitted.Location = new System.Drawing.Point(224, 24);
			this.chkNotAdmitted.Name = "chkNotAdmitted";
			this.chkNotAdmitted.Size = new System.Drawing.Size(128, 24);
			this.chkNotAdmitted.TabIndex = 1;
			this.chkNotAdmitted.Text = "Youth not admitted.";
			// 
			// chkIntakeCompleted
			// 
			this.chkIntakeCompleted.Location = new System.Drawing.Point(16, 24);
			this.chkIntakeCompleted.Name = "chkIntakeCompleted";
			this.chkIntakeCompleted.Size = new System.Drawing.Size(192, 24);
			this.chkIntakeCompleted.TabIndex = 0;
			this.chkIntakeCompleted.Text = "Intake admission form completed.";
			// 
			// grpDischarge
			// 
			this.grpDischarge.Controls.Add(this.txtRemarksReadmission);
			this.grpDischarge.Controls.Add(this.dtmDischargeDate);
			this.grpDischarge.Controls.Add(this.lblDischargeDate);
			this.grpDischarge.Controls.Add(this.txtReadmissionCriteria);
			this.grpDischarge.Controls.Add(this.lblReadmissionCriteria);
			this.grpDischarge.Controls.Add(this.txtNoOfDays);
			this.grpDischarge.Controls.Add(this.lblNoOfDays);
			this.grpDischarge.Controls.Add(this.txtDischargedTo);
			this.grpDischarge.Controls.Add(this.lblDischargedTo);
			this.grpDischarge.Controls.Add(this.txtReasonDischarge);
			this.grpDischarge.Location = new System.Drawing.Point(8, 312);
			this.grpDischarge.Name = "grpDischarge";
			this.grpDischarge.Size = new System.Drawing.Size(632, 408);
			this.grpDischarge.TabIndex = 1;
			this.grpDischarge.TabStop = false;
			this.grpDischarge.Text = "Discharge";
			// 
			// txtRemarksReadmission
			// 
			this.txtRemarksReadmission.FreeText = "";
			this.txtRemarksReadmission.FreeTextSize = 400;
			this.txtRemarksReadmission.Label = "Remarks re: Readmission:";
			this.txtRemarksReadmission.Location = new System.Drawing.Point(8, 272);
			this.txtRemarksReadmission.Name = "txtRemarksReadmission";
			this.txtRemarksReadmission.Size = new System.Drawing.Size(592, 128);
			this.txtRemarksReadmission.TabIndex = 14;
			// 
			// dtmDischargeDate
			// 
			this.dtmDischargeDate.Location = new System.Drawing.Point(208, 24);
			this.dtmDischargeDate.Name = "dtmDischargeDate";
			this.dtmDischargeDate.TabIndex = 13;
			// 
			// lblDischargeDate
			// 
			this.lblDischargeDate.Location = new System.Drawing.Point(8, 24);
			this.lblDischargeDate.Name = "lblDischargeDate";
			this.lblDischargeDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDischargeDate.Size = new System.Drawing.Size(136, 23);
			this.lblDischargeDate.TabIndex = 12;
			this.lblDischargeDate.Text = "Discharge Date";
			// 
			// txtReadmissionCriteria
			// 
			this.txtReadmissionCriteria.Location = new System.Drawing.Point(208, 240);
			this.txtReadmissionCriteria.Name = "txtReadmissionCriteria";
			this.txtReadmissionCriteria.TabIndex = 11;
			this.txtReadmissionCriteria.Text = "";
			// 
			// lblReadmissionCriteria
			// 
			this.lblReadmissionCriteria.Location = new System.Drawing.Point(8, 240);
			this.lblReadmissionCriteria.Name = "lblReadmissionCriteria";
			this.lblReadmissionCriteria.Size = new System.Drawing.Size(176, 23);
			this.lblReadmissionCriteria.TabIndex = 10;
			this.lblReadmissionCriteria.Text = "Re-admission criteria";
			// 
			// txtNoOfDays
			// 
			this.txtNoOfDays.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.txtNoOfDays.Location = new System.Drawing.Point(208, 216);
			this.txtNoOfDays.Name = "txtNoOfDays";
			this.txtNoOfDays.TabIndex = 7;
			this.txtNoOfDays.Text = "";
			// 
			// lblNoOfDays
			// 
			this.lblNoOfDays.Location = new System.Drawing.Point(8, 216);
			this.lblNoOfDays.Name = "lblNoOfDays";
			this.lblNoOfDays.Size = new System.Drawing.Size(136, 23);
			this.lblNoOfDays.TabIndex = 6;
			this.lblNoOfDays.Text = "No. of Days";
			// 
			// txtDischargedTo
			// 
			this.txtDischargedTo.Location = new System.Drawing.Point(208, 192);
			this.txtDischargedTo.Name = "txtDischargedTo";
			this.txtDischargedTo.TabIndex = 5;
			this.txtDischargedTo.Text = "";
			// 
			// lblDischargedTo
			// 
			this.lblDischargedTo.Location = new System.Drawing.Point(8, 192);
			this.lblDischargedTo.Name = "lblDischargedTo";
			this.lblDischargedTo.Size = new System.Drawing.Size(80, 23);
			this.lblDischargedTo.TabIndex = 4;
			this.lblDischargedTo.Text = "Discharged To";
			// 
			// txtReasonDischarge
			// 
			this.txtReasonDischarge.FreeText = "";
			this.txtReasonDischarge.FreeTextSize = 400;
			this.txtReasonDischarge.Label = "Reason for discharge:";
			this.txtReasonDischarge.Location = new System.Drawing.Point(8, 56);
			this.txtReasonDischarge.Name = "txtReasonDischarge";
			this.txtReasonDischarge.Size = new System.Drawing.Size(592, 128);
			this.txtReasonDischarge.TabIndex = 3;
			// 
			// ctlPage4
			// 
			this.AutoScroll = true;
			this.Controls.Add(this.grpDischarge);
			this.Controls.Add(this.grpNonAdmission);
			this.Name = "ctlPage4";
			this.Size = new System.Drawing.Size(648, 728);
			this.grpNonAdmission.ResumeLayout(false);
			this.grpDischarge.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
	}
}
