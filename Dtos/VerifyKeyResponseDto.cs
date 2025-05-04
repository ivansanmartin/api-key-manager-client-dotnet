using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_key_manager_client_dotnet.Dtos
{
    public class VerifyKeyResponseDto
    {
        public bool Ok;
        public required string Message;
        public required ApiReferenceDto ApiReference;

    }
}