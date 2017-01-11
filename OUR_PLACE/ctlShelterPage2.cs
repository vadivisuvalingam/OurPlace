using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace OUR_PLACE
{
	/// <summary>
	/// Summary description for ctlPage2.
	/// </summary>
	public class ctlPage2 : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.GroupBox grpHealthInformation;
		private System.Windows.Forms.CheckBox chkSTDs;
		private System.Windows.Forms.CheckBox chkDiabetes;
		private System.Windows.Forms.CheckBox chkAsthma;
		private System.Windows.Forms.CheckBox chkAllergies;
		private System.Windows.Forms.Label lblHealthConcerns;
		private System.Windows.Forms.CheckBox chkPregnancy;
		private System.Windows.Forms.TextBox txtOtherHealthConcerns;
		private System.Windows.Forms.CheckBox chkOtherHealthConcerns;
		private System.Windows.Forms.CheckBox chkDepression;
		private System.Windows.Forms.CheckBox chkAlcoholAbuse;
		private System.Windows.Forms.CheckBox chkDrugUse;
		private System.Windows.Forms.CheckBox chkCerebralPalsy;
		private System.Windows.Forms.CheckBox chkBlind;
		private System.Windows.Forms.CheckBox chkADD;
		private System.Windows.Forms.CheckBox chkOtherMentalHealth;
		private System.Windows.Forms.CheckBox chkSchizophrenia;
		private System.Windows.Forms.CheckBox chkEatingDisorder;
		private System.Windows.Forms.CheckBox chkDeafBlind;
		private System.Windows.Forms.CheckBox chkDeaf;
		private System.Windows.Forms.Label lblTakingMedication;

		private System.Windows.Forms.Label lblMedication;
		private System.Windows.Forms.GroupBox grpPoliceInvolvement;
		private System.Windows.Forms.Label lblPoliceInvolvement;

		private System.Windows.Forms.Label lblProbation;

		private System.Windows.Forms.Label lblProbationOfficerInfo;
		private OUR_PLACE.ctlYesNo chkProbation;
		private OUR_PLACE.ctlYesNo chkPoliceInvolvement;
		private OUR_PLACE.ctlYesNo chkTakingMedication;
		private OUR_PLACE.ctlFreeText txtProbationDetail;
		private System.Windows.Forms.GroupBox grpEducation;
		private System.Windows.Forms.Label lblCurrentlyInSchool;
		private OUR_PLACE.ctlYesNo chkCurrentlyInSchool;
		private System.Windows.Forms.Label lblCurrentGrade;
		private System.Windows.Forms.TextBox txtCurrentGrade;
		private System.Windows.Forms.Label lblLastGrade;
		private System.Windows.Forms.TextBox txtLastGrade;
		private System.Windows.Forms.GroupBox grpEmployment;
		private System.Windows.Forms.Label lblEmployed;
		private OUR_PLACE.ctlYesNo chkEmployed;
		private System.Windows.Forms.GroupBox grpEmploymentSituation;
		private System.Windows.Forms.RadioButton btnFullTime;
		private System.Windows.Forms.RadioButton btnPartTime;
		private System.Windows.Forms.RadioButton btnTempAgency;
		private System.Windows.Forms.GroupBox grpBackgroundInformation;
		private System.Windows.Forms.Label lblHomeCommunity;
		private System.Windows.Forms.ComboBox cboHomeCommunity;
		private System.Windows.Forms.TextBox txtHomeCommunityExtended;
		private System.Windows.Forms.TextBox txtCountryOriginExtended;
		private System.Windows.Forms.ComboBox cboCountryOrigin;
		private System.Windows.Forms.Label lblCountryOrigin;
		private OUR_PLACE.ctlFreeText txtProbationOfficer;
		private System.Windows.Forms.ListView lstMedication;
		private System.Windows.Forms.ColumnHeader MedicationType;
		private System.Windows.Forms.ColumnHeader Dosage;
		private System.Windows.Forms.ColumnHeader Purpose;
		private System.Windows.Forms.ColumnHeader Doctor;
		private System.Windows.Forms.ColumnHeader DoctorType;
		private System.Windows.Forms.ColumnHeader ContactInfo;
		private System.Windows.Forms.Button btnAddMedication;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ctlPage2()
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
			this.grpHealthInformation = new System.Windows.Forms.GroupBox();
			this.btnAddMedication = new System.Windows.Forms.Button();
			this.lstMedication = new System.Windows.Forms.ListView();
			this.MedicationType = new System.Windows.Forms.ColumnHeader();
			this.Dosage = new System.Windows.Forms.ColumnHeader();
			this.Purpose = new System.Windows.Forms.ColumnHeader();
			this.Doctor = new System.Windows.Forms.ColumnHeader();
			this.DoctorType = new System.Windows.Forms.ColumnHeader();
			this.ContactInfo = new System.Windows.Forms.ColumnHeader();
			this.chkTakingMedication = new OUR_PLACE.ctlYesNo();
			this.lblMedication = new System.Windows.Forms.Label();
			this.lblTakingMedication = new System.Windows.Forms.Label();
			this.chkDeaf = new System.Windows.Forms.CheckBox();
			this.chkDeafBlind = new System.Windows.Forms.CheckBox();
			this.chkPregnancy = new System.Windows.Forms.CheckBox();
			this.txtOtherHealthConcerns = new System.Windows.Forms.TextBox();
			this.chkOtherHealthConcerns = new System.Windows.Forms.CheckBox();
			this.chkDepression = new System.Windows.Forms.CheckBox();
			this.chkAlcoholAbuse = new System.Windows.Forms.CheckBox();
			this.chkDrugUse = new System.Windows.Forms.CheckBox();
			this.chkCerebralPalsy = new System.Windows.Forms.CheckBox();
			this.chkBlind = new System.Windows.Forms.CheckBox();
			this.chkADD = new System.Windows.Forms.CheckBox();
			this.chkOtherMentalHealth = new System.Windows.Forms.CheckBox();
			this.chkSchizophrenia = new System.Windows.Forms.CheckBox();
			this.chkEatingDisorder = new System.Windows.Forms.CheckBox();
			this.chkSTDs = new System.Windows.Forms.CheckBox();
			this.chkDiabetes = new System.Windows.Forms.CheckBox();
			this.chkAsthma = new System.Windows.Forms.CheckBox();
			this.chkAllergies = new System.Windows.Forms.CheckBox();
			this.lblHealthConcerns = new System.Windows.Forms.Label();
			this.grpPoliceInvolvement = new System.Windows.Forms.GroupBox();
			this.txtProbationOfficer = new OUR_PLACE.ctlFreeText();
			this.txtProbationDetail = new OUR_PLACE.ctlFreeText();
			this.chkProbation = new OUR_PLACE.ctlYesNo();
			this.chkPoliceInvolvement = new OUR_PLACE.ctlYesNo();
			this.lblProbation = new System.Windows.Forms.Label();
			this.lblPoliceInvolvement = new System.Windows.Forms.Label();
			this.lblProbationOfficerInfo = new System.Windows.Forms.Label();
			this.grpEducation = new System.Windows.Forms.GroupBox();
			this.txtLastGrade = new System.Windows.Forms.TextBox();
			this.lblLastGrade = new System.Windows.Forms.Label();
			this.txtCurrentGrade = new System.Windows.Forms.TextBox();
			this.lblCurrentGrade = new System.Windows.Forms.Label();
			this.chkCurrentlyInSchool = new OUR_PLACE.ctlYesNo();
			this.lblCurrentlyInSchool = new System.Windows.Forms.Label();
			this.grpEmployment = new System.Windows.Forms.GroupBox();
			this.grpEmploymentSituation = new System.Windows.Forms.GroupBox();
			this.btnTempAgency = new System.Windows.Forms.RadioButton();
			this.btnPartTime = new System.Windows.Forms.RadioButton();
			this.btnFullTime = new System.Windows.Forms.RadioButton();
			this.chkEmployed = new OUR_PLACE.ctlYesNo();
			this.lblEmployed = new System.Windows.Forms.Label();
			this.grpBackgroundInformation = new System.Windows.Forms.GroupBox();
			this.txtCountryOriginExtended = new System.Windows.Forms.TextBox();
			this.cboCountryOrigin = new System.Windows.Forms.ComboBox();
			this.lblCountryOrigin = new System.Windows.Forms.Label();
			this.txtHomeCommunityExtended = new System.Windows.Forms.TextBox();
			this.cboHomeCommunity = new System.Windows.Forms.ComboBox();
			this.lblHomeCommunity = new System.Windows.Forms.Label();
			this.grpHealthInformation.SuspendLayout();
			this.grpPoliceInvolvement.SuspendLayout();
			this.grpEducation.SuspendLayout();
			this.grpEmployment.SuspendLayout();
			this.grpEmploymentSituation.SuspendLayout();
			this.grpBackgroundInformation.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpHealthInformation
			// 
			this.grpHealthInformation.Controls.Add(this.btnAddMedication);
			this.grpHealthInformation.Controls.Add(this.lstMedication);
			this.grpHealthInformation.Controls.Add(this.chkTakingMedication);
			this.grpHealthInformation.Controls.Add(this.lblMedication);
			this.grpHealthInformation.Controls.Add(this.lblTakingMedication);
			this.grpHealthInformation.Controls.Add(this.chkDeaf);
			this.grpHealthInformation.Controls.Add(this.chkDeafBlind);
			this.grpHealthInformation.Controls.Add(this.chkPregnancy);
			this.grpHealthInformation.Controls.Add(this.txtOtherHealthConcerns);
			this.grpHealthInformation.Controls.Add(this.chkOtherHealthConcerns);
			this.grpHealthInformation.Controls.Add(this.chkDepression);
			this.grpHealthInformation.Controls.Add(this.chkAlcoholAbuse);
			this.grpHealthInformation.Controls.Add(this.chkDrugUse);
			this.grpHealthInformation.Controls.Add(this.chkCerebralPalsy);
			this.grpHealthInformation.Controls.Add(this.chkBlind);
			this.grpHealthInformation.Controls.Add(this.chkADD);
			this.grpHealthInformation.Controls.Add(this.chkOtherMentalHealth);
			this.grpHealthInformation.Controls.Add(this.chkSchizophrenia);
			this.grpHealthInformation.Controls.Add(this.chkEatingDisorder);
			this.grpHealthInformation.Controls.Add(this.chkSTDs);
			this.grpHealthInformation.Controls.Add(this.chkDiabetes);
			this.grpHealthInformation.Controls.Add(this.chkAsthma);
			this.grpHealthInformation.Controls.Add(this.chkAllergies);
			this.grpHealthInformation.Controls.Add(this.lblHealthConcerns);
			this.grpHealthInformation.Location = new System.Drawing.Point(8, 8);
			this.grpHealthInformation.Name = "grpHealthInformation";
			this.grpHealthInformation.Size = new System.Drawing.Size(632, 352);
			this.grpHealthInformation.TabIndex = 43;
			this.grpHealthInformation.TabStop = false;
			this.grpHealthInformation.Text = "Health Information";
			// 
			// btnAddMedication
			// 
			this.btnAddMedication.Location = new System.Drawing.Point(576, 240);
			this.btnAddMedication.Name = "btnAddMedication";
			this.btnAddMedication.Size = new System.Drawing.Size(48, 23);
			this.btnAddMedication.TabIndex = 91;
			this.btnAddMedication.Text = "Add";
			this.btnAddMedication.Click += new System.EventHandler(this.btnAddMedication_Click);
			// 
			// lstMedication
			// 
			this.lstMedication.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																							this.MedicationType,
																							this.Dosage,
																							this.Purpose,
																							this.Doctor,
																							this.DoctorType,
																							this.ContactInfo});
			this.lstMedication.Location = new System.Drawing.Point(8, 240);
			this.lstMedication.Name = "lstMedication";
			this.lstMedication.Size = new System.Drawing.Size(560, 104);
			this.lstMedication.TabIndex = 90;
			this.lstMedication.View = System.Windows.Forms.View.Details;
			// 
			// MedicationType
			// 
			this.MedicationType.Text = "Type/Name of Medication";
			this.MedicationType.Width = 143;
			// 
			// Dosage
			// 
			this.Dosage.Text = "Dosage";
			// 
			// Purpose
			// 
			this.Purpose.Text = "Purpose";
			// 
			// Doctor
			// 
			this.Doctor.Text = "Doctor";
			// 
			// DoctorType
			// 
			this.DoctorType.Text = "Type of Doctor";
			this.DoctorType.Width = 95;
			// 
			// ContactInfo
			// 
			this.ContactInfo.Text = "Contact Info";
			this.ContactInfo.Width = 175;
			// 
			// chkTakingMedication
			// 
			this.chkTakingMedication.Checked = false;
			this.chkTakingMedication.Location = new System.Drawing.Point(160, 200);
			this.chkTakingMedication.Name = "chkTakingMedication";
			this.chkTakingMedication.Size = new System.Drawing.Size(150, 24);
			this.chkTakingMedication.TabIndex = 89;
			// 
			// lblMedication
			// 
			this.lblMedication.Location = new System.Drawing.Point(8, 224);
			this.lblMedication.Name = "lblMedication";
			this.lblMedication.Size = new System.Drawing.Size(264, 23);
			this.lblMedication.TabIndex = 88;
			this.lblMedication.Text = "If yes, please identify type, dosage and purpose.";
			// 
			// lblTakingMedication
			// 
			this.lblTakingMedication.Location = new System.Drawing.Point(8, 200);
			this.lblTakingMedication.Name = "lblTakingMedication";
			this.lblTakingMedication.Size = new System.Drawing.Size(160, 23);
			this.lblTakingMedication.TabIndex = 86;
			this.lblTakingMedication.Text = "Is youth taking medication?";
			// 
			// chkDeaf
			// 
			this.chkDeaf.Location = new System.Drawing.Point(416, 48);
			this.chkDeaf.Name = "chkDeaf";
			this.chkDeaf.Size = new System.Drawing.Size(160, 24);
			this.chkDeaf.TabIndex = 84;
			this.chkDeaf.Text = "Deaf";
			// 
			// chkDeafBlind
			// 
			this.chkDeafBlind.Location = new System.Drawing.Point(416, 96);
			this.chkDeafBlind.Name = "chkDeafBlind";
			this.chkDeafBlind.Size = new System.Drawing.Size(160, 24);
			this.chkDeafBlind.TabIndex = 82;
			this.chkDeafBlind.Text = "Deaf/Blind";
			// 
			// chkPregnancy
			// 
			this.chkPregnancy.Location = new System.Drawing.Point(8, 144);
			this.chkPregnancy.Name = "chkPregnancy";
			this.chkPregnancy.Size = new System.Drawing.Size(160, 24);
			this.chkPregnancy.TabIndex = 81;
			this.chkPregnancy.Text = "Pregnancy";
			// 
			// txtOtherHealthConcerns
			// 
			this.txtOtherHealthConcerns.Location = new System.Drawing.Point(240, 168);
			this.txtOtherHealthConcerns.Name = "txtOtherHealthConcerns";
			this.txtOtherHealthConcerns.Size = new System.Drawing.Size(144, 20);
			this.txtOtherHealthConcerns.TabIndex = 80;
			this.txtOtherHealthConcerns.Text = "";
			// 
			// chkOtherHealthConcerns
			// 
			this.chkOtherHealthConcerns.Location = new System.Drawing.Point(184, 168);
			this.chkOtherHealthConcerns.Name = "chkOtherHealthConcerns";
			this.chkOtherHealthConcerns.TabIndex = 79;
			this.chkOtherHealthConcerns.Text = "Other";
			// 
			// chkDepression
			// 
			this.chkDepression.Location = new System.Drawing.Point(8, 168);
			this.chkDepression.Name = "chkDepression";
			this.chkDepression.Size = new System.Drawing.Size(184, 24);
			this.chkDepression.TabIndex = 78;
			this.chkDepression.Text = "Depression";
			// 
			// chkAlcoholAbuse
			// 
			this.chkAlcoholAbuse.Location = new System.Drawing.Point(416, 144);
			this.chkAlcoholAbuse.Name = "chkAlcoholAbuse";
			this.chkAlcoholAbuse.Size = new System.Drawing.Size(160, 24);
			this.chkAlcoholAbuse.TabIndex = 77;
			this.chkAlcoholAbuse.Text = "Alcohol Abuse";
			// 
			// chkDrugUse
			// 
			this.chkDrugUse.Location = new System.Drawing.Point(416, 120);
			this.chkDrugUse.Name = "chkDrugUse";
			this.chkDrugUse.Size = new System.Drawing.Size(160, 24);
			this.chkDrugUse.TabIndex = 76;
			this.chkDrugUse.Text = "Drug Use";
			// 
			// chkCerebralPalsy
			// 
			this.chkCerebralPalsy.Location = new System.Drawing.Point(184, 144);
			this.chkCerebralPalsy.Name = "chkCerebralPalsy";
			this.chkCerebralPalsy.Size = new System.Drawing.Size(160, 24);
			this.chkCerebralPalsy.TabIndex = 75;
			this.chkCerebralPalsy.Text = "Cerebral Palsy";
			// 
			// chkBlind
			// 
			this.chkBlind.Location = new System.Drawing.Point(416, 72);
			this.chkBlind.Name = "chkBlind";
			this.chkBlind.Size = new System.Drawing.Size(160, 24);
			this.chkBlind.TabIndex = 74;
			this.chkBlind.Text = "Blind";
			// 
			// chkADD
			// 
			this.chkADD.Location = new System.Drawing.Point(184, 120);
			this.chkADD.Name = "chkADD";
			this.chkADD.Size = new System.Drawing.Size(160, 24);
			this.chkADD.TabIndex = 73;
			this.chkADD.Text = "ADD/ADHD";
			// 
			// chkOtherMentalHealth
			// 
			this.chkOtherMentalHealth.Location = new System.Drawing.Point(184, 96);
			this.chkOtherMentalHealth.Name = "chkOtherMentalHealth";
			this.chkOtherMentalHealth.Size = new System.Drawing.Size(160, 24);
			this.chkOtherMentalHealth.TabIndex = 72;
			this.chkOtherMentalHealth.Text = "Other Mental Health";
			// 
			// chkSchizophrenia
			// 
			this.chkSchizophrenia.Location = new System.Drawing.Point(184, 72);
			this.chkSchizophrenia.Name = "chkSchizophrenia";
			this.chkSchizophrenia.Size = new System.Drawing.Size(224, 24);
			this.chkSchizophrenia.TabIndex = 71;
			this.chkSchizophrenia.Text = "Schizophrenia";
			// 
			// chkEatingDisorder
			// 
			this.chkEatingDisorder.Location = new System.Drawing.Point(184, 48);
			this.chkEatingDisorder.Name = "chkEatingDisorder";
			this.chkEatingDisorder.Size = new System.Drawing.Size(160, 24);
			this.chkEatingDisorder.TabIndex = 70;
			this.chkEatingDisorder.Text = "Eating Disorder";
			// 
			// chkSTDs
			// 
			this.chkSTDs.Location = new System.Drawing.Point(8, 120);
			this.chkSTDs.Name = "chkSTDs";
			this.chkSTDs.Size = new System.Drawing.Size(160, 24);
			this.chkSTDs.TabIndex = 69;
			this.chkSTDs.Text = "STD\'s";
			// 
			// chkDiabetes
			// 
			this.chkDiabetes.Location = new System.Drawing.Point(8, 96);
			this.chkDiabetes.Name = "chkDiabetes";
			this.chkDiabetes.Size = new System.Drawing.Size(160, 24);
			this.chkDiabetes.TabIndex = 68;
			this.chkDiabetes.Text = "Diabetes";
			// 
			// chkAsthma
			// 
			this.chkAsthma.Location = new System.Drawing.Point(8, 72);
			this.chkAsthma.Name = "chkAsthma";
			this.chkAsthma.Size = new System.Drawing.Size(160, 24);
			this.chkAsthma.TabIndex = 67;
			this.chkAsthma.Text = "Asthma";
			// 
			// chkAllergies
			// 
			this.chkAllergies.Location = new System.Drawing.Point(8, 48);
			this.chkAllergies.Name = "chkAllergies";
			this.chkAllergies.Size = new System.Drawing.Size(160, 24);
			this.chkAllergies.TabIndex = 66;
			this.chkAllergies.Text = "Allergies";
			// 
			// lblHealthConcerns
			// 
			this.lblHealthConcerns.Location = new System.Drawing.Point(8, 24);
			this.lblHealthConcerns.Name = "lblHealthConcerns";
			this.lblHealthConcerns.Size = new System.Drawing.Size(128, 23);
			this.lblHealthConcerns.TabIndex = 65;
			this.lblHealthConcerns.Text = "Health Concerns";
			// 
			// grpPoliceInvolvement
			// 
			this.grpPoliceInvolvement.Controls.Add(this.txtProbationOfficer);
			this.grpPoliceInvolvement.Controls.Add(this.txtProbationDetail);
			this.grpPoliceInvolvement.Controls.Add(this.chkProbation);
			this.grpPoliceInvolvement.Controls.Add(this.chkPoliceInvolvement);
			this.grpPoliceInvolvement.Controls.Add(this.lblProbation);
			this.grpPoliceInvolvement.Controls.Add(this.lblPoliceInvolvement);
			this.grpPoliceInvolvement.Location = new System.Drawing.Point(8, 368);
			this.grpPoliceInvolvement.Name = "grpPoliceInvolvement";
			this.grpPoliceInvolvement.Size = new System.Drawing.Size(632, 328);
			this.grpPoliceInvolvement.TabIndex = 44;
			this.grpPoliceInvolvement.TabStop = false;
			this.grpPoliceInvolvement.Text = "Police Involvement";
			// 
			// txtProbationOfficer
			// 
			this.txtProbationOfficer.FreeText = "";
			this.txtProbationOfficer.FreeTextSize = 400;
			this.txtProbationOfficer.Label = "Probation Officer Info";
			this.txtProbationOfficer.Location = new System.Drawing.Point(8, 200);
			this.txtProbationOfficer.Name = "txtProbationOfficer";
			this.txtProbationOfficer.Size = new System.Drawing.Size(584, 120);
			this.txtProbationOfficer.TabIndex = 6;
			// 
			// txtProbationDetail
			// 
			this.txtProbationDetail.FreeText = "";
			this.txtProbationDetail.FreeTextSize = 400;
			this.txtProbationDetail.Label = "If yes, details?";
			this.txtProbationDetail.Location = new System.Drawing.Point(8, 72);
			this.txtProbationDetail.Name = "txtProbationDetail";
			this.txtProbationDetail.Size = new System.Drawing.Size(584, 120);
			this.txtProbationDetail.TabIndex = 5;
			// 
			// chkProbation
			// 
			this.chkProbation.Checked = false;
			this.chkProbation.Location = new System.Drawing.Point(152, 48);
			this.chkProbation.Name = "chkProbation";
			this.chkProbation.Size = new System.Drawing.Size(150, 24);
			this.chkProbation.TabIndex = 4;
			// 
			// chkPoliceInvolvement
			// 
			this.chkPoliceInvolvement.Checked = false;
			this.chkPoliceInvolvement.Location = new System.Drawing.Point(192, 24);
			this.chkPoliceInvolvement.Name = "chkPoliceInvolvement";
			this.chkPoliceInvolvement.Size = new System.Drawing.Size(150, 24);
			this.chkPoliceInvolvement.TabIndex = 3;
			// 
			// lblProbation
			// 
			this.lblProbation.Location = new System.Drawing.Point(8, 48);
			this.lblProbation.Name = "lblProbation";
			this.lblProbation.Size = new System.Drawing.Size(152, 23);
			this.lblProbation.TabIndex = 2;
			this.lblProbation.Text = "Currently on Probation?";
			// 
			// lblPoliceInvolvement
			// 
			this.lblPoliceInvolvement.Location = new System.Drawing.Point(8, 24);
			this.lblPoliceInvolvement.Name = "lblPoliceInvolvement";
			this.lblPoliceInvolvement.Size = new System.Drawing.Size(184, 23);
			this.lblPoliceInvolvement.TabIndex = 0;
			this.lblPoliceInvolvement.Text = "Past or Present Police Involvement";
			// 
			// lblProbationOfficerInfo
			// 
			this.lblProbationOfficerInfo.Location = new System.Drawing.Point(0, 0);
			this.lblProbationOfficerInfo.Name = "lblProbationOfficerInfo";
			this.lblProbationOfficerInfo.TabIndex = 0;
			// 
			// grpEducation
			// 
			this.grpEducation.Controls.Add(this.txtLastGrade);
			this.grpEducation.Controls.Add(this.lblLastGrade);
			this.grpEducation.Controls.Add(this.txtCurrentGrade);
			this.grpEducation.Controls.Add(this.lblCurrentGrade);
			this.grpEducation.Controls.Add(this.chkCurrentlyInSchool);
			this.grpEducation.Controls.Add(this.lblCurrentlyInSchool);
			this.grpEducation.Location = new System.Drawing.Point(8, 712);
			this.grpEducation.Name = "grpEducation";
			this.grpEducation.Size = new System.Drawing.Size(632, 104);
			this.grpEducation.TabIndex = 45;
			this.grpEducation.TabStop = false;
			this.grpEducation.Text = "Education";
			// 
			// txtLastGrade
			// 
			this.txtLastGrade.Location = new System.Drawing.Point(272, 72);
			this.txtLastGrade.Name = "txtLastGrade";
			this.txtLastGrade.TabIndex = 5;
			this.txtLastGrade.Text = "";
			// 
			// lblLastGrade
			// 
			this.lblLastGrade.Location = new System.Drawing.Point(8, 72);
			this.lblLastGrade.Name = "lblLastGrade";
			this.lblLastGrade.Size = new System.Drawing.Size(272, 23);
			this.lblLastGrade.TabIndex = 4;
			this.lblLastGrade.Text = "If not in school what was the last grade completed?";
			// 
			// txtCurrentGrade
			// 
			this.txtCurrentGrade.Location = new System.Drawing.Point(272, 48);
			this.txtCurrentGrade.Name = "txtCurrentGrade";
			this.txtCurrentGrade.TabIndex = 3;
			this.txtCurrentGrade.Text = "";
			// 
			// lblCurrentGrade
			// 
			this.lblCurrentGrade.Location = new System.Drawing.Point(8, 48);
			this.lblCurrentGrade.Name = "lblCurrentGrade";
			this.lblCurrentGrade.Size = new System.Drawing.Size(112, 23);
			this.lblCurrentGrade.TabIndex = 2;
			this.lblCurrentGrade.Text = "If yes, what Grade?";
			// 
			// chkCurrentlyInSchool
			// 
			this.chkCurrentlyInSchool.Checked = false;
			this.chkCurrentlyInSchool.Location = new System.Drawing.Point(128, 24);
			this.chkCurrentlyInSchool.Name = "chkCurrentlyInSchool";
			this.chkCurrentlyInSchool.Size = new System.Drawing.Size(150, 24);
			this.chkCurrentlyInSchool.TabIndex = 1;
			// 
			// lblCurrentlyInSchool
			// 
			this.lblCurrentlyInSchool.Location = new System.Drawing.Point(8, 24);
			this.lblCurrentlyInSchool.Name = "lblCurrentlyInSchool";
			this.lblCurrentlyInSchool.TabIndex = 0;
			this.lblCurrentlyInSchool.Text = "Currently In School";
			// 
			// grpEmployment
			// 
			this.grpEmployment.Controls.Add(this.grpEmploymentSituation);
			this.grpEmployment.Controls.Add(this.chkEmployed);
			this.grpEmployment.Controls.Add(this.lblEmployed);
			this.grpEmployment.Location = new System.Drawing.Point(8, 832);
			this.grpEmployment.Name = "grpEmployment";
			this.grpEmployment.Size = new System.Drawing.Size(632, 112);
			this.grpEmployment.TabIndex = 46;
			this.grpEmployment.TabStop = false;
			this.grpEmployment.Text = "Employment";
			// 
			// grpEmploymentSituation
			// 
			this.grpEmploymentSituation.Controls.Add(this.btnTempAgency);
			this.grpEmploymentSituation.Controls.Add(this.btnPartTime);
			this.grpEmploymentSituation.Controls.Add(this.btnFullTime);
			this.grpEmploymentSituation.Location = new System.Drawing.Point(16, 56);
			this.grpEmploymentSituation.Name = "grpEmploymentSituation";
			this.grpEmploymentSituation.Size = new System.Drawing.Size(352, 48);
			this.grpEmploymentSituation.TabIndex = 2;
			this.grpEmploymentSituation.TabStop = false;
			this.grpEmploymentSituation.Text = "Employment Situation";
			// 
			// btnTempAgency
			// 
			this.btnTempAgency.Location = new System.Drawing.Point(224, 16);
			this.btnTempAgency.Name = "btnTempAgency";
			this.btnTempAgency.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnTempAgency.TabIndex = 2;
			this.btnTempAgency.Text = "Temp. Agency";
			// 
			// btnPartTime
			// 
			this.btnPartTime.Location = new System.Drawing.Point(112, 16);
			this.btnPartTime.Name = "btnPartTime";
			this.btnPartTime.TabIndex = 1;
			this.btnPartTime.Text = "Part-Time";
			// 
			// btnFullTime
			// 
			this.btnFullTime.Location = new System.Drawing.Point(8, 16);
			this.btnFullTime.Name = "btnFullTime";
			this.btnFullTime.TabIndex = 0;
			this.btnFullTime.Text = "Full-Time";
			// 
			// chkEmployed
			// 
			this.chkEmployed.Checked = false;
			this.chkEmployed.Location = new System.Drawing.Point(112, 24);
			this.chkEmployed.Name = "chkEmployed";
			this.chkEmployed.Size = new System.Drawing.Size(150, 24);
			this.chkEmployed.TabIndex = 1;
			// 
			// lblEmployed
			// 
			this.lblEmployed.Location = new System.Drawing.Point(8, 24);
			this.lblEmployed.Name = "lblEmployed";
			this.lblEmployed.TabIndex = 0;
			this.lblEmployed.Text = "Employed?";
			// 
			// grpBackgroundInformation
			// 
			this.grpBackgroundInformation.Controls.Add(this.txtCountryOriginExtended);
			this.grpBackgroundInformation.Controls.Add(this.cboCountryOrigin);
			this.grpBackgroundInformation.Controls.Add(this.lblCountryOrigin);
			this.grpBackgroundInformation.Controls.Add(this.txtHomeCommunityExtended);
			this.grpBackgroundInformation.Controls.Add(this.cboHomeCommunity);
			this.grpBackgroundInformation.Controls.Add(this.lblHomeCommunity);
			this.grpBackgroundInformation.Location = new System.Drawing.Point(8, 960);
			this.grpBackgroundInformation.Name = "grpBackgroundInformation";
			this.grpBackgroundInformation.Size = new System.Drawing.Size(632, 88);
			this.grpBackgroundInformation.TabIndex = 47;
			this.grpBackgroundInformation.TabStop = false;
			this.grpBackgroundInformation.Text = "Background Information";
			// 
			// txtCountryOriginExtended
			// 
			this.txtCountryOriginExtended.Location = new System.Drawing.Point(480, 48);
			this.txtCountryOriginExtended.Name = "txtCountryOriginExtended";
			this.txtCountryOriginExtended.Size = new System.Drawing.Size(120, 20);
			this.txtCountryOriginExtended.TabIndex = 5;
			this.txtCountryOriginExtended.Text = "";
			// 
			// cboCountryOrigin
			// 
			this.cboCountryOrigin.Location = new System.Drawing.Point(312, 48);
			this.cboCountryOrigin.Name = "cboCountryOrigin";
			this.cboCountryOrigin.Size = new System.Drawing.Size(160, 21);
			this.cboCountryOrigin.TabIndex = 4;
			// 
			// lblCountryOrigin
			// 
			this.lblCountryOrigin.Location = new System.Drawing.Point(312, 24);
			this.lblCountryOrigin.Name = "lblCountryOrigin";
			this.lblCountryOrigin.TabIndex = 3;
			this.lblCountryOrigin.Text = "Country of Origin";
			// 
			// txtHomeCommunityExtended
			// 
			this.txtHomeCommunityExtended.Location = new System.Drawing.Point(176, 48);
			this.txtHomeCommunityExtended.Name = "txtHomeCommunityExtended";
			this.txtHomeCommunityExtended.Size = new System.Drawing.Size(120, 20);
			this.txtHomeCommunityExtended.TabIndex = 2;
			this.txtHomeCommunityExtended.Text = "";
			// 
			// cboHomeCommunity
			// 
			this.cboHomeCommunity.Location = new System.Drawing.Point(8, 48);
			this.cboHomeCommunity.Name = "cboHomeCommunity";
			this.cboHomeCommunity.Size = new System.Drawing.Size(160, 21);
			this.cboHomeCommunity.TabIndex = 1;
			// 
			// lblHomeCommunity
			// 
			this.lblHomeCommunity.Location = new System.Drawing.Point(8, 24);
			this.lblHomeCommunity.Name = "lblHomeCommunity";
			this.lblHomeCommunity.TabIndex = 0;
			this.lblHomeCommunity.Text = "Home Community";
			// 
			// ctlPage2
			// 
			this.AutoScroll = true;
			this.Controls.Add(this.grpBackgroundInformation);
			this.Controls.Add(this.grpEmployment);
			this.Controls.Add(this.grpEducation);
			this.Controls.Add(this.grpPoliceInvolvement);
			this.Controls.Add(this.grpHealthInformation);
			this.Name = "ctlPage2";
			this.Size = new System.Drawing.Size(648, 1064);
			this.grpHealthInformation.ResumeLayout(false);
			this.grpPoliceInvolvement.ResumeLayout(false);
			this.grpEducation.ResumeLayout(false);
			this.grpEmployment.ResumeLayout(false);
			this.grpEmploymentSituation.ResumeLayout(false);
			this.grpBackgroundInformation.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Private Methods

		private void LoadCombos()
		{
			StaticMethods.LoadCombos(cboHomeCommunity, "HOME_COMMUNITY");
			StaticMethods.LoadCombos(cboCountryOrigin, "ORIGIN_COUNTRY");
		}

		#endregion

		private void btnAddMedication_Click(object sender, System.EventArgs e)
		{
			frmMedication lo_frmMedication = new frmMedication();
			lo_frmMedication.ShowDialog(this);
		}
	}
}
