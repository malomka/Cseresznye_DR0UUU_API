using System;
using System.Collections.Generic;

namespace Cseresznye_DR0UUU_API.LibraryModels;

public partial class Kolcsonze
{
    public int KolcsonzesId { get; set; }

    public int TagId { get; set; }

    public int KonyvId { get; set; }

    public DateTime KolcsonzesDatum { get; set; }

    public DateTime? VisszahozasDatum { get; set; }

    public string Statusz { get; set; } = null!;

    public virtual Konyv Konyv { get; set; } = null!;

    public virtual Tag Tag { get; set; } = null!;
}
