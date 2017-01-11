using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace OUR_PLACE
{
	/// <summary>
	/// Summary description for frmMedication.
	/// </summary>
	public class frmMedication : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblMedicationType;
		private System.Windows.Forms.TextBox txtMedicationType;
		private System.Windows.Forms.TextBox txtDosage;
		private System.Windows.Forms.Label lblDosage;
		private System.Windows.Forms.TextBox txtPurpose;
		private System.Windows.Forms.Label lblPurpose;
		private System.Windows.Forms.TextBox txtDoctor;
		private System.Windows.Forms.Label lblDoctor;
		private System.Windows.Forms.TextBox txtContactInfo;
		private System.Windows.Forms.Label lblContactInfo;
		private System.Windows.Forms.TextBox txtDoctorType;
		private System.Windows.Forms.Label lblDoctorType;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmMedication()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblMedicationType = new System.Windows.Forms.Label();
			this.txtMedicationType = new System.Windows.Forms.TextBox();
			this.txtDosage = new System.Windows.Forms.TextBox();
			this.lblDosage = new System.Windows.Forms.Label();
			this.txtPurpose = new System.Windows.Forms.TextBox();
			this.lblPurpose = new System.Windows.Forms.Label();
			this.txtDoctor = new System.Windows.Forms.TextBox();
			this.lblDoctor = new System.Windows.Forms.Label();
			this.txtContactInfo = new System.Windows.Forms.TextBox();
			this.lblContactInfo = new System.Windows.Forms.Label();
			this.txtDoctorType = new System.Windows.Forms.TextBox();
			this.lblDoctorType = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblMedicationType
			// 
			this.lblMedicationType.Location = new System.Drawing.Point(8, 24);
			this.lblMedicationType.Name = "lblMedicationType";
			this.lblMedicationType.Size = new System.Drawing.Size(136, 23);
			this.lblMedicationType.TabIndex = 0;
			this.lblMedicationType.Text = "Type/Name of Medication";
			// 
			// txtMedicationType
			// 
			this.txtMedicationType.Location = new System.Drawing.Point(160, 24);
			this.txtMedicationType.Name = "txtMedicationType";
			this.txtMedicationType.Size = new System.Drawing.Size(256, 20);
			this.txtMedicationType.TabIndex = 1;
			this.txtMedicationType.Text = "";
			// 
			// txtDosage
			// 
			this.txtDosage.Location = new System.Drawing.Point(160, 48);
			this.txtDosage.Name = "txtDosage";
			this.txtDosage.Size = new System.Drawing.Size(256, 20);
			this.txtDosage.TabIndex = 3;
			this.txtDosage.Text = "";
			// 
			// lblDosage
			// 
			this.lblDosage.Location = new System.Drawing.Point(8, 48);
			this.lblDosage.Name = "lblDosage";
			this.lblDosage.Size = new System.Drawing.Size(136, 23);
			this.lblDosage.TabIndex = 2;
			this.lblDosage.Text = "Dosage";
			// 
			// txtPurpose
			// 
			this.txtPurpose.Location = new System.Drawing.Point(160, 72);
			this.txtPurpose.Name = "txtPurpose";
			this.txtPurpose.Size = new System.Drawing.Size(256, 20);
			this.txtPurpose.TabIndex = 5;
			this.txtPurpose.Text = "";
			// 
			// lblPurpose
			// 
			this.lblPurpose.Location = new System.Drawing.Point(8, 72);
			this.lblPurpose.Name = "lblPurpose";
			this.lblPurpose.Size = new System.Drawing.Size(136, 23);
			this.lblPurpose.TabIndex = 4;
			this.lblPurpose.Text = "Purpose";
			// 
			// txtDoctor
			// 
			this.txtDoctor.Location = new System.Drawing.Point(160, 96);
			this.txtDoctor.Name = "txtDoctor";
			this.txtDoctor.Size = new System.Drawing.Size(256, 20);
			this.txtDoctor.TabIndex = 7;
			this.txtDoctor.Text = "";
			// 
			// lblDoctor
			// 
			this.lblDoctor.Location = new System.Drawing.Point(8, 96);
			this.lblDoctor.Name = "lblDoctor";
			this.lblDoctor.Size = new System.Drawing.Size(136, 23);
			this.lblDoctor.TabIndex = 6;
			this.lblDoctor.Text = "Doctor";
			// 
			// txtContactInfo
			// 
			this.txtContactInfo.Location = new System.Drawing.Point(160, 144);
			this.txtContactInfo.Name = "txtContactInfo";
			this.txtContactInfo.Size = new System.Drawing.Size(256, 20);
			this.txtContactInfo.TabIndex = 11;
			this.txtContactInfo.Text = "";
			// 
			// lblContactInfo
			// 
			this.lblContactInfo.Location = new System.Drawing.Point(8, 144);
			this.lblContactInfo.Name = "lblContactInfo";
			this.lblContactInfo.Size = new System.Drawing.Size(136, 23);
			this.lblContactInfo.TabIndex = 10;
			this.lblContactInfo.Text = "Contact Info";
			// 
			// txtDoctorType
			// 
			this.txtDoctorType.Location = new System.Drawing.Point(160, 120);
			this.txtDoctorType.Name = "txtDoctorType";
			this.txtDoctorType.Size = new System.Drawing.Size(256, 20);
			this.txtDoctorType.TabIndex = 9;
			this.txtDoctorType.Text = "";
			// 
			// lblDoctorType
			// 
			this.lblDoctorType.Location = new System.Drawing.Point(8, 120);
			this.lblDoctorType.Name = "lblDoctorType";
			this.lblDoctorType.Size = new System.Drawing.Size(136, 23);
			this.lblDoctorType.TabIndex = 8;
			this.lblDoctorType.Text = "Type of Doctor";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(264, 176);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 12;
			this.btnOK.Text = "OK";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(344, 176);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 13;
			this.btnCancel.Text = "Cancel";
			// 
			// frmMedication
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(432, 206);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtContactInfo);
			this.Controls.Add(this.txtDoctorType);
			this.Controls.Add(this.txtDoctor);
			this.Controls.Add(this.txtPurpose);
			this.Controls.Add(this.txtDosage);
			this.Controls.Add(this.txtMedicationType);
			this.Controls.Add(this.lblContactInfo);
			this.Controls.Add(this.lblDoctorType);
			this.Controls.Add(this.lblDoctor);
			this.Controls.Add(this.lblPurpose);
			this.Controls.Add(this.lblDosage);
			this.Controls.Add(this.lblMedicationType);
			this.Name = "frmMedication";
			this.ShowInTaskbar = false;
			this.Text = "Add Medication Info";
			this.ResumeLayout(false);

		}
		#endregion

	}
}
