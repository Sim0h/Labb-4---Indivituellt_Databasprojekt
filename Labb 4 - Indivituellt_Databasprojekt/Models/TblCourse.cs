using System;
using System.Collections.Generic;

namespace Labb_4___Indivituellt_Databasprojekt.Models;

public partial class TblCourse
{
    public int CourseId { get; set; }

    public string? CourseName { get; set; }

    public virtual ICollection<TblGrade> TblGrades { get; set; } = new List<TblGrade>();
}
