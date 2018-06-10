using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace OnlineAuctionSystem.BussinessLogicLayer
{
    public abstract class User
    {
        //Properties
        private int _ID;
        private string _UserName;
        private string _Password;
        private string _Email;
        private string _Address;
        private string _Mobile;
        private string _UserType;

        // Setter and Getter
        public void setID(int id)
        {
            _ID = id;
        }

        public int getID()
        {
            return _ID;
        }

        public void setUserName(string username)
        {
            _UserName = username;
        }

        public string getUserName()
        {
            return _UserName;
        }

        public void setPassword(string password)
        {
            _Password = password;
        }

        public string getPassword()
        {
            return _Password;
        }

        public void setEmail(string email)
        {
            _Email = email;
        }

        public string getEmail()
        {
            return _Email;
        }

        public void setAddress(string address)
        {
            _Address = address;
        }

        public string getAddress()
        {
            return _Address;
        }

        public void setMobile(string mobile)
        {
            _Mobile = mobile;
        }

        public string getMobile()
        {
            return _Mobile;
        }

        public void setUserType(string userType)
        {
            _UserType = userType;
        }

        public string getUserType()
        {
            return _UserType;
        }


        //Consutructor
        public User()
        {
        }

        //Function to Login 
        public DataTable LOGIN(string UserName, string Password,string UserType)
        {
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param[0].Value = UserName;

            param[1] = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            param[1].Value = Password;

            param[2] = new SqlParameter("@UserType", SqlDbType.VarChar, 50);
            param[2].Value = UserType;
            
            dataBaseHelperL.Open();
            DataTable Dt = new DataTable();
            Dt = dataBaseHelperL.SelectData("SP_Login", param);
            dataBaseHelperL.Close();
            return Dt;

        }

        //Function Logout
        public void LogOut()
        {           
        }

        //Function Edit profile
        public void EditProfile(User user)
        { 
           
            DataAccessLayer.DataBaseHelper dataBaseHelperL = DataAccessLayer.DataBaseHelper.GetDataBaseHelperInstance;
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param[0].Value = user.getUserName(); ;

            param[1] = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            param[1].Value = user.getPassword();

            param[2] = new SqlParameter("@Email", SqlDbType.VarChar, 70);
            param[2].Value = user.getEmail();

            param[3] = new SqlParameter("@Address", SqlDbType.VarChar, 100);
            param[3].Value = user.getAddress();

            param[4] = new SqlParameter("@Mobile", SqlDbType.VarChar, 50);
            param[4].Value = user.getMobile();

            param[5] = new SqlParameter("@UserType", SqlDbType.VarChar, 50);
            param[5].Value = user.getUserType(); 

            dataBaseHelperL.Open();
            dataBaseHelperL.SelectData("SP_UPDATE_PROFILE", param);
            dataBaseHelperL.Close();
            
        }

    }
}
