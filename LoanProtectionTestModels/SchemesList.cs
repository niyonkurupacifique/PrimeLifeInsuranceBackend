using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class SchemesList
{
    public int IdRecord { get; set; }

    public string SchemeId { get; set; } = null!;

    public string SchemeName { get; set; } = null!;

    public DateOnly CreationDate { get; set; }

    public string ContactPerson { get; set; } = null!;

    public string ContactPersonPhone { get; set; } = null!;

    public string SchemeType { get; set; } = null!;

    public string Username { get; set; } = null!;

    public bool? SurrendersAllowed { get; set; }
}
