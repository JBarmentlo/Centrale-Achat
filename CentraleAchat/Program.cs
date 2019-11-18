using System;

namespace CentraleAchat
{

    class Program
    {
        //la fonction LoginTryCatch s'apelle elle meme, on apelle ca un fonction recursive;

        static void Main(string[] args)
        {
            Centrale centrale = new Centrale();
            Console.WriteLine("Enter eMail adress");
            string mail = Console.ReadLine();
            Console.WriteLine("Enter password ");
            string passwd = Console.ReadLine();

            User client = new Client("jean", "moi@gmail.com", "pass");
            User vendeur = new Vendeur("Momo", "momo@gmail.com", "pass");
            centrale.Users.Add(client);
            centrale.Users.Add(vendeur);

            User LogClient = centrale.LoginTryCatch(mail, passwd);
            Console.WriteLine(LogClient.Nom);




        }
    }
}
