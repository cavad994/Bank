using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Client
    {
        static int ID = 0;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public List<BankCard> bankCards { get; set; } = new List<BankCard>();

        public Client(string name, string surname, int age, double salary, BankCard bankCard)
        {
            ID = ID++;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            Age = age;
            Salary = salary;
            if (bankCards != null)
                bankCards.Add(bankCard);
            else
                bankCards.Append(bankCard);
        }

        public void AddCard(BankCard bankCard)
        {
            bankCards.Add(bankCard);
        }

    }
}
