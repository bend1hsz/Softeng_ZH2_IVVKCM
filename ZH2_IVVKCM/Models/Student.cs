using System;
using System.Collections.Generic;

namespace ZH2_IVVKCM.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? Name { get; set; }

    public string? Neptun { get; set; }

    public virtual ICollection<Order> Order { get; set; } = new List<Order>();
}
