using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FintFellesModel
{
    public abstract class Aktor
    {
        public Kontaktinformasjon Kontaktinformasjon { get; set; }
        public Adresse Postadresse { get; set; }

    }
}
