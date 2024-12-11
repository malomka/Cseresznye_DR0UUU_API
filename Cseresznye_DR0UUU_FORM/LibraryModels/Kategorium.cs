using System;
using System.Collections.Generic;

namespace Cseresznye_DR0UUU_FORM.LibraryModels;

public partial class Kategorium
{
    public int KategoriaId { get; set; }

    public string Nev { get; set; } = null!;

    public string? Leiras { get; set; }

    public virtual ICollection<Konyv> Konyvs { get; set; } = new List<Konyv>();
}
