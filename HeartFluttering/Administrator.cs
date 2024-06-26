﻿using System;
using System.Collections.Generic;

namespace HeartFluttering;

public partial class Administrator
{
    public string IdAdmin { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Id { get; set; } = null!;

    public int? Blocker { get; set; }

    public virtual Account IdNavigation { get; set; } = null!;
}
