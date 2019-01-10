using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Titan_Internet_Providers.Class.ClassActive
{
    class Active
    {
        public DataTable GetPaperList()
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            return control.Getdata("GET_ACTIVE_LISTPAPER", null);
        }

        public DataTable SearchWithDate(DateTime Date)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@D", SqlDbType.Date);
            Param[0].Value = Date;
            return control.Getdata("SERCH_WITH_DATE_PAPER", Param);
        }

        public void DeleteOldPaper(int ID)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID", SqlDbType.Int);
            Param[0].Value = ID;
            control.Execution("DELETE_OLD_PAPER", Param);
        }

        public void DeleteAll()
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            control.Execution("DeleteAllOldPAPER", null);
        }

        public DataTable GetSubcInfo(string Text)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@txt", SqlDbType.VarChar,50);
            Param[0].Value = Text;
            return control.Getdata("GET_SUBC_INFO_FOR_ACTIVE", Param);
        }

        public string GetAccountQty(string Code)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@Code", SqlDbType.VarChar, 50);
            Param[0].Value = Code;
            DataTable T = new DataTable();
            T = control.Getdata("GET_ACCOUNT_QTY", Param);
            if(T.Rows.Count !=0 )
            {
                return Convert.ToString(T.Rows[0][0]);
            }
            else
            {
                return "nothing Get";
            }
        }

        public DataTable GetPersonInfo(string Text)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@txt", SqlDbType.VarChar, 50);
            Param[0].Value = Text;
            return control.Getdata("GET_PERSON_INFO_FORACTIVE", Param);
        }

        public string PersonDebtCheck(int ID)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID", SqlDbType.Int);
            Param[0].Value = ID;
            DataTable T = new DataTable();
            T= control.Getdata("CHECK_DEBT_PERSON", Param);
            if(T.Rows.Count !=0)
            {
                return Convert.ToString(T.Rows[0][0]);
            }
            else
            {
                return "لايوجد";
            }
        }

        public void SavePaper(DateTime PaperDate , string PaperTime , string PaperType , int PersonID , string PersonName , string PersonUser , int SubcID , string SubcLabel ,string Price, string QTY , string Amount , string Giv , string Rest , string MonyType , string USER , string NOTS,DateTime End )
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[17];

            Param[0] = new SqlParameter("@P_DATE", SqlDbType.Date);
            Param[0].Value = PaperDate;

            Param[1] = new SqlParameter("@P_TIME", SqlDbType.VarChar, 50);
            Param[1].Value = PaperTime;

            Param[2] = new SqlParameter("@P_TYPE", SqlDbType.VarChar, 50);
            Param[2].Value = PaperType;

            Param[3] = new SqlParameter("@PERSON_ID", SqlDbType.Int);
            Param[3].Value = PersonID;

            Param[4] = new SqlParameter("@PERSON_NAME", SqlDbType.VarChar, 50);
            Param[4].Value = PersonName;

            Param[5] = new SqlParameter("@PERSON_USER", SqlDbType.VarChar, 50);
            Param[5].Value = PersonUser;

            Param[6] = new SqlParameter("@SUBC_ID", SqlDbType.Int);
            Param[6].Value = SubcID;

            Param[7] = new SqlParameter("@SUBC_LABEL", SqlDbType.VarChar, 50);
            Param[7].Value = SubcLabel;

            Param[8] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            Param[8].Value =Price ;

            Param[9] = new SqlParameter("@QTY", SqlDbType.VarChar, 50);
            Param[9].Value = QTY;

            Param[10] = new SqlParameter("@AMOUNT", SqlDbType.VarChar, 50);
            Param[10].Value = Amount;

            Param[11] = new SqlParameter("GIV", SqlDbType.VarChar, 50);
            Param[11].Value =Giv;

            Param[12] = new SqlParameter("@REST", SqlDbType.VarChar, 50);
            Param[12].Value = Rest;

            Param[13] = new SqlParameter("@MONY_TYPE", SqlDbType.VarChar, 50);
            Param[13].Value =MonyType;

            Param[14] = new SqlParameter("@USER", SqlDbType.VarChar, 50);
            Param[14].Value = USER;

            Param[15] = new SqlParameter("@NOTS", SqlDbType.VarChar, 50);
            Param[15].Value = NOTS;

            Param[16] = new SqlParameter("@END_DATE", SqlDbType.Date);
            Param[16].Value = End;

            control.Execution("SAVE_ACTIVE_PAPER", Param);
        }

        public void UpdateAccount(string AccountCode ,string NewAccountQTY)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[2];

            Param[0] = new SqlParameter("@Code", SqlDbType.VarChar,50);
            Param[0].Value = AccountCode;

            Param[1] = new SqlParameter("@NewQty", SqlDbType.VarChar, 50);
            Param[1].Value = NewAccountQTY;

            control.Execution("UPDATE_ACCOUNT_AFTER_ACTIVE", Param);
        }

        public void UpdateStatus(int SubcID, string SubcLabel,string NewStatus , DateTime StartDate , DateTime EndDate,int PersonID)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[6];

            Param[0] = new SqlParameter("@SubciD", SqlDbType.Int);
            Param[0].Value = SubcID;


            Param[1] = new SqlParameter("@Subc", SqlDbType.VarChar, 50);
            Param[1].Value = SubcLabel;

            Param[2] = new SqlParameter("@NewStatus", SqlDbType.VarChar, 50);
            Param[2].Value = NewStatus;

            Param[3] = new SqlParameter("@StartDate", SqlDbType.Date);
            Param[3].Value = StartDate;

            Param[4] = new SqlParameter("@EndDate", SqlDbType.Date);
            Param[4].Value = EndDate;

            Param[5] = new SqlParameter("@ID", SqlDbType.Int);
            Param[5].Value = PersonID;

            control.Execution("UPDATE_STATUS_AFTER_ACTIVE", Param);
        }

        public void SaveDebt(int PaperID , int PersonID , string PersonName , string PersonUser , string Qty ,DateTime LastDate , string MonyType)
        {
            //@PaperID,@PersonID,@PersonName,@PersonUser,@QTY,@Lastdate,@MonyType
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[7];

            Param[0] = new SqlParameter("@PaperID", SqlDbType.Int);
            Param[0].Value = PaperID;

            Param[1] = new SqlParameter("@PersonID", SqlDbType.Int);
            Param[1].Value = PersonID;

            Param[2] = new SqlParameter("@PersonName", SqlDbType.VarChar, 50);
            Param[2].Value = PersonName;

            Param[3] = new SqlParameter("@PersonUser", SqlDbType.VarChar,50);
            Param[3].Value = PersonUser;

            Param[4] = new SqlParameter("@QTY", SqlDbType.VarChar,50);
            Param[4].Value = Qty;

            Param[5] = new SqlParameter("@Lastdate", SqlDbType.Date);
            Param[5].Value = LastDate;

            Param[6] = new SqlParameter("@MonyType", SqlDbType.VarChar,50);
            Param[6].Value = MonyType;

            control.Execution("Save_Debt_With_Active", Param);
        }

        public int GetMaxPaperID()
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            DataTable T = new DataTable();
            T = control.Getdata("GET_MAXID_FROM_ACTIVE_PAPER", null);
            return Convert.ToInt32(T.Rows[0][0].ToString());
        }

        public int CheckState(int Person)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@Person", SqlDbType.Int);
            Param[0].Value = Person;

            Param[1] = new SqlParameter("@NowDate", SqlDbType.Date);
            Param[1].Value = DateTime.Now.Date;

            DataTable T = new DataTable();
            T = control.Getdata("CHECK_StaTUS", Param);
            if (T.Rows.Count != 0)
            {
                DateTime StatusDate = Convert.ToDateTime(T.Rows[0][0]);
                DateTime NowDate = DateTime.Now.Date;
                TimeSpan span = StatusDate - NowDate;
                return Convert.ToInt32(span.TotalDays);
            }
            else
            {
                return 0;
            }
        }

        public void DeletOldDebt(int PersonID)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID", SqlDbType.Int);
            Param[0].Value = PersonID;
            control.Execution("DeleteoldDebtAfterActiveee", Param);
        }
    }
}
