using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShopApp.Models
{
    public class UserInfo
    {
        private string firstName;
        private string lastName;
        private string emailAdd;
        private string password;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string EmailAdd
        {
            get
            {
                return emailAdd;
            }

            set
            {
                emailAdd = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public UserInfo()
        {
            firstName = "";
            lastName = "";
            emailAdd = "";
            password = "";


        }

        public UserInfo(string FirstName, string LastName, string EmailAdd, string Password)
        {
            firstName = FirstName;
            lastName = LastName;
            emailAdd = EmailAdd;
            password = Password;
        }
    }
}