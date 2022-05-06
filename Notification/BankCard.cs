using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankCard
    {
        public string Bankname { get; set; }
        public string Fullname { get; set; }
        public string PAN { get; set; }
        public string PIN { get; set; }
        public string CVC { get; set; }
        public DateTime ExpireDate { get; set; }
        public double Balance { get; set; }

        public BankCard(string bankname, string fullname,string pAN, string pIN)
        {
            System.Random rand = new System.Random();
            Bankname = bankname ?? throw new ArgumentNullException(nameof(bankname));
            Fullname = fullname ?? throw new ArgumentNullException(nameof(fullname));
            PAN = pAN;
            PIN = pIN;
            CVC = SetCVC();
            ExpireDate = new DateTime(rand.Next(2023,2030),rand.Next(1,12),2);
            Balance = SetBalance();
        }
        //string SetPAN()
        //{
        //    string pan = "0000000000000000";
        //    System.Random random = new System.Random();
        //    //pan = $"{random.Next(99999999) + random.Next(99999999)}";
        //    for (int i = 0; i < 16; i++)
        //    {
        //        pan = $"{random.Next(99999999).ToString() + random.Next(99999999).ToString()} ";
        //    }
        //    return pan;
        //}
        //string SetPIN()
        //{
        //    string pin;
        //    System.Random random = new System.Random();
        //    pin = random.Next(9999).ToString();
        //    return pin;
        //}
        string SetCVC()
        {
            string CVC;
            System.Random random= new System.Random();
            CVC = random.Next(100,999).ToString();
            return CVC;
        }
        double SetBalance()
        {
            double balance;
            System.Random random = new System.Random();
            balance = random.Next(100, 10000);
            return balance;
        }
    }

}
