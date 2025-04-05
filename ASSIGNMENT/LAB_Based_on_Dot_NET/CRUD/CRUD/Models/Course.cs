using System;
using System.Collections.Generic;

namespace CRUD.Models;

public partial class Course
{
    public int Cid { get; set; }

    public string? Cname { get; set; }

    public string? Credits { get; set; }

    public int Did { get; set; }

    public virtual Department DidNavigation { get; set; } = null!;
}
