using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Phase3Section2._14.Models
{
    public class Student
    {
        public string Name { get; set; }

       
        public string Address { get; set; }

       
        public string Class { get; set; }

        public string ContactEmail { get; set; }

       
        public int Age { get; set; }
    }
}