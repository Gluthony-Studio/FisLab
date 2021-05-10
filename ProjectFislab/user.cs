using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace ProjectFislab
{
    public class userAccount
    {
        private string _username;
        private string _password;
        private string _email;

        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        public userAccount() { }
        public userAccount(string Username, string Password)
        {
            username = Username;
            password = Password;
        }
        public userAccount(string Username, string Password, string Email) 
        {
            username = Username;
            password = Password;
            email = Email;
        }
        public void login()
        {
            connect data = new connect();
        }
        public void signup()
        {

        }
    }
}