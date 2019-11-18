using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CentraleAchat
{
    class Centrale
    {
        public List<User> Users { get; set; }
        public List<Article> Articles { get; set; }
        public Centrale()
        {
            Users = new List<User> { };
            Articles = new List<Article> { };
        }

        public Client           CreateClientAccount(string Nom, string Mail, string Password)
        {
            throw new NotImplementedException();
        }
        public Vendeur          CreateVendeurAccount(string Nom, string Mail, string Password)
        {
            throw new NotImplementedException();
        }
        public User             Login(string mail, string password)
        {
            User LoggingIn = Users.Where((user) => user.Mail.Equals(mail)).First();
            if (LoggingIn == null)
                throw new ArgumentNullException("email not registered");
            if (LoggingIn.Password == password)
                return LoggingIn;
            else
                throw new ArgumentException("Wrong Password");

        }
        public void             AddArticle(Article article)
        {
            if (article == null)
                throw new ArgumentNullException();
            Articles.Add(article);
        }
        public void             DeactivateArticle(Article article)
        {
            article.Active = false;
        }
        public void             UpdateStockArticle(Article article, int stock)
        {
            article.Stock = stock;
        }
        public List<Article>    SearchArticles(string searchInput)
        {
            List<Article> SearchResults = new List<Article> { };
            foreach (Article article in Articles)
            {
                if (article.Active && article.Name.Contains(searchInput))
                    SearchResults.Add(article);
            }
            return (SearchResults);
        }
        //ici on OVERLOAD SearchArticles avec deux declarations prenant des arguments differents
        public List<Article>    SearchArticles(string searchInput, double MinPrice, double MaxPrice)
        {
            List<Article> Result = SearchArticles(searchInput);
            Result.Where((x) => x.Price < MaxPrice && x.Price > MinPrice);
            return Result;
        }
        public bool             ConfirmAccount(User user, string confirmationString)
        {
            throw new NotImplementedException();
        }
    }
}
