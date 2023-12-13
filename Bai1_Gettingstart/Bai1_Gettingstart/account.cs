using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Gettingstart
{
    public class account
    {
        public string name { get;set; }
        public  string address { get;set; }
        public string username { get;set; }
        public string password { get;set; }
        public string phone { get;set; }
        public bool gender { get;set; }
        public DateTime DOB { get;set; }
        public string ImgPath { get;set; }

        public account() { }

        public account(string name, string address, string username, string password, string phone, bool gender, DateTime dOB, string imgPath)
        {
            this.name = name;
            this.address = address;
            this.username = username;
            this.password = password;
            this.phone = phone;
            this.gender = gender;
            DOB = dOB;
            ImgPath = imgPath;
        }

        public string CreateAccount()
        {
            return $"{name}|{address}|{username}|{password}|{phone}|{gender}|{DOB}|{ImgPath}\n";
        }
    }
}
