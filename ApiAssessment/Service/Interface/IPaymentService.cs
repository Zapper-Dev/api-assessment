namespace ApiAssessment.Service.Interface;

public interface IPaymentService
{
    int Authorise(string cardNumber, string expiry, string cvv, int amount);
}