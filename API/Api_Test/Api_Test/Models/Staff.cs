using System;
using System.Collections.Generic;

namespace Api_Test.Models;

public partial class Staff
{
    public int ? IdStaff { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Patronymic { get; set; } = null!;

    public string JobTitle { get; set; } = null!;

    public string Role { get; set; } = null!;


}
