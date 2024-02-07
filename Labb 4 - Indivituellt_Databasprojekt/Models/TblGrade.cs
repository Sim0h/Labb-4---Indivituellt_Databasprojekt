using System;
using System.Collections.Generic;

namespace Labb_4___Indivituellt_Databasprojekt.Models;

public partial class TblGrade
{
    public int GradeId { get; set; }

    public int? CourseId { get; set; }

    public int? PersonalId { get; set; }

    public int? StudentId { get; set; }

    public int? Grade { get; set; }

    public DateOnly? GradeDate { get; set; }

    public virtual TblCourse? Course { get; set; }

    public virtual TblPersonal? Personal { get; set; }

    public virtual TblStudent? Student { get; set; }
}
