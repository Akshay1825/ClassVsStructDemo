using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsStruct.Models
{
    internal class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human()
        {
            Name = "Kartik";
            Age = 10;
        }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
