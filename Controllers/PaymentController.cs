using Microsoft.AspNetCore.Mvc;
using Pagamento.API.Domain.Payments.Contracts;
using Pagamento.API.Domain.Payments.Dtos;

namespace Pagamento.API.Controllers;


[ApiController]
[Route("api/[controller]")]
public class PaymentController(IPaymentService PaymentService) : Default.Controller
{
    [HttpPost("/process-payment")]
    public async Task<IActionResult> ProcessPayment([FromBody] ProcessRequest paymentRequest)
        => await HandleRequest(() => PaymentService.ProcessPayment(paymentRequest));
}

