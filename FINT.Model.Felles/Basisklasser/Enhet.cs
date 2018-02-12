// Built from tag v2.6.0-beta-1

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Felles.Basisklasser
{
	public abstract class Enhet : Aktor {
	
		public Adresse Forretningsadresse { get; set; }
		public string Organisasjonsnavn { get; set; }
		public Identifikator Organisasjonsnummer { get; set; }
		
	}
}
