﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.MobileControls;

namespace Chukou1Demo.Aspnet
{
    public class UserKeyAndToken
    {
        // PAN
        //public static readonly string userKey = "23ti3purnk";//填写你的TOKEN
        //public static readonly string token = "85BE7A9577A81E0C7D8FC8696D5D099D";

        // Guest
        public static readonly string userKey = "wr5qjqh4gj";//填写你的TOKEN
        public static readonly string token = "887E99B5F89BB18BEA12B204B620D236";
        
        public string getUserKey() { return userKey;}
        public string getToken() { return token; }


    }
}