
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClientsHotels
{
    internal class Hotel
    {
        // declaration des attribut
        private ArrayList clients;

        // declaration des propriété
        public ArrayList Clients {get;set;}

        // constructeur
        public Hotel() { this.Clients = new ArrayList(); }

        /// <summary>
        /// Ajouter un client a la liste des clients de l hotel
        /// </summary>
        /// <param name="client"></param>
        public void ajouterClient(Client client)
        {
            this.Clients.Add(client);
        }
    }
}
