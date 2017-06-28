using System;


using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Felles.Basisklasser.ISO;
using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Felles
{
	public class Person : Aktor {
		public enum Relasjonsnavn
        {
			STATSBORGERSKAP,
			KJONN,
			ELEV
        }
        
	
		public Identifikator fodselsnummer { get; set; }
		public Personnavn navn { get; set; }
		public DateTime fodselsdato { get; set; }
		public string bilde { get; set; }
		public Adresse bostedsadresse { get; set; }
		public Sprak malform { get; set; }
		public Sprak morsmal { get; set; }
		
	}
}
