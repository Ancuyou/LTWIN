using System;
using System.Collections.Generic;

namespace SQLProgramming.Models;

public partial class Order
{
    public string OrderId { get; set; } = null!;

    public DateOnly? Date { get; set; }

    public string? CustomerId { get; set; }

    public decimal? TotalPayment { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
