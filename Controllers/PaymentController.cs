using System.Security.Principal;
using Microsoft.AspNetCore.Mvc;
using pagamento.Dtos;
using pagamento.Interfaces;

namespace pagamento.Controllers;


[ApiController]
[Route("api/[controller]")]
public class PaymentController() : Controller
{

    [HttpPost("v1/process-payment")]
    public ProcessResponse ProcessPayment([FromBody] ProcessRequest paymentRequest, IPaymentService paymentService)
    {
        paymentService.ProcessPayment(paymentRequest.Email, paymentRequest.Amount, paymentRequest.AuthorizationToken);

        return new ProcessResponse()
        {
            Status = "200",
            Message = "Payment processed successfully"
        };
    }

    [HttpPost("v1/refund-payment")]
    public ProcessResponse RefundPayment([FromBody] RefundRequest refundRequest, IPaymentService paymentService)
    {
        paymentService.RefoundPayment(refundRequest.PaymentId, refundRequest.Amount, refundRequest.TransactionId, refundRequest.AuthorizationToken);

        return new ProcessResponse()
        {
            Status = "200",
            Message = "Payment refunded successfully"
        };
    }   

}

