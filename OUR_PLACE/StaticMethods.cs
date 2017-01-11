using System;
using System.Data;
using System.Windows.Forms;

namespace OUR_PLACE
{
	/// <summary>
	/// Summary description for StaticMethods.
	/// </summary>
	public class StaticMethods
	{
		public static void LoadCombos(ComboBox ao_cboComboBox, string as_LookupType)
		{
			try
			{
				string ls_SQL = ""
					+ "SELECT		LOO_ID, LOO_NAME "
					+ "FROM			LOOKUP "
					+ "WHERE		LOO_TYPE = '" + as_LookupType + "' ";

				DataSet lo_DS = StaticVariables.mo_DBLayer.ExecuteSQL(ls_SQL);
	
				ao_cboComboBox.DataSource = lo_DS.Tables[0];
				ao_cboComboBox.DisplayMember = "LOO_NAME";
				ao_cboComboBox.ValueMember = "LOO_ID";
			}
			catch (Exception lo_ex)
			{
				string message = lo_ex.Message;
			}
		}
	}
}
