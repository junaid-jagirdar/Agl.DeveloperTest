using Agl.Domain.Models;
using Agl.Infrastructure.AppConfig;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Agl.Infrastructure.Context
{
    public class PersonDbContext
    {
        public IQueryable<Person> GetPersons()
        {
            return Task.Run(async () => await GetPersonsFromWebService()).Result;
        }

        private async Task<IQueryable<Person>> GetPersonsFromWebService()
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = httpClient.GetAsync(AppConfiguration.AglWebServiceUrl))
                {
                    var jsonString = await response.Result.Content.ReadAsStringAsync();
                    return string.IsNullOrEmpty(jsonString) ? null : JsonConvert.DeserializeObject<List<Person>>(jsonString)?.AsQueryable();
                }
            }
        }
    }
}
