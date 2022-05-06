using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Bank
    {
        public string Name { get; set; }
        public List<Client> Clients { get; set; } = new List<Client>();

        public Bank(string name)
        {
            Name = name;
        }

        public void ShowCardBalance(BankCard card)
        {
            Console.WriteLine(card.Balance);
        }
        public void AddClient(Client client)
        {
            Clients.Add(client);
        }
        public void ShowClients()
        {
            for (int i = 0; i < Clients.Count; i++)
            {
                for (int j = 0; j < Clients[i].bankCards.Count; j++)
                {
                    Console.WriteLine(Clients[i].bankCards[j].PAN);

                }
            }
        }
    }
}
