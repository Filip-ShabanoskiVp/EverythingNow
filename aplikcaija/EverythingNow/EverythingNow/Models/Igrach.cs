using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Igrach
{
    public string EmbgIgrach { get; set; } = null!;

    public string? ImeIgrach { get; set; }

    public string? Pozicija { get; set; }

    public string? Tim { get; set; }

    public string? Drzhava { get; set; }

    public virtual Reprezentacii? DrzhavaNavigation { get; set; }

    public virtual ICollection<Pogodoci> Pogodocis { get; } = new List<Pogodoci>();
}
