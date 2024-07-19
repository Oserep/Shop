using System;
using System.Collections.Generic;

namespace Api_Test.Models;

public partial class NumberOrder
{
    public int ? IdNumberOrder { get; set; }

    public int Amount { get; set; }

    public int IdProduct { get; set; }

    public int IdOrder { get; set; }


}
