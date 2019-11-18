using System;

namespace CentraleAchat
{

    class Program
    {
        //la fonction LoginTryCatch s'apelle elle meme, on apelle ca un fonction recursive;
        static User LoginTryCatch(string mail, string passwd, Centrale centrale)
        {
            // if empty user list in centrale => infinite loop
            User user = null;
            try
            {
                user = centrale.Login(mail, passwd);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Wrong email, try again");
                mail = Console.ReadLine();
                LoginTryCatch(mail, passwd, centrale);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Wrong password, try again");
                passwd = Console.ReadLine();
                LoginTryCatch(mail, passwd, centrale);
            }
            return (user);

        }
        static void Main(string[] args)
        {
            Centrale centrale = new Centrale();
            Console.WriteLine("Enter eMail adress");
            string mail = Console.ReadLine();
            Console.WriteLine("Enter password ");
            string passwd = Console.ReadLine();

            LoginTryCatch(mail, passwd, centrale);




        }
    }
}
