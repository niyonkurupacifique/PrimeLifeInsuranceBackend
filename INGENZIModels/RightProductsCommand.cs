using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class RightProductsCommand
{
    public int IdRecord { get; set; }

    public string? ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? CommandId { get; set; }

    public string? CommandName { get; set; }

    public bool DefaultRight { get; set; }

    public bool Status { get; set; }

    public DateOnly? CreationDate { get; set; }
}
