using System;
using System.Collections.Generic;

namespace Api_Test.Models;

public partial class Product
{
    public int ? IdProduct { get; set; }

    public string NameProduct { get; set; } = null!;

    public int Price { get; set; }

    public int ? IdStaff { get; set; }


}
