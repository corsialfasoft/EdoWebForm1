using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EdoWebForm1 {
    public class Prodotto {
        public int Id {get; set;}
        public string Nome {get; set;}
        public int Quantita {get; set;}
        public int QuantitaRichiesta { get; set; }
    }
}