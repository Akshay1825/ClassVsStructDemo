﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsStruct.Models
{
    struct HumanStruct
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public HumanStruct(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
