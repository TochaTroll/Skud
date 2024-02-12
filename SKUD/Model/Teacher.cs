using System;
using System.Collections.Generic;

namespace SKUD.Model;

public partial class Teacher
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public int CabinetNumber { get; set; }

    public virtual ICollection<AdmissionTeacher> AdmissionTeachers { get; set; } = new List<AdmissionTeacher>();

    public virtual ICollection<AllDataTeacher> AllDataTeachers { get; set; } = new List<AllDataTeacher>();
}
