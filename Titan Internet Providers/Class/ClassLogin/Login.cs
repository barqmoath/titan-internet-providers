using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Titan_Internet_Providers.Class.ClassLogin
{
    class Login
    {
        private Main.MainClass.DataControl control = new Main.MainClass.DataControl();
        private DataTable Table = new DataTable();
        private SqlParameter[] Param = new SqlParameter[2];
        private string Username = null;
        private string Password = null;
        private string UserType = null;

        public Login(string US , string PW)
        {
            this.Username = US;
            this.Password = PW;
        }

        public bool TheLoginOk()
        {
            Param[0] = new SqlParameter("@US", SqlDbType.VarChar, 50);
            Param[0].Value = this.Username;
            Param[1] = new SqlParameter("@PW", SqlDbType.VarChar, 50);
            Param[1].Value = this.Password;
            Table = control.Getdata("LOGN", Param);
            if(Table.Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetUserType()
        {
            this.UserType = Convert.ToString(Table.Rows[0][2]);
            return this.UserType;
        }

        public string GetUserName()
        {
            return Convert.ToString(Table.Rows[0][0]);
        }
    }
}
