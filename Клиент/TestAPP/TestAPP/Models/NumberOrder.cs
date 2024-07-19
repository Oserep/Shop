using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPP.Models
{
    public partial class NumberOrder
    {
        public int? IdNumberOrder { get; set; }

        public int Amount { get; set; }

        public int IdProduct { get; set; }

        public int IdOrder { get; set; }


    }
}
