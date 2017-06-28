using System;


using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Felles.Basisklasser
{
	public abstract class Enhet : Aktor {
	
		public Identifikator organisasjonsnummer { get; set; }
		public string organisasjonsnavn { get; set; }
		public Adresse forretningsadresse { get; set; }
		
	}
}
