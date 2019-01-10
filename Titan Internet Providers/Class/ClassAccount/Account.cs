using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Titan_Internet_Providers.Class.ClassAccount
{
    class Account
    {
        public DataTable GetAccountList()
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            return control.Getdata("SELECT_ALL_FROM_ACCOUNT", null);
        }

        public void DeleteAccount(int ID)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID", SqlDbType.Int);
            Param[0].Value = ID;
            control.Execution("DELETE_ACCOUNT", Param);
        }

        public void SaveAccount(string Code , string Label , string Owner , DateTime OpenDate , DateTime LastUpdateDate , string MonyType , string Qty , string MainOrnot )
        {
            //@CODE,@LABEL,@OWNER,@ACCOINTOPEN,@LASTUPDATE,@MONYTYPE,@QTY,@MAIN

            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[8];

            Param[0] = new SqlParameter("@CODE", SqlDbType.VarChar, 50);
            Param[0].Value = Code;

            Param[1] = new SqlParameter("@LABEL", SqlDbType.VarChar, 50);
            Param[1].Value = Label;

            Param[2] = new SqlParameter("@OWNER", SqlDbType.VarChar, 50);
            Param[2].Value = Owner;

            Param[3] = new SqlParameter("@ACCOINTOPEN", SqlDbType.Date);
            Param[3].Value = OpenDate;

            Param[4] = new SqlParameter("@LASTUPDATE", SqlDbType.Date);
            Param[4].Value = LastUpdateDate;

            Param[5] = new SqlParameter("@MONYTYPE", SqlDbType.VarChar, 50);
            Param[5].Value = MonyType;

            Param[6] = new SqlParameter("@QTY", SqlDbType.VarChar, 50);
            Param[6].Value = Qty;

            Param[7] = new SqlParameter("@MAIN", SqlDbType.VarChar, 50);
            Param[7].Value = MainOrnot;

            control.Execution("SAVE_MY_ACCOUNT", Param);
        }

        public void EditAccount(string Code, string Label, string Owner, DateTime OpenDate, DateTime LastUpdateDate, string MonyType, string Qty, string MainOrnot,int ID)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[9];

            Param[0] = new SqlParameter("@CODE", SqlDbType.VarChar, 50);
            Param[0].Value = Code;

            Param[1] = new SqlParameter("@LABEL", SqlDbType.VarChar, 50);
            Param[1].Value = Label;

            Param[2] = new SqlParameter("@OWNER", SqlDbType.VarChar, 50);
            Param[2].Value = Owner;

            Param[3] = new SqlParameter("@ACCOINTOPEN", SqlDbType.Date);
            Param[3].Value = OpenDate;

            Param[4] = new SqlParameter("@LASTUPDATE", SqlDbType.Date);
            Param[4].Value = LastUpdateDate;

            Param[5] = new SqlParameter("@MONYTYPE", SqlDbType.VarChar, 50);
            Param[5].Value = MonyType;

            Param[6] = new SqlParameter("@QTY", SqlDbType.VarChar, 50);
            Param[6].Value = Qty;

            Param[7] = new SqlParameter("@MAIN", SqlDbType.VarChar, 50);
            Param[7].Value = MainOrnot;

            Param[8] = new SqlParameter("@ID", SqlDbType.Int);
            Param[8].Value = ID;

            control.Execution("Update_Accounts", Param);

        }

        public DataTable MultiSerach(string txt)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];

            Param[0] = new SqlParameter("@txt", SqlDbType.VarChar, 50);
            Param[0].Value = txt;

            return control.Getdata("MULTI_SEARCH_IN_MYACCOUNT", Param);
        }

        public bool AccountCodeOk(string Code)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];

            Param[0] = new SqlParameter("@Code", SqlDbType.VarChar, 50);
            Param[0].Value = Code;

            DataTable t = new DataTable();
            t = control.Getdata("CODE_OK_OF_ACCOUNT", Param);

            if(t.Rows.Count >0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
