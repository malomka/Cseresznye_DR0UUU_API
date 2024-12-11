using System;
using System.Collections.Generic;

namespace Cseresznye_DR0UUU_API.LibraryModels;

public partial class Tag
{
    public int TagId { get; set; }

    public string Nev { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Telefonszam { get; set; } = null!;

    public string TagsagiSzam { get; set; } = null!;

    public DateTime TagsagiDatum { get; set; }

    public virtual ICollection<Kolcsonze> Kolcsonzes { get; set; } = new List<Kolcsonze>();
}
