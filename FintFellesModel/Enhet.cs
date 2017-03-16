using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FintFellesModel
{
    public class Enhet : Aktor
    {
        public Identifikator Organisasjonsnummer { get; set; }
        public string Organisasjonsnavn { get; set; }
        public Adresse Foretningsadresse { get; set; }
    }
}
