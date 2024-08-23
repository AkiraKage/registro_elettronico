using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace registro_elettronico
{
    public class Student
    {
        [JsonProperty("matricola")]
        public int numericID { get; set; }

        [JsonProperty("nome")]
        public string name { get; set; }

        [JsonProperty("cognome")]
        public string surname { get; set; }

        [JsonProperty("data_nascita")]
        public DateTime birthdate { get; set; }

        [JsonProperty("luogo_nascita")]
        public string birthplace { get; set; }

        [JsonProperty("classe")]
        public string year_section { get; set; }

        [JsonProperty("voti")]
        public Dictionary<string, List<int>> scores { get; set; }
    }
}
