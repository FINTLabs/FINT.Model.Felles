using System;


using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Felles.Basisklasser
{
	public abstract class Begrep {
	
		public Identifikator systemId { get; set; }
		public string kode { get; set; }
		public string navn { get; set; }
		public Periode gyldighetsperiode { get; set; }
		
	}
}
