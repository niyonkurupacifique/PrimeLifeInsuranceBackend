using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class MifotraCommitment
{
    public int IdRecord { get; set; }

    public double? CommitmentId { get; set; }

    public double? EmployeeId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? IdNumber { get; set; }

    public string? PhoneNumber { get; set; }

    public string? CreditorId { get; set; }

    public string? Creditor { get; set; }

    public string? CreditorAccountNumber { get; set; }

    public double? Amount { get; set; }

    public string? Position { get; set; }

    public string? Unit { get; set; }

    public string? Institution { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? RequestType { get; set; }

    public string? Reason { get; set; }

    public string? CommitmentStatus { get; set; }

    public string? Name { get; set; }

    public byte[]? DocumentContent { get; set; }

    public string? Extn { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? UserName { get; set; }

    public string? InternalAction { get; set; }

    public string? UserNameAction { get; set; }

    public DateTime? InternalActionDate { get; set; }

    public string? UserChangedBy { get; set; }

    public DateTime? UserChangedOnDate { get; set; }

    public string? Comments { get; set; }
}
