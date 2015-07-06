using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myfollow.Models
{
    public class productowner:user
    {
        public string companyname
        {
            get;
            set;
        }
        public string description
        {
            get;
            set;
        }
        public DateTime foundeddate
        {
            get;
            set;
        }
        public string website
        {
            get;
            set;
        }
        public string facebookurl
        {
            get;
            set;
        }
        
        public string twitterhandler
        {
            get;
            set;
        }
    }
}