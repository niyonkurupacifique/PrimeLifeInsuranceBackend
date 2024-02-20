using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewUpdateCustomerIngenzi
{
    public int IdRecord { get; set; }

    public string FullName { get; set; } = null!;

    public string FullNameNida { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string? IdDocumentNumberNida { get; set; }
}
