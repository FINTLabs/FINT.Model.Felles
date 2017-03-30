using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FintFellesModel
{
    public class Person : Aktor
    {
        public Identifikator Foedselsnummer { get; set; }
        public Personnavn Navn { get; set; }
        public string Kjoenn { get; set; }
        public DateTime Foedselsdato { get; set; }
        public string Statsborgerskap { get; set; }
        
        public Adresse Bostedsadresse { get; set; }
    }
}
