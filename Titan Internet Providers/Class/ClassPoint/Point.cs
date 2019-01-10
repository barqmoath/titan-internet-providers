using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Titan_Internet_Providers.Class.ClassPoint
{
    class Point
    {
        public DataTable GetPointsList()
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            return control.Getdata("GET_POINTS_LIST", null);
        }

        public DataTable GetDeviceList()
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            return control.Getdata("GET_DEVICELIST_FROM_SECTORS", null);
        }

        public DataTable ShowDeviceWithPoint(int PointID)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@PID", SqlDbType.Int);
            Param[0].Value = PointID;
            return control.Getdata("SHOW_DEVICE_WITH_POINT", Param);
        }

        public void SaveThePoint(string LABEL , string POINT , string OWNER , string PROVIDER , string CITY , string STAR ,string MAIN)
        {
            //@LABEL,@POINT,@OWNER,@PROVIDER,@CITY,@STAR,@MAIN

            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[7];

            Param[0] = new SqlParameter("@LABEL", SqlDbType.VarChar,50);
            Param[0].Value = LABEL;

            Param[1] = new SqlParameter("@POINT", SqlDbType.VarChar, 50);
            Param[1].Value = POINT;

            Param[2] = new SqlParameter("@OWNER", SqlDbType.VarChar, 50);
            Param[2].Value = OWNER;

            Param[3] = new SqlParameter("@PROVIDER", SqlDbType.VarChar, 50);
            Param[3].Value = PROVIDER;

            Param[4] = new SqlParameter("@CITY", SqlDbType.VarChar);
            Param[4].Value = CITY;

            Param[5] = new SqlParameter("@STAR", SqlDbType.VarChar, 50);
            Param[5].Value = STAR;

            Param[6] = new SqlParameter("@MAIN", SqlDbType.VarChar, 50);
            Param[6].Value = MAIN;

            control.Execution("SAVE_POINTS", Param);
        }

        public void DeletePoint(int ID)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];

            Param[0] = new SqlParameter("@ID", SqlDbType.Int);
            Param[0].Value = ID;

            control.Execution("DELETE_THE_POINTS", Param);
        }

        public void EditePoint(string LABEL, string POINT, string OWNER, string PROVIDER, string CITY, string STAR, string MAIN,int ID)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[8];

            Param[0] = new SqlParameter("@LABEL", SqlDbType.VarChar, 50);
            Param[0].Value = LABEL;

            Param[1] = new SqlParameter("@POINT", SqlDbType.VarChar, 50);
            Param[1].Value = POINT;

            Param[2] = new SqlParameter("@OWNER", SqlDbType.VarChar, 50);
            Param[2].Value = OWNER;

            Param[3] = new SqlParameter("@PROVIDER", SqlDbType.VarChar, 50);
            Param[3].Value = PROVIDER;

            Param[4] = new SqlParameter("@CITY", SqlDbType.VarChar);
            Param[4].Value = CITY;

            Param[5] = new SqlParameter("@STAR", SqlDbType.VarChar, 50);
            Param[5].Value = STAR;

            Param[6] = new SqlParameter("@MAIN", SqlDbType.VarChar, 50);
            Param[6].Value = MAIN;

            Param[7] = new SqlParameter("@ID", SqlDbType.Int);
            Param[7].Value = ID;

            control.Execution("EDITE_POINTS", Param);
        }

        public void SaveDevice(int PointID,string Label,string Ip , string Mac  ,string Map )
        {
            //@POINT_ID,@LABEL,@IP,@MAC,@DIR

            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[5];

            Param[0] = new SqlParameter("@POINT_ID", SqlDbType.Int);
            Param[0].Value = PointID;

            Param[1] = new SqlParameter("@LABEL", SqlDbType.VarChar, 50);
            Param[1].Value = Label;

            Param[2] = new SqlParameter("@IP", SqlDbType.VarChar, 50);
            Param[2].Value = Ip;

            Param[3] = new SqlParameter("@MAC", SqlDbType.VarChar, 50);
            Param[3].Value = Mac;

            Param[4] = new SqlParameter("@DIR", SqlDbType.VarChar,50);
            Param[4].Value = Map;

            control.Execution("SAVE_NEW_DEVICESS", Param);
        }

        public void DeleteDevice(int ID)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[1];

            Param[0] = new SqlParameter("@ID", SqlDbType.Int);
            Param[0].Value = ID;

            control.Execution("DELETE_DEVICE", Param);
        }

        public void EditeDevice(int PointID, string Label, string Ip, string Mac, string Map,int ID)
        {
            Main.MainClass.DataControl control = new Main.MainClass.DataControl();
            SqlParameter[] Param = new SqlParameter[6];

            Param[0] = new SqlParameter("@POINT_ID", SqlDbType.Int);
            Param[0].Value = PointID;

            Param[1] = new SqlParameter("@LABEL", SqlDbType.VarChar, 50);
            Param[1].Value = Label;

            Param[2] = new SqlParameter("@IP", SqlDbType.VarChar, 50);
            Param[2].Value = Ip;

            Param[3] = new SqlParameter("@MAC", SqlDbType.VarChar, 50);
            Param[3].Value = Mac;

            Param[4] = new SqlParameter("@DIR", SqlDbType.VarChar, 50);
            Param[4].Value = Map;

            Param[5] = new SqlParameter("@ID", SqlDbType.Int);
            Param[5].Value = ID;

            control.Execution("EDITE_DEVICE", Param);
        }
    }
}
