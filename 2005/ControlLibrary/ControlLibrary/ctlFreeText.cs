using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class ctlFreeText : UserControl
    {
        private string ms_lblFreeText;
        private string ms_txtFreeText;
        private int mi_FreeTextSize;

        public ctlFreeText()
        {
            mi_FreeTextSize = 0; 

            InitializeComponent();
        }

        #region Event Handlers

        private void txtFreeText_TextChanged(object sender, EventArgs e)
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
