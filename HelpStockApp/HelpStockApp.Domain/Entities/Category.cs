﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpStockApp.Domain.Entities
{
    public class Category
    {
        public string Name { get; set; }

        public Category(string name)
        { this.Name = name; }
    }
}
