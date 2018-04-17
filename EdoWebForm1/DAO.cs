using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EdoWebForm1 {
    public class DAO {
        public static List<Prodotto> CreaProdotti () {
            List<Prodotto> result = new List<Prodotto>();
            result.Add(new Prodotto(1, "bullone 3mm", 50));
            result.Add(new Prodotto(2, "bullone 5mm", 50));
            result.Add(new Prodotto(3, "bullone 7mm", 50));
            result.Add(new Prodotto(4, "staffa L", 50));
            result.Add(new Prodotto(5, "staffa U", 50));
            result.Add(new Prodotto(6, "staffa T", 50));
            result.Add(new Prodotto(7, "viti autofilettanti", 50));
            result.Add(new Prodotto(8, "viti a testa piatta", 50));
            result.Add(new Prodotto(9, "viti con intaglio croce", 50));
            return result;
        }
    }

    public class Prodotto {
        int Id {get; set;}
        string Nome {get; set;}
        int Quantita {get; set;}

        public Prodotto() {}
        public Prodotto(string nome, int quant) {
            this.Nome = nome;
            this.Quantita = quant;
        }
        public Prodotto(int id, string nome, int quant) {
            this.Id = id;
            this.Nome = nome;
            this.Quantita = quant;
        }
    }
}