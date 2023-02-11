using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Pogodoci
{
    public long IdPogodoci { get; set; }

    public int? Golovi { get; set; }

    public int? Asistencii { get; set; }

    public int? CrveniKartoni { get; set; }

    public int? ZoltiKartoni { get; set; }

    public int? Korneri { get; set; }

    public TimeOnly? Vreme { get; set; }

    public string? EmbgIgrach { get; set; }

    public string? Drzhava { get; set; }

    public long? IdNatprevar { get; set; }

    public virtual Reprezentacii? DrzhavaNavigation { get; set; }

    public virtual Igrach? EmbgIgrachNavigation { get; set; }

    public virtual Natprevar? IdNatprevarNavigation { get; set; }
}
