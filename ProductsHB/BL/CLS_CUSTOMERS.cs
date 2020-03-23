using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ProductsHB.BL
{
    class CLS_CUSTOMERS
    {
        public DataTable GET_ALL_CUSTEMORS()
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CUSTEMORS", null);
            DAL.Close();
            return Dt;


        }
        public void ADD_CUSTOMER( string FIRST_NAME, string LAST_NAME,
                                string TEL)
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@FIRST_NAME", SqlDbType.VarChar,25);
            param[0].Value = FIRST_NAME;

            param[1] = new SqlParameter("@LAST_NAME", SqlDbType.VarChar, 25);
            param[1].Value = LAST_NAME;

            param[2] = new SqlParameter("@TEL", SqlDbType.VarChar, 15);
            param[2].Value = TEL;

            DAL.ExecuteCommand("ADD_CUSTOMER", param);
            DAL.Close();


        }
        public void EDIT_CUSTOMER(string FIRST_NAME, string LAST_NAME,
                                string TEL,int ID)
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@FIRST_NAME", SqlDbType.VarChar, 25);
            param[0].Value = FIRST_NAME;

            param[1] = new SqlParameter("@LAST_NAME", SqlDbType.VarChar, 25);
            param[1].Value = LAST_NAME;

            param[2] = new SqlParameter("@TEL", SqlDbType.VarChar, 15);
            param[2].Value = TEL;

            param[3] = new SqlParameter("@ID", SqlDbType.Int);
            param[3].Value = ID;

            DAL.ExecuteCommand("EDIT_CUSTOME", param);
            DAL.Close();

        }
        public void DEL_CUSTOMER(int ID)
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("DEL_CUSTOMER", param);
            DAL.Close();
        }
        public DataTable SEARCH_CUSTOMER(string C)
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@c", SqlDbType.VarChar, 50);
            Param[0].Value = C;
            Dt = DAL.SelectData("SEARCH_CUSTOMER", Param);
            DAL.Close();
            return Dt;


        }

    }
}
