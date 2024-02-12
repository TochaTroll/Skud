using System;
using System.Collections.Generic;

namespace SKUD.Model;

public partial class DocumentName
{
    public int Id { get; set; }

    public string DocumentName1 { get; set; } = null!;

    public virtual ICollection<Admission> Admissions { get; set; } = new List<Admission>();

    public virtual ICollection<AllDataAdmission> AllDataAdmissions { get; set; } = new List<AllDataAdmission>();
}
