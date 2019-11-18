using System;
using System.Collections.Generic;
using System.Text;

namespace CentraleAchat
{
    class Commande
    {
        public Client Client { get; set; }
        public Vendeur Vendeur { get; set; }
        public Article Article { get; set; }
        public int Quantite { get; set; }
        public bool Completed { get; set; }
    }
}
