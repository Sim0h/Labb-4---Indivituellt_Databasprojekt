using System;
using System.Collections.Generic;

namespace Labb_4___Indivituellt_Databasprojekt.Models;

public partial class TblPersonal
{
    public int PersonalId { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Occupation { get; set; }

    public DateOnly? StartWork { get; set; }

    public int? Salary { get; set; }

    public virtual ICollection<TblGrade> TblGrades { get; set; } = new List<TblGrade>();
}
