using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassVsStruct.Models
{
    internal class Man:Human
    {
        public string Standard { get; set; }

        public Man(string name, int age, string standard) :base(name,age)
        {
            Standard = standard;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Standard}");
        }
    }
}
