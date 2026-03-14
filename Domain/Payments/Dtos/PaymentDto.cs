using System.ComponentModel.DataAnnotations;

namespace Pagamento.API.Domain.Payments.Dtos
{
    public record ProcessRequest
        (
            [Required]
            string Method,
            [Required]
            decimal Amount
        );


    public record ProcessResponse(
            string Status,
            string Message
        );
}