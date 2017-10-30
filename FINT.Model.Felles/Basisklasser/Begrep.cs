// Built from tag v2.0.10

using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Felles.Basisklasser
{
    public abstract class Begrep
    {
        public Periode Gyldighetsperiode { get; set; }
        public string Kode { get; set; }
        public string Navn { get; set; }
        public Identifikator SystemId { get; set; }
    }
}