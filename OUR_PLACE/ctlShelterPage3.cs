using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace OUR_PLACE
{
	/// <summary>
	/// Summary description for ctlPage3.
	/// </summary>
	public class ctlPage3 : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.GroupBox grpFamilyComposition;
		private System.Windows.Forms.Label lblLiveWith;
		private System.Windows.Forms.TextBox txtLiveWithExtended;
		private System.Windows.Forms.ComboBox cboLiveWith;
		private System.Windows.Forms.GroupBox grpAgencyInvolvement;
		private System.Windows.Forms.Label lblCASNow;
		private OUR_PLACE.ctlYesNo chkCASNow;
		private OUR_PLACE.ctlYesNo chkCASPast;
		private System.Windows.Forms.Label lblCASPast;
		private System.Windows.Forms.Label lblInvolvedWith;
		private System.Windows.Forms.CheckBox chkDrugAlcohol;
		private System.Windows.Forms.TextBox txtOtherInvolvedWithExtended;
		private System.Windows.Forms.CheckBox chkOtherInvolvedWith;
		private System.Windows.Forms.CheckBox chkPsychiatrist;
		private System.Windows.Forms.CheckBox chkCustody;
		private System.Windows.Forms.CheckBox chkResidentialProgram;
		private System.Windows.Forms.CheckBox chkHospitalTeamWorker;
		private System.Windows.Forms.CheckBox chkPsychologist;
		private System.Windows.Forms.CheckBox chkIndividualFamilyCounselling;
		private OUR_PLACE.ctlFreeText txtWorkerNameInfo;
		private OUR_PLACE.ctlFreeText txtPresentingBehaviour;
		private OUR_PLACE.ctlFreeText txtImmediateNeeds;
		private OUR_PLACE.ctlFreeText txtLongTermNeeds;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ctlPage3()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			LoadCombos();

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
			this.grpFamilyComposition = new System.Windows.Forms.GroupBox();
			this.txtLiveWithExtended = new System.Windows.Forms.TextBox();
			this.cboLiveWith = new System.Windows.Forms.ComboBox();
			this.lblLiveWith = new System.Windows.Forms.Label();
			this.grpAgencyInvolvement = new System.Windows.Forms.GroupBox();
			this.txtLongTermNeeds = new OUR_PLACE.ctlFreeText();
			this.txtImmediateNeeds = new OUR_PLACE.ctlFreeText();
			this.txtPresentingBehaviour = new OUR_PLACE.ctlFreeText();
			this.chkDrugAlcohol = new System.Windows.Forms.CheckBox();
			this.txtOtherInvolvedWithExtended = new System.Windows.Forms.TextBox();
			this.chkOtherInvolvedWith = new System.Windows.Forms.CheckBox();
			this.chkPsychiatrist = new System.Windows.Forms.CheckBox();
			this.chkCustody = new System.Windows.Forms.CheckBox();
			this.chkResidentialProgram = new System.Windows.Forms.CheckBox();
			this.chkHospitalTeamWorker = new System.Windows.Forms.CheckBox();
			this.chkPsychologist = new System.Windows.Forms.CheckBox();
			this.chkIndividualFamilyCounselling = new System.Windows.Forms.CheckBox();
			this.lblInvolvedWith = new System.Windows.Forms.Label();
			this.txtWorkerNameInfo = new OUR_PLACE.ctlFreeText();
			this.chkCASPast = new OUR_PLACE.ctlYesNo();
			this.lblCASPast = new System.Windows.Forms.Label();
			this.chkCASNow = new OUR_PLACE.ctlYesNo();
			this.lblCASNow = new System.Windows.Forms.Label();
			this.grpFamilyComposition.SuspendLayout();
			this.grpAgencyInvolvement.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpFamilyComposition
			// 
			this.grpFamilyComposition.Controls.Add(this.txtLiveWithExtended);
			this.grpFamilyComposition.Controls.Add(this.cboLiveWith);
			this.grpFamilyComposition.Controls.Add(this.lblLiveWith);
			this.grpFamilyComposition.Location = new System.Drawing.Point(8, 8);
			this.grpFamilyComposition.Name = "grpFamilyComposition";
			this.grpFamilyComposition.Size = new System.Drawing.Size(632, 56);
			this.grpFamilyComposition.TabIndex = 0;
			this.grpFamilyComposition.TabStop = false;
			this.grpFamilyComposition.Text = "Family Composition";
			// 
			// txtLiveWithExtended
			// 
			this.txtLiveWithExtended.Location = new System.Drawing.Point(440, 24);
			this.txtLiveWithExtended.Name = "txtLiveWithExtended";
			this.txtLiveWithExtended.Size = new System.Drawing.Size(120, 20);
			this.txtLiveWithExtended.TabIndex = 7;
			this.txtLiveWithExtended.Text = "";
			// 
			// cboLiveWith
			// 
			this.cboLiveWith.Location = new System.Drawing.Point(272, 24);
			this.cboLiveWith.Name = "cboLiveWith";
			this.cboLiveWith.Size = new System.Drawing.Size(160, 21);
			this.cboLiveWith.TabIndex = 6;
			// 
			// lblLiveWith
			// 
			this.lblLiveWith.Location = new System.Drawing.Point(8, 24);
			this.lblLiveWith.Name = "lblLiveWith";
			this.lblLiveWith.Size = new System.Drawing.Size(264, 23);
			this.lblLiveWith.TabIndex = 0;
			this.lblLiveWith.Text = "Prior to leaving home, who did the youth live with?";
			// 
			// grpAgencyInvolvement
			// 
			this.grpAgencyInvolvement.Controls.Add(this.txtLongTermNeeds);
			this.grpAgencyInvolvement.Controls.Add(this.txtImmediateNeeds);
			this.grpAgencyInvolvement.Controls.Add(this.txtPresentingBehaviour);
			this.grpAgencyInvolvement.Controls.Add(this.chkDrugAlcohol);
			this.grpAgencyInvolvement.Controls.Add(this.txtOtherInvolvedWithExtended);
			this.grpAgencyInvolvement.Controls.Add(this.chkOtherInvolvedWith);
			this.grpAgencyInvolvement.Controls.Add(this.chkPsychiatrist);
			this.grpAgencyInvolvement.Controls.Add(this.chkCustody);
			this.grpAgencyInvolvement.Controls.Add(this.chkResidentialProgram);
			this.grpAgencyInvolvement.Controls.Add(this.chkHospitalTeamWorker);
			this.grpAgencyInvolvement.Controls.Add(this.chkPsychologist);
			this.grpAgencyInvolvement.Controls.Add(this.chkIndividualFamilyCounselling);
			this.grpAgencyInvolvement.Controls.Add(this.lblInvolvedWith);
			this.grpAgencyInvolvement.Controls.Add(this.txtWorkerNameInfo);
			this.grpAgencyInvolvement.Controls.Add(this.chkCASPast);
			this.grpAgencyInvolvement.Controls.Add(this.lblCASPast);
			this.grpAgencyInvolvement.Controls.Add(this.chkCASNow);
			this.grpAgencyInvolvement.Controls.Add(this.lblCASNow);
			this.grpAgencyInvolvement.Location = new System.Drawing.Point(8, 72);
			this.grpAgencyInvolvement.Name = "grpAgencyInvolvement";
			this.grpAgencyInvolvement.Size = new System.Drawing.Size(632, 720);
			this.grpAgencyInvolvement.TabIndex = 1;
			this.grpAgencyInvolvement.TabStop = false;
			this.grpAgencyInvolvement.Text = "Agency Involvement";
			// 
			// txtLongTermNeeds
			// 
			this.txtLongTermNeeds.FreeText = "";
			this.txtLongTermNeeds.FreeTextSize = 400;
			this.txtLongTermNeeds.Label = "Long-Term Needs";
			this.txtLongTermNeeds.Location = new System.Drawing.Point(8, 544);
			this.txtLongTermNeeds.Name = "txtLongTermNeeds";
			this.txtLongTermNeeds.Size = new System.Drawing.Size(592, 128);
			this.txtLongTermNeeds.TabIndex = 93;
			// 
			// txtImmediateNeeds
			// 
			this.txtImmediateNeeds.FreeText = "";
			this.txtImmediateNeeds.FreeTextSize = 400;
			this.txtImmediateNeeds.Label = "Immediate Needs";
			this.txtImmediateNeeds.Location = new System.Drawing.Point(8, 416);
			this.txtImmediateNeeds.Name = "txtImmediateNeeds";
			this.txtImmediateNeeds.Size = new System.Drawing.Size(592, 128);
			this.txtImmediateNeeds.TabIndex = 92;
			// 
			// txtPresentingBehaviour
			// 
			this.txtPresentingBehaviour.FreeText = "";
			this.txtPresentingBehaviour.FreeTextSize = 400;
			this.txtPresentingBehaviour.Label = "Presenting Behaviour";
			this.txtPresentingBehaviour.Location = new System.Drawing.Point(8, 288);
			this.txtPresentingBehaviour.Name = "txtPresentingBehaviour";
			this.txtPresentingBehaviour.Size = new System.Drawing.Size(592, 128);
			this.txtPresentingBehaviour.TabIndex = 91;
			// 
			// chkDrugAlcohol
			// 
			this.chkDrugAlcohol.Location = new System.Drawing.Point(8, 240);
			this.chkDrugAlcohol.Name = "chkDrugAlcohol";
			this.chkDrugAlcohol.Size = new System.Drawing.Size(160, 24);
			this.chkDrugAlcohol.TabIndex = 90;
			this.chkDrugAlcohol.Text = "Drug/Alcohol";
			// 
			// txtOtherInvolvedWithExtended
			// 
			this.txtOtherInvolvedWithExtended.Location = new System.Drawing.Point(272, 264);
			this.txtOtherInvolvedWithExtended.Name = "txtOtherInvolvedWithExtended";
			this.txtOtherInvolvedWithExtended.Size = new System.Drawing.Size(144, 20);
			this.txtOtherInvolvedWithExtended.TabIndex = 89;
			this.txtOtherInvolvedWithExtended.Text = "";
			// 
			// chkOtherInvolvedWith
			// 
			this.chkOtherInvolvedWith.Location = new System.Drawing.Point(216, 264);
			this.chkOtherInvolvedWith.Name = "chkOtherInvolvedWith";
			this.chkOtherInvolvedWith.Size = new System.Drawing.Size(80, 24);
			this.chkOtherInvolvedWith.TabIndex = 88;
			this.chkOtherInvolvedWith.Text = "Other";
			// 
			// chkPsychiatrist
			// 
			this.chkPsychiatrist.Location = new System.Drawing.Point(8, 264);
			this.chkPsychiatrist.Name = "chkPsychiatrist";
			this.chkPsychiatrist.Size = new System.Drawing.Size(184, 24);
			this.chkPsychiatrist.TabIndex = 87;
			this.chkPsychiatrist.Text = "Psychiatrist";
			// 
			// chkCustody
			// 
			this.chkCustody.Location = new System.Drawing.Point(448, 240);
			this.chkCustody.Name = "chkCustody";
			this.chkCustody.Size = new System.Drawing.Size(160, 24);
			this.chkCustody.TabIndex = 86;
			this.chkCustody.Text = "Open/Closed Custody";
			// 
			// chkResidentialProgram
			// 
			this.chkResidentialProgram.Location = new System.Drawing.Point(448, 216);
			this.chkResidentialProgram.Name = "chkResidentialProgram";
			this.chkResidentialProgram.Size = new System.Drawing.Size(160, 24);
			this.chkResidentialProgram.TabIndex = 85;
			this.chkResidentialProgram.Text = "Residential Program";
			// 
			// chkHospitalTeamWorker
			// 
			this.chkHospitalTeamWorker.Location = new System.Drawing.Point(216, 240);
			this.chkHospitalTeamWorker.Name = "chkHospitalTeamWorker";
			this.chkHospitalTeamWorker.Size = new System.Drawing.Size(216, 24);
			this.chkHospitalTeamWorker.TabIndex = 84;
			this.chkHospitalTeamWorker.Text = "Hospital (Crisis Team/Social Worker)";
			// 
			// chkPsychologist
			// 
			this.chkPsychologist.Location = new System.Drawing.Point(216, 216);
			this.chkPsychologist.Name = "chkPsychologist";
			this.chkPsychologist.Size = new System.Drawing.Size(160, 24);
			this.chkPsychologist.TabIndex = 83;
			this.chkPsychologist.Text = "Psychologist";
			// 
			// chkIndividualFamilyCounselling
			// 
			this.chkIndividualFamilyCounselling.Location = new System.Drawing.Point(8, 216);
			this.chkIndividualFamilyCounselling.Name = "chkIndividualFamilyCounselling";
			this.chkIndividualFamilyCounselling.Size = new System.Drawing.Size(176, 24);
			this.chkIndividualFamilyCounselling.TabIndex = 82;
			this.chkIndividualFamilyCounselling.Text = "Individual/Family Counselling";
			// 
			// lblInvolvedWith
			// 
			this.lblInvolvedWith.Location = new System.Drawing.Point(8, 200);
			this.lblInvolvedWith.Name = "lblInvolvedWith";
			this.lblInvolvedWith.Size = new System.Drawing.Size(432, 23);
			this.lblInvolvedWith.TabIndex = 5;
			this.lblInvolvedWith.Text = "What other agencies/helping professionals has the youth been involved with?";
			// 
			// txtWorkerNameInfo
			// 
			this.txtWorkerNameInfo.FreeText = "";
			this.txtWorkerNameInfo.FreeTextSize = 400;
			this.txtWorkerNameInfo.Label = "Children\'s Aid Society Worker Name and Info";
			this.txtWorkerNameInfo.Location = new System.Drawing.Point(8, 72);
			this.txtWorkerNameInfo.Name = "txtWorkerNameInfo";
			this.txtWorkerNameInfo.Size = new System.Drawing.Size(592, 128);
			this.txtWorkerNameInfo.TabIndex = 4;
			// 
			// chkCASPast
			// 
			this.chkCASPast.Checked = false;
			this.chkCASPast.Location = new System.Drawing.Point(408, 48);
			this.chkCASPast.Name = "chkCASPast";
			this.chkCASPast.Size = new System.Drawing.Size(150, 24);
			this.chkCASPast.TabIndex = 3;
			// 
			// lblCASPast
			// 
			this.lblCASPast.Location = new System.Drawing.Point(8, 48);
			this.lblCASPast.Name = "lblCASPast";
			this.lblCASPast.Size = new System.Drawing.Size(376, 23);
			this.lblCASPast.TabIndex = 2;
			this.lblCASPast.Text = "Has the youth been involved with the Children\'s Aid Society in the past?";
			// 
			// chkCASNow
			// 
			this.chkCASNow.Checked = false;
			this.chkCASNow.Location = new System.Drawing.Point(384, 24);
			this.chkCASNow.Name = "chkCASNow";
			this.chkCASNow.Size = new System.Drawing.Size(150, 24);
			this.chkCASNow.TabIndex = 1;
			// 
			// lblCASNow
			// 
			this.lblCASNow.Location = new System.Drawing.Point(8, 24);
			this.lblCASNow.Name = "lblCASNow";
			this.lblCASNow.Size = new System.Drawing.Size(352, 23);
			this.lblCASNow.TabIndex = 0;
			this.lblCASNow.Text = "Has the youth been involved with the Children\'s Aid Society now?";
			// 
			// ctlPage3
			// 
			this.AutoScroll = true;
			this.Controls.Add(this.grpAgencyInvolvement);
			this.Controls.Add(this.grpFamilyComposition);
			this.Name = "ctlPage3";
			this.Size = new System.Drawing.Size(648, 800);
			this.grpFamilyComposition.ResumeLayout(false);
			this.grpAgencyInvolvement.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Private Methods

		private void LoadCombos()
		{
			StaticMethods.LoadCombos(cboLiveWith, "PRIOR_LIVE_WITH");
		}

		#endregion
	
	}
}
