namespace ControlLibrary
{
    partial class ctlFreeText
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFreeText = new System.Windows.Forms.Label();
            this.txtFreeText = new System.Windows.Forms.TextBox();
            this.lblFreeTextSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFreeText
            // 
            this.lblFreeText.AutoSize = true;
            this.lblFreeText.Location = new System.Drawing.Point(-3, 0);
            this.lblFreeText.Name = "lblFreeText";
            this.lblFreeText.Size = new System.Drawing.Size(35, 13);
            this.lblFreeText.TabIndex = 0;
            this.lblFreeText.Text = "label1";
            // 
            // txtFreeText
            // 
            this.txtFreeText.Location = new System.Drawing.Point(0, 16);
            this.txtFreeText.Multiline = true;
            this.txtFreeText.Name = "txtFreeText";
            this.txtFreeText.Size = new System.Drawing.Size(600, 114);
            this.txtFreeText.TabIndex = 1;
            this.txtFreeText.TextChanged += new System.EventHandler(this.txtFreeText_TextChanged);
            // 
            // lblFreeTextSize
            // 
            this.lblFreeTextSize.AutoSize = true;
            this.lblFreeTextSize.Location = new System.Drawing.Point(565, 137);
            this.lblFreeTextSize.Name = "lblFreeTextSize";
            this.lblFreeTextSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFreeTextSize.Size = new System.Drawing.Size(35, 13);
            this.lblFreeTextSize.TabIndex = 2;
            this.lblFreeTextSize.Text = "label2";
            // 
            // ctlFreeText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFreeTextSize);
            this.Controls.Add(this.txtFreeText);
            this.Controls.Add(this.lblFreeText);
            this.Name = "ctlFreeText";
            this.Size = new System.Drawing.Size(600, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFreeText;
        private System.Windows.Forms.TextBox txtFreeText;
        private System.Windows.Forms.Label lblFreeTextSize;
    }
}
