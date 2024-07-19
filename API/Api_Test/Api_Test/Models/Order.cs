using System;
using System.Collections.Generic;

namespace Api_Test.Models;

public partial class Order
{
    public int ? IdOrder { get; set; } 

    public DateTime DateOrder { get; set; }

    public int CartCost { get; set; }

    public int ? IdProduct { get; set; }

    public int ? IdUser { get; set; }


}
