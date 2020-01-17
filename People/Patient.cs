using NtpModels.Geography;
using System.Collections.Generic;
using NtpModels.Finding;

namespace NtpModels.People
{
    public class Patient:Person
    {
        public IEnumerable<Contact.Contact> Contacts { get; set; }
        public Address Address { get; set; }
        public IEnumerable<Telecommunication.Telecommunication> TeleCommunications { get; set; }
        public IEnumerable<PresumptiveTb> PresumptiveTbs { get; set; }
        public IEnumerable<HealthProvidersPatients> HealthProviderPatients { get; set; }
        public override string ToString()
        {
            //return JsonSerializer.Serialize<Patient>(this);
            return null;
        }
    }
}
