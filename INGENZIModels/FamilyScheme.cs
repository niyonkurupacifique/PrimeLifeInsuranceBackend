using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class FamilyScheme
{
    public int IdRecord { get; set; }

    public string? SchemeType { get; set; }

    public string SchemeId { get; set; } = null!;

    public string SchemeName { get; set; } = null!;

    public DateOnly CreationDate { get; set; }

    public string UserName { get; set; } = null!;

    public bool Status { get; set; }
}
