using System;
using System.Collections.Generic;

namespace CRUD.Models;

public partial class Department
{
    public int Did { get; set; }

    public string? Dname { get; set; }

    public string? Hod { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
