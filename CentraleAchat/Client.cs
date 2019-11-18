using System;
using System.Collections.Generic;
using System.Text;

namespace CentraleAchat
{
    class Client : User
    {
        public Panier Panier { get; set; }
        public Client(string nom, string mail, string password) : base(nom, mail, password)
        {
            Panier = new Panier(this);
        }

        public void CommanderPanier(Centrale centrale)
        {
            foreach (KeyValuePair<Article, int> articleQtePair in Panier.Articles)
            {
                //articleQtePair.Key.Vendeur.AddToBonus(this, articleQtePair.Key.Price * articleQtePair.Value);
                articleQtePair.Key.Stock -= articleQtePair.Value;
            }
            Panier.Articles.Clear();
        }
        public void Comment(Article article, string comment)
        {
            article.Commentaires.Add(new Commentaire(comment, this));
        }
        public void Reclamation(Article article, string texte) //Define
        {
            article.Vendeur.Reclamations.Add(new Reclamation(texte, this));
        }


    }
}
