using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;
using api_key_manager_client_dotnet.Dtos;
using api_key_manager_client_dotnet.Interfaces;

namespace api_key_manager_client_dotnet
{
    public class ApiKeyManagerClient : IVerifyKey
    {
        static HttpClient client = new();
        public required string ApiUrl;
        public string Version = "v1";

        public ApiKeyManagerClient(string apiUrl, string version)
        {
            ApiUrl = apiUrl;
            Version = version;
        }

        public async Task<VerifyKeyResponseDto> VerifyApiKey(VerifyKeyDto verifyKeyDto, CancellationToken cancellationToken = default)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(ApiUrl, verifyKeyDto, cancellationToken);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<VerifyKeyResponseDto>(cancellationToken: cancellationToken);

            return result!;
        }
    }
}