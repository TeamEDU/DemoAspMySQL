using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain
{
    public class Human
    {
        public int id { get; set; }
        public string Name { get; set; }

        public Human()
        {
            Name = "";
        }
    }
}
