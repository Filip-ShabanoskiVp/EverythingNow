using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Dogovori
{
    public long FkId { get; set; }

    public long AId { get; set; }

    public long LIdSupervizor { get; set; }

    public DateOnly DatumSkl { get; set; }

    public DateOnly? DatumIst { get; set; }

    public string? Sodrzhina { get; set; }

    public virtual Apteki1 AIdNavigation { get; set; } = null!;

    public virtual Farmakomi1 Fk { get; set; } = null!;

    public virtual Supervizori1 LIdSupervizorNavigation { get; set; } = null!;
}
