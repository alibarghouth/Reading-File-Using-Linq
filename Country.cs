﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reading_File_Using_LINQ
{
    internal class Country
    {
        public String Name { get; }
        public String Code { get; }
        public String Region { get; }
        public int population { get; }

        public Country(string name, string code, string region, int population)
        {
            this.Name = name;
            this.Code = code;
            this.Region = region;
            this.population = population;
        }
    }
}
