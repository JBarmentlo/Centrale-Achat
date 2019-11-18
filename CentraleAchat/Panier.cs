using System;
using System.Collections.Generic;
using System.Text;

namespace CentraleAchat
{
    class Panier
    {
        public Client Client { get; set; }
        public List<KeyValuePair<Article, int>> Articles { get; set; }
        public Panier(Client client)
        {
            Client = client;
            Articles = new List<KeyValuePair<Article, int>> { };
        }

        public void AddArticleToPanier(Article article, int quantite)
        {
            throw new NotImplementedException();
        }
        public void ModifyQuantityInPanier(Article article, int newQuantity)
        {
            throw new NotImplementedException();
        }
        public void RemoveArticleFromPanier(Article article)
        {
            throw new NotImplementedException();
        }
    }
}
