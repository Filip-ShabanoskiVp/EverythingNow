using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Lugje1
{
    public long LId { get; set; }

    public string? Embg { get; set; }

    public string? Ime { get; set; }

    public string? Prezime { get; set; }

    public DateOnly? DatumRagj { get; set; }

    public virtual Doktori1? Doktori1 { get; set; }

    public virtual Pacienti1? Pacienti1 { get; set; }

    public virtual Supervizori1? Supervizori1 { get; set; }
}
