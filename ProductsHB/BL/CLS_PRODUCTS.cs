using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Products_Managment.BL
{
    class CLS_PRODUCTS
    {
        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CATEGORIES", null);
            DAL.Close();
            return Dt;


        }

        public void ADD_PRODUCT(int ID_cat, string label_product, string ID_product,
                                int Qte, string Price, byte[] img)
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = ID_cat;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 25);
            param[1].Value = ID_product;

            param[2] = new SqlParameter("@LABEL", SqlDbType.VarChar, 25);
            param[2].Value = label_product;

            param[3] = new SqlParameter("@QTE", SqlDbType.Int);
            param[3].Value = Qte;

            param[4] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            param[4].Value = Price;

            param[5] = new SqlParameter("@IMG", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("ADD_PRODUCT", param);
            DAL.Close();


        }


        public void UPDATE_PRODUCTS(int ID_cat, string label_product, string ID_product,
                              int Qte, string Price, byte[] img)
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = ID_cat;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 25);
            param[1].Value = ID_product;

            param[2] = new SqlParameter("@LABEL", SqlDbType.VarChar, 25);
            param[2].Value = label_product;

            param[3] = new SqlParameter("@QTE", SqlDbType.Int);
            param[3].Value = Qte;

            param[4] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            param[4].Value = Price;

            param[5] = new SqlParameter("@IMG", SqlDbType.Image);
            param[5].Value = img;

            DAL.ExecuteCommand("UPDATE_PRODUCTS", param);
            DAL.Close();


        }
        public DataTable VerifyProductID1(string ID)
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 25);
            Param[0].Value = ID;
            Dt = DAL.SelectData("VerifyProductID1", Param);
            DAL.Close();
            return Dt;


        }
        public DataTable GET_ALL_PRODUCTS()
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_PRODUCTS", null);
            DAL.Close();
            return Dt;

        }


        public DataTable SearchProduct(string ID)
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 25);
            Param[0].Value = ID;
            Dt = DAL.SelectData("SearchProduct", Param);
            DAL.Close();
            return Dt;


        }



        public DataTable GET_PRODUCT_IMAGE(string ID)
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 25);
            Param[0].Value = ID;
            Dt = DAL.SelectData("GET_PRODUCT_IMAGE", Param);
            DAL.Close();
            return Dt;


        }

        public void DeleteProduct(string ID) 
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,25);
            param[0].Value = ID;

            DAL.ExecuteCommand("DeleteProduct", param);
            DAL.Close();
        }
   
    }
}
