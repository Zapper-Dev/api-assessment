namespace ApiAssessment.Models;

public class PaymentProviderRequest
{
    public int Amount { get; set; }
    public string CardNumber { get; set; }
    public string Expiry { get; set; }
    public string Cvv { get; set; }
}