using System;
using System.Collections.Generic;

namespace SKUD.Model;

public partial class AllDataTeacher
{
    public int Id { get; set; }

    public int TeachersId { get; set; }

    public int CabinetNumber { get; set; }

    public DateTime Date { get; set; }

    public TimeSpan Time { get; set; }

    public int StateId { get; set; }

    public virtual State State { get; set; } = null!;

    public virtual Teacher Teachers { get; set; } = null!;
}
