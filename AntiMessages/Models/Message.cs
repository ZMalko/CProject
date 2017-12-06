using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AntiMessages.Models
{
    public class Message
    {


        public int MessageId { get; set; }
        public String MessageDate { get; set; }
        public String Content { get; set; }
        
        
        

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}