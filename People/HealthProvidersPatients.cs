namespace NtpModels.People
{
    public class HealthProvidersPatients
    {
        public int HealthProviderId { get; set; }
        public virtual HealthProvider HealthProvider { get; set; }

        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

       
    }
}