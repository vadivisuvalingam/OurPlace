using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace OUR_PLACE
{
	/// <summary>
	/// Summary description for ctlFreeText.
	/// </summary>
	public class ctlFreeText : System.Windows.Forms.UserControl
	{
		private string ms_lblFreeText;
		private string ms_txtFreeText;
		private int mi_FreeTextSize;

		private System.Windows.Forms.TextBox txtFreeText;
		private System.Windows.Forms.Label lblFreeText;
		private System.Windows.Forms.Label lblFreeTextSize;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ctlFreeText()
		{
			mi_FreeTextSize = 0; 

			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			PublishTextLength();

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
			this.txtFreeText = new System.Windows.Forms.TextBox();
			this.lblFreeText = new System.Windows.Forms.Label();
			this.lblFreeTextSize = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtFreeText
			// 
			this.txtFreeText.Location = new System.Drawing.Point(0, 24);
			this.txtFreeText.MaxLength = 0;
			this.txtFreeText.Multiline = true;
			this.txtFreeText.Name = "txtFreeText";
			this.txtFreeText.Size = new System.Drawing.Size(580, 80);
			this.txtFreeText.TabIndex = 7;
			this.txtFreeText.Text = "";
			this.txtFreeText.TextChanged += new System.EventHandler(this.txtFreeText_TextChanged);
			// 
			// lblFreeText
			// 
			this.lblFreeText.Location = new System.Drawing.Point(0, 0);
			this.lblFreeText.Name = "lblFreeText";
			this.lblFreeText.Size = new System.Drawing.Size(580, 23);
			this.lblFreeText.TabIndex = 6;
			// 
			// lblFreeTextSize
			// 
			this.lblFreeTextSize.Location = new System.Drawing.Point(0, 104);
			this.lblFreeTextSize.Name = "lblFreeTextSize";
			this.lblFreeTextSize.Size = new System.Drawing.Size(580, 16);
			this.lblFreeTextSize.TabIndex = 8;
			this.lblFreeTextSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// ctlFreeText
			// 
			this.Controls.Add(this.lblFreeTextSize);
			this.Controls.Add(this.txtFreeText);
			this.Controls.Add(this.lblFreeText);
			this.Name = "ctlFreeText";
			this.Size = new System.Drawing.Size(592, 128);
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers

		private void txtFreeText_TextChanged(object sender, System.EventArgs e)
		{
		
			PublishTextLength();
		}

		#endregion

		#region Private Methods

		private void PublishTextLength()
		{
			lblFreeTextSize.Text = txtFreeText.TextLength + " Characters (" + mi_FreeTextSize + " Character Max)";			
		}

		#endregion

		#region Properties

		public string Label
		{
			get
			{
				ms_lblFreeText = lblFreeText.Text;
				return ms_lblFreeText;
			}
			set
			{
				ms_lblFreeText = value;
				lblFreeText.Text = ms_lblFreeText;
			}
		}

		public string FreeText
		{
			get
			{
				ms_txtFreeText = txtFreeText.Text;
				return ms_txtFreeText;
			}
			set
			{
				ms_txtFreeText = value;
				txtFreeText.Text = ms_txtFreeText;
			}
		}

		public int FreeTextSize
		{
			get
			{
				return mi_FreeTextSize;
			}
			set
			{
				mi_FreeTextSize = value;
				txtFreeText.MaxLength = mi_FreeTextSize;
				PublishTextLength();
			}

		}

		#endregion

	}
}
