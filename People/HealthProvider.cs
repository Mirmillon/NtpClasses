using System;
using System.Collections.Generic;
using System.Text;

namespace NtpModels.People
{
    public class HealthProvider:Person
    {
     
        public int KindHealthWorkerId { get; set; }

        public IEnumerable<HealthProvidersPatients> HealthProviderPatients { get; set; }

    }
}
