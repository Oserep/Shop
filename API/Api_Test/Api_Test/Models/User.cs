﻿using System;
using System.Collections.Generic;

namespace Api_Test.Models;

public partial class User
{
    public int ? IdUser { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Patronymic { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

  
}
