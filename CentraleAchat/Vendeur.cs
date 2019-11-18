using System;
using System.Collections.Generic;
using System.Text;

namespace CentraleAchat
{
    class Vendeur : User
    { 
        public List<KeyValuePair<Client, double>> Fidelite { get; set; }
        public List<Article> Articles { get; set; }
        public List<Reclamation> Reclamations { get; set; }

        public Vendeur(string nom, string mail, string password) : base(nom, mail, password)
        {
            Articles =      new List<Article> { };
            Reclamations =  new List<Reclamation> { };
            Fidelite =      new List<KeyValuePair<Client, double>> { };
        }
        public void AddArticle(Article article, Centrale centrale)
        {
            throw new NotImplementedException();
        }
        public void AddArticleToStock(Article article, int stock, Centrale centrale)
        {
            throw new NotImplementedException();
        }
        public void DeactivateArticle(Article article, Centrale centrale)
        {
            throw new NotImplementedException();
        }
        public void GererCommentaires()
        {
            throw new NotImplementedException();
        }
        public void GererReclamations()
        {
            throw new NotImplementedException();
        }
        public void RecompenseFidelite(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
