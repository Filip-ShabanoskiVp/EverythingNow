using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Reprezentacii
{
    public string Drzhava { get; set; } = null!;

    public string? ImeReprezentacii { get; set; }

    public string? Username { get; set; }

    public virtual ICollection<Igrach> Igraches { get; } = new List<Igrach>();

    public virtual ICollection<Pogodoci> Pogodocis { get; } = new List<Pogodoci>();

    public virtual ICollection<TituliReprezentacii> TituliReprezentaciis { get; } = new List<TituliReprezentacii>();

    public virtual Admin? UsernameNavigation { get; set; }

    public virtual ICollection<Natprevar> IdNatprevars { get; } = new List<Natprevar>();

    public virtual ICollection<Igra> Igras { get; } = new List<Igra>();

    public virtual ICollection<Natprevar> Natprevars { get; } = new List<Natprevar>();


}
