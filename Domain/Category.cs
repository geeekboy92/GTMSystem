﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;

public class Category
{
    public Guid CategoryID { get; set; }
    public string Name { get; set; } = string.Empty;
}
