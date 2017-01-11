using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace OUR_PLACE
{
	/// <summary>
	/// Summary description for ctlPage1.
	/// </summary>
	public class ctlPage1 : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.TextBox txtFileNo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblDateAdmission;
		private System.Windows.Forms.Label lblDateDischarge;
		private System.Windows.Forms.DateTimePicker dtmDateDischarge;
		private System.Windows.Forms.Label lblDateDischargeAdditional;
		private System.Windows.Forms.Label lblLocation;
		private System.Windows.Forms.ComboBox cboLocation;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label lblMiddleName;
		private System.Windows.Forms.TextBox txtMiddleName;
		private System.Windows.Forms.Label lblAKA;
		private System.Windows.Forms.TextBox txtAKA;
		private System.Windows.Forms.Label lblAgeIntake;
		private System.Windows.Forms.TextBox txtAgeIntake;
		private System.Windows.Forms.Label lblCurrentAge;
		private System.Windows.Forms.TextBox txtCurrentAge;
		private System.Windows.Forms.DateTimePicker dtmBirthDate;
		private System.Windows.Forms.Label lblBirthDate;
		private System.Windows.Forms.RadioButton btnMale;
		private System.Windows.Forms.RadioButton btnFemale;
		private System.Windows.Forms.GroupBox grpPersonalData;
		private System.Windows.Forms.CheckBox chkSocialInsurance;
		private System.Windows.Forms.TextBox txtSocialInsurance;
		private System.Windows.Forms.TextBox txtHealthCard;
		private System.Windows.Forms.CheckBox chkHealthCard;
		private System.Windows.Forms.TextBox txtDriversLicence;
		private System.Windows.Forms.CheckBox chkDriversLicence;
		private System.Windows.Forms.TextBox txtBirthCertificate;
		private System.Windows.Forms.CheckBox chkBirthCertificate;
		private System.Windows.Forms.TextBox txtOtherIdentification;
		private System.Windows.Forms.CheckBox chkOtherIdentification;
		private System.Windows.Forms.TextBox txtCitizenship;
		private System.Windows.Forms.CheckBox chkCitizenship;
		private System.Windows.Forms.TextBox txtPassport;
		private System.Windows.Forms.CheckBox chkPassport;
		private System.Windows.Forms.TextBox txtSchoolID;
		private System.Windows.Forms.CheckBox chkSchoolID;
		private System.Windows.Forms.TextBox txtOtherTypeIdentification;
		private System.Windows.Forms.Label lblOtherTypeIdentification;
		private System.Windows.Forms.GroupBox grpIdentification;
		private System.Windows.Forms.Label lblReferralSource;
		private System.Windows.Forms.ComboBox cboReferralSource;
		private System.Windows.Forms.Label lblReferralReason;
		private System.Windows.Forms.CheckBox chkParentTeenConflict;
		private System.Windows.Forms.CheckBox chkSiblingConflict;
		private System.Windows.Forms.CheckBox chkLostOwnAccomodation;
		private System.Windows.Forms.CheckBox chkAbuse;
		private System.Windows.Forms.CheckBox chkHospitalDischarge;
		private System.Windows.Forms.CheckBox chkMentalHealthIssues;
		private System.Windows.Forms.CheckBox chkResidingAtOther;
		private System.Windows.Forms.CheckBox chkResidingAtShelter;
		private System.Windows.Forms.CheckBox chkParentalDrugAlcohol;
		private System.Windows.Forms.CheckBox chkSponsorshipBreakdown;
		private System.Windows.Forms.CheckBox chkInsufficientRoom;
		private System.Windows.Forms.CheckBox chkFosterCareBreakdown;
		private System.Windows.Forms.CheckBox chkParentalMentalHealthIssues;
		private System.Windows.Forms.CheckBox chkOtherReferralReason;
		private System.Windows.Forms.TextBox txtOtherReferralReason;
		private System.Windows.Forms.Label lblAbuseKind;
		private System.Windows.Forms.TextBox txtAbuseKind;
		private System.Windows.Forms.TextBox txtAbusePerpetrator;
		private System.Windows.Forms.Label lblAbusePerpetrator;
		private System.Windows.Forms.GroupBox grpReferralInformation;
		private System.Windows.Forms.Label lblShelterUseBefore;
		private System.Windows.Forms.Label lblOurPlaceIIBefore;
		private System.Windows.Forms.Label lblTimes;
		private System.Windows.Forms.TextBox txtTimes;
		private System.Windows.Forms.Label lblOurPlaceRecentStay;
		private System.Windows.Forms.TextBox txtOurPlaceRecentStay;
		private System.Windows.Forms.GroupBox grpShelterUse;
		private OUR_PLACE.ctlYesNo chkShelterUseBefore;
		private OUR_PLACE.ctlYesNo chkOurPlaceIIBefore;
		private System.Windows.Forms.GroupBox grpGender;
		private System.Windows.Forms.DateTimePicker dtmDateAdmission;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ctlPage1()
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
			this.txtFileNo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblDateAdmission = new System.Windows.Forms.Label();
			this.lblDateDischarge = new System.Windows.Forms.Label();
			this.dtmDateDischarge = new System.Windows.Forms.DateTimePicker();
			this.lblDateDischargeAdditional = new System.Windows.Forms.Label();
			this.lblLocation = new System.Windows.Forms.Label();
			this.cboLocation = new System.Windows.Forms.ComboBox();
			this.lblLastName = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.lblMiddleName = new System.Windows.Forms.Label();
			this.txtMiddleName = new System.Windows.Forms.TextBox();
			this.lblAKA = new System.Windows.Forms.Label();
			this.txtAKA = new System.Windows.Forms.TextBox();
			this.lblAgeIntake = new System.Windows.Forms.Label();
			this.txtAgeIntake = new System.Windows.Forms.TextBox();
			this.lblCurrentAge = new System.Windows.Forms.Label();
			this.txtCurrentAge = new System.Windows.Forms.TextBox();
			this.dtmBirthDate = new System.Windows.Forms.DateTimePicker();
			this.lblBirthDate = new System.Windows.Forms.Label();
			this.btnMale = new System.Windows.Forms.RadioButton();
			this.btnFemale = new System.Windows.Forms.RadioButton();
			this.grpPersonalData = new System.Windows.Forms.GroupBox();
			this.grpGender = new System.Windows.Forms.GroupBox();
			this.chkSocialInsurance = new System.Windows.Forms.CheckBox();
			this.txtSocialInsurance = new System.Windows.Forms.TextBox();
			this.txtHealthCard = new System.Windows.Forms.TextBox();
			this.chkHealthCard = new System.Windows.Forms.CheckBox();
			this.txtDriversLicence = new System.Windows.Forms.TextBox();
			this.chkDriversLicence = new System.Windows.Forms.CheckBox();
			this.txtBirthCertificate = new System.Windows.Forms.TextBox();
			this.chkBirthCertificate = new System.Windows.Forms.CheckBox();
			this.txtOtherIdentification = new System.Windows.Forms.TextBox();
			this.chkOtherIdentification = new System.Windows.Forms.CheckBox();
			this.txtCitizenship = new System.Windows.Forms.TextBox();
			this.chkCitizenship = new System.Windows.Forms.CheckBox();
			this.txtPassport = new System.Windows.Forms.TextBox();
			this.chkPassport = new System.Windows.Forms.CheckBox();
			this.txtSchoolID = new System.Windows.Forms.TextBox();
			this.chkSchoolID = new System.Windows.Forms.CheckBox();
			this.txtOtherTypeIdentification = new System.Windows.Forms.TextBox();
			this.lblOtherTypeIdentification = new System.Windows.Forms.Label();
			this.grpIdentification = new System.Windows.Forms.GroupBox();
			this.lblReferralSource = new System.Windows.Forms.Label();
			this.cboReferralSource = new System.Windows.Forms.ComboBox();
			this.lblReferralReason = new System.Windows.Forms.Label();
			this.chkParentTeenConflict = new System.Windows.Forms.CheckBox();
			this.chkSiblingConflict = new System.Windows.Forms.CheckBox();
			this.chkLostOwnAccomodation = new System.Windows.Forms.CheckBox();
			this.chkAbuse = new System.Windows.Forms.CheckBox();
			this.chkHospitalDischarge = new System.Windows.Forms.CheckBox();
			this.chkMentalHealthIssues = new System.Windows.Forms.CheckBox();
			this.chkResidingAtOther = new System.Windows.Forms.CheckBox();
			this.chkResidingAtShelter = new System.Windows.Forms.CheckBox();
			this.chkParentalDrugAlcohol = new System.Windows.Forms.CheckBox();
			this.chkSponsorshipBreakdown = new System.Windows.Forms.CheckBox();
			this.chkInsufficientRoom = new System.Windows.Forms.CheckBox();
			this.chkFosterCareBreakdown = new System.Windows.Forms.CheckBox();
			this.chkParentalMentalHealthIssues = new System.Windows.Forms.CheckBox();
			this.chkOtherReferralReason = new System.Windows.Forms.CheckBox();
			this.txtOtherReferralReason = new System.Windows.Forms.TextBox();
			this.lblAbuseKind = new System.Windows.Forms.Label();
			this.txtAbuseKind = new System.Windows.Forms.TextBox();
			this.txtAbusePerpetrator = new System.Windows.Forms.TextBox();
			this.lblAbusePerpetrator = new System.Windows.Forms.Label();
			this.grpReferralInformation = new System.Windows.Forms.GroupBox();
			this.lblShelterUseBefore = new System.Windows.Forms.Label();
			this.lblOurPlaceIIBefore = new System.Windows.Forms.Label();
			this.lblTimes = new System.Windows.Forms.Label();
			this.txtTimes = new System.Windows.Forms.TextBox();
			this.lblOurPlaceRecentStay = new System.Windows.Forms.Label();
			this.txtOurPlaceRecentStay = new System.Windows.Forms.TextBox();
			this.grpShelterUse = new System.Windows.Forms.GroupBox();
			this.dtmDateAdmission = new System.Windows.Forms.DateTimePicker();
			this.grpPersonalData.SuspendLayout();
			this.grpGender.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtFileNo
			// 
			this.txtFileNo.Location = new System.Drawing.Point(192, 16);
			this.txtFileNo.Name = "txtFileNo";
			this.txtFileNo.TabIndex = 0;
			this.txtFileNo.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 1;
			this.label1.Text = "File #";
			// 
			// lblDateAdmission
			// 
			this.lblDateAdmission.Location = new System.Drawing.Point(16, 40);
			this.lblDateAdmission.Name = "lblDateAdmission";
			this.lblDateAdmission.TabIndex = 2;
			this.lblDateAdmission.Text = "Date of Admission";
			// 
			// lblDateDischarge
			// 
			this.lblDateDischarge.Location = new System.Drawing.Point(16, 64);
			this.lblDateDischarge.Name = "lblDateDischarge";
			this.lblDateDischarge.Size = new System.Drawing.Size(160, 16);
			this.lblDateDischarge.TabIndex = 4;
			this.lblDateDischarge.Text = "Anticipated Date of Discharge";
			// 
			// dtmDateDischarge
			// 
			this.dtmDateDischarge.Location = new System.Drawing.Point(192, 64);
			this.dtmDateDischarge.Name = "dtmDateDischarge";
			this.dtmDateDischarge.TabIndex = 6;
			// 
			// lblDateDischargeAdditional
			// 
			this.lblDateDischargeAdditional.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblDateDischargeAdditional.Location = new System.Drawing.Point(16, 80);
			this.lblDateDischargeAdditional.Name = "lblDateDischargeAdditional";
			this.lblDateDischargeAdditional.Size = new System.Drawing.Size(128, 23);
			this.lblDateDischargeAdditional.TabIndex = 7;
			this.lblDateDischargeAdditional.Text = "(3 wks from Intake Date)";
			// 
			// lblLocation
			// 
			this.lblLocation.Location = new System.Drawing.Point(16, 96);
			this.lblLocation.Name = "lblLocation";
			this.lblLocation.TabIndex = 8;
			this.lblLocation.Text = "Location";
			// 
			// cboLocation
			// 
			this.cboLocation.Location = new System.Drawing.Point(192, 96);
			this.cboLocation.Name = "cboLocation";
			this.cboLocation.Size = new System.Drawing.Size(121, 21);
			this.cboLocation.TabIndex = 9;
			// 
			// lblLastName
			// 
			this.lblLastName.Location = new System.Drawing.Point(16, 136);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.TabIndex = 10;
			this.lblLastName.Text = "Last Name";
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(192, 136);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.TabIndex = 11;
			this.txtLastName.Text = "";
			// 
			// lblFirstName
			// 
			this.lblFirstName.Location = new System.Drawing.Point(16, 160);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.TabIndex = 12;
			this.lblFirstName.Text = "First Name";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(192, 160);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.TabIndex = 13;
			this.txtFirstName.Text = "";
			// 
			// lblMiddleName
			// 
			this.lblMiddleName.Location = new System.Drawing.Point(16, 184);
			this.lblMiddleName.Name = "lblMiddleName";
			this.lblMiddleName.TabIndex = 14;
			this.lblMiddleName.Text = "Middle Name";
			// 
			// txtMiddleName
			// 
			this.txtMiddleName.Location = new System.Drawing.Point(192, 184);
			this.txtMiddleName.Name = "txtMiddleName";
			this.txtMiddleName.TabIndex = 15;
			this.txtMiddleName.Text = "";
			// 
			// lblAKA
			// 
			this.lblAKA.Location = new System.Drawing.Point(16, 208);
			this.lblAKA.Name = "lblAKA";
			this.lblAKA.Size = new System.Drawing.Size(168, 23);
			this.lblAKA.TabIndex = 16;
			this.lblAKA.Text = "Other names known by (A.K.A.)";
			// 
			// txtAKA
			// 
			this.txtAKA.Location = new System.Drawing.Point(192, 208);
			this.txtAKA.Name = "txtAKA";
			this.txtAKA.TabIndex = 17;
			this.txtAKA.Text = "";
			// 
			// lblAgeIntake
			// 
			this.lblAgeIntake.Location = new System.Drawing.Point(16, 232);
			this.lblAgeIntake.Name = "lblAgeIntake";
			this.lblAgeIntake.TabIndex = 18;
			this.lblAgeIntake.Text = "Age at Intake";
			// 
			// txtAgeIntake
			// 
			this.txtAgeIntake.Location = new System.Drawing.Point(192, 232);
			this.txtAgeIntake.Name = "txtAgeIntake";
			this.txtAgeIntake.TabIndex = 19;
			this.txtAgeIntake.Text = "";
			// 
			// lblCurrentAge
			// 
			this.lblCurrentAge.Location = new System.Drawing.Point(16, 256);
			this.lblCurrentAge.Name = "lblCurrentAge";
			this.lblCurrentAge.TabIndex = 20;
			this.lblCurrentAge.Text = "Current Age";
			// 
			// txtCurrentAge
			// 
			this.txtCurrentAge.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.txtCurrentAge.Location = new System.Drawing.Point(192, 256);
			this.txtCurrentAge.Name = "txtCurrentAge";
			this.txtCurrentAge.TabIndex = 21;
			this.txtCurrentAge.Text = "";
			// 
			// dtmBirthDate
			// 
			this.dtmBirthDate.Location = new System.Drawing.Point(192, 280);
			this.dtmBirthDate.Name = "dtmBirthDate";
			this.dtmBirthDate.TabIndex = 23;
			// 
			// lblBirthDate
			// 
			this.lblBirthDate.Location = new System.Drawing.Point(16, 280);
			this.lblBirthDate.Name = "lblBirthDate";
			this.lblBirthDate.Size = new System.Drawing.Size(160, 16);
			this.lblBirthDate.TabIndex = 22;
			this.lblBirthDate.Text = "Date of Birth";
			// 
			// btnMale
			// 
			this.btnMale.Location = new System.Drawing.Point(16, 16);
			this.btnMale.Name = "btnMale";
			this.btnMale.Size = new System.Drawing.Size(48, 24);
			this.btnMale.TabIndex = 25;
			this.btnMale.Text = "Male";
			// 
			// btnFemale
			// 
			this.btnFemale.Location = new System.Drawing.Point(72, 16);
			this.btnFemale.Name = "btnFemale";
			this.btnFemale.Size = new System.Drawing.Size(64, 24);
			this.btnFemale.TabIndex = 26;
			this.btnFemale.Text = "Female";
			// 
			// grpPersonalData
			// 
			this.grpPersonalData.Controls.Add(this.grpGender);
			this.grpPersonalData.Location = new System.Drawing.Point(8, 120);
			this.grpPersonalData.Name = "grpPersonalData";
			this.grpPersonalData.Size = new System.Drawing.Size(632, 192);
			this.grpPersonalData.TabIndex = 27;
			this.grpPersonalData.TabStop = false;
			this.grpPersonalData.Text = "Personal Data";
			// 
			// grpGender
			// 
			this.grpGender.Controls.Add(this.btnMale);
			this.grpGender.Controls.Add(this.btnFemale);
			this.grpGender.Location = new System.Drawing.Point(408, 136);
			this.grpGender.Name = "grpGender";
			this.grpGender.Size = new System.Drawing.Size(144, 48);
			this.grpGender.TabIndex = 0;
			this.grpGender.TabStop = false;
			this.grpGender.Text = "Gender";
			// 
			// chkSocialInsurance
			// 
			this.chkSocialInsurance.Location = new System.Drawing.Point(16, 336);
			this.chkSocialInsurance.Name = "chkSocialInsurance";
			this.chkSocialInsurance.Size = new System.Drawing.Size(120, 24);
			this.chkSocialInsurance.TabIndex = 28;
			this.chkSocialInsurance.Text = "Social Insurance";
			// 
			// txtSocialInsurance
			// 
			this.txtSocialInsurance.Location = new System.Drawing.Point(136, 336);
			this.txtSocialInsurance.Name = "txtSocialInsurance";
			this.txtSocialInsurance.TabIndex = 29;
			this.txtSocialInsurance.Text = "";
			// 
			// txtHealthCard
			// 
			this.txtHealthCard.Location = new System.Drawing.Point(136, 360);
			this.txtHealthCard.Name = "txtHealthCard";
			this.txtHealthCard.TabIndex = 31;
			this.txtHealthCard.Text = "";
			// 
			// chkHealthCard
			// 
			this.chkHealthCard.Location = new System.Drawing.Point(16, 360);
			this.chkHealthCard.Name = "chkHealthCard";
			this.chkHealthCard.Size = new System.Drawing.Size(120, 24);
			this.chkHealthCard.TabIndex = 30;
			this.chkHealthCard.Text = "Health Card";
			// 
			// txtDriversLicence
			// 
			this.txtDriversLicence.Location = new System.Drawing.Point(136, 408);
			this.txtDriversLicence.Name = "txtDriversLicence";
			this.txtDriversLicence.TabIndex = 35;
			this.txtDriversLicence.Text = "";
			// 
			// chkDriversLicence
			// 
			this.chkDriversLicence.Location = new System.Drawing.Point(16, 408);
			this.chkDriversLicence.Name = "chkDriversLicence";
			this.chkDriversLicence.Size = new System.Drawing.Size(120, 24);
			this.chkDriversLicence.TabIndex = 34;
			this.chkDriversLicence.Text = "Drivers Licence";
			// 
			// txtBirthCertificate
			// 
			this.txtBirthCertificate.Location = new System.Drawing.Point(136, 384);
			this.txtBirthCertificate.Name = "txtBirthCertificate";
			this.txtBirthCertificate.TabIndex = 33;
			this.txtBirthCertificate.Text = "";
			// 
			// chkBirthCertificate
			// 
			this.chkBirthCertificate.Location = new System.Drawing.Point(16, 384);
			this.chkBirthCertificate.Name = "chkBirthCertificate";
			this.chkBirthCertificate.Size = new System.Drawing.Size(120, 24);
			this.chkBirthCertificate.TabIndex = 32;
			this.chkBirthCertificate.Text = "Birth Certificate";
			// 
			// txtOtherIdentification
			// 
			this.txtOtherIdentification.Location = new System.Drawing.Point(408, 408);
			this.txtOtherIdentification.Name = "txtOtherIdentification";
			this.txtOtherIdentification.TabIndex = 43;
			this.txtOtherIdentification.Text = "";
			// 
			// chkOtherIdentification
			// 
			this.chkOtherIdentification.Location = new System.Drawing.Point(288, 408);
			this.chkOtherIdentification.Name = "chkOtherIdentification";
			this.chkOtherIdentification.Size = new System.Drawing.Size(120, 24);
			this.chkOtherIdentification.TabIndex = 42;
			this.chkOtherIdentification.Text = "Other";
			// 
			// txtCitizenship
			// 
			this.txtCitizenship.Location = new System.Drawing.Point(408, 384);
			this.txtCitizenship.Name = "txtCitizenship";
			this.txtCitizenship.TabIndex = 41;
			this.txtCitizenship.Text = "";
			// 
			// chkCitizenship
			// 
			this.chkCitizenship.Location = new System.Drawing.Point(288, 384);
			this.chkCitizenship.Name = "chkCitizenship";
			this.chkCitizenship.Size = new System.Drawing.Size(120, 24);
			this.chkCitizenship.TabIndex = 40;
			this.chkCitizenship.Text = "Citizenship";
			// 
			// txtPassport
			// 
			this.txtPassport.Location = new System.Drawing.Point(408, 360);
			this.txtPassport.Name = "txtPassport";
			this.txtPassport.TabIndex = 39;
			this.txtPassport.Text = "";
			// 
			// chkPassport
			// 
			this.chkPassport.Location = new System.Drawing.Point(288, 360);
			this.chkPassport.Name = "chkPassport";
			this.chkPassport.Size = new System.Drawing.Size(120, 24);
			this.chkPassport.TabIndex = 38;
			this.chkPassport.Text = "Passport";
			// 
			// txtSchoolID
			// 
			this.txtSchoolID.Location = new System.Drawing.Point(408, 336);
			this.txtSchoolID.Name = "txtSchoolID";
			this.txtSchoolID.TabIndex = 37;
			this.txtSchoolID.Text = "";
			// 
			// chkSchoolID
			// 
			this.chkSchoolID.Location = new System.Drawing.Point(288, 336);
			this.chkSchoolID.Name = "chkSchoolID";
			this.chkSchoolID.Size = new System.Drawing.Size(120, 24);
			this.chkSchoolID.TabIndex = 36;
			this.chkSchoolID.Text = "School I.D.";
			// 
			// txtOtherTypeIdentification
			// 
			this.txtOtherTypeIdentification.Location = new System.Drawing.Point(408, 432);
			this.txtOtherTypeIdentification.Name = "txtOtherTypeIdentification";
			this.txtOtherTypeIdentification.TabIndex = 44;
			this.txtOtherTypeIdentification.Text = "";
			// 
			// lblOtherTypeIdentification
			// 
			this.lblOtherTypeIdentification.Location = new System.Drawing.Point(288, 432);
			this.lblOtherTypeIdentification.Name = "lblOtherTypeIdentification";
			this.lblOtherTypeIdentification.TabIndex = 45;
			this.lblOtherTypeIdentification.Text = "Other Type";
			// 
			// grpIdentification
			// 
			this.grpIdentification.Location = new System.Drawing.Point(8, 320);
			this.grpIdentification.Name = "grpIdentification";
			this.grpIdentification.Size = new System.Drawing.Size(632, 144);
			this.grpIdentification.TabIndex = 46;
			this.grpIdentification.TabStop = false;
			this.grpIdentification.Text = "Identification";
			// 
			// lblReferralSource
			// 
			this.lblReferralSource.Location = new System.Drawing.Point(16, 488);
			this.lblReferralSource.Name = "lblReferralSource";
			this.lblReferralSource.TabIndex = 47;
			this.lblReferralSource.Text = "Referral Source";
			// 
			// cboReferralSource
			// 
			this.cboReferralSource.Location = new System.Drawing.Point(136, 488);
			this.cboReferralSource.Name = "cboReferralSource";
			this.cboReferralSource.Size = new System.Drawing.Size(121, 21);
			this.cboReferralSource.TabIndex = 48;
			// 
			// lblReferralReason
			// 
			this.lblReferralReason.Location = new System.Drawing.Point(16, 512);
			this.lblReferralReason.Name = "lblReferralReason";
			this.lblReferralReason.Size = new System.Drawing.Size(128, 23);
			this.lblReferralReason.TabIndex = 49;
			this.lblReferralReason.Text = "Reason for Referral";
			// 
			// chkParentTeenConflict
			// 
			this.chkParentTeenConflict.Location = new System.Drawing.Point(16, 536);
			this.chkParentTeenConflict.Name = "chkParentTeenConflict";
			this.chkParentTeenConflict.Size = new System.Drawing.Size(160, 24);
			this.chkParentTeenConflict.TabIndex = 50;
			this.chkParentTeenConflict.Text = "(step) Parent/Teen Conflict";
			// 
			// chkSiblingConflict
			// 
			this.chkSiblingConflict.Location = new System.Drawing.Point(16, 560);
			this.chkSiblingConflict.Name = "chkSiblingConflict";
			this.chkSiblingConflict.Size = new System.Drawing.Size(160, 24);
			this.chkSiblingConflict.TabIndex = 51;
			this.chkSiblingConflict.Text = "Sibling Conflict";
			// 
			// chkLostOwnAccomodation
			// 
			this.chkLostOwnAccomodation.Location = new System.Drawing.Point(16, 608);
			this.chkLostOwnAccomodation.Name = "chkLostOwnAccomodation";
			this.chkLostOwnAccomodation.Size = new System.Drawing.Size(160, 24);
			this.chkLostOwnAccomodation.TabIndex = 53;
			this.chkLostOwnAccomodation.Text = "Lost own accomodation";
			// 
			// chkAbuse
			// 
			this.chkAbuse.Location = new System.Drawing.Point(16, 584);
			this.chkAbuse.Name = "chkAbuse";
			this.chkAbuse.Size = new System.Drawing.Size(160, 24);
			this.chkAbuse.TabIndex = 52;
			this.chkAbuse.Text = "Abuse";
			// 
			// chkHospitalDischarge
			// 
			this.chkHospitalDischarge.Location = new System.Drawing.Point(192, 608);
			this.chkHospitalDischarge.Name = "chkHospitalDischarge";
			this.chkHospitalDischarge.Size = new System.Drawing.Size(160, 24);
			this.chkHospitalDischarge.TabIndex = 57;
			this.chkHospitalDischarge.Text = "Hospital Discharge";
			// 
			// chkMentalHealthIssues
			// 
			this.chkMentalHealthIssues.Location = new System.Drawing.Point(192, 584);
			this.chkMentalHealthIssues.Name = "chkMentalHealthIssues";
			this.chkMentalHealthIssues.Size = new System.Drawing.Size(160, 24);
			this.chkMentalHealthIssues.TabIndex = 56;
			this.chkMentalHealthIssues.Text = "Mental Health Issues";
			// 
			// chkResidingAtOther
			// 
			this.chkResidingAtOther.Location = new System.Drawing.Point(192, 560);
			this.chkResidingAtOther.Name = "chkResidingAtOther";
			this.chkResidingAtOther.Size = new System.Drawing.Size(224, 24);
			this.chkResidingAtOther.TabIndex = 55;
			this.chkResidingAtOther.Text = "Residing at Other Residential Program";
			// 
			// chkResidingAtShelter
			// 
			this.chkResidingAtShelter.Location = new System.Drawing.Point(192, 536);
			this.chkResidingAtShelter.Name = "chkResidingAtShelter";
			this.chkResidingAtShelter.Size = new System.Drawing.Size(160, 24);
			this.chkResidingAtShelter.TabIndex = 54;
			this.chkResidingAtShelter.Text = "Residing at Shelter";
			// 
			// chkParentalDrugAlcohol
			// 
			this.chkParentalDrugAlcohol.Location = new System.Drawing.Point(424, 608);
			this.chkParentalDrugAlcohol.Name = "chkParentalDrugAlcohol";
			this.chkParentalDrugAlcohol.Size = new System.Drawing.Size(160, 24);
			this.chkParentalDrugAlcohol.TabIndex = 61;
			this.chkParentalDrugAlcohol.Text = "Parental Drug/Alcohol";
			// 
			// chkSponsorshipBreakdown
			// 
			this.chkSponsorshipBreakdown.Location = new System.Drawing.Point(424, 584);
			this.chkSponsorshipBreakdown.Name = "chkSponsorshipBreakdown";
			this.chkSponsorshipBreakdown.Size = new System.Drawing.Size(160, 24);
			this.chkSponsorshipBreakdown.TabIndex = 60;
			this.chkSponsorshipBreakdown.Text = "Sponsorship Breakdown";
			// 
			// chkInsufficientRoom
			// 
			this.chkInsufficientRoom.Location = new System.Drawing.Point(424, 560);
			this.chkInsufficientRoom.Name = "chkInsufficientRoom";
			this.chkInsufficientRoom.Size = new System.Drawing.Size(160, 24);
			this.chkInsufficientRoom.TabIndex = 59;
			this.chkInsufficientRoom.Text = "Insufficient Room at Home";
			// 
			// chkFosterCareBreakdown
			// 
			this.chkFosterCareBreakdown.Location = new System.Drawing.Point(424, 536);
			this.chkFosterCareBreakdown.Name = "chkFosterCareBreakdown";
			this.chkFosterCareBreakdown.Size = new System.Drawing.Size(160, 24);
			this.chkFosterCareBreakdown.TabIndex = 58;
			this.chkFosterCareBreakdown.Text = "Foster Care Breakdown";
			// 
			// chkParentalMentalHealthIssues
			// 
			this.chkParentalMentalHealthIssues.Location = new System.Drawing.Point(16, 632);
			this.chkParentalMentalHealthIssues.Name = "chkParentalMentalHealthIssues";
			this.chkParentalMentalHealthIssues.Size = new System.Drawing.Size(184, 24);
			this.chkParentalMentalHealthIssues.TabIndex = 62;
			this.chkParentalMentalHealthIssues.Text = "Parental Mental Health Issues";
			// 
			// chkOtherReferralReason
			// 
			this.chkOtherReferralReason.Location = new System.Drawing.Point(192, 632);
			this.chkOtherReferralReason.Name = "chkOtherReferralReason";
			this.chkOtherReferralReason.TabIndex = 63;
			this.chkOtherReferralReason.Text = "Other";
			// 
			// txtOtherReferralReason
			// 
			this.txtOtherReferralReason.Location = new System.Drawing.Point(264, 632);
			this.txtOtherReferralReason.Name = "txtOtherReferralReason";
			this.txtOtherReferralReason.Size = new System.Drawing.Size(144, 20);
			this.txtOtherReferralReason.TabIndex = 64;
			this.txtOtherReferralReason.Text = "";
			// 
			// lblAbuseKind
			// 
			this.lblAbuseKind.Location = new System.Drawing.Point(16, 664);
			this.lblAbuseKind.Name = "lblAbuseKind";
			this.lblAbuseKind.Size = new System.Drawing.Size(112, 23);
			this.lblAbuseKind.TabIndex = 65;
			this.lblAbuseKind.Text = "If abused, what kind?";
			// 
			// txtAbuseKind
			// 
			this.txtAbuseKind.Location = new System.Drawing.Point(152, 664);
			this.txtAbuseKind.Name = "txtAbuseKind";
			this.txtAbuseKind.TabIndex = 66;
			this.txtAbuseKind.Text = "";
			// 
			// txtAbusePerpetrator
			// 
			this.txtAbusePerpetrator.Location = new System.Drawing.Point(152, 688);
			this.txtAbusePerpetrator.Name = "txtAbusePerpetrator";
			this.txtAbusePerpetrator.TabIndex = 68;
			this.txtAbusePerpetrator.Text = "";
			// 
			// lblAbusePerpetrator
			// 
			this.lblAbusePerpetrator.Location = new System.Drawing.Point(16, 688);
			this.lblAbusePerpetrator.Name = "lblAbusePerpetrator";
			this.lblAbusePerpetrator.Size = new System.Drawing.Size(120, 23);
			this.lblAbusePerpetrator.TabIndex = 67;
			this.lblAbusePerpetrator.Text = "If abused, perpetrator?";
			// 
			// grpReferralInformation
			// 
			this.grpReferralInformation.Location = new System.Drawing.Point(8, 472);
			this.grpReferralInformation.Name = "grpReferralInformation";
			this.grpReferralInformation.Size = new System.Drawing.Size(648, 248);
			this.grpReferralInformation.TabIndex = 69;
			this.grpReferralInformation.TabStop = false;
			this.grpReferralInformation.Text = "Referral Information";
			// 
			// lblShelterUseBefore
			// 
			this.lblShelterUseBefore.Location = new System.Drawing.Point(16, 744);
			this.lblShelterUseBefore.Name = "lblShelterUseBefore";
			this.lblShelterUseBefore.Size = new System.Drawing.Size(192, 23);
			this.lblShelterUseBefore.TabIndex = 70;
			this.lblShelterUseBefore.Text = "Has youth stayed at a shelter before?";
			// 
			// lblOurPlaceIIBefore
			// 
			this.lblOurPlaceIIBefore.Location = new System.Drawing.Point(16, 768);
			this.lblOurPlaceIIBefore.Name = "lblOurPlaceIIBefore";
			this.lblOurPlaceIIBefore.Size = new System.Drawing.Size(208, 23);
			this.lblOurPlaceIIBefore.TabIndex = 73;
			this.lblOurPlaceIIBefore.Text = "Has youth stayed at Our Place II before?";
			// 
			// lblTimes
			// 
			this.lblTimes.Location = new System.Drawing.Point(16, 792);
			this.lblTimes.Name = "lblTimes";
			this.lblTimes.Size = new System.Drawing.Size(152, 23);
			this.lblTimes.TabIndex = 76;
			this.lblTimes.Text = "If yes: How many times?";
			// 
			// txtTimes
			// 
			this.txtTimes.Location = new System.Drawing.Point(368, 792);
			this.txtTimes.Name = "txtTimes";
			this.txtTimes.TabIndex = 77;
			this.txtTimes.Text = "";
			// 
			// lblOurPlaceRecentStay
			// 
			this.lblOurPlaceRecentStay.Location = new System.Drawing.Point(16, 816);
			this.lblOurPlaceRecentStay.Name = "lblOurPlaceRecentStay";
			this.lblOurPlaceRecentStay.Size = new System.Drawing.Size(352, 23);
			this.lblOurPlaceRecentStay.TabIndex = 78;
			this.lblOurPlaceRecentStay.Text = "How many months ago was his/her most recent stay at Our Place II?";
			// 
			// txtOurPlaceRecentStay
			// 
			this.txtOurPlaceRecentStay.Location = new System.Drawing.Point(368, 816);
			this.txtOurPlaceRecentStay.Name = "txtOurPlaceRecentStay";
			this.txtOurPlaceRecentStay.TabIndex = 79;
			this.txtOurPlaceRecentStay.Text = "";
			// 
			// grpShelterUse
			// 
			this.grpShelterUse.Location = new System.Drawing.Point(8, 728);
			this.grpShelterUse.Name = "grpShelterUse";
			this.grpShelterUse.Size = new System.Drawing.Size(632, 120);
			this.grpShelterUse.TabIndex = 80;
			this.grpShelterUse.TabStop = false;
			this.grpShelterUse.Text = "Shelter Use";
			// 
			// dtmDateAdmission
			// 
			this.dtmDateAdmission.Location = new System.Drawing.Point(192, 40);
			this.dtmDateAdmission.Name = "dtmDateAdmission";
			this.dtmDateAdmission.TabIndex = 81;
			// 
			// ctlPage1
			// 
			this.AutoScroll = true;
			this.Controls.Add(this.dtmDateAdmission);
			this.Controls.Add(this.txtOurPlaceRecentStay);
			this.Controls.Add(this.lblOurPlaceRecentStay);
			this.Controls.Add(this.txtTimes);
			this.Controls.Add(this.lblTimes);
			this.Controls.Add(this.lblOurPlaceIIBefore);
			this.Controls.Add(this.lblShelterUseBefore);
			this.Controls.Add(this.txtAbusePerpetrator);
			this.Controls.Add(this.lblAbusePerpetrator);
			this.Controls.Add(this.txtAbuseKind);
			this.Controls.Add(this.lblAbuseKind);
			this.Controls.Add(this.txtOtherReferralReason);
			this.Controls.Add(this.chkOtherReferralReason);
			this.Controls.Add(this.chkParentalMentalHealthIssues);
			this.Controls.Add(this.chkParentalDrugAlcohol);
			this.Controls.Add(this.chkSponsorshipBreakdown);
			this.Controls.Add(this.chkInsufficientRoom);
			this.Controls.Add(this.chkFosterCareBreakdown);
			this.Controls.Add(this.chkHospitalDischarge);
			this.Controls.Add(this.chkMentalHealthIssues);
			this.Controls.Add(this.chkResidingAtOther);
			this.Controls.Add(this.chkResidingAtShelter);
			this.Controls.Add(this.chkLostOwnAccomodation);
			this.Controls.Add(this.chkAbuse);
			this.Controls.Add(this.chkSiblingConflict);
			this.Controls.Add(this.chkParentTeenConflict);
			this.Controls.Add(this.lblReferralReason);
			this.Controls.Add(this.cboReferralSource);
			this.Controls.Add(this.lblReferralSource);
			this.Controls.Add(this.lblOtherTypeIdentification);
			this.Controls.Add(this.txtOtherTypeIdentification);
			this.Controls.Add(this.txtOtherIdentification);
			this.Controls.Add(this.chkOtherIdentification);
			this.Controls.Add(this.txtCitizenship);
			this.Controls.Add(this.chkCitizenship);
			this.Controls.Add(this.txtPassport);
			this.Controls.Add(this.chkPassport);
			this.Controls.Add(this.txtSchoolID);
			this.Controls.Add(this.chkSchoolID);
			this.Controls.Add(this.txtDriversLicence);
			this.Controls.Add(this.chkDriversLicence);
			this.Controls.Add(this.txtBirthCertificate);
			this.Controls.Add(this.chkBirthCertificate);
			this.Controls.Add(this.txtHealthCard);
			this.Controls.Add(this.chkHealthCard);
			this.Controls.Add(this.txtSocialInsurance);
			this.Controls.Add(this.chkSocialInsurance);
			this.Controls.Add(this.dtmBirthDate);
			this.Controls.Add(this.lblBirthDate);
			this.Controls.Add(this.txtCurrentAge);
			this.Controls.Add(this.lblCurrentAge);
			this.Controls.Add(this.txtAgeIntake);
			this.Controls.Add(this.lblAgeIntake);
			this.Controls.Add(this.txtAKA);
			this.Controls.Add(this.lblAKA);
			this.Controls.Add(this.txtMiddleName);
			this.Controls.Add(this.lblMiddleName);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.lblFirstName);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.cboLocation);
			this.Controls.Add(this.lblLocation);
			this.Controls.Add(this.lblDateDischargeAdditional);
			this.Controls.Add(this.dtmDateDischarge);
			this.Controls.Add(this.lblDateDischarge);
			this.Controls.Add(this.lblDateAdmission);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtFileNo);
			this.Controls.Add(this.grpPersonalData);
			this.Controls.Add(this.grpIdentification);
			this.Controls.Add(this.grpReferralInformation);
			this.Controls.Add(this.grpShelterUse);
			this.Name = "ctlPage1";
			this.Size = new System.Drawing.Size(631, 839);
			this.grpPersonalData.ResumeLayout(false);
			this.grpGender.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Private Methods

		private void LoadCombos()
		{
			StaticMethods.LoadCombos(cboLocation, "LOCATION");
			StaticMethods.LoadCombos(cboReferralSource, "REFERRAL_SOURCE");
		}

		#endregion
	}
}
