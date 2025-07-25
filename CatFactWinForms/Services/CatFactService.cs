using CatFactWinForms.Interfaces;
using CatFactWinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CatFactWinForms.Services
{
    public class CatFactService : ICatFactService
    {
        private readonly HttpClient _httpClient;

        public CatFactService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        public async Task<CatFactResponse> GetCatFactAsync()
        {
            
            var response = await _httpClient.GetStringAsync("https://catfact.ninja/fact");
            var factResponse = JsonSerializer.Deserialize<CatFactResponse>(response,
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            if (factResponse != null)
            {
                return factResponse;
            }
            
            throw new Exception("Nie udało się sparsować odpowiedzi z API.");
        }
    }
}
