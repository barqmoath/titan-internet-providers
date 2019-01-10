using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Titan_Internet_Providers.Class.ClassDebtAlert
{
    class Debt
    {
        public int ShowNumberOfPersonDebt()
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@NowDate", SqlDbType.Date);
            Param[0].Value = DateTime.Now;
            DataTable T = new DataTable();
            T = control.Getdata("SHOWING_DEBT", Param);
            if(T.Rows.Count !=0)
            {
                return T.Rows.Count;
            }
            else
            {
                return 0;
            }
        }
    }
}
