using ApiAssessment.Models;

namespace ApiAssessment.Repository;

public class PaymentRepository
{
    // Extremely complex Repo, with async methods to write to db and fetch items, assume this is an actual repo

    private List<Payment> _payments = new List<Payment>()
    {
        new Payment()
        {
            Amount = 1000,
            CreatedUtcDate = DateTime.Now.AddDays(-2),
            Reference = Guid.Empty,
            Status = PaymentStatus.Success
        }
    };

    public async Task<bool> SavePayment(Payment result)
    {
        return await Task.Run(() =>
        {
            _payments.Add(result);
            return true;
        });
    }

    public async Task<Payment?> GetPayment(Guid id)
    {
        return await Task.Run(() =>
        {
            return _payments.FirstOrDefault(x => x.Reference == id);
        });
    }

    public async Task<IEnumerable<Payment>> GetPayments(DateTime from, DateTime to)
    {
        return await Task.Run(() =>
        {
            return _payments.Where(x => x.CreatedUtcDate > from && x.CreatedUtcDate < to);
        });
    }
}