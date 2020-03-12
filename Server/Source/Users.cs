﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Source
{
    public class Users
    {
        public string name { get; set; }
        public int idNumber { get; set; }
        public string eMail { get; set; }
        public string password { get; set; }
        public int phone { get; set; }
        public string address { get; set; }
        public string province { get; set; }
        public string city { get; set; }

        public Users()
        {
        }

        public Users(string clientName, int clientIDNumber, string clientEMail, string clientPassword, int clientPhone, string clientAddress, string clientProvince, string clientCity)
        {
            name = clientName;
            idNumber = clientIDNumber;
            eMail = clientEMail;
            password = clientPassword;
            phone = clientPhone;
            address = clientAddress;
            province = clientProvince;
            city = clientCity;
        }
    }
}
