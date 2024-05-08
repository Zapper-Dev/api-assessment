using ApiAssessment.Models;
using ApiAssessment.Service;
using Microsoft.AspNetCore.Mvc;

namespace ApiAssessment.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PaymentsController : ControllerBase
{
    // POST: api/Payments
    [HttpPost]
    public IActionResult Post([FromBody] PaymentRequest request)
    {
        var service = new PaymentService();
        var result = service.Authorise("1234", "12/27", "123", 1000);

        return Ok(new PaymentResponse()
        {
            Id = result
        });
    }
}
