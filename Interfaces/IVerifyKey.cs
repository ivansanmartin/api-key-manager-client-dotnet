using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_key_manager_client_dotnet.Dtos;

namespace api_key_manager_client_dotnet.Interfaces
{
    public interface IVerifyKey
    {
        public Task<VerifyKeyResponseDto> VerifyApiKey(VerifyKeyDto verifyKeyDto, CancellationToken cancellationToken);
    }
}