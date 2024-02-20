using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewAllChannelsLoan
{
    public int? InRecord { get; set; }

    public string VendorCode { get; set; } = null!;

    public int? LicenceId { get; set; }

    public string? VendorType { get; set; }

    public string? VendorName { get; set; }

    public int? ChannelContactTelephone { get; set; }

    public int? ChannelContactEmail { get; set; }

    public int? ChannelAdress { get; set; }

    public int? CreationDate { get; set; }

    public bool? Active { get; set; }

    public int? Username { get; set; }

    public double? CommissionRate { get; set; }

    public int? ContactPerson { get; set; }

    public string Products { get; set; } = null!;
}
