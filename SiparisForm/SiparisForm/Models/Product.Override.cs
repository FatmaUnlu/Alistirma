using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisForm.Models
{
    public partial class Product
    {
        public override string ToString()
        {
            return $"{ProductName} - {UnitPrice}";
        }
    }
}
