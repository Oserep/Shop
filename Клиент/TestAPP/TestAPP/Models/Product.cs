using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPP.Models
{
    public partial class Product
    {
        public int? IdProduct { get; set; }

        public string NameProduct { get; set; } 

        public int Price { get; set; }

        public int? IdStaff { get; set; }


    }
}
