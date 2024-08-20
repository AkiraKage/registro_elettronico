using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registro_elettronico
{
    public class Teacher
    {
        [JsonProperty("nome")]
        public string name { get; set; }

        [JsonProperty("cognome")]
        public string surname { get; set; }

        [JsonProperty("codiceID")]
        public int numericID { get; set; }

        [JsonProperty("chiavepers")]
        public string perskey { get; set; }
    }
}
