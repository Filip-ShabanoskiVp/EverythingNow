using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Admin
{
    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Natprevar> Natprevars { get; } = new List<Natprevar>();

    public virtual ICollection<Reprezentacii> Reprezentaciis { get; } = new List<Reprezentacii>();

    public virtual ICollection<Rezultat> Rezultats { get; } = new List<Rezultat>();

    public virtual ICollection<Tiket> Tikets { get; } = new List<Tiket>();
}
