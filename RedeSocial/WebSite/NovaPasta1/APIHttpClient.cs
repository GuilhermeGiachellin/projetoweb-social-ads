using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;

namespace WebSite.NovaPasta1
{
    public class APIHttpClient
    {
        private string baseAPI = string.Empty;
        public APIHttpClient(string baseAPI)
        {
            this.baseAPI = baseAPI;
        }

        public Guid Put<T>(string action, Guid id, T data)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAPI);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); 
                
                HttpResponseMessage response = client.PutAsJsonAsync(action + id.ToString(), data).Result; 
                if(response.IsSuccessStatusCode)
                {
                    var sucesso = response.Content.ReadAsAsync<Guid>().Result;
                    return sucesso;
                }
                else
                {
                    throw new Exception(response.Content.ReadAsStringAsync().Result);   
                }

            }
        }

        public Guid Post<T>(string action, T data) 
        {
            using (var client = new HttpClient()) 
            {
                client.BaseAddress = new Uri(baseAPI);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.PutAsJsonAsync(action, data).Result;
                if (response.IsSuccessStatusCode)
                {
                    var sucesso = response.Content.ReadAsAsync(Guid).Result;
                    return sucesso;
                }
                else
                {
                    throw new Exception(response.Content.ReadAsStringAsync().Result);
                }

            }
        }

        public Guid Get<T>(string actionUri, Guid id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAPI);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync(actionUri + id.ToString()).Result;
                if (response.IsSuccessStatusCode)
                {
                    T sucesso = response.Content.ReadAsAsync<T>().Result;
                    return sucesso;
                }
                else
                {
                    throw new Exception(response.Content.ReadAsStringAsync().Result);
                }

            }
        }

        public Guid Delete<T>(string action, Guid id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAPI);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.DeleteAsync(action + id.ToString()).Result;
                if (response.IsSuccessStatusCode)
                {
                    var sucesso = response.Content.DeleteAsync<T>().Result;
                    return sucesso;
                }
                else
                {
                    throw new Exception(response.Content.ReadAsStringAsync().Result);
                }

            }
        }



    }
}
