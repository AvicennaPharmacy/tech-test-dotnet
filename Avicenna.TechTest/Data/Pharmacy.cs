using System.Collections.Generic;

namespace Avicenna.TechTest.Data
{
    public class Pharmacy
    {
        public string Id { get; set; }
        public string BranchNumber { get; set; }
        public string Code { get; set; }
        public string BusinessName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public List<string> ServicesOffered { get; set; }
    }
}
