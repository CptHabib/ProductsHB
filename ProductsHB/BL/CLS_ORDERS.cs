using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ProductsHB.BL
{
    class CLS_ORDERS
    {

        public DataTable GET_LAST_ORDER_ID()
        {
            DAL.DataAccesLayer DAL = new DAL.DataAccesLayer();
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_LAST_ORDER_ID", null);
            DAL.Close();
            return Dt;


        }

    }
}
