using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class FarmakomiBroevi
{
    public long FkId { get; set; }

    public int FkRedenBr { get; set; }

    public string? TelBroj { get; set; }

    public virtual Farmakomi Fk { get; set; } = null!;
}
