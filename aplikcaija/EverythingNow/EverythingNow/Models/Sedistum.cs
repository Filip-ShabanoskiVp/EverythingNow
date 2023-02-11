using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EverythingNow.Models;

public partial class Sedistum
{
    public long? IdStadion { get; set; }

    [DisplayName("Број на Седиште")]
    public int Broj { get; set; }

    public bool? Slobodno { get; set; }

    public int? Cena { get; set; }

    public Sedistum(long? idStadion, int broj, bool? slobodno)
    {
        IdStadion = idStadion;
        Broj = broj;
        Slobodno = slobodno;
    }

    public virtual Stadion? IdStadionNavigation { get; set; }

    public virtual Tiket? Tiket { get; set; }
}
