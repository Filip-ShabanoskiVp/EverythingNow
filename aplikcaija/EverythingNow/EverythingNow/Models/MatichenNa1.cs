using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class MatichenNa1
{
    public long PLId { get; set; }

    public DateOnly MDatumPoch { get; set; }

    public DateOnly? MDatumKraj { get; set; }

    public long DLId { get; set; }

    public virtual Doktori1 DL { get; set; } = null!;

    public virtual Pacienti1 PL { get; set; } = null!;
}
