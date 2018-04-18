using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EdoWebForm1 {
    public partial class _Cart : Page {
        public string Message{get; set;}
        public List<Prodotto> prodotti{get; set;}

        protected void Page_Load(object sender,EventArgs e) {
            prodotti = (List<Prodotto>)Session["listaRichieste"] ?? null;
            Message = prodotti==null?"Nessun prodotto tra le richieste di ordine":null;
        }

        protected void Invia(object sender,EventArgs e) {
            IDomainModel model = new MockDomainModel();
            foreach(Prodotto p in prodotti){
                model.AddQta(p.Id, p.QuantitaRichiesta);
            }
            Session["listaRichieste"]=null;
            Response.Redirect("~/SearchProduct.aspx?Message='Richiesta di ordine salavata!'");
        }
    }
}