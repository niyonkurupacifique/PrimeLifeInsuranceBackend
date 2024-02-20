using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class TermDeposit
{
    public int IdRecord { get; set; }

    public string LeBook { get; set; } = null!;

    public decimal YearMonth { get; set; }

    public string BankAccountNo { get; set; } = null!;

    public string BankLeBook { get; set; } = null!;

    public string? BankName { get; set; }

    public string? AccountType { get; set; }

    public string? PensionSchemeType { get; set; }

    public string? CreditRating { get; set; }

    public string? CreditRatingAgency { get; set; }

    public string? RelatedPartyFlag { get; set; }

    public DateOnly? OpeningDate { get; set; }

    public DateOnly? MaturityDate { get; set; }

    public decimal? InterestRate { get; set; }

    public decimal? PrincipalAmount { get; set; }

    public decimal? AccruedInterest { get; set; }

    public decimal? ChargesIncurred { get; set; }
}
