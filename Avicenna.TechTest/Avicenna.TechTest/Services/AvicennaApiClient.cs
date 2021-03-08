using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Avicenna.TechTest.Models;

namespace Avicenna.TechTest.Services
{
    public class AvicennaApiClient : IAvicennaApiClient
    {
        public Task<IEnumerable<PharmacyViewModel>> GetPharmacies()
        {
            throw new NotImplementedException();
        }
    }
}
