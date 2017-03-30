using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FintFellesModel.Model
{
    public class Begrep
    {
        public Identifikator systemId { get; set; }
        public String Kode { get; set; }
        public String Navn { get; set; }
        public Periode Gyldighetsperiode { get; set; }
    }
}
