﻿using System.Text.Json.Serialization;

namespace AngelValdiviezoWebApi.Application.Features.Token.Commands.CreateTokenCommand
{
    public class CreateTokenRequest 
    {
        public CreateTokenRequest() { }

        [JsonPropertyName("identificacion")]
        public string Identificacion { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("organizacionId")]
        public string OrganizacionId { get; set; }

        [JsonPropertyName("tokenEcommerce")]
        public string TokenEcommerce { get; set; }

        [JsonPropertyName("ipDevice")]
        public string IpDevice { get; set; }
      

    }
}
