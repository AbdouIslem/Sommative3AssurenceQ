using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClientsHotels
{
    internal class Client
    {
        // Declaration des attributs
        private string nom, prénom, courriel, carteCrédit;
        private int numeroChambre;

        //Creation des propriétés
        public string Nom { get; set; }
        public string Prénom { get; set; }
        public string Courriel { get;set; }
        public string CarteCrédit { get; set; }
        public int NumeroChambre { get;set; }

        // Creation du constructeur

        public Client(string nom, string prenom, string courriel, string cartcredit, int numChambre)
        {
            this.Nom = nom;
            this.Prénom= prenom;
            this.Courriel= courriel;
            this.CarteCrédit= cartcredit;
            this.NumeroChambre= numChambre;

        }

    }
}
