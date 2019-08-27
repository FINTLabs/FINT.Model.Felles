// Built from tag v3.3.0-rc-1

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Felles
{
	public class Kontaktperson {
		public enum Relasjonsnavn
        {
			KONTAKTPERSON,
			PERSON
        }
        
	
		public bool Foreldreansvar { get; set; }
		public Kontaktinformasjon Kontaktinformasjon { get; set; }
		public Personnavn Navn { get; set; }
		public Identifikator SystemId { get; set; }
		public string Type { get; set; }
		
	}
}
