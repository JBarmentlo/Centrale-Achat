using System;
using System.Collections.Generic;
using System.Text;

namespace CentraleAchat
{
    class Reclamation
    {
        public string Text { get; set; }
        public Client Client { get; set; }

        public Reclamation(string text, Client client)
        {
            Text = text;
            Client = client;
        }
    }
}
