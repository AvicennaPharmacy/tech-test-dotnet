using System.Collections.Generic;
using System.Threading.Tasks;
using Avicenna.TechTest.Models;

namespace Avicenna.TechTest.Services
{
    public interface IAvicennaApiClient
    {
        Task<IEnumerable<PharmacyViewModel>> GetPharmacies();
    }
}
