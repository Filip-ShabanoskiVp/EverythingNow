using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Lugje
{
    public long LId { get; set; }

    public string? Embg { get; set; }

    public string? Ime { get; set; }

    public string? Prezime { get; set; }

    public DateOnly? DatumRagj { get; set; }

    public virtual Doktori? Doktori { get; set; }

    public virtual Pacienti? Pacienti { get; set; }

    public virtual Supervizori? Supervizori { get; set; }
}
