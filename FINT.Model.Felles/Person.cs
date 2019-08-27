// Built from tag v3.3.0-rc-1

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Felles
{
	public class Person : Aktor {
		public enum Relasjonsnavn
        {
			STATSBORGERSKAP,
			KJONN,
			FORELDREANSVAR,
			MALFORM,
			PERSONALRESSURS,
			MORSMAL,
			PARORENDE,
			FORELDRE,
			ELEV
        }
        
	
		public string Bilde { get; set; }
		public Adresse Bostedsadresse { get; set; }
		public DateTime? Fodselsdato { get; set; }
		public Identifikator Fodselsnummer { get; set; }
		public Personnavn Navn { get; set; }
		
	}
}
