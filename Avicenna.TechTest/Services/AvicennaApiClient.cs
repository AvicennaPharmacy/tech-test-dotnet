using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Avicenna.TechTest.Data;

namespace Avicenna.TechTest.Services
{
    public class AvicennaApiClient : IAvicennaApiClient
    {
        public Task<IEnumerable<Pharmacy>> GetPharmacies()
        {
            throw new NotImplementedException();
        }
    }
}
