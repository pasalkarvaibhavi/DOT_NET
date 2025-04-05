using System;
using System.Collections.Generic;

namespace CRUD.Models;

public partial class Student
{
    public int Sid { get; set; }

    public string? Sname { get; set; }

    public string? Gender { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public int? Age { get; set; }

    public int? Did { get; set; }

    public virtual Department? DidNavigation { get; set; }
}
