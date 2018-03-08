// Built from tag v0.99.9

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Felles.Basisklasser
{
	public abstract class Begrep {
	
		public Periode Gyldighetsperiode { get; set; }
		public string Kode { get; set; }
		public string Navn { get; set; }
		public bool? Passiv { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}
