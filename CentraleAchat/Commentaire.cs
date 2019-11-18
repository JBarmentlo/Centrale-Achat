using System;
using System.Collections.Generic;
using System.Text;

namespace CentraleAchat
{
    class Commentaire
    {
        public string Text { get; set; }
        public Client Auteur { get; set; }

        public Commentaire(string text, Client auteur)
        {
            Text = text;
            Auteur = auteur;
        }
    }
}
