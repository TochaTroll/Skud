﻿using System;
using System.Collections.Generic;

namespace SKUD.Model;

public partial class Admission
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public int DocumentsId { get; set; }

    public string DocumentNumber { get; set; } = null!;

    public DateTime DateTime { get; set; }

    public int StateId { get; set; }

    public virtual DocumentName Documents { get; set; } = null!;

    public virtual State State { get; set; } = null!;
}
