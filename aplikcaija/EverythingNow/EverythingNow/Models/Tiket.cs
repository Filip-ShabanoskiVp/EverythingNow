using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EverythingNow.Models;

public partial class Tiket
{

    [DisplayName("Седиште")]
    public int Sediste { get; set; }

    [DisplayName("Цена")]
    public int? Cena { get; set; }

    public string? Username { get; set; }

    public string? Emailaddress { get; set; }

    public long? IdNatprevar { get; set; }

    public virtual Posetitel? EmailaddressNavigation { get; set; }

    public virtual Natprevar? IdNatprevarNavigation { get; set; }

    public virtual Sedistum SedisteNavigation { get; set; } = null!;

    public virtual Admin? UsernameNavigation { get; set; }
}
