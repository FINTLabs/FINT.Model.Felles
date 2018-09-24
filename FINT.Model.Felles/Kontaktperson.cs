// Built from tag v3.1.0

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
		public Identifikator SystemId { get; set; }
		public string Type { get; set; }
		
	}
}
