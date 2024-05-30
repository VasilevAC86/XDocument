using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_Document
{
    public interface IProcuct
    {
        int Id { get; set; }
        string Name { get; set; }
        double Price { get; set; }
        string Category { get; set; }
    }
}
