using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EdoWebForm1;

namespace EdoWebForm1 {
    public partial class _SearchProduct : Page {
        public List<Prodotto> Prodotti { get; set; }
        public string Message { get; set; }
        
        protected void Page_Load(object sender,EventArgs e) {
            Message = Request["Message"] ?? null;
        }
        protected void CercaProdotto(object sender,EventArgs e) {
            if (!String.IsNullOrEmpty(Codice.Text)) {
                Response.Redirect($"~/ProductDetail.aspx?codice={Codice.Text}");
            } else if (!String.IsNullOrEmpty(Descrizione.Text)) {
                Response.Redirect($"~/ProductList.aspx?codice={Descrizione.Text}");
            }
        }
    }
}