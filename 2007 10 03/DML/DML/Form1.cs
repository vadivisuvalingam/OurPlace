using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace DML
{
    public partial class Form1 : Form
    {
        private string ms_strConnect;

        public Form1()
        {
            InitializeComponent();

            ms_strConnect = @"Server=ANANTHAN_WIDESC\SQLEXPRESS;Database=OUR_PLACE_DEV;Uid=database_sa_our_place;Pwd=qwer1234ASDF;Trusted_Connection=yes;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ls_SQL = " SELECT * FROM " + textBox1.Text;

            DataTable lo_DT = ((DataSet)ExecuteSQL(ls_SQL)).Tables[0];

            FileStream file = new FileStream("Load" + textBox1.Text + ".sql", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(file);

            foreach (DataRow lo_DR in lo_DT.Rows)
            {
                sw.WriteLine("INSERT INTO " + textBox1.Text);
                sw.Write("           (");
                for (int i = 1; i < lo_DT.Columns.Count; i++)
                {
                    if (i == (lo_DT.Columns.Count - 1))
                    {
                        sw.Write(lo_DT.Columns[i].ColumnName);
                    }
                    else
                    {
                        sw.Write(lo_DT.Columns[i].ColumnName + ", ");
                    }
                }
                sw.WriteLine(")");
                sw.WriteLine("VALUES");
                sw.Write("           (");
                for (int i = 1; i < lo_DT.Columns.Count; i++)
                {
                    if (i == (lo_DT.Columns.Count - 1))
                    {
                        sw.Write("'" + lo_DR[i].ToString() + "'");
                    }
                    else
                    {
                        sw.Write("'" + lo_DR[i].ToString() + "'" + ", ");
                    }
                }
                sw.WriteLine(");");
                sw.WriteLine(" ");

            }
            sw.Close();
        }


        public DataSet ExecuteSQL(string as_strSQL)
        {
            
                DataSet lo_DS = new DataSet();

                SqlConnection lo_conn = new SqlConnection(ms_strConnect);

                SqlCommand lo_comm = new SqlCommand();

                lo_comm.Connection = lo_conn;

                SqlDataAdapter lo_adapter = new SqlDataAdapter(lo_comm);

                lo_conn.Open();

                //as_strSQL = as_strSQL.Replace("children's", "childrens");
                lo_comm.CommandText = as_strSQL;

                lo_adapter.Fill(lo_DS);

                lo_conn.Close();

                return lo_DS;
            
        }

    }
}