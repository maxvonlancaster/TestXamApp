using System;
using System.Collections.Generic;
using System.Text;

namespace TestXamApp.DAL.Entities
{
    public class Message
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
        public User Sander { get; set; }
        public User Recipient { get; set; }
        public int MessageNumber { get; set; }
    }
}
