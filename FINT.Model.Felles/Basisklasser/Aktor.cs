// Built from tag v2.0.10

using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Felles.Basisklasser
{
    public abstract class Aktor
    {
        public Kontaktinformasjon Kontaktinformasjon { get; set; }
        public Adresse Postadresse { get; set; }
    }
}