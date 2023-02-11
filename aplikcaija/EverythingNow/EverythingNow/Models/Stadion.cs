using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EverythingNow.Models;

public partial class Stadion
{
    public long IdStadion { get; set; }

    [DisplayName("Име на стадион")]
    public string? ImeStadion { get; set; }

    [DisplayName("Капацитет")]
    public float? CelosenKapacitet { get; set; }

    [DisplayName("Град")]
    public string? Grad { get; set; }

    [DisplayName("Дали е слободно")]
    public bool? Slobodno { get; set; }

    [DisplayName("Координати")]
    public string? Koordinati { get; set; }

    public virtual ICollection<Natprevar> Natprevars { get; } = new List<Natprevar>();

    public virtual ICollection<Sedistum> Sedista { get; } = new List<Sedistum>();
}
