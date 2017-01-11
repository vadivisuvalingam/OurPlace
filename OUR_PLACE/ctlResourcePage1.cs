using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace OUR_PLACE
{
	/// <summary>
	/// Summary description for ctlResourcePage1.
	/// </summary>
	public class ctlResourcePage1 : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.GroupBox grpPersonalData;
		private System.Windows.Forms.Label lblOtherCommunityServices;
		private System.Windows.Forms.TextBox txtHomeCommunity;
		private System.Windows.Forms.ComboBox cboHomeCommunity;
		private System.Windows.Forms.Label lblHomeCommunity;
		private System.Windows.Forms.TextBox txtLivingSituationExtended;
		private System.Windows.Forms.ComboBox cboLivingSituation;
		private System.Windows.Forms.Label lblLivingSituation;
		private System.Windows.Forms.TextBox txtResourceRoomSourceExtended;
		private System.Windows.Forms.ComboBox cboResourceRoomSource;
		private System.Windows.Forms.Label lblResourceRoomSource;
		private System.Windows.Forms.Label lblResourceRoomUsage;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.GroupBox grpGender;
		private System.Windows.Forms.RadioButton btnFemale;
		private System.Windows.Forms.RadioButton btnMale;
		private System.Windows.Forms.DateTimePicker dtmBirthDate;
		private System.Windows.Forms.Label lblBirthDate;
		private System.Windows.Forms.DateTimePicker dtmDate;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFileNo;
		private System.Windows.Forms.TextBox txtAKA;
		private System.Windows.Forms.Label lblAKA;
		private System.Windows.Forms.TextBox txtMiddleName;
		private System.Windows.Forms.Label lblMiddleName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.GroupBox grpEthnicCulturalBackground;
		private System.Windows.Forms.TextBox txtMotherTongueExtended;
		private System.Windows.Forms.ComboBox cboMotherTongue;
		private System.Windows.Forms.Label lblMotherTongue;
		private System.Windows.Forms.TextBox txtCountryOriginExtended;
		private System.Windows.Forms.ComboBox cboCountryOrigin;
		private System.Windows.Forms.Label lblCountryOrigin;
		private System.Windows.Forms.TextBox txtOtherStatusCanadaExtended;
		private System.Windows.Forms.Label lblStatusCanada;
		private System.Windows.Forms.Label lblCurrentlySchool;
		private System.Windows.Forms.GroupBox grpEducation;
		private System.Windows.Forms.Label lblSchoolStatus;
		private System.Windows.Forms.CheckBox chkFullTimeSchool;
		private System.Windows.Forms.CheckBox chkPartTimeSchool;
		private System.Windows.Forms.Label lblSchoolName;
		private System.Windows.Forms.TextBox txtSchoolName;
		private System.Windows.Forms.ComboBox cboLastGradeCompleted;
		private System.Windows.Forms.Label lblLastGradeCompleted;
		private System.Windows.Forms.GroupBox grpIncome;
		private System.Windows.Forms.CheckBox chkPartTimeJob;
		private System.Windows.Forms.CheckBox chkFullTimeJob;
		private System.Windows.Forms.Label lblJobStatus;
		private System.Windows.Forms.Label lblSocialAssistance;
		private System.Windows.Forms.CheckBox chkTempJob;
		private System.Windows.Forms.Label lblJob;
		private System.Windows.Forms.Label lblSocialAssistanceDetail;
		private OUR_PLACE.ctlYesNo chkOtherCommunityServices;
		private OUR_PLACE.ctlFreeText txtOtherCommunityServices;
		private OUR_PLACE.ctlYesNo chkResourceRoomUsage;
		private OUR_PLACE.ctlYesNo chkSocialAssistance;
		private OUR_PLACE.ctlYesNo chkCurrentlySchool;
		private OUR_PLACE.ctlYesNo chkJob;
		private System.Windows.Forms.CheckBox chkEI;
		private System.Windows.Forms.CheckBox chkODSP;
		private System.Windows.Forms.CheckBox chkCPPOrphan;
		private System.Windows.Forms.CheckBox chkWSIB;
		private System.Windows.Forms.CheckBox chkCAS;
		private System.Windows.Forms.CheckBox chkOW;
		private System.Windows.Forms.ComboBox cboStatusCanada;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ctlResourcePage1()
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
			this.grpPersonalData = new System.Windows.Forms.GroupBox();
			this.chkResourceRoomUsage = new OUR_PLACE.ctlYesNo();
			this.chkOtherCommunityServices = new OUR_PLACE.ctlYesNo();
			this.txtOtherCommunityServices = new OUR_PLACE.ctlFreeText();
			this.lblOtherCommunityServices = new System.Windows.Forms.Label();
			this.txtHomeCommunity = new System.Windows.Forms.TextBox();
			this.cboHomeCommunity = new System.Windows.Forms.ComboBox();
			this.lblHomeCommunity = new System.Windows.Forms.Label();
			this.txtLivingSituationExtended = new System.Windows.Forms.TextBox();
			this.cboLivingSituation = new System.Windows.Forms.ComboBox();
			this.lblLivingSituation = new System.Windows.Forms.Label();
			this.txtResourceRoomSourceExtended = new System.Windows.Forms.TextBox();
			this.cboResourceRoomSource = new System.Windows.Forms.ComboBox();
			this.lblResourceRoomSource = new System.Windows.Forms.Label();
			this.lblResourceRoomUsage = new System.Windows.Forms.Label();
			this.lblGender = new System.Windows.Forms.Label();
			this.grpGender = new System.Windows.Forms.GroupBox();
			this.btnFemale = new System.Windows.Forms.RadioButton();
			this.btnMale = new System.Windows.Forms.RadioButton();
			this.dtmBirthDate = new System.Windows.Forms.DateTimePicker();
			this.lblBirthDate = new System.Windows.Forms.Label();
			this.dtmDate = new System.Windows.Forms.DateTimePicker();
			this.lblDate = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFileNo = new System.Windows.Forms.TextBox();
			this.txtAKA = new System.Windows.Forms.TextBox();
			this.lblAKA = new System.Windows.Forms.Label();
			this.txtMiddleName = new System.Windows.Forms.TextBox();
			this.lblMiddleName = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.lblLastName = new System.Windows.Forms.Label();
			this.grpEthnicCulturalBackground = new System.Windows.Forms.GroupBox();
			this.cboStatusCanada = new System.Windows.Forms.ComboBox();
			this.txtMotherTongueExtended = new System.Windows.Forms.TextBox();
			this.cboMotherTongue = new System.Windows.Forms.ComboBox();
			this.lblMotherTongue = new System.Windows.Forms.Label();
			this.txtCountryOriginExtended = new System.Windows.Forms.TextBox();
			this.cboCountryOrigin = new System.Windows.Forms.ComboBox();
			this.lblCountryOrigin = new System.Windows.Forms.Label();
			this.txtOtherStatusCanadaExtended = new System.Windows.Forms.TextBox();
			this.lblStatusCanada = new System.Windows.Forms.Label();
			this.grpEducation = new System.Windows.Forms.GroupBox();
			this.chkCurrentlySchool = new OUR_PLACE.ctlYesNo();
			this.cboLastGradeCompleted = new System.Windows.Forms.ComboBox();
			this.lblLastGradeCompleted = new System.Windows.Forms.Label();
			this.txtSchoolName = new System.Windows.Forms.TextBox();
			this.lblSchoolName = new System.Windows.Forms.Label();
			this.chkPartTimeSchool = new System.Windows.Forms.CheckBox();
			this.chkFullTimeSchool = new System.Windows.Forms.CheckBox();
			this.lblSchoolStatus = new System.Windows.Forms.Label();
			this.lblCurrentlySchool = new System.Windows.Forms.Label();
			this.grpIncome = new System.Windows.Forms.GroupBox();
			this.chkOW = new System.Windows.Forms.CheckBox();
			this.chkCAS = new System.Windows.Forms.CheckBox();
			this.chkWSIB = new System.Windows.Forms.CheckBox();
			this.chkCPPOrphan = new System.Windows.Forms.CheckBox();
			this.chkODSP = new System.Windows.Forms.CheckBox();
			this.chkEI = new System.Windows.Forms.CheckBox();
			this.chkJob = new OUR_PLACE.ctlYesNo();
			this.chkSocialAssistance = new OUR_PLACE.ctlYesNo();
			this.lblSocialAssistanceDetail = new System.Windows.Forms.Label();
			this.lblJob = new System.Windows.Forms.Label();
			this.chkTempJob = new System.Windows.Forms.CheckBox();
			this.chkPartTimeJob = new System.Windows.Forms.CheckBox();
			this.chkFullTimeJob = new System.Windows.Forms.CheckBox();
			this.lblJobStatus = new System.Windows.Forms.Label();
			this.lblSocialAssistance = new System.Windows.Forms.Label();
			this.grpPersonalData.SuspendLayout();
			this.grpGender.SuspendLayout();
			this.grpEthnicCulturalBackground.SuspendLayout();
			this.grpEducation.SuspendLayout();
			this.grpIncome.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpPersonalData
			// 
			this.grpPersonalData.Controls.Add(this.chkResourceRoomUsage);
			this.grpPersonalData.Controls.Add(this.chkOtherCommunityServices);
			this.grpPersonalData.Controls.Add(this.txtOtherCommunityServices);
			this.grpPersonalData.Controls.Add(this.lblOtherCommunityServices);
			this.grpPersonalData.Controls.Add(this.txtHomeCommunity);
			this.grpPersonalData.Controls.Add(this.cboHomeCommunity);
			this.grpPersonalData.Controls.Add(this.lblHomeCommunity);
			this.grpPersonalData.Controls.Add(this.txtLivingSituationExtended);
			this.grpPersonalData.Controls.Add(this.cboLivingSituation);
			this.grpPersonalData.Controls.Add(this.lblLivingSituation);
			this.grpPersonalData.Controls.Add(this.txtResourceRoomSourceExtended);
			this.grpPersonalData.Controls.Add(this.cboResourceRoomSource);
			this.grpPersonalData.Controls.Add(this.lblResourceRoomSource);
			this.grpPersonalData.Controls.Add(this.lblResourceRoomUsage);
			this.grpPersonalData.Controls.Add(this.lblGender);
			this.grpPersonalData.Controls.Add(this.grpGender);
			this.grpPersonalData.Controls.Add(this.dtmBirthDate);
			this.grpPersonalData.Controls.Add(this.lblBirthDate);
			this.grpPersonalData.Controls.Add(this.dtmDate);
			this.grpPersonalData.Controls.Add(this.lblDate);
			this.grpPersonalData.Controls.Add(this.label1);
			this.grpPersonalData.Controls.Add(this.txtFileNo);
			this.grpPersonalData.Controls.Add(this.txtAKA);
			this.grpPersonalData.Controls.Add(this.lblAKA);
			this.grpPersonalData.Controls.Add(this.txtMiddleName);
			this.grpPersonalData.Controls.Add(this.lblMiddleName);
			this.grpPersonalData.Controls.Add(this.txtFirstName);
			this.grpPersonalData.Controls.Add(this.lblFirstName);
			this.grpPersonalData.Controls.Add(this.txtLastName);
			this.grpPersonalData.Controls.Add(this.lblLastName);
			this.grpPersonalData.Location = new System.Drawing.Point(8, 8);
			this.grpPersonalData.Name = "grpPersonalData";
			this.grpPersonalData.Size = new System.Drawing.Size(632, 512);
			this.grpPersonalData.TabIndex = 104;
			this.grpPersonalData.TabStop = false;
			this.grpPersonalData.Text = "Personal Data";
			// 
			// chkResourceRoomUsage
			// 
			this.chkResourceRoomUsage.Checked = false;
			this.chkResourceRoomUsage.Location = new System.Drawing.Point(368, 248);
			this.chkResourceRoomUsage.Name = "chkResourceRoomUsage";
			this.chkResourceRoomUsage.Size = new System.Drawing.Size(150, 24);
			this.chkResourceRoomUsage.TabIndex = 134;
			// 
			// chkOtherCommunityServices
			// 
			this.chkOtherCommunityServices.Checked = false;
			this.chkOtherCommunityServices.Location = new System.Drawing.Point(368, 352);
			this.chkOtherCommunityServices.Name = "chkOtherCommunityServices";
			this.chkOtherCommunityServices.Size = new System.Drawing.Size(150, 24);
			this.chkOtherCommunityServices.TabIndex = 133;
			// 
			// txtOtherCommunityServices
			// 
			this.txtOtherCommunityServices.FreeText = "";
			this.txtOtherCommunityServices.FreeTextSize = 400;
			this.txtOtherCommunityServices.Label = "If yes, please list:";
			this.txtOtherCommunityServices.Location = new System.Drawing.Point(24, 376);
			this.txtOtherCommunityServices.Name = "txtOtherCommunityServices";
			this.txtOtherCommunityServices.Size = new System.Drawing.Size(584, 128);
			this.txtOtherCommunityServices.TabIndex = 132;
			// 
			// lblOtherCommunityServices
			// 
			this.lblOtherCommunityServices.Location = new System.Drawing.Point(20, 352);
			this.lblOtherCommunityServices.Name = "lblOtherCommunityServices";
			this.lblOtherCommunityServices.Size = new System.Drawing.Size(344, 23);
			this.lblOtherCommunityServices.TabIndex = 131;
			this.lblOtherCommunityServices.Text = "Are you connected with any other community services or agencies?";
			// 
			// txtHomeCommunity
			// 
			this.txtHomeCommunity.Location = new System.Drawing.Point(492, 328);
			this.txtHomeCommunity.Name = "txtHomeCommunity";
			this.txtHomeCommunity.TabIndex = 130;
			this.txtHomeCommunity.Text = "";
			// 
			// cboHomeCommunity
			// 
			this.cboHomeCommunity.Location = new System.Drawing.Point(364, 328);
			this.cboHomeCommunity.Name = "cboHomeCommunity";
			this.cboHomeCommunity.Size = new System.Drawing.Size(121, 21);
			this.cboHomeCommunity.TabIndex = 129;
			// 
			// lblHomeCommunity
			// 
			this.lblHomeCommunity.Location = new System.Drawing.Point(20, 328);
			this.lblHomeCommunity.Name = "lblHomeCommunity";
			this.lblHomeCommunity.Size = new System.Drawing.Size(248, 23);
			this.lblHomeCommunity.TabIndex = 128;
			this.lblHomeCommunity.Text = "What is your home community?";
			// 
			// txtLivingSituationExtended
			// 
			this.txtLivingSituationExtended.Location = new System.Drawing.Point(492, 304);
			this.txtLivingSituationExtended.Name = "txtLivingSituationExtended";
			this.txtLivingSituationExtended.TabIndex = 127;
			this.txtLivingSituationExtended.Text = "";
			// 
			// cboLivingSituation
			// 
			this.cboLivingSituation.Location = new System.Drawing.Point(364, 304);
			this.cboLivingSituation.Name = "cboLivingSituation";
			this.cboLivingSituation.Size = new System.Drawing.Size(121, 21);
			this.cboLivingSituation.TabIndex = 126;
			// 
			// lblLivingSituation
			// 
			this.lblLivingSituation.Location = new System.Drawing.Point(20, 304);
			this.lblLivingSituation.Name = "lblLivingSituation";
			this.lblLivingSituation.Size = new System.Drawing.Size(248, 23);
			this.lblLivingSituation.TabIndex = 125;
			this.lblLivingSituation.Text = "What is your current living situation?";
			// 
			// txtResourceRoomSourceExtended
			// 
			this.txtResourceRoomSourceExtended.Location = new System.Drawing.Point(492, 280);
			this.txtResourceRoomSourceExtended.Name = "txtResourceRoomSourceExtended";
			this.txtResourceRoomSourceExtended.TabIndex = 124;
			this.txtResourceRoomSourceExtended.Text = "";
			// 
			// cboResourceRoomSource
			// 
			this.cboResourceRoomSource.Location = new System.Drawing.Point(364, 280);
			this.cboResourceRoomSource.Name = "cboResourceRoomSource";
			this.cboResourceRoomSource.Size = new System.Drawing.Size(121, 21);
			this.cboResourceRoomSource.TabIndex = 123;
			// 
			// lblResourceRoomSource
			// 
			this.lblResourceRoomSource.Location = new System.Drawing.Point(20, 280);
			this.lblResourceRoomSource.Name = "lblResourceRoomSource";
			this.lblResourceRoomSource.Size = new System.Drawing.Size(248, 23);
			this.lblResourceRoomSource.TabIndex = 122;
			this.lblResourceRoomSource.Text = "How did you find out about the Resource Room?";
			// 
			// lblResourceRoomUsage
			// 
			this.lblResourceRoomUsage.Location = new System.Drawing.Point(20, 256);
			this.lblResourceRoomUsage.Name = "lblResourceRoomUsage";
			this.lblResourceRoomUsage.Size = new System.Drawing.Size(224, 23);
			this.lblResourceRoomUsage.TabIndex = 120;
			this.lblResourceRoomUsage.Text = "Have you used the Resource Room before?";
			// 
			// lblGender
			// 
			this.lblGender.Location = new System.Drawing.Point(20, 208);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(136, 23);
			this.lblGender.TabIndex = 119;
			this.lblGender.Text = "Are you male or female?";
			// 
			// grpGender
			// 
			this.grpGender.Controls.Add(this.btnFemale);
			this.grpGender.Controls.Add(this.btnMale);
			this.grpGender.Location = new System.Drawing.Point(364, 200);
			this.grpGender.Name = "grpGender";
			this.grpGender.Size = new System.Drawing.Size(144, 48);
			this.grpGender.TabIndex = 118;
			this.grpGender.TabStop = false;
			this.grpGender.Text = "Gender";
			// 
			// btnFemale
			// 
			this.btnFemale.Location = new System.Drawing.Point(64, 16);
			this.btnFemale.Name = "btnFemale";
			this.btnFemale.Size = new System.Drawing.Size(64, 24);
			this.btnFemale.TabIndex = 27;
			this.btnFemale.Text = "Female";
			// 
			// btnMale
			// 
			this.btnMale.Location = new System.Drawing.Point(16, 16);
			this.btnMale.Name = "btnMale";
			this.btnMale.Size = new System.Drawing.Size(48, 24);
			this.btnMale.TabIndex = 25;
			this.btnMale.Text = "Male";
			// 
			// dtmBirthDate
			// 
			this.dtmBirthDate.Location = new System.Drawing.Point(364, 168);
			this.dtmBirthDate.Name = "dtmBirthDate";
			this.dtmBirthDate.TabIndex = 117;
			// 
			// lblBirthDate
			// 
			this.lblBirthDate.Location = new System.Drawing.Point(20, 168);
			this.lblBirthDate.Name = "lblBirthDate";
			this.lblBirthDate.Size = new System.Drawing.Size(136, 23);
			this.lblBirthDate.TabIndex = 116;
			this.lblBirthDate.Text = "What is your date of birth?";
			// 
			// dtmDate
			// 
			this.dtmDate.Location = new System.Drawing.Point(364, 48);
			this.dtmDate.Name = "dtmDate";
			this.dtmDate.TabIndex = 115;
			// 
			// lblDate
			// 
			this.lblDate.Location = new System.Drawing.Point(20, 48);
			this.lblDate.Name = "lblDate";
			this.lblDate.TabIndex = 114;
			this.lblDate.Text = "Date";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(20, 24);
			this.label1.Name = "label1";
			this.label1.TabIndex = 113;
			this.label1.Text = "File #";
			// 
			// txtFileNo
			// 
			this.txtFileNo.Location = new System.Drawing.Point(364, 24);
			this.txtFileNo.Name = "txtFileNo";
			this.txtFileNo.TabIndex = 112;
			this.txtFileNo.Text = "";
			// 
			// txtAKA
			// 
			this.txtAKA.Location = new System.Drawing.Point(364, 144);
			this.txtAKA.Name = "txtAKA";
			this.txtAKA.TabIndex = 111;
			this.txtAKA.Text = "";
			// 
			// lblAKA
			// 
			this.lblAKA.Location = new System.Drawing.Point(20, 144);
			this.lblAKA.Name = "lblAKA";
			this.lblAKA.Size = new System.Drawing.Size(168, 23);
			this.lblAKA.TabIndex = 110;
			this.lblAKA.Text = "Other names known by (A.K.A.)";
			// 
			// txtMiddleName
			// 
			this.txtMiddleName.Location = new System.Drawing.Point(364, 120);
			this.txtMiddleName.Name = "txtMiddleName";
			this.txtMiddleName.TabIndex = 109;
			this.txtMiddleName.Text = "";
			// 
			// lblMiddleName
			// 
			this.lblMiddleName.Location = new System.Drawing.Point(20, 120);
			this.lblMiddleName.Name = "lblMiddleName";
			this.lblMiddleName.TabIndex = 108;
			this.lblMiddleName.Text = "Middle Name";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(364, 96);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.TabIndex = 107;
			this.txtFirstName.Text = "";
			// 
			// lblFirstName
			// 
			this.lblFirstName.Location = new System.Drawing.Point(20, 96);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.TabIndex = 106;
			this.lblFirstName.Text = "First Name";
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(364, 72);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.TabIndex = 105;
			this.txtLastName.Text = "";
			// 
			// lblLastName
			// 
			this.lblLastName.Location = new System.Drawing.Point(20, 72);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.TabIndex = 104;
			this.lblLastName.Text = "Last Name";
			// 
			// grpEthnicCulturalBackground
			// 
			this.grpEthnicCulturalBackground.Controls.Add(this.cboStatusCanada);
			this.grpEthnicCulturalBackground.Controls.Add(this.txtMotherTongueExtended);
			this.grpEthnicCulturalBackground.Controls.Add(this.cboMotherTongue);
			this.grpEthnicCulturalBackground.Controls.Add(this.lblMotherTongue);
			this.grpEthnicCulturalBackground.Controls.Add(this.txtCountryOriginExtended);
			this.grpEthnicCulturalBackground.Controls.Add(this.cboCountryOrigin);
			this.grpEthnicCulturalBackground.Controls.Add(this.lblCountryOrigin);
			this.grpEthnicCulturalBackground.Controls.Add(this.txtOtherStatusCanadaExtended);
			this.grpEthnicCulturalBackground.Controls.Add(this.lblStatusCanada);
			this.grpEthnicCulturalBackground.Location = new System.Drawing.Point(8, 528);
			this.grpEthnicCulturalBackground.Name = "grpEthnicCulturalBackground";
			this.grpEthnicCulturalBackground.Size = new System.Drawing.Size(632, 104);
			this.grpEthnicCulturalBackground.TabIndex = 105;
			this.grpEthnicCulturalBackground.TabStop = false;
			this.grpEthnicCulturalBackground.Text = "Ethnic/Cultural Background";
			// 
			// cboStatusCanada
			// 
			this.cboStatusCanada.Location = new System.Drawing.Point(368, 24);
			this.cboStatusCanada.Name = "cboStatusCanada";
			this.cboStatusCanada.Size = new System.Drawing.Size(121, 21);
			this.cboStatusCanada.TabIndex = 146;
			// 
			// txtMotherTongueExtended
			// 
			this.txtMotherTongueExtended.Location = new System.Drawing.Point(496, 72);
			this.txtMotherTongueExtended.Name = "txtMotherTongueExtended";
			this.txtMotherTongueExtended.TabIndex = 139;
			this.txtMotherTongueExtended.Text = "";
			// 
			// cboMotherTongue
			// 
			this.cboMotherTongue.Location = new System.Drawing.Point(368, 72);
			this.cboMotherTongue.Name = "cboMotherTongue";
			this.cboMotherTongue.Size = new System.Drawing.Size(121, 21);
			this.cboMotherTongue.TabIndex = 138;
			// 
			// lblMotherTongue
			// 
			this.lblMotherTongue.Location = new System.Drawing.Point(24, 72);
			this.lblMotherTongue.Name = "lblMotherTongue";
			this.lblMotherTongue.Size = new System.Drawing.Size(248, 23);
			this.lblMotherTongue.TabIndex = 137;
			this.lblMotherTongue.Text = "What is your mother tongue?";
			// 
			// txtCountryOriginExtended
			// 
			this.txtCountryOriginExtended.Location = new System.Drawing.Point(496, 48);
			this.txtCountryOriginExtended.Name = "txtCountryOriginExtended";
			this.txtCountryOriginExtended.TabIndex = 136;
			this.txtCountryOriginExtended.Text = "";
			// 
			// cboCountryOrigin
			// 
			this.cboCountryOrigin.Location = new System.Drawing.Point(368, 48);
			this.cboCountryOrigin.Name = "cboCountryOrigin";
			this.cboCountryOrigin.Size = new System.Drawing.Size(121, 21);
			this.cboCountryOrigin.TabIndex = 135;
			// 
			// lblCountryOrigin
			// 
			this.lblCountryOrigin.Location = new System.Drawing.Point(24, 48);
			this.lblCountryOrigin.Name = "lblCountryOrigin";
			this.lblCountryOrigin.Size = new System.Drawing.Size(320, 23);
			this.lblCountryOrigin.TabIndex = 134;
			this.lblCountryOrigin.Text = "If born outside of Canada , what is your country of origin?";
			// 
			// txtOtherStatusCanadaExtended
			// 
			this.txtOtherStatusCanadaExtended.Location = new System.Drawing.Point(496, 24);
			this.txtOtherStatusCanadaExtended.Name = "txtOtherStatusCanadaExtended";
			this.txtOtherStatusCanadaExtended.TabIndex = 133;
			this.txtOtherStatusCanadaExtended.Text = "";
			// 
			// lblStatusCanada
			// 
			this.lblStatusCanada.Location = new System.Drawing.Point(24, 24);
			this.lblStatusCanada.Name = "lblStatusCanada";
			this.lblStatusCanada.Size = new System.Drawing.Size(248, 23);
			this.lblStatusCanada.TabIndex = 131;
			this.lblStatusCanada.Text = "What is your status in Canada?";
			// 
			// grpEducation
			// 
			this.grpEducation.Controls.Add(this.chkCurrentlySchool);
			this.grpEducation.Controls.Add(this.cboLastGradeCompleted);
			this.grpEducation.Controls.Add(this.lblLastGradeCompleted);
			this.grpEducation.Controls.Add(this.txtSchoolName);
			this.grpEducation.Controls.Add(this.lblSchoolName);
			this.grpEducation.Controls.Add(this.chkPartTimeSchool);
			this.grpEducation.Controls.Add(this.chkFullTimeSchool);
			this.grpEducation.Controls.Add(this.lblSchoolStatus);
			this.grpEducation.Controls.Add(this.lblCurrentlySchool);
			this.grpEducation.Location = new System.Drawing.Point(8, 808);
			this.grpEducation.Name = "grpEducation";
			this.grpEducation.Size = new System.Drawing.Size(632, 112);
			this.grpEducation.TabIndex = 106;
			this.grpEducation.TabStop = false;
			this.grpEducation.Text = "Education";
			// 
			// chkCurrentlySchool
			// 
			this.chkCurrentlySchool.Checked = false;
			this.chkCurrentlySchool.Location = new System.Drawing.Point(192, 32);
			this.chkCurrentlySchool.Name = "chkCurrentlySchool";
			this.chkCurrentlySchool.Size = new System.Drawing.Size(150, 24);
			this.chkCurrentlySchool.TabIndex = 142;
			// 
			// cboLastGradeCompleted
			// 
			this.cboLastGradeCompleted.Location = new System.Drawing.Point(272, 80);
			this.cboLastGradeCompleted.Name = "cboLastGradeCompleted";
			this.cboLastGradeCompleted.Size = new System.Drawing.Size(121, 21);
			this.cboLastGradeCompleted.TabIndex = 141;
			// 
			// lblLastGradeCompleted
			// 
			this.lblLastGradeCompleted.Location = new System.Drawing.Point(24, 80);
			this.lblLastGradeCompleted.Name = "lblLastGradeCompleted";
			this.lblLastGradeCompleted.Size = new System.Drawing.Size(248, 23);
			this.lblLastGradeCompleted.TabIndex = 140;
			this.lblLastGradeCompleted.Text = "What is your last grade or diploma completed?";
			// 
			// txtSchoolName
			// 
			this.txtSchoolName.Location = new System.Drawing.Point(416, 56);
			this.txtSchoolName.Name = "txtSchoolName";
			this.txtSchoolName.TabIndex = 139;
			this.txtSchoolName.Text = "";
			// 
			// lblSchoolName
			// 
			this.lblSchoolName.Location = new System.Drawing.Point(320, 56);
			this.lblSchoolName.Name = "lblSchoolName";
			this.lblSchoolName.TabIndex = 138;
			this.lblSchoolName.Text = "School Name";
			// 
			// chkPartTimeSchool
			// 
			this.chkPartTimeSchool.Location = new System.Drawing.Point(256, 56);
			this.chkPartTimeSchool.Name = "chkPartTimeSchool";
			this.chkPartTimeSchool.TabIndex = 137;
			this.chkPartTimeSchool.Text = "P/T";
			// 
			// chkFullTimeSchool
			// 
			this.chkFullTimeSchool.Location = new System.Drawing.Point(200, 56);
			this.chkFullTimeSchool.Name = "chkFullTimeSchool";
			this.chkFullTimeSchool.TabIndex = 136;
			this.chkFullTimeSchool.Text = "F/T";
			// 
			// lblSchoolStatus
			// 
			this.lblSchoolStatus.Location = new System.Drawing.Point(24, 56);
			this.lblSchoolStatus.Name = "lblSchoolStatus";
			this.lblSchoolStatus.Size = new System.Drawing.Size(176, 23);
			this.lblSchoolStatus.TabIndex = 135;
			this.lblSchoolStatus.Text = "If yes, what is your status?";
			// 
			// lblCurrentlySchool
			// 
			this.lblCurrentlySchool.Location = new System.Drawing.Point(24, 32);
			this.lblCurrentlySchool.Name = "lblCurrentlySchool";
			this.lblCurrentlySchool.Size = new System.Drawing.Size(176, 23);
			this.lblCurrentlySchool.TabIndex = 133;
			this.lblCurrentlySchool.Text = "Are you currently in school?";
			// 
			// grpIncome
			// 
			this.grpIncome.Controls.Add(this.chkOW);
			this.grpIncome.Controls.Add(this.chkCAS);
			this.grpIncome.Controls.Add(this.chkWSIB);
			this.grpIncome.Controls.Add(this.chkCPPOrphan);
			this.grpIncome.Controls.Add(this.chkODSP);
			this.grpIncome.Controls.Add(this.chkEI);
			this.grpIncome.Controls.Add(this.chkJob);
			this.grpIncome.Controls.Add(this.chkSocialAssistance);
			this.grpIncome.Controls.Add(this.lblSocialAssistanceDetail);
			this.grpIncome.Controls.Add(this.lblJob);
			this.grpIncome.Controls.Add(this.chkTempJob);
			this.grpIncome.Controls.Add(this.chkPartTimeJob);
			this.grpIncome.Controls.Add(this.chkFullTimeJob);
			this.grpIncome.Controls.Add(this.lblJobStatus);
			this.grpIncome.Controls.Add(this.lblSocialAssistance);
			this.grpIncome.Location = new System.Drawing.Point(8, 640);
			this.grpIncome.Name = "grpIncome";
			this.grpIncome.Size = new System.Drawing.Size(632, 160);
			this.grpIncome.TabIndex = 107;
			this.grpIncome.TabStop = false;
			this.grpIncome.Text = "Income";
			// 
			// chkOW
			// 
			this.chkOW.Location = new System.Drawing.Point(432, 80);
			this.chkOW.Name = "chkOW";
			this.chkOW.TabIndex = 149;
			this.chkOW.Text = "OW";
			// 
			// chkCAS
			// 
			this.chkCAS.Location = new System.Drawing.Point(368, 80);
			this.chkCAS.Name = "chkCAS";
			this.chkCAS.TabIndex = 148;
			this.chkCAS.Text = "CAS";
			// 
			// chkWSIB
			// 
			this.chkWSIB.Location = new System.Drawing.Point(296, 80);
			this.chkWSIB.Name = "chkWSIB";
			this.chkWSIB.TabIndex = 147;
			this.chkWSIB.Text = "WSIB";
			// 
			// chkCPPOrphan
			// 
			this.chkCPPOrphan.Location = new System.Drawing.Point(152, 80);
			this.chkCPPOrphan.Name = "chkCPPOrphan";
			this.chkCPPOrphan.Size = new System.Drawing.Size(144, 24);
			this.chkCPPOrphan.TabIndex = 146;
			this.chkCPPOrphan.Text = "CPP (orphan\'s benefit)";
			// 
			// chkODSP
			// 
			this.chkODSP.Location = new System.Drawing.Point(80, 80);
			this.chkODSP.Name = "chkODSP";
			this.chkODSP.TabIndex = 145;
			this.chkODSP.Text = "ODSP";
			// 
			// chkEI
			// 
			this.chkEI.Location = new System.Drawing.Point(32, 80);
			this.chkEI.Name = "chkEI";
			this.chkEI.TabIndex = 144;
			this.chkEI.Text = "EI";
			// 
			// chkJob
			// 
			this.chkJob.Checked = false;
			this.chkJob.Location = new System.Drawing.Point(176, 104);
			this.chkJob.Name = "chkJob";
			this.chkJob.Size = new System.Drawing.Size(150, 24);
			this.chkJob.TabIndex = 143;
			// 
			// chkSocialAssistance
			// 
			this.chkSocialAssistance.Checked = false;
			this.chkSocialAssistance.Location = new System.Drawing.Point(280, 32);
			this.chkSocialAssistance.Name = "chkSocialAssistance";
			this.chkSocialAssistance.Size = new System.Drawing.Size(150, 24);
			this.chkSocialAssistance.TabIndex = 142;
			// 
			// lblSocialAssistanceDetail
			// 
			this.lblSocialAssistanceDetail.Location = new System.Drawing.Point(24, 56);
			this.lblSocialAssistanceDetail.Name = "lblSocialAssistanceDetail";
			this.lblSocialAssistanceDetail.Size = new System.Drawing.Size(152, 23);
			this.lblSocialAssistanceDetail.TabIndex = 141;
			this.lblSocialAssistanceDetail.Text = "If yes, do you receive:";
			// 
			// lblJob
			// 
			this.lblJob.Location = new System.Drawing.Point(24, 104);
			this.lblJob.Name = "lblJob";
			this.lblJob.Size = new System.Drawing.Size(120, 23);
			this.lblJob.TabIndex = 139;
			this.lblJob.Text = "Do you have a job?";
			// 
			// chkTempJob
			// 
			this.chkTempJob.Location = new System.Drawing.Point(312, 128);
			this.chkTempJob.Name = "chkTempJob";
			this.chkTempJob.TabIndex = 138;
			this.chkTempJob.Text = "Temp";
			// 
			// chkPartTimeJob
			// 
			this.chkPartTimeJob.Location = new System.Drawing.Point(256, 128);
			this.chkPartTimeJob.Name = "chkPartTimeJob";
			this.chkPartTimeJob.TabIndex = 137;
			this.chkPartTimeJob.Text = "P/T";
			// 
			// chkFullTimeJob
			// 
			this.chkFullTimeJob.Location = new System.Drawing.Point(200, 128);
			this.chkFullTimeJob.Name = "chkFullTimeJob";
			this.chkFullTimeJob.TabIndex = 136;
			this.chkFullTimeJob.Text = "F/T";
			// 
			// lblJobStatus
			// 
			this.lblJobStatus.Location = new System.Drawing.Point(24, 128);
			this.lblJobStatus.Name = "lblJobStatus";
			this.lblJobStatus.Size = new System.Drawing.Size(144, 23);
			this.lblJobStatus.TabIndex = 135;
			this.lblJobStatus.Text = "If yes, what is your status?";
			// 
			// lblSocialAssistance
			// 
			this.lblSocialAssistance.Location = new System.Drawing.Point(24, 32);
			this.lblSocialAssistance.Name = "lblSocialAssistance";
			this.lblSocialAssistance.Size = new System.Drawing.Size(240, 23);
			this.lblSocialAssistance.TabIndex = 133;
			this.lblSocialAssistance.Text = "Do you receive any type of social assistance?";
			// 
			// ctlResourcePage1
			// 
			this.AutoScroll = true;
			this.Controls.Add(this.grpIncome);
			this.Controls.Add(this.grpEducation);
			this.Controls.Add(this.grpEthnicCulturalBackground);
			this.Controls.Add(this.grpPersonalData);
			this.Name = "ctlResourcePage1";
			this.Size = new System.Drawing.Size(648, 928);
			this.grpPersonalData.ResumeLayout(false);
			this.grpGender.ResumeLayout(false);
			this.grpEthnicCulturalBackground.ResumeLayout(false);
			this.grpEducation.ResumeLayout(false);
			this.grpIncome.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Private Methods

		private void LoadCombos()
		{
			StaticMethods.LoadCombos(cboHomeCommunity, "HOME_COMMUNITY");
			StaticMethods.LoadCombos(cboLivingSituation, "CURRENT_LIVING_SITUATION");
			StaticMethods.LoadCombos(cboResourceRoomSource, "LEARN_RESOURCE_ROOM");
			StaticMethods.LoadCombos(cboStatusCanada, "CANADA_STATUS");
			StaticMethods.LoadCombos(cboCountryOrigin, "ORIGIN_COUNTRY");
			StaticMethods.LoadCombos(cboMotherTongue, "MOTHER_TONGUE");
			StaticMethods.LoadCombos(cboLastGradeCompleted, "LAST_GRADE_COMPLETED");
		}

		#endregion

	}
}
