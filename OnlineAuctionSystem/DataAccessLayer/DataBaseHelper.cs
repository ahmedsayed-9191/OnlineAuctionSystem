using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OnlineAuctionSystem.DataAccessLayer
{
    class DataBaseHelper
    {
        //DataBaseHelper Instance
        private static DataBaseHelper _DataBaseHelper;

        //Connection Object
        private static SqlConnection sqlConnection;

        //Private Constructor (SingleTon)
        private DataBaseHelper(){}

        //Property to Get DataBaseHelper Instance
        public static DataBaseHelper GetDataBaseHelperInstance
        {
            get
            {
                if (_DataBaseHelper == null)
                {
                    _DataBaseHelper = new DataBaseHelper();
                    sqlConnection = new SqlConnection(@"Server=.\SQLEXPRESS; Database=Auction_System; Integrated Security=true");

                }
                return _DataBaseHelper;
            }
        }

        //Method to open the connection
        public void Open()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        //Method to Close the connection
        public void Close()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        //Method to read data from the DataBase
        public DataTable SelectData(string Strored_Procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = Strored_Procedure;
            sqlcmd.Connection = sqlConnection;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter Da = new SqlDataAdapter(sqlcmd);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            sqlcmd.Parameters.Clear();
            return Dt;
            
        }

        //Method To Insert , Update , And Delete Data From the DataBase
        public void ExecuteCommand(string Stored_Procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = Stored_Procedure;
            sqlcmd.Connection = sqlConnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }

            sqlcmd.ExecuteNonQuery();
            sqlcmd.Parameters.Clear();
        }

    }
}
