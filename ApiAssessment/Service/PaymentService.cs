using ApiAssessment.Models;
using ApiAssessment.Repository;
using ApiAssessment.Service.Interface;

namespace ApiAssessment.Service;

public class PaymentService : IPaymentService
{
    public int Authorise(string cardNumber, string expiry, string cvv, int amount)
    {
        var httpClient = new HttpClient();

        var providerRequest = new PaymentProviderRequest()
        {
            Amount = amount,
            CardNumber = cardNumber,
            Expiry = expiry,
            Cvv = cvv
        };

        var url = "api/payments";

        var result = httpClient.PostAsync(url, JsonContent.Create(providerRequest)).Result;

        if (result.IsSuccessStatusCode)
        {
            var payment = new Payment()
            {
                Reference = Guid.NewGuid(),
                Status = PaymentStatus.Success,
                Amount = amount,
                CreatedUtcDate = DateTime.UtcNow
            };

            var repository = new PaymentRepository();
            var saved = repository.SavePayment(payment).Result;

            QueueService.GetInstance.PublishMessage("SuccessResult");
        }

        return 1;
    }
}