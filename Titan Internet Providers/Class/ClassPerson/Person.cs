using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Titan_Internet_Providers.Class.ClassPerson
{
    class Person 
    {
        public DataTable GetThePointList()
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            return control.Getdata("GET_THE_POINT_LISTS", null);
        }

        public DataTable GetTheDeviceList(int PointID)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];

            Param[0] = new SqlParameter("@POINT_ID", SqlDbType.Int);
            Param[0].Value = PointID;

            return control.Getdata("FILL_DEVICE_COMBO",Param);
        }

        public DataTable GetPersonList()
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            return control.Getdata("GET_THE_PERSON_LISTS", null);
        }

        public DataTable MultiSeatch(string Text)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@txt", SqlDbType.VarChar, 50);
            Param[0].Value = Text;
            return control.Getdata("MULTI_SEARCH_IN_PERSON", Param);
        }

        public DataTable SearchWithDate(DateTime Date)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@Date", SqlDbType.Date);
            Param[0].Value = Date;
            return control.Getdata("SEARCH_WITH_DATE_IN_PERSON", Param);
        }

        public void SavePersonInformation(string Fullname , string Username , string Password , string Point , string Device , string Phone , string Home , string Ip , string Mac , string StarPerson , DateTime InDate , string Nots , string Location)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[13];

            Param[0] = new SqlParameter("@FULLNAME", SqlDbType.VarChar, 50);
            Param[0].Value = Fullname;

            Param[1] = new SqlParameter("@USERNAME", SqlDbType.VarChar, 50);
            Param[1].Value = Username;

            Param[2] = new SqlParameter("@PASSWORD", SqlDbType.VarChar, 50);
            Param[2].Value = Password;

            Param[3] = new SqlParameter("@POINT", SqlDbType.VarChar, 50);
            Param[3].Value = Point;

            Param[4] = new SqlParameter("@SECTOR", SqlDbType.VarChar, 50);
            Param[4].Value = Device;

            Param[5] = new SqlParameter("@PHONE", SqlDbType.VarChar, 50);
            Param[5].Value = Phone;

            Param[6] = new SqlParameter("@HOME", SqlDbType.VarChar, 50);
            Param[6].Value = Home;

            Param[7] = new SqlParameter("@IP", SqlDbType.VarChar, 50);
            Param[7].Value = Ip;

            Param[8] = new SqlParameter("@MAC", SqlDbType.VarChar, 50);
            Param[8].Value = Mac;

            Param[9] = new SqlParameter("@STAR", SqlDbType.VarChar, 50);
            Param[9].Value = StarPerson;

            Param[10] = new SqlParameter("@IN_DATE", SqlDbType.Date);
            Param[10].Value = InDate;

            Param[11] = new SqlParameter("@NOTS", SqlDbType.VarChar,100);
            Param[11].Value = Nots;

            Param[12] = new SqlParameter("@LOCATION", SqlDbType.VarChar, 1000);
            Param[12].Value = Location;

            control.Execution("SAVE_PERSON_INFORMATION", Param);
        }

        public void SavePersonState(int PersonID , string PersonName , string PersonUser )
        {

            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[3];

            Param[0] = new SqlParameter("@PID", SqlDbType.Int);
            Param[0].Value = PersonID;

            Param[1] = new SqlParameter("@PNM", SqlDbType.VarChar,50);
            Param[1].Value = PersonName;

            Param[2] = new SqlParameter("@PUS", SqlDbType.VarChar, 50);
            Param[2].Value = PersonUser;

            control.Execution("SAVE_STATE_FOR_PERSON", Param);
        }

        public int GetMaxPersonID()
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();        
            DataTable T = new DataTable();
            T = control.Getdata("GET_MAX_ID_FROM_TBL_PERSON", null);
                return Convert.ToInt32(T.Rows[0][0].ToString()); 
        }

        public void DeletePerson(int ID)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];

            Param[0] = new SqlParameter("@ID", SqlDbType.Int);
            Param[0].Value =ID;

            control.Execution("DELET_THE_PERSON_FROM_TBL_PERSONS", Param);
        }

        public void DeletePersonState(int ID)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];

            Param[0] = new SqlParameter("@ID", SqlDbType.Int);
            Param[0].Value = ID;

            control.Execution("DELETE_PERSON_STATE", Param);
        }

        public void UpdatePersonInformation(int ID,string Fullname, string Username, string Password, string Point, string Device, string Phone, string Home, string Ip, string Mac, string StarPerson, DateTime InDate, string Nots , string Location)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[14];

            Param[0] = new SqlParameter("@FULLNAME", SqlDbType.VarChar, 50);
            Param[0].Value = Fullname;

            Param[1] = new SqlParameter("@USERNAME", SqlDbType.VarChar, 50);
            Param[1].Value = Username;

            Param[2] = new SqlParameter("@PASSWORD", SqlDbType.VarChar, 50);
            Param[2].Value = Password;

            Param[3] = new SqlParameter("@POINT", SqlDbType.VarChar, 50);
            Param[3].Value = Point;

            Param[4] = new SqlParameter("@SECTOR", SqlDbType.VarChar, 50);
            Param[4].Value = Device;

            Param[5] = new SqlParameter("@PHONE", SqlDbType.VarChar, 50);
            Param[5].Value = Phone;

            Param[6] = new SqlParameter("@HOME", SqlDbType.VarChar, 50);
            Param[6].Value = Home;

            Param[7] = new SqlParameter("@IP", SqlDbType.VarChar, 50);
            Param[7].Value = Ip;

            Param[8] = new SqlParameter("@MAC", SqlDbType.VarChar, 50);
            Param[8].Value = Mac;

            Param[9] = new SqlParameter("@STAR", SqlDbType.VarChar, 50);
            Param[9].Value = StarPerson;

            Param[10] = new SqlParameter("@IN_DATE", SqlDbType.Date);
            Param[10].Value = InDate;

            Param[11] = new SqlParameter("@NOTS", SqlDbType.VarChar, 100);
            Param[11].Value = Nots;

            Param[12] = new SqlParameter("@ID", SqlDbType.Int);
            Param[12].Value = ID;

            Param[13] = new SqlParameter("@LOCATION", SqlDbType.VarChar, 1000);
            Param[13].Value = Location;

            control.Execution("UPDATE_PERSON_INFORMATIONS", Param);
        }

        public string ShowPersonState(int PersonID)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            Param[0].Value = PersonID;
            DataTable T = new DataTable();
            T=control.Getdata("SHOW_MY_STATE_PERSON", Param);
            if (T.Rows[0][0].ToString() == "فعال")
                return "حاله المشترك المحدد هي " + T.Rows[0][0].ToString() + " بدء اشتراكه بتاريخ " + T.Rows[0][1].ToString() + " وسينتهي بتاريخ " + T.Rows[0][2] + "";
            else
                return "لم يتم تفعيل الاشتراك او ان الاشتراك قد انتهت مدته";
        }


    }
}
