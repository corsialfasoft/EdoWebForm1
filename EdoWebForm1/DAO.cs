using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EdoWebForm1 {
    public class DAO {
        Prodotto prod1 = new Prodotto("bullone 3mm", 50);
        Prodotto prod2 = new Prodotto("bullone 5mm",50);
        Prodotto prod3 = new Prodotto("bullone 7mm",50);
        Prodotto prod4 = new Prodotto("staffa L",50);
        Prodotto prod5 = new Prodotto("staffa U",50);
        Prodotto prod6 = new Prodotto("staffa T",50);
        Prodotto prod7 = new Prodotto("viti autofilettanti", 50);
        Prodotto prod8 = new Prodotto("viti testa piatta", 50);
        Prodotto prod9 = new Prodotto("viti intaglio croce", 250);
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