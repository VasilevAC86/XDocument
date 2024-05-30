using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X_Document;

namespace X_Document
{
    public class Product: IProcuct
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
    }
}
