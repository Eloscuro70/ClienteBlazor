using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using Tienda_De_Instrumentos_MUsicales.ClienteBlazor.Models;

namespace Tienda_De_Instrumentos_MUsicales.ClienteBlazor.Services
{
    public class ContactoService : IContactoService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient _httpClient;
        public ContactoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //configurar las opciones del Serializador
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public async Task<IEnumerable<Contacto>> GetAll()
        {
            string resp = await _httpClient.GetStringAsync($"Contacto");
            return JsonSerializer.Deserialize<IEnumerable<Contacto>>(resp, options);
        }

        public async Task<IEnumerable<Contacto>> GetByDepartamento(int idCategoria)
        {
            var resp = await _httpClient.PostAsJsonAsync($"Contacto/Buscar", new { idCategoria = idCategoria });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Contacto>>(respString, options);
        }

        public async Task<Contacto> GetById(int id)
        {
            string resp = await _httpClient.GetStringAsync($"Contacto/{id}");
            return JsonSerializer.Deserialize<Contacto>(resp, options);
        }

        Task<IEnumerable<Contacto>> IContactoService.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Contacto>> IContactoService.GetByDepartamento(int idCategoria)
        {
            throw new NotImplementedException();
        }

        Task<Contacto> IContactoService.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
    

