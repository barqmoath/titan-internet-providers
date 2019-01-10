using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Titan_Internet_Providers.Class.ClassDebt
{
    class Debt
    {
        public DataTable GetDebtList()
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            return control.Getdata("GET_DEBT_LIST", null);
        }

        public DataTable ShowImportList()
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@NowDate", SqlDbType.Date);
            Param[0].Value = DateTime.Now.Date;
            return control.Getdata("SHOW_IMPORT_DEBT_INLIST", Param);
        }

        public void DeletDebt(int ID)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID", SqlDbType.Int);
            Param[0].Value = ID;
            control.Execution("DeleteDebt", Param);
        }

        public void UpdateDebt(int ID ,string NewQty, DateTime NewDate)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[3];
            Param[0] = new SqlParameter("@ID", SqlDbType.Int);
            Param[0].Value = ID;
            Param[1] = new SqlParameter("@NewQty", SqlDbType.VarChar,50);
            Param[1].Value = NewQty;
            Param[2] = new SqlParameter("@NewDate", SqlDbType.Date);
            Param[2].Value = NewDate;
            control.Execution("UpdateDebt", Param);
        }

        public DataTable MultiSearch(string Text)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@txt", SqlDbType.VarChar,50);
            Param[0].Value = Text;
            return control.Getdata("MultSearch", Param);
        }

        public string GetMyPersonPhone(int PersonID)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID", SqlDbType.Int);
            Param[0].Value = PersonID;
            DataTable T = new DataTable();
            T=control.Getdata("Get_My_Phone_Number_in_Debt", Param);
            string PhoneNumber = T.Rows[0][0].ToString();
            return PhoneNumber;
        }
    }
}
