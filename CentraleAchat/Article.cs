using System;
using System.Collections.Generic;
using System.Text;

namespace CentraleAchat
{
    class Article
    {
        public String Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Active { get; set; }
        public List<Commentaire> Commentaires { get; set; }
        public int Stock { get; set; }
        public List<KeyValuePair<Client, int>> Reservations { get; set; }
        public Vendeur Vendeur { get; set; }

        public Article(string name, string description, double price, Vendeur vendeur)
        {
            Name = name;
            Description = description;
            Price = price;
            Vendeur = vendeur;
            Stock = 0;
            Commentaires = new List<Commentaire> { };
            Reservations = new List<KeyValuePair<Client, int>> { };
            Active = true;

        }
    }
}
