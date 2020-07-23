using System;
using System.Collections.Generic;
using System.Text;

namespace TestXamApp.DAL.Entities
{
    public class Match
    {
        public long Id { get; set; }
        public User UserOne { get; set; }
        public User UserTwo { get; set; }
        public bool Archived { get; set; }

    }
}
