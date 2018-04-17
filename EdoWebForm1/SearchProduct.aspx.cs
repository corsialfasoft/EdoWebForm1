using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EdoWebForm1;

namespace EdoWebForm1 {
    public partial class _SearchProduct : Page {
        protected void Page_Load(object sender,EventArgs e) {

        }
        protected void CercaProdotto(object sender,EventArgs e) {
            List<Prodotto> prodottos = DAO.CreaProdotti();
        }
    }
}