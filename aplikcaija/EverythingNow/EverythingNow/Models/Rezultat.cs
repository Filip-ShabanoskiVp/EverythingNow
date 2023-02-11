using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EverythingNow.Models;

public partial class Rezultat
{
    public long IdRezultat { get; set; }

    [DisplayName("Конечен резултат")]
    public string KonecenRezultat { get; set; } = null!;

    public int Domakjin { get; set; }

    public int Gostin { get; set; }

    public string? Username { get; set; }

    public virtual ICollection<Natprevar> Natprevars { get; } = new List<Natprevar>();

    public virtual Admin? UsernameNavigation { get; set; }
}
