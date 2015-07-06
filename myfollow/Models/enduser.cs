using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myfollow.Models
{
    public class enduser:user
    {
        public Boolean gender
        {
            get;
            set;
        }
        public DateTime dateofbirth
        {
            get;
            set;
        }
    }
}