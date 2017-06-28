using System;


namespace FINT.Model.Felles.Kompleksedatatyper
{
	public class Adresse {
		public enum Relasjonsnavn
        {
			LAND
        }
        
	
		public string adresse { get; set; }
		public string postnummer { get; set; }
		public string poststed { get; set; }
		
	}
}
