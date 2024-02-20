using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class CustomersUser
{
    public int IdRecord { get; set; }

    public string Names { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? NationalId { get; set; }

    public bool Active { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? Otpcode { get; set; }
}
