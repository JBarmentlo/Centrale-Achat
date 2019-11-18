using System;

namespace CentraleAchat
{

    class Program
    {
        //la fonction LoginTryCatch s'apelle elle meme, on apelle ca un fonction recursive;

        static void Main(string[] args)
        {
            Centrale centrale = new Centrale();
            User client = new Client("jean", "moi", "pass");
            User vendeur = new Vendeur("Momo", "momo@gmail.com", "pass");
            Client clicli = (Client)client;
            centrale.Users.Add(client);
            centrale.Users.Add(vendeur);

            Console.WriteLine("Enter eMail adress");
            string mail = Console.ReadLine();
            Console.WriteLine("Enter password ");
            string passwd = Console.ReadLine();

            User LogClient = centrale.LoginTryCatch(mail, passwd);
            Console.WriteLine(LogClient.Nom);

            


            // on cast la variable vendeur (declaree de tye user) ds le type vendeur
            Article art = new Article("velo", "un super velo", 100.5, (Vendeur)vendeur);
            Article art1 = new Article("montre velo", "rolex", 10000.5, (Vendeur)vendeur);
            Article art2 = new Article("Un coca", "c'est frais", 1.5, (Vendeur)vendeur);

            centrale.AddArticle(art);
            centrale.AddArticle(art1);
            centrale.AddArticle(art2);
            centrale.UpdateStockArticle(art, 10);

            clicli.Panier.AddArticleToPanier(art, 11);
            clicli.CommanderPanier(centrale);

            foreach (Article article in centrale.SearchArticles("velo"))
            {
                Console.WriteLine(article.Name);
                Console.WriteLine(article.Stock);
            }
            



        }
    }
}
