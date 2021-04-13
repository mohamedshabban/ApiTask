﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Hoppy
    {
        public int HoppyId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Person>Persons { get; set; }

       public Hoppy()
        {
            Persons = new HashSet<Person>();
        }
    }
   
}