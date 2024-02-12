using System;
using System.Collections.Generic;

namespace SKUD.Model;

public partial class State
{
    public int Id { get; set; }

    public string State1 { get; set; } = null!;

    public virtual ICollection<AdmissionTeacher> AdmissionTeachers { get; set; } = new List<AdmissionTeacher>();

    public virtual ICollection<Admission> Admissions { get; set; } = new List<Admission>();

    public virtual ICollection<AllDataTeacher> AllDataTeachers { get; set; } = new List<AllDataTeacher>();
    public virtual ICollection<AllDataAdmission> AllDataAdmission { get; set; } = new List<AllDataAdmission>();
}
