namespace GestionClientsHotels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel h1= new Hotel();
            Client client1 = new Client("abdou","mohamed islem","test@,com","134131231",3);
            Client client2 = new Client("tony", "mohamed islem", "test@,com", "134131231", 4);
            h1.ajouterClient(client1);
            h1.ajouterClient(client2);

            // Afficher le nombre de client

            Console.WriteLine(h1.Clients.Count);
            Console.WriteLine("demain on aura d'autre client");

            for(int i; i<5; i++)
            {
                Console.WriteLine(i)
            }

        }
    }
}