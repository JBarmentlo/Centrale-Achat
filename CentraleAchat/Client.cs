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
                if (articleQtePair.Key.Stock >= articleQtePair.Value)
                    articleQtePair.Key.Stock -= articleQtePair.Value;
                else
                {
                    Console.WriteLine(articleQtePair.Key.Name + " is out of stock. you ordered " + articleQtePair.Value + "and there are " + articleQtePair.Key.Stock + " left in stack.");
                }
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
