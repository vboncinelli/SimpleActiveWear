﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveWear.Core.Entities
{
    public class Brand: BaseEntity
    {
        public string Name { get; set; }

        public Brand(string name)
        {
            this.Name = name;
        }
    }
}
