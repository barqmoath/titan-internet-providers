using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Titan_Internet_Providers.Class.ClassSubscribe
{
    class Subc
    {
        public DataTable GetSubcList()
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            return control.Getdata("GET_ALL_SUBCS", null);
        }

        public DataTable GetAccont()
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            return control.Getdata("SELECT_ALL_FROM_ACCOUNT", null);
        }

        public string GetAccountMonyType(string Code)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@Code", SqlDbType.VarChar, 50);
            Param[0].Value = Code;
            DataTable T = new DataTable();
            T= control.Getdata("GetMonyTypeFromMyAccount", Param);
            return T.Rows[0][0].ToString();
        }

        public void DeleteSubc(int ID)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID", SqlDbType.Int);
            Param[0].Value = ID;
            control.Execution("DELETE_SUBSCRIBE", Param);
        }

        public void SaveSubc(string Label , string Type , string ActivePrice , string MonyType , string FromAccount , string MainPrice ,string BuyMonytype)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[7];

            Param[0] = new SqlParameter("@LABEL", SqlDbType.VarChar,50);
            Param[0].Value = Label;

            Param[1] = new SqlParameter("@TYPE", SqlDbType.VarChar, 50);
            Param[1].Value = Type;

            Param[2] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            Param[2].Value = ActivePrice;

            Param[3] = new SqlParameter("@MONYTYPE", SqlDbType.VarChar, 50);
            Param[3].Value = MonyType;

            Param[4] = new SqlParameter("@FROM_ACCOUNT", SqlDbType.VarChar, 50);
            Param[4].Value = FromAccount;

            Param[5] = new SqlParameter("@BuyPrice", SqlDbType.VarChar, 50);
            Param[5].Value = MainPrice;

            Param[6] = new SqlParameter("@BuyMonyType", SqlDbType.VarChar, 50);
            Param[6].Value = BuyMonytype;

            control.Execution("SAVE_SUBC", Param);

        }

        public void EditSubc(string Label, string Type, string ActivePrice, string MonyType, string FromAccount, string MainPrice , int ID , string BuyMonytype)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[8];

            Param[0] = new SqlParameter("@LABEL", SqlDbType.VarChar, 50);
            Param[0].Value = Label;

            Param[1] = new SqlParameter("@TYPE", SqlDbType.VarChar, 50);
            Param[1].Value = Type;

            Param[2] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            Param[2].Value = ActivePrice;

            Param[3] = new SqlParameter("@MONYTYPE", SqlDbType.VarChar, 50);
            Param[3].Value = MonyType;

            Param[4] = new SqlParameter("@FROM_ACCOUNT", SqlDbType.VarChar, 50);
            Param[4].Value = FromAccount;

            Param[5] = new SqlParameter("@BuyPrice", SqlDbType.VarChar, 50);
            Param[5].Value = MainPrice;

            Param[6] = new SqlParameter("@ID", SqlDbType.Int);
            Param[6].Value = ID;

            Param[7] = new SqlParameter("@BuyMonyType", SqlDbType.VarChar, 50);
            Param[7].Value = BuyMonytype;

            control.Execution("UPDATE_SUBC", Param);
        }
    }
}
