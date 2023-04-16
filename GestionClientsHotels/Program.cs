namespace GestionClientsHotels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel h1= new Hotel();
            Client client1 = new Client("abdou","mohamed islem","test@,com","134131231",3);
            h1.ajouterClient(client1);

            // Afficher le nombre de client

            Console.WriteLine(h1.Clients.Count);
            Console.WriteLine("demain on aura d'autre client");

        }
    }
}