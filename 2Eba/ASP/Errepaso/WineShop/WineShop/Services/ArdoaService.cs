using Newtonsoft.Json;
using WineShop.Models;
using WineShop.Services;

namespace Wineshop.Services
{
    public class ArdoaService : IArdoaService
    {
        private Uri rutaTodos = new Uri("https://localhost:44367/api/Ardoa/");
        public async Task<IList<ArdoaUpeltegi>> GetMota(int id)
        {
            List<ArdoaUpeltegi> ardoaUpeltegiList = new List<ArdoaUpeltegi>();
            Uri rutaUpeltegiak = new Uri(rutaTodos, "Mota/" + id.ToString());
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(rutaUpeltegiak))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ardoaUpeltegiList = JsonConvert.DeserializeObject<List<ArdoaUpeltegi>>(apiResponse);
                }
            }
            return ardoaUpeltegiList;
        }
        public async Task<List<Ardoa>> GetArdoak()
        {
            List<Ardoa> ardoaList = new List<Ardoa>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(rutaTodos))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ardoaList = JsonConvert.DeserializeObject<List<Ardoa>>(apiResponse);
                }
            }
            return ardoaList;
        }
        public async Task<Ardoa> GetArdoa(int id)
        {
            Ardoa ardoa = new Ardoa();
            Uri rutaArdoBat = new Uri(rutaTodos, id.ToString());
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(rutaArdoBat))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ardoa = JsonConvert.DeserializeObject<Ardoa>(apiResponse);
                }
            }
            return ardoa;
        }
    }
}
