// Built from tag v2.6.0-beta-2

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
			MALFORM,
			PERSONALRESSURS,
			MORSMAL,
			ELEV
        }
        
	
		public string Bilde { get; set; }
		public Adresse Bostedsadresse { get; set; }
		public DateTime? Fodselsdato { get; set; }
		public Identifikator Fodselsnummer { get; set; }
		public Personnavn Navn { get; set; }
		
	}
}
