using System;
using System.Collections.Generic;

namespace SKUD.Model;

public partial class AdmissionTeacher
{
    public int Id { get; set; }

    public int TeachersId { get; set; }

    public int CabinetNumber { get; set; }

    public DateTime DateTime { get; set; }

    public int StateId { get; set; }

    public virtual State State { get; set; } = null!;

    public virtual Teacher Teachers { get; set; } = null!;
}
