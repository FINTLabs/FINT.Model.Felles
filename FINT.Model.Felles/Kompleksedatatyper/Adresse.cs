// Built from tag v2.4.0-rc-4

using System;
using System.Collections.Generic;



namespace FINT.Model.Felles.Kompleksedatatyper
{
	public class Adresse {
		public enum Relasjonsnavn
        {
			LAND
        }
        
	
		public List<string> Adresselinje { get; set; }
		public string Postnummer { get; set; }
		public string Poststed { get; set; }
		
	}
}
