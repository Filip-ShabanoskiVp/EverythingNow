using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class SudiNa
{
    public long IdNatprevar { get; set; }

    public string EmbgSudii { get; set; } = null!;

    public string? Uloga { get; set; }

    public virtual Sudii EmbgSudiiNavigation { get; set; } = null!;

    public virtual Natprevar IdNatprevarNavigation { get; set; } = null!;
}
