using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AntiMessages.Models
{
    public class User
    {
        public int UserId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }



        public virtual List<Message> Messages { get; set; }
    }
}