using System.Collections.Generic;

namespace Avicenna.TechTest.Models
{
    public class PharmacyViewModel
    {
        public string Id { get; set; }
        public string BusinessName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string TelephoneNumber { get; set; }
        public List<string> ServicesOffered { get; set; }
    }
}
