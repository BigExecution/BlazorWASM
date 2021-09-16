using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TEST.Models;

namespace TEST.Services
{
    public class UniversityService : BaseService, IUniversityService
    {
        public UniversityService(HttpClient httpClient) : base(httpClient) { }

        public async Task<IEnumerable<University>> GetUniversities(string country)
        {
            //return await GetMethodList<University>($"/search?country=Korea,+Republic+of");
            return await GetMethodList<University>($"/search?country={country}");
        }
    }
}
