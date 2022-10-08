using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Tienda_De_Instrumentos_MUsicales.ClienteBlazor.Models;

namespace Tienda_De_Instrumentos_MUsicales.ClienteBlazor.Services
{
    public class CategoriaService : ICategoriaService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient _httpClient;
        public CategoriaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Categoria>> GetAll()
        {
            
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                string resp = await _httpClient.GetStringAsync($"Departamento");
                return JsonSerializer.Deserialize<IEnumerable<Categoria>>(resp, options);
            
        }
    }
}
