using System;
using System.Collections.Generic;

namespace Labb_4___Indivituellt_Databasprojekt.Models;

public partial class TblStudent
{
    public int StudentId { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public int? Pnumber { get; set; }

    public string? Class { get; set; }

    public virtual ICollection<TblGrade> TblGrades { get; set; } = new List<TblGrade>();
}
