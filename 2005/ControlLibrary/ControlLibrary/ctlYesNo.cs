using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class ctlYesNo : UserControl
    {
        private bool mb_Checked;

        public ctlYesNo()
        {
            InitializeComponent();
        }

        #region Event Handlers

        private void chkYes_CheckedChanged(object sender, EventArgs e)
        {
            chkNo.Checked = !chkYes.Checked;
            mb_Checked = true;
        }

        private void chkNo_CheckedChanged(object sender, EventArgs e)
        {
            chkYes.Checked = !chkNo.Checked;
            mb_Checked = false;
        }

        #endregion

        #region Properties

        public bool Checked
        {
            get
            {
                return mb_Checked;
            }
            set
            {
                mb_Checked = value;
                if (mb_Checked)
                {
                    chkYes.Checked = true;
                    chkNo.Checked = false;
                }
                else
                {
                    chkYes.Checked = false;
                    chkNo.Checked = true;
                }
            }
        }

        #endregion
    }
}
