using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewEducationMainDdg
{
    public string? SchemeName { get; set; }

    public string ProductType { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string? FullName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string PolicyStatus { get; set; } = null!;

    public string PolicyNumberMain { get; set; } = null!;

    public string PolicyNumberEndo { get; set; } = null!;

    public double? InitialPremium { get; set; }

    public double? Premium { get; set; }

    public int? Annule { get; set; }

    public int? DateAnnul { get; set; }

    public int? DateTrait { get; set; }

    public DateTime? DateEffet { get; set; }

    public int? Differe { get; set; }

    public double? RenteGarantie { get; set; }

    public double? RenteDifere { get; set; }

    public int Impayes { get; set; }

    public double? TauxTech { get; set; }

    public int XFraisDAcquisition { get; set; }

    public decimal XFraisDeGestionG1 { get; set; }

    public decimal XFraisDeGestionG2 { get; set; }

    public string? PremiumFrequency { get; set; }

    public DateTime? MaturityDate { get; set; }

    public DateTime? EndDateOfPremiumPayment { get; set; }

    public DateTime? EndDateOfEndowmentPayment { get; set; }

    public int? PolicyTermInYear { get; set; }

    public int? DureeLiquidationRente { get; set; }

    public DateTime PremiumPaymentDate { get; set; }

    public double PremiumAmountPayed { get; set; }
}
