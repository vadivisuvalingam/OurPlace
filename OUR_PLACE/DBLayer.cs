using System;
using System.Data;
using System.Data.SqlClient; 
using System.Configuration;

namespace OUR_PLACE
{
	/// <summary>
	/// Summary description for DBLayer.
	/// </summary>
	public class DBLayer
	{

		private	string ms_strConnect;

		public DBLayer()
		{
			ms_strConnect = ConfigurationSettings.AppSettings.Get("ConnectionString").ToString();
		}

		public DataSet ExecuteSQL(string as_strSQL)
		{

			SqlConnection lo_conn = new SqlConnection(ms_strConnect);

			SqlCommand lo_comm = new SqlCommand();

			lo_comm.Connection = lo_conn;

			SqlDataAdapter lo_adapter = new SqlDataAdapter(lo_comm);

			DataSet lo_DS = new DataSet();

			lo_conn.Open();

			lo_comm.CommandText = as_strSQL;
			
			lo_adapter.Fill(lo_DS, "Checklist");

			lo_conn.Close();

			return lo_DS;
		}

	}
}
