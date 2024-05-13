
namespace AngelValdiviezoWebApi.Application.Features.Token.Dto
{
    public class TokenType
    {
        public string Identificacion { get; set; }

        public string Password { get; set; } = String.Empty;

        public string OrganizacionId { get; set; } = String.Empty;

        public string TokenEcommerce { get; set; }

        public string Token { get; set; } = String.Empty;

        public string IpDevice { get; set; } = String.Empty;

        public string IdDevice { get; set; } = String.Empty;

        public string Expira { get; set; } = String.Empty;

    }
}