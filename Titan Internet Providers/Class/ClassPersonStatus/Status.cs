using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Titan_Internet_Providers.Class.ClassPersonStatus
{
    class Status
    {
        public DataTable GetStatusList()
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            return control.Getdata("GET_ALL_STATUS", null);
        }
        public DataTable ShowEndStatus()
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];

            Param[0] = new SqlParameter("@NowDate", SqlDbType.Date);
            Param[0].Value = DateTime.Now.Date;

            return control.Getdata("SHOW_END_STATUS", Param);
        }
        public DataTable ShowStartStatus()
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];

            Param[0] = new SqlParameter("@NowDate", SqlDbType.Date);
            Param[0].Value = DateTime.Now.Date;

            return control.Getdata("SHOW_START_STATUS", Param);
        }
        public DataTable MultiSeacrch(string Text)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];

            Param[0] = new SqlParameter("@txt", SqlDbType.VarChar, 50);
            Param[0].Value = Text;

            return control.Getdata("MULTI_SEARCH_FROM_STATUS", Param);
        }
        public DataTable ShowEndTodyStatus()
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];

            Param[0] = new SqlParameter("@NowDate", SqlDbType.Date);
            Param[0].Value = DateTime.Now.Date;

            return control.Getdata("SHOW_STARTED_STATUS", Param);
        }
        public DataTable ShowStartTodyStatus()
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];

            Param[0] = new SqlParameter("@NowDate", SqlDbType.Date);
            Param[0].Value = DateTime.Now.Date;

            return control.Getdata("SHOW_STARTED_TORY_STATUS", Param);
        }
        public void UpdateStaus(int PersonID , string NewStatus)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[3];

            Param[0] = new SqlParameter("@ID", SqlDbType.Int);
            Param[0].Value = PersonID;

            Param[1] = new SqlParameter("@NewState", SqlDbType.VarChar,50);
            Param[1].Value = NewStatus;

            Param[2] = new SqlParameter("@NowDate", SqlDbType.Date);
            Param[2].Value = DateTime.Now.Date;

            control.Execution("UPDATE_STATUS", Param);
        }
    }
}
