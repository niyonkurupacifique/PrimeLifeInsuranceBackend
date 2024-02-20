using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewListAllVendor
{
    public string VendorCode { get; set; } = null!;

    public string? VendorType { get; set; }

    public string? VendorName { get; set; }

    public string Products { get; set; } = null!;
}
