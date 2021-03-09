using System.Collections.Generic;
using System.Threading.Tasks;
using Avicenna.TechTest.Data;

namespace Avicenna.TechTest.Services
{
    public interface IAvicennaApiClient
    {
        Task<IEnumerable<Pharmacy>> GetPharmacies();
    }
}
