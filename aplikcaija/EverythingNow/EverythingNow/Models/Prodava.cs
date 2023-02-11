using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Prodava
{
    public long FkId { get; set; }

    public long ProdId { get; set; }

    public long AId { get; set; }

    public decimal? Cena { get; set; }

    public virtual Apteki1 AIdNavigation { get; set; } = null!;

    public virtual Lekovi1 Lekovi1 { get; set; } = null!;
}
