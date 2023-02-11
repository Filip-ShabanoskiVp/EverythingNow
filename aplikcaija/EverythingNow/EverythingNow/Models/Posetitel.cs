using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EverythingNow.Models;

public partial class Posetitel
{

    [DisplayName("Емаил")]
    [Required(ErrorMessage = "Внеси емаил")]
    public string Emailaddress { get; set; } = null!;


    [DisplayName("Име")]
    [Required(ErrorMessage = "Внеси име")]
    public string? ImePosetitel { get; set; }

    [DisplayName("Корисничко име")]
    [Required(ErrorMessage = "Внеси корисничко име")]
    public string? UsernamePosetitel { get; set; }


    [DisplayName("Лозинка")]
    [Required(ErrorMessage = "Внеси лозинка")]
    public string? PasswordPosetitel { get; set; }

    public virtual ICollection<Tiket> Tikets { get; } = new List<Tiket>();
}
