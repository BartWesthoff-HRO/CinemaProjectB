using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaProjectB.Classes
{
    public abstract class Person
    {
        
        public string Firstname { get; set; } = "not valid";
        public string Lastname { get; set; } = "not valid";
        public List<string> MiddleName { get; set; } = new List<string>();
    }
}
