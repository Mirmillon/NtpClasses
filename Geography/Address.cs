using NtpModels.People;



namespace NtpModels.Geography
{
    public class Address
    {
        public int AddressId { get; set; }
        public int? PatientId { get; set; }
        public string DistributionPoint { get; set; }
        public string NumberStreet { get; set; }
        /* Appellation qui est donnée à la voie par les municipalités.Ce libellé figure in extenso ou en abrégé sur les plaques aux différents angles de chaque rue.
        Synonyme: nom de la voie
         */
        public string StreetName { get; set; }
        public string BaranguayId { get; set; }
        public string MunicipalityId { get; set; }
        public string Zip { get; set; }
        public string CityId { get; set; }
        public string ProvinceId { get; set; }
        public Contact.Contact Contact { get; set; }

        public Patient Patient { get; set; }


        public Address()
        {

        }
    }
}
