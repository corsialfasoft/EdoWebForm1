using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EdoWebForm1 {
    public partial class _ProductDetail : Page {
        public string Message;
        public Prodotto prodotto;
        private IDomainModel model = new MockDomainModel();

        protected void Page_Load(object sender,EventArgs e) {
            prodotto = int.TryParse(Request["Codice"], out int code) ? model.SearchProductByCode(code) : null;
            if (prodotto == null) {
                Response.Redirect("~/SearchProduct.aspx?Message='Prodotto non trovato!'");
            }
        }

        protected void AggiungiProdottoACarrello(object sender,EventArgs e) {
            if (int.TryParse(qta.Text, out int quantitaRichiesta)) {
                List<Prodotto> prodotti = (List<Prodotto>)Session["listaRichieste"] ?? new List<Prodotto>();
                var query = from prod in prodotti
                    where prod.Id==prodotto.Id
                    select prod;
                if(query.FirstOrDefault()!=null){
                    query.FirstOrDefault().QuantitaRichiesta=  query.FirstOrDefault().QuantitaRichiesta +  quantitaRichiesta;
                }else{
                    prodotto.QuantitaRichiesta=quantitaRichiesta;
                    prodotti.Add(prodotto);
                }
                Session["listaRichieste"]=prodotti;
                Response.Redirect("~/SearchProduct.aspx?Message='Quantita aggiunta al carrello!'");
            } else {
                Message= "La quantità deve essere un valore numerico..!";
            }
        }

        protected void Annulla(object sender,EventArgs e) {
            //if (PreviousPage.Request["Descrizione"] != null) {
            //    Response.Redirect($"~/ProductList.aspx?descrizione={PreviousPage.Request["Descrizione"]}");
            //} else {
                Response.Redirect($"~/SearchProduct");
            //}
        }
    }
    public partial interface IDomainModel {
        Prodotto SearchProductByCode(int code);
        void AddQta(int ProductCode, int qta);
    }

    public partial class MockDomainModel : IDomainModel {
        public void AddQta(int ProductCode, int qta) {
        }

        public Prodotto SearchProductByCode(int code) {
            return new Prodotto() {
                Id = 1, Nome = "Staffa U", Quantita = 500
            };
        }
    }
}