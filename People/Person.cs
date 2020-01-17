using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NtpModels.People
{
    public class Person
    {
        public int ID { get; set; }    
        public bool ActiveRecord { get; set; }//  Whether the patient record is active
        public string FirstName { get; set; }
        public string Middlename { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public string GenderId { get; set; }
        public double? Weight { get; set; }
        public bool Deceased { get; set; }
        public DateTime? DateDeceasesd { get; set; }
        public override string ToString()
        {
            // return JsonSerializer.Serialize<Person>(this);
            return null;
        }
    }
}
