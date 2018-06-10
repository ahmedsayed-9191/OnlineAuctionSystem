using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace OnlineAuctionSystem.BussinessLogicLayer
{
    class Validation
    {
        //Functions

        //function to check if username exist or not in all tables
        public Boolean IsUserName_Exist(string username)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param[0].Value = username;

            dataBaseHelperL.Open();


            DataTable Dt1 = new DataTable();
            Dt1 = dataBaseHelperL.SelectData("SP_IsUserName_ExistInAdmin", param);

            DataTable Dt2 = new DataTable();
            Dt2 = dataBaseHelperL.SelectData("SP_IsUserName_ExistInBidder", param);

            DataTable Dt3 = new DataTable();
            Dt3 = dataBaseHelperL.SelectData("SP_IsUserName_ExistInSeller", param);

            if (Dt1.Rows.Count > 0 || Dt2.Rows.Count > 0 || Dt3.Rows.Count > 0)
            {
                dataBaseHelperL.Close();
                return true;
            }
            else
            {
                dataBaseHelperL.Close();
                return false;
            }
        }

        //function to check if username exist or not in Admin
        public Boolean IsUserName_ExistInAdmin(string username)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param[0].Value = username;

            dataBaseHelperL.Open();

            DataTable Dt1 = new DataTable();
            Dt1 = dataBaseHelperL.SelectData("SP_IsUserName_ExistInAdmin", param);

            if (Dt1.Rows.Count > 0)
            {
                dataBaseHelperL.Close();
                return true;
            }
            else
            {
                dataBaseHelperL.Close();
                return false;
            }
        }

        //function to check if username exist or not in Bidder
        public Boolean IsUserName_ExistInBidder(string username)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param[0].Value = username;

            dataBaseHelperL.Open();

            DataTable Dt2 = new DataTable();
            Dt2 = dataBaseHelperL.SelectData("SP_IsUserName_ExistInBidder", param);

            if ( Dt2.Rows.Count > 0)
            {
                dataBaseHelperL.Close();
                return true;
            }
            else
            {
                dataBaseHelperL.Close();
                return false;
            }
        }

        //function to check if username exist or not in Seller
        public Boolean IsUserName_ExistInSeller(string username)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param[0].Value = username;

            dataBaseHelperL.Open();
            DataTable Dt3 = new DataTable();

            Dt3 = dataBaseHelperL.SelectData("SP_IsUserName_ExistInSeller", param);

            if (Dt3.Rows.Count > 0)
            {
                dataBaseHelperL.Close();
                return true;
            }
            else
            {
                dataBaseHelperL.Close();
                return false;
            }
        }

        //function to check if Email exist or not
        public Boolean IsEmail_Exist(string email)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Email", SqlDbType.VarChar, 70);
            param[0].Value = email;

            dataBaseHelperL.Open();


            DataTable Dt1 = new DataTable();
            Dt1 = dataBaseHelperL.SelectData("SP_IsEmail_ExistInAdmin", param);

            DataTable Dt2 = new DataTable();
            Dt2 = dataBaseHelperL.SelectData("SP_IsEmail_ExistInBidder", param);

            DataTable Dt3 = new DataTable();
            Dt3 = dataBaseHelperL.SelectData("SP_IsEmail_ExistInSeller", param);

            if (Dt1.Rows.Count > 0 || Dt2.Rows.Count > 0 || Dt3.Rows.Count > 0)
            {
                dataBaseHelperL.Close();
                return true;
            }
            else
            {
                dataBaseHelperL.Close();
                return false;
            }
        }

        // Function to Check Email Correctness
        public Boolean IsValidEmail(string email)
        {
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(email, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Function to Check String
        public Boolean IsString(string str)
        {
            Regex regex = new Regex(@"^[a-zA-Z]+$");

            if (regex.IsMatch(str))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Function to Check  Number
        public Boolean IsIntNumber(string strNumber)
        {
            Regex regex = new Regex(@"^[0-9]+$");

            if (regex.IsMatch(strNumber))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Function to Check float Number
        public Boolean IsPrice(string strNumber)
        {
            Regex regex = new Regex(@"^(?![0.]+$)\d+(\.\d{1,2})?$");

            if (regex.IsMatch(strNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //function to check if Mobile exist or not
        public Boolean IsMobile_Exist(string mobile)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Mobile", SqlDbType.VarChar, 50);
            param[0].Value = mobile;

            dataBaseHelperL.Open();

            DataTable Dt1 = new DataTable();
            Dt1 = dataBaseHelperL.SelectData("SP_IsMobile_ExistInAdmin", param);

            DataTable Dt2 = new DataTable();
            Dt2 = dataBaseHelperL.SelectData("SP_IsMobile_ExistInBidder", param);

            DataTable Dt3 = new DataTable();
            Dt3 = dataBaseHelperL.SelectData("SP_IsMobile_ExistInSeller", param);

            if (Dt1.Rows.Count > 0 || Dt2.Rows.Count > 0 || Dt3.Rows.Count > 0)
            {
                dataBaseHelperL.Close();
                return true;
            }
            else
            {
                dataBaseHelperL.Close();
                return false;
            }
        }

        //Function to Validate User Name
        public Boolean IsUserName(string username)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9_]+$");

            if (regex.IsMatch(username))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        
        //Function to Validate User Name
        public Boolean IsAddres(string address)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9 ]+$");

            if (regex.IsMatch(address))
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        //Function To Check Session Name Existence
        public Boolean IsSessionNameExist(string name)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Name", SqlDbType.VarChar, 50);
            param[0].Value = name;

            dataBaseHelperL.Open();

            DataTable Dt1 = new DataTable();
            Dt1 = dataBaseHelperL.SelectData("SP_IS_SessionNameExist", param);

            if (Dt1.Rows.Count > 0)
            {
                dataBaseHelperL.Close();
                return true;
            }
            else
            {
                dataBaseHelperL.Close();
                return false;
            }
        }



    }
}
