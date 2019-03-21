using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace ActionFilters.Models
{
    public class Login
    {
        private int LoginID;
        private string username;
        private string password;

        [DisplayName("LoginID")]
        public int LoginID1 { get => LoginID; set => LoginID = value; }
        [DisplayName("Username")]
        public string Username { get => username; set => username = value; }
        [DisplayName("Password")]
        public string Password { get => password; set => password = value; }
       
    }
}