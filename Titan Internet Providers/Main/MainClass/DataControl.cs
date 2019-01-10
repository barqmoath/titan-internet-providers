using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Titan_Internet_Providers.Main.MainClass
{
    class DataControl
    {
        //This is a Private connection Varible -----------
        SqlConnection Connection;
        //----------------------
      
        //This is a Private Connection string Varible-----
        string Server = Properties.Settings.Default.dbs_Servername;
        string Database = Properties.Settings.Default.dbs_Databasename;
        string Authentication = Properties.Settings.Default.dbs_Authentication;
        string UserID = Properties.Settings.Default.dbs_Username;
        string Password = Properties.Settings.Default.dbs_Password;


        //This is a Constrctor 
        public DataControl()
        {
            if(this.Authentication=="windows")
            {
                this.Connection = new SqlConnection(@"Server="+this.Server+"; Database="+this.Database+ "; Integrated Security=true");
            }
            else if(this.Authentication=="sql")
            {
                this.Connection = new SqlConnection(@"Server=" + this.Server + "; Database=" + this.Database + "; Integrated Security=false; User ID=" + this.UserID + "; Password=" + this.Password + ";");
            }
        }

        // Function Open Connection With Database ---------------------------------
        private void OpenConnection()
        {
            if (this.Connection.State == ConnectionState.Closed)
                this.Connection.Open();
        }

        // Function Close Connection With Database ---------------------------------
        private void CloseConnection()
        {
            if (this.Connection.State == ConnectionState.Open)
                this.Connection.Close();
        }

        // Function To Send or Delete or Update The Data From Database --------------
        public void Execution(string StoredProcedure , SqlParameter[] Parameters)
        {
            SqlCommand Command = new SqlCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.Connection = this.Connection;
            Command.CommandText = StoredProcedure;

            if(Parameters != null)
            {
                Command.Parameters.AddRange(Parameters);
            }

            OpenConnection();
            Command.ExecuteNonQuery();
            CloseConnection();
        }

        //Function To Get Data From Database ------------------------------------------
        public DataTable Getdata (string StoredProcedure, SqlParameter[] Parameters)
        {
            SqlCommand Command = new SqlCommand();
            Command.CommandType = CommandType.StoredProcedure;
            Command.Connection = this.Connection;
            Command.CommandText = StoredProcedure;

            if (Parameters != null)
            {
                Command.Parameters.AddRange(Parameters);
            }

            SqlDataAdapter Adapter = new SqlDataAdapter(Command);
            DataTable Table = new DataTable();
            Adapter.Fill(Table);
            return Table;
        }
    }
}
