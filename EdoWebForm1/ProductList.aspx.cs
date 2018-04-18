using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EdoWebForm1;

namespace EdoWebForm1 {
    public partial class _ProductList : Page {
        public List<Prodotto> Prodotti { get; set; }
        private IDomainModel model = new MockDomainModel();
        public string Message { get; set; }

        protected void Page_Load(object sender,EventArgs e) {
            Prodotti = model.SearchByDescription(Request["Descrizione"]) ?? null;
            if (Prodotti == null) {
                Response.Redirect("~/SearchProduct.aspx?Message='Prodotto non trovato!'");
            } else {
                foreach (Prodotto p in Prodotti) {
                    TableRow tr = new TableRow();
                    TableCell tdCodice = new TableCell();
                    tdCodice.Controls.Add(new Label() { Text = p.Id.ToString(),CssClass="col-xs-2" });
                    tr.Cells.Add(tdCodice);
                    TableCell tdDescrizione = new TableCell();
                    tdDescrizione.Controls.Add(new Label() { Text = p.Nome ,CssClass="col-xs-6" });
                    tr.Cells.Add(tdDescrizione);
                    TableCell tdGiacenza = new TableCell();
                    tdGiacenza.Controls.Add(new Label() { Text = p.Quantita.ToString(),CssClass="col-xs-2" });
                    tr.Cells.Add(tdGiacenza);
                    TableCell tdButton = new TableCell();
                    tdButton.Controls.Add(new Button() {Text="Dettaglio Prodotto", PostBackUrl=$"~/ProductDetail.aspx?codice={p.Id}", CssClass="col-xs-2", Width=150});
                    tr.Cells.Add(tdButton);
                    Table1.Rows.Add(tr);
                }
            }
            Message = Request["Message"] ?? null;
        }
    }

    public partial interface IDomainModel {
    List<Prodotto> SearchByDescription(string description);
    }
    public partial class MockDomainModel : IDomainModel {
        public List<Prodotto> SearchByDescription(string description) {
            return new List<Prodotto>(){
                new Prodotto(){Id=1, Nome="Staffa U", Quantita=500},
                new Prodotto(){Id=2, Nome="Staffa I", Quantita=10250},
                new Prodotto(){Id=3, Nome="Staffa L", Quantita=675}
            };
        }
    }
}