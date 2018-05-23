// Built from tag v2.8.0

using System;
using System.Collections.Generic;



namespace FINT.Model.Felles
{
	public class Kontaktperson {
		public enum Relasjonsnavn
        {
			KONTAKTPERSON,
			PERSON
        }
        
	
		public bool Foreldreansvar { get; set; }
		public string Type { get; set; }
		
	}
}
