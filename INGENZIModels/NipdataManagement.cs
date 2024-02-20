using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class NipdataManagement
{
    public int IdRecord { get; set; }

    public string Nipcode { get; set; } = null!;

    public string? EmployeeId { get; set; }

    public string FullNames { get; set; } = null!;

    public string? IdNumber { get; set; }

    public DateTime? PaymentDate { get; set; }

    public double Amount { get; set; }

    public string? EntityName { get; set; }

    public string? Unit { get; set; }

    public string? FinanceComment { get; set; }

    public DateTime RecoredDate { get; set; }

    public string? FinanceUserName { get; set; }

    public string AssignedDepartement { get; set; } = null!;

    public DateTime? AssignedDate { get; set; }

    public string? OperationStatus { get; set; }

    public string? UnderwriterResponsible { get; set; }

    public string? UnderwrtingComment { get; set; }

    public DateTime? UnderwritingActionDate { get; set; }

    public string? SalesResponsible { get; set; }

    public string? CommercialComment { get; set; }

    public DateTime? CommercialActionDate { get; set; }

    public string? FinalFinanceComment { get; set; }

    public DateTime? ClosingDate { get; set; }

    public string? UnderwriterUserLast { get; set; }

    public string? CommercialUserLast { get; set; }

    public string? FinanceUserClosing { get; set; }
}
