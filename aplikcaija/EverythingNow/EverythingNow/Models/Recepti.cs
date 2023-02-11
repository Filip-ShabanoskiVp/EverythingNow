using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Recepti
{
    public long PLId { get; set; }

    public long DLId { get; set; }

    public DateOnly DatumIzd { get; set; }

    public long FkId { get; set; }

    public long ProdId { get; set; }

    public string? Doza { get; set; }

    public virtual Doktori1 DL { get; set; } = null!;

    public virtual Lekovi1 Lekovi1 { get; set; } = null!;

    public virtual Pacienti1 PL { get; set; } = null!;
}
