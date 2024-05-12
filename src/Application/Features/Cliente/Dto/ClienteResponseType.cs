using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AngelValdiviezoWebApi.Application.Features.Cliente.Dto
{
    public class ClienteResponseType
    {
        [JsonPropertyName("mensajeRespuesta")]
        public string MensajeRespuesta { get; set; }
    }
}
