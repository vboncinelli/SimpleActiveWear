using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveWear.Core.Entities
{
    public class Category: BaseEntity
    {
        public Category(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; init; }

        public string Description { get; init; }
    }
}
