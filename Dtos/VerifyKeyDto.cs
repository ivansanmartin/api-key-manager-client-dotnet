using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_key_manager_client_dotnet.Dtos
{
    public class VerifyKeyDto
    {

        public string ApiReferenceId { get; set; } = String.Empty;
        public string ApiKeyId { get; set; } = String.Empty;
        public string ApiKey { get; set; } = String.Empty;
        
    }
}