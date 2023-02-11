using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class AptekiLokacii
{
    public long AId { get; set; }

    public int ARedenBr { get; set; }

    public string? Adresa { get; set; }

    public string? TelBroj { get; set; }

    public virtual Apteki AIdNavigation { get; set; } = null!;
}
