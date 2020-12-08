using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginApp;
using System.Drawing;
using System.Security.Policy;
using System.Data.SqlClient;

namespace LoginApp
{
    public class User : Person
    {
        protected string username;
        protected string password;
        protected string type;
        protected string group_id;

        private SqlConnection conn;

        public User(string name, string surname, DateTime birthDate, string username, string password, string type, string group_id) : base(name, surname, birthDate)
        {
            if (username != "")
                this.username = username;
            else throw new Exception("Username is required");

            if (password != "")
                this.password = password;
            else throw new Exception("Password is required");

                this.type = type;
                this.group_id = group_id;
            conn = new SqlConnection(@"Server=DESKTOP-RNNVSRR\SQLEXPRESS;Database=test;User ID=sa;Password=123456");

        }

        public string GetUserName()
        {
            return username;
        }

        public string GetPassword()
        {
            return password;
        }


        public string GetUserType()
        {
            return type;
        }

        public string GetGroupId()
        {
            return group_id;
        }

        public void SetUserType(string type)
        {
            this.type = type;
        }
    }
}
