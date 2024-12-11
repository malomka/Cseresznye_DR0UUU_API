using System;
using System.Collections.Generic;

namespace Cseresznye_DR0UUU_FORM.LibraryModels;

public partial class Konyv
{
    public int KonyvId { get; set; }

    public string Cim { get; set; } = null!;

    public int SzerzoId { get; set; }

    public int KategoriaId { get; set; }

    public string Isbn { get; set; } = null!;

    public int Keszlet { get; set; }

    public virtual Kategorium Kategoria { get; set; } = null!;

    public virtual ICollection<Kolcsonze> Kolcsonzes { get; set; } = new List<Kolcsonze>();

    public virtual Szerzo Szerzo { get; set; } = null!;
}
