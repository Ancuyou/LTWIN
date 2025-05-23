﻿using System;
using System.Collections.Generic;

namespace SQLProgramming.Models;

public partial class Customer
{
    public string CustomerId { get; set; } = null!;

    public string? CustomerName { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public int? DiscountRate { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
