using System;
using System.Collections.Generic;
using System.Text;

namespace TestXamApp.DAL.Entities
{
    public class User
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Desription { get; set; }
        public UserType UserType { get; set; }
        public UserType Interest { get; set; }

    }
}
