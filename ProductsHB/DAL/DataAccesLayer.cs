using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProductsHB.DAL
{
    class DataAccesLayer
    {
        SqlConnection sqlconnection;
        //this constructor initialize the connection object
        public DataAccesLayer() 
        {
            //sqlconnection = new SqlConnection(@"Server=BURAK-PC\SQLEXPRESS;Database=Product.DB; Integrated Security=true");
            sqlconnection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=Product_DB; Integrated Security=true"); 
        }

        //method to open the connection
        public void Open() {

            if (sqlconnection.State != ConnectionState.Open)
            {


                sqlconnection.Open();
                
            }
        }
        //Method To Close the connection
            public void Close(){
            if(sqlconnection.State==ConnectionState.Open){
            sqlconnection.Close();
            }
            
            }

        //Method to read data from database
            public DataTable SelectData(string stored_procedure, SqlParameter[] param) {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = stored_procedure;
                sqlcmd.Connection = sqlconnection;
                if (param != null) {
                    for (int i = 0; i < param.Length; i++) {
                        sqlcmd.Parameters.Add(param[i]);
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

        //Method to insert , update , and Delete Data From Database

            public void ExecuteCommand(string stored_procedure, SqlParameter[] param) 
            {

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = stored_procedure;
                sqlcmd.Connection = sqlconnection;

                if (param != null)
                {
                    sqlcmd.Parameters.AddRange(param);
                
                }
                sqlcmd.ExecuteNonQuery();
            
            }
        }
    }

