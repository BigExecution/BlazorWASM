using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TEST.Models;

namespace TEST.Services
{
    public interface IUniversityService
    {
        Task<IEnumerable<University>> GetUniversities(string country);
    }
}
