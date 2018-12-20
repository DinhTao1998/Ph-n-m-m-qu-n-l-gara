using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BaoCao.DAO
{
    class DataAccessHelper
    {
        //Data access properties
        SqlConnection con;
        SqlCommand cmd;
        public DataTable dt;
        string path = System.IO.Directory.GetCurrentDirectory() + @"\Gara.mdf";
        

        //Init properties
        public DataAccessHelper()
        {
            String connectionString = Properties.Settings.Default.BaoCaoConnectionString.ToString();

            con = new SqlConnection(connectionString);
        }


        //Procceed with database
        public void Open()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }

        private void Close()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }

        public DataTable GetDataTable(string select)
        {
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public SqlCommand Command(String commandString)
        {
            this.cmd = new SqlCommand(commandString, con);
            return cmd;
        }
    }
}
