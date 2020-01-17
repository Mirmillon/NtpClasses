using NtpModels.People;

namespace NtpModels.Telecommunication
{
    public class Telecommunication
    {
        public int TeleCommunicationId { get; set; }
        /*
        FOREIGN KEY
        */
        public int? PatientId { get; set; }
        /*
       Précise l'utilisation du canal de communication (par exemple à des fins
       professionnelles, privées, etc.).
       Table 77 Attributs de la classe "Telecommunication"
       Mise en correspondance FHIR R4: ContactPoint.use
       */
        public short? UsePhoneId { get; set; }
        /*
        Le niveau de confidentialité permet de définir le niveau de restriction de l'accès
        aux attributs de la classe Telecommunication.
        Nomenclature(s) associée(s) :
        TRE_R283-NiveauConfidentialite
        */
        public string LevelConfidentialityId { get; set; }
        public int? ContactId { get; set; }
        public Contact.Contact Contact { get; set; }
        public Patient Patient { get; set; }

        public Telecommunication()
        {

        }
    }
}
