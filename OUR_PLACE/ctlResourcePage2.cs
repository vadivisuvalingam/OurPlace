using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace OUR_PLACE
{
	/// <summary>
	/// Summary description for ctlResourcePage2.
	/// </summary>
	public class ctlResourcePage2 : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.GroupBox grpAdditionalPersonalData;
		private System.Windows.Forms.Label lblContactInformation;
		private System.Windows.Forms.TextBox txtContactInformation;
		private System.Windows.Forms.Label lblShortTermGoals;
		private System.Windows.Forms.CheckBox chkSecureHousing;
		private System.Windows.Forms.CheckBox chkGetJob;
		private System.Windows.Forms.CheckBox chkPursueEducation;
		private System.Windows.Forms.CheckBox chkApplyOW;
		private System.Windows.Forms.CheckBox chkLearnToUse;
		private System.Windows.Forms.TextBox txtSpecifyLearnToUse;
		private System.Windows.Forms.Label lblSpecifyLearnToUse;
		private System.Windows.Forms.TextBox txtOtherShortTermGoalsExtended;
		private System.Windows.Forms.CheckBox chkOtherShortTermGoals;
		private System.Windows.Forms.ComboBox cboReadingWritingSkills;
		private System.Windows.Forms.Label lblReadingWritingSkills;
		private System.Windows.Forms.ComboBox cboComputerSkills;
		private System.Windows.Forms.Label lblComputerSkills;
		private System.Windows.Forms.Label lblContactInFuture;
		private OUR_PLACE.ctlYesNo chkContactInFuture;
		private System.Windows.Forms.Label lblContactInFutureContactInformation;
		private System.Windows.Forms.TextBox txtPhoneNumber;
		private System.Windows.Forms.Label lblPhoneNumber;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label lblEmail;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ctlResourcePage2()
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
			this.grpAdditionalPersonalData = new System.Windows.Forms.GroupBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.txtPhoneNumber = new System.Windows.Forms.TextBox();
			this.lblPhoneNumber = new System.Windows.Forms.Label();
			this.lblContactInFutureContactInformation = new System.Windows.Forms.Label();
			this.chkContactInFuture = new OUR_PLACE.ctlYesNo();
			this.lblContactInFuture = new System.Windows.Forms.Label();
			this.cboReadingWritingSkills = new System.Windows.Forms.ComboBox();
			this.lblReadingWritingSkills = new System.Windows.Forms.Label();
			this.cboComputerSkills = new System.Windows.Forms.ComboBox();
			this.lblComputerSkills = new System.Windows.Forms.Label();
			this.txtOtherShortTermGoalsExtended = new System.Windows.Forms.TextBox();
			this.chkOtherShortTermGoals = new System.Windows.Forms.CheckBox();
			this.txtSpecifyLearnToUse = new System.Windows.Forms.TextBox();
			this.lblSpecifyLearnToUse = new System.Windows.Forms.Label();
			this.chkLearnToUse = new System.Windows.Forms.CheckBox();
			this.chkApplyOW = new System.Windows.Forms.CheckBox();
			this.chkPursueEducation = new System.Windows.Forms.CheckBox();
			this.chkGetJob = new System.Windows.Forms.CheckBox();
			this.chkSecureHousing = new System.Windows.Forms.CheckBox();
			this.lblShortTermGoals = new System.Windows.Forms.Label();
			this.txtContactInformation = new System.Windows.Forms.TextBox();
			this.lblContactInformation = new System.Windows.Forms.Label();
			this.grpAdditionalPersonalData.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpAdditionalPersonalData
			// 
			this.grpAdditionalPersonalData.Controls.Add(this.txtEmail);
			this.grpAdditionalPersonalData.Controls.Add(this.lblEmail);
			this.grpAdditionalPersonalData.Controls.Add(this.txtPhoneNumber);
			this.grpAdditionalPersonalData.Controls.Add(this.lblPhoneNumber);
			this.grpAdditionalPersonalData.Controls.Add(this.lblContactInFutureContactInformation);
			this.grpAdditionalPersonalData.Controls.Add(this.chkContactInFuture);
			this.grpAdditionalPersonalData.Controls.Add(this.lblContactInFuture);
			this.grpAdditionalPersonalData.Controls.Add(this.cboReadingWritingSkills);
			this.grpAdditionalPersonalData.Controls.Add(this.lblReadingWritingSkills);
			this.grpAdditionalPersonalData.Controls.Add(this.cboComputerSkills);
			this.grpAdditionalPersonalData.Controls.Add(this.lblComputerSkills);
			this.grpAdditionalPersonalData.Controls.Add(this.txtOtherShortTermGoalsExtended);
			this.grpAdditionalPersonalData.Controls.Add(this.chkOtherShortTermGoals);
			this.grpAdditionalPersonalData.Controls.Add(this.txtSpecifyLearnToUse);
			this.grpAdditionalPersonalData.Controls.Add(this.lblSpecifyLearnToUse);
			this.grpAdditionalPersonalData.Controls.Add(this.chkLearnToUse);
			this.grpAdditionalPersonalData.Controls.Add(this.chkApplyOW);
			this.grpAdditionalPersonalData.Controls.Add(this.chkPursueEducation);
			this.grpAdditionalPersonalData.Controls.Add(this.chkGetJob);
			this.grpAdditionalPersonalData.Controls.Add(this.chkSecureHousing);
			this.grpAdditionalPersonalData.Controls.Add(this.lblShortTermGoals);
			this.grpAdditionalPersonalData.Controls.Add(this.txtContactInformation);
			this.grpAdditionalPersonalData.Controls.Add(this.lblContactInformation);
			this.grpAdditionalPersonalData.Location = new System.Drawing.Point(8, 8);
			this.grpAdditionalPersonalData.Name = "grpAdditionalPersonalData";
			this.grpAdditionalPersonalData.Size = new System.Drawing.Size(632, 336);
			this.grpAdditionalPersonalData.TabIndex = 0;
			this.grpAdditionalPersonalData.TabStop = false;
			this.grpAdditionalPersonalData.Text = "Additional Personal Data";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(112, 304);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.TabIndex = 149;
			this.txtEmail.Text = "";
			// 
			// lblEmail
			// 
			this.lblEmail.Location = new System.Drawing.Point(16, 304);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.TabIndex = 148;
			this.lblEmail.Text = "Email";
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Location = new System.Drawing.Point(112, 280);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.TabIndex = 147;
			this.txtPhoneNumber.Text = "";
			// 
			// lblPhoneNumber
			// 
			this.lblPhoneNumber.Location = new System.Drawing.Point(16, 280);
			this.lblPhoneNumber.Name = "lblPhoneNumber";
			this.lblPhoneNumber.TabIndex = 146;
			this.lblPhoneNumber.Text = "Phone Number";
			// 
			// lblContactInFutureContactInformation
			// 
			this.lblContactInFutureContactInformation.Location = new System.Drawing.Point(16, 256);
			this.lblContactInFutureContactInformation.Name = "lblContactInFutureContactInformation";
			this.lblContactInFutureContactInformation.Size = new System.Drawing.Size(392, 23);
			this.lblContactInFutureContactInformation.TabIndex = 145;
			this.lblContactInFutureContactInformation.Text = "If yes, please provide a phone number or email where we can contact you:";
			// 
			// chkContactInFuture
			// 
			this.chkContactInFuture.Checked = false;
			this.chkContactInFuture.Location = new System.Drawing.Point(368, 200);
			this.chkContactInFuture.Name = "chkContactInFuture";
			this.chkContactInFuture.Size = new System.Drawing.Size(150, 24);
			this.chkContactInFuture.TabIndex = 144;
			// 
			// lblContactInFuture
			// 
			this.lblContactInFuture.Location = new System.Drawing.Point(16, 200);
			this.lblContactInFuture.Name = "lblContactInFuture";
			this.lblContactInFuture.Size = new System.Drawing.Size(352, 48);
			this.lblContactInFuture.TabIndex = 143;
			this.lblContactInFuture.Text = "We are currently trying to measure our impact and improve our services.  Can we c" +
				"ontact you in the future to ask you a few questions about your experiences in th" +
				"e Resource Room?";
			// 
			// cboReadingWritingSkills
			// 
			this.cboReadingWritingSkills.Location = new System.Drawing.Point(288, 168);
			this.cboReadingWritingSkills.Name = "cboReadingWritingSkills";
			this.cboReadingWritingSkills.Size = new System.Drawing.Size(336, 21);
			this.cboReadingWritingSkills.TabIndex = 142;
			// 
			// lblReadingWritingSkills
			// 
			this.lblReadingWritingSkills.Location = new System.Drawing.Point(16, 168);
			this.lblReadingWritingSkills.Name = "lblReadingWritingSkills";
			this.lblReadingWritingSkills.Size = new System.Drawing.Size(264, 23);
			this.lblReadingWritingSkills.TabIndex = 141;
			this.lblReadingWritingSkills.Text = "How would you rate your reading and writing skills?";
			// 
			// cboComputerSkills
			// 
			this.cboComputerSkills.Location = new System.Drawing.Point(288, 144);
			this.cboComputerSkills.Name = "cboComputerSkills";
			this.cboComputerSkills.Size = new System.Drawing.Size(336, 21);
			this.cboComputerSkills.TabIndex = 140;
			// 
			// lblComputerSkills
			// 
			this.lblComputerSkills.Location = new System.Drawing.Point(16, 144);
			this.lblComputerSkills.Name = "lblComputerSkills";
			this.lblComputerSkills.Size = new System.Drawing.Size(256, 23);
			this.lblComputerSkills.TabIndex = 139;
			this.lblComputerSkills.Text = "How would you rate your computer skills?";
			// 
			// txtOtherShortTermGoalsExtended
			// 
			this.txtOtherShortTermGoalsExtended.Location = new System.Drawing.Point(88, 112);
			this.txtOtherShortTermGoalsExtended.Name = "txtOtherShortTermGoalsExtended";
			this.txtOtherShortTermGoalsExtended.TabIndex = 12;
			this.txtOtherShortTermGoalsExtended.Text = "";
			// 
			// chkOtherShortTermGoals
			// 
			this.chkOtherShortTermGoals.Location = new System.Drawing.Point(24, 112);
			this.chkOtherShortTermGoals.Name = "chkOtherShortTermGoals";
			this.chkOtherShortTermGoals.Size = new System.Drawing.Size(64, 24);
			this.chkOtherShortTermGoals.TabIndex = 10;
			this.chkOtherShortTermGoals.Text = "Other";
			// 
			// txtSpecifyLearnToUse
			// 
			this.txtSpecifyLearnToUse.Location = new System.Drawing.Point(320, 88);
			this.txtSpecifyLearnToUse.Name = "txtSpecifyLearnToUse";
			this.txtSpecifyLearnToUse.TabIndex = 9;
			this.txtSpecifyLearnToUse.Text = "";
			// 
			// lblSpecifyLearnToUse
			// 
			this.lblSpecifyLearnToUse.Location = new System.Drawing.Point(272, 88);
			this.lblSpecifyLearnToUse.Name = "lblSpecifyLearnToUse";
			this.lblSpecifyLearnToUse.TabIndex = 8;
			this.lblSpecifyLearnToUse.Text = "Specify:";
			// 
			// chkLearnToUse
			// 
			this.chkLearnToUse.Location = new System.Drawing.Point(24, 88);
			this.chkLearnToUse.Name = "chkLearnToUse";
			this.chkLearnToUse.Size = new System.Drawing.Size(216, 24);
			this.chkLearnToUse.TabIndex = 7;
			this.chkLearnToUse.Text = "Learn to use Computer/Internet/E-mail";
			// 
			// chkApplyOW
			// 
			this.chkApplyOW.Location = new System.Drawing.Point(352, 64);
			this.chkApplyOW.Name = "chkApplyOW";
			this.chkApplyOW.TabIndex = 6;
			this.chkApplyOW.Text = "Apply for OW";
			// 
			// chkPursueEducation
			// 
			this.chkPursueEducation.Location = new System.Drawing.Point(224, 64);
			this.chkPursueEducation.Name = "chkPursueEducation";
			this.chkPursueEducation.Size = new System.Drawing.Size(128, 24);
			this.chkPursueEducation.TabIndex = 5;
			this.chkPursueEducation.Text = "Pursue Education";
			// 
			// chkGetJob
			// 
			this.chkGetJob.Location = new System.Drawing.Point(136, 64);
			this.chkGetJob.Name = "chkGetJob";
			this.chkGetJob.TabIndex = 4;
			this.chkGetJob.Text = "Get a Job";
			// 
			// chkSecureHousing
			// 
			this.chkSecureHousing.Location = new System.Drawing.Point(24, 64);
			this.chkSecureHousing.Name = "chkSecureHousing";
			this.chkSecureHousing.TabIndex = 3;
			this.chkSecureHousing.Text = "Secure Housing";
			// 
			// lblShortTermGoals
			// 
			this.lblShortTermGoals.Location = new System.Drawing.Point(16, 48);
			this.lblShortTermGoals.Name = "lblShortTermGoals";
			this.lblShortTermGoals.Size = new System.Drawing.Size(232, 23);
			this.lblShortTermGoals.TabIndex = 2;
			this.lblShortTermGoals.Text = "What are your short term goals?";
			// 
			// txtContactInformation
			// 
			this.txtContactInformation.Location = new System.Drawing.Point(152, 24);
			this.txtContactInformation.Name = "txtContactInformation";
			this.txtContactInformation.Size = new System.Drawing.Size(240, 20);
			this.txtContactInformation.TabIndex = 1;
			this.txtContactInformation.Text = "";
			// 
			// lblContactInformation
			// 
			this.lblContactInformation.Location = new System.Drawing.Point(16, 24);
			this.lblContactInformation.Name = "lblContactInformation";
			this.lblContactInformation.Size = new System.Drawing.Size(128, 23);
			this.lblContactInformation.TabIndex = 0;
			this.lblContactInformation.Text = "Email or Phone Number";
			// 
			// ctlResourcePage2
			// 
			this.AutoScroll = true;
			this.Controls.Add(this.grpAdditionalPersonalData);
			this.Name = "ctlResourcePage2";
			this.Size = new System.Drawing.Size(648, 360);
			this.grpAdditionalPersonalData.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Private Methods

		private void LoadCombos()
		{			
			StaticMethods.LoadCombos(cboComputerSkills, "COMPUTER_SKILLS");
			StaticMethods.LoadCombos(cboReadingWritingSkills, "READING_WRITING_SKILLS");
		}

		#endregion
	}
}
