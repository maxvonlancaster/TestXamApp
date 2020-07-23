using System;
using System.Collections.Generic;
using System.Text;

namespace TestXamApp.DAL.Entities
{
    public class Connection
    {
        public long Id { get; set; }
        public User UserOne { get; set; }
        public User UserTwo { get; set; }
        public string UserOneResponse { get; set; }
        public string UserTwoResponse { get; set; }

    }
}
