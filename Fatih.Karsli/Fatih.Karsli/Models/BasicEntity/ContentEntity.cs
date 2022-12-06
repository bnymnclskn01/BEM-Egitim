using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fatih.Karsli.Models.BasicEntity
{
    public class ContentEntity : BasicEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
