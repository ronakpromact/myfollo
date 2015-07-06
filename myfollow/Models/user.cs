using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myfollow.Models
{
    public class user: address
    {
        public int ID
        {
            get;
            set;
        }
        public EmailService email
        {
            get;
            set;
        }
        public DateTime dateofjoin
        {
            get;
            set;
        }
        public AddPhoneNumberViewModel contactno
        {
            get;
            set;
        }
    
    }
}