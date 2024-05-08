namespace ApiAssessment.Models;

public class Payment
{
    public Guid Reference { get; set; }
    public PaymentStatus Status { get; set; }
    public int Amount { get; set; }
    public DateTime CreatedUtcDate { get; set; }
}

public enum PaymentStatus
{
    Success = 1,
    Failed = 2
}