using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveWear.WebApi.Models
{
    public class Category: BaseApiEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
