using Bank;
using System.Text;



namespace Bank
{
    class MyClass
    {
        public static void enteringPAN(ref List<string> pan, ref string a)
        {
            for (int i = 1; i < 20; i++)
            {
                // 0,1,2,3, ,5,6,7,8, ,10,11,12,13, ,15,16,19,20
                if (i % 5 == 0)
                {
                    a = " ";
                }
                else
                    a = Console.ReadKey().KeyChar.ToString();
                pan.Add(a);
                Console.Clear();
                Console.WriteLine("\n\n\n\t\t\t\t\tEnter PAN (16) : ");
                for (int j = 0; j < pan.Count; j++)
                {
                    Console.Write(pan[j]);
                }
            }
        }
        static void process()
        {
            #region Def

            Banks banks = new Banks();

            Bank xalq = new("XalqBank");
            Bank kapital = new("KapitalBank");
            Bank uni = new("UniBank");

            BankCard javadsXalq = new("XalqBank", "Cavad Yusifzade", "1111 1111 1111 1111", "0801");
            BankCard javids = new("KapitalBank", "Cavid Memmedov", "2222 2222 2222 2222", "4411");
            BankCard javadsUni = new("LeoBank", "Cavad Yusifzade", "0101 0101 0101 0101", "0801");

            Client javad = new("Cavad", "Yusifzade", 19, 200, javadsXalq);
            Client javid = new("Cavid", "Memmedov", 35, 2000, javids);
            javad.AddCard(javadsUni);

            xalq.AddClient(javad);
            kapital.AddClient(javid);
            kapital.ShowClients();

            banks.AddBank(xalq);
            banks.AddBank(kapital);
        #endregion
        //DefaultAdding();
        start:
            Console.WriteLine("CARDS FOR EXAMPLE :\n" +
                "1 - 1111 1111 1111 1111\n" +
                "2 - 2222 2222 2222 2222\n" +
                "3 - 0101 0101 0101 0101\n" +
                "!!!REMEMBER THIS CARDS BEFORE START!!!");
            Console.ReadKey();
            Console.Clear();
            List<string> pan = new List<string>();
            Console.WriteLine("\n\n\n\t\t\t\t\tEnter PAN (16) : ");
            string a = "";
            enteringPAN(ref pan, ref a);
            for (int i = 0; i < banks.banks.Count; i++)
            {
                for (int j = 0; j < banks.banks[i].Clients.Count; j++)
                {
                    bool ptrue = true;
                    for (int card = 0; card < banks.banks[i].Clients[j].bankCards.Count; card++)
                    {
                        for (int p = 0; p < 16; p++)
                        {
                            if (pan[p].ToString() != banks.banks[i].Clients[j].bankCards[card].PAN[p].ToString())
                            {
                                ptrue = false;
                                break;
                            }
                        }
                        if (ptrue)
                        {
                        entered:
                            Console.Clear();
                            Console.WriteLine($"\n\n\n\t\t\t\t\t\t\tWelcome Mr. {banks.banks[i].Clients[j].Name} {banks.banks[i].Clients[j].Surname}!");
                            int ch1;
                            Console.WriteLine($"\n\n\t\t\t\t\t1 - Balance" +
                                $"\n\t\t\t\t\t2 - Cash" +
                                $"\n\t\t\t\t\t3 - CardToCard" +
                                $"\n\t\t\t\t\t4 - Exit" +
                                $"\n\t\t\t\t\tEnter : ");
                            ch1 = Console.ReadKey().KeyChar;
                            if (ch1 == '1')
                            {
                                Console.WriteLine($"Your balance is {banks.banks[i].Clients[j].bankCards[card].Balance}");
                                Console.ReadKey();
                                goto entered;
                            }
                            else if (ch1 == '2')
                            {
                            gettingCash:
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n\t\t\t\t\t1. 10" +
                                    "\n\t\t\t\t\t2. 20" +
                                    "\n\t\t\t\t\t3. 50" +
                                    "\n\t\t\t\t\t4. 100" +
                                    "\n\t\t\t\t\t5. Other" +
                                    "\n\t\t\t\t\t6. Back\n");
                                int cash = Console.ReadKey().KeyChar;
                                if (cash == '1')
                                {
                                    if (banks.banks[i].Clients[j].bankCards[card].Balance - 10 >= 0)
                                    {
                                        banks.banks[i].Clients[j].bankCards[card].Balance -= 10;
                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tYour cash is preparing...");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tGet your cash!");
                                    }
                                    else
                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tNot enough money in card!\n");
                                    Console.ReadKey();
                                    goto entered;
                                }
                                else if (cash == '2')
                                {
                                    if (banks.banks[i].Clients[j].bankCards[card].Balance - 20 >= 0)
                                    {
                                        banks.banks[i].Clients[j].bankCards[card].Balance -= 20;
                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tYour cash is preparing...");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tGet your cash!");
                                    }
                                    else
                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tNot enough money in card!\n");
                                    Console.ReadKey();
                                    goto entered;
                                }
                                else if (cash == '3')
                                {
                                    if (banks.banks[i].Clients[j].bankCards[card].Balance - 50 >= 0)
                                    {
                                        banks.banks[i].Clients[j].bankCards[card].Balance -= 50;
                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tYour cash is preparing...");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tGet your cash!");
                                    }
                                    else
                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tNot enough money in card!\n");
                                    Console.ReadKey();
                                    goto entered;
                                }
                                else if (cash == '4')
                                {
                                    if (banks.banks[i].Clients[j].bankCards[card].Balance - 100 >= 0)
                                    {
                                        banks.banks[i].Clients[j].bankCards[card].Balance -= 100;
                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tYour cash is preparing...");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tGet your cash!");
                                    }
                                    else
                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tNot enough money in card!\n");
                                    Console.ReadKey();
                                    goto entered;
                                }
                                else if (cash == '5')
                                {
                                    int userCash;
                                    Console.Clear();
                                    Console.WriteLine("Enter your cash : "); userCash = Convert.ToInt32(Console.ReadLine());
                                    if (banks.banks[i].Clients[j].bankCards[card].Balance - userCash >= 0)
                                    {
                                        banks.banks[i].Clients[j].bankCards[card].Balance -= userCash;
                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tYour cash is preparing...");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tGet your cash!");
                                    }
                                    else
                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tNot enough money in card!\n");
                                    Console.ReadKey();
                                    goto entered;
                                }
                                else if(cash == '6')
                                    goto entered;
                                else
                                    goto gettingCash;
                            }
                            else if (ch1 == '3')
                            {
                            enteringPAN:
                                Console.Clear();
                                List<string> SecondPan = new List<string>();
                                Console.WriteLine("\n\n\n\t\t\t\t\tEnter PAN (16) : ");
                                string b = "";
                                enteringPAN(ref SecondPan, ref b);
                                bool ptrue2 = true;
                                for (int ii = 0; ii < banks.banks.Count; ii++)
                                {
                                    for (int jj = 0; jj < banks.banks[ii].Clients.Count; jj++)
                                    {
                                        for (int card2 = 0; card2 < banks.banks[ii].Clients[jj].bankCards.Count; card2++)
                                        {
                                            for (int pp = 0; pp < 16; pp++)
                                            {
                                                if (SecondPan[pp].ToString() != banks.banks[ii].Clients[jj].bankCards[card2].PAN[pp].ToString())
                                                {
                                                    ptrue2 = false;
                                                    break;
                                                }
                                            }
                                            if (ptrue2)
                                            {
                                            sendingCash:
                                                Console.Clear();
                                                Console.WriteLine("\n\n\n\n\t\t\t\t\t1. 10" +
                                                    "\n\t\t\t\t\t2. 20" +
                                                    "\n\t\t\t\t\t3. 50" +
                                                    "\n\t\t\t\t\t4. 100" +
                                                    "\n\t\t\t\t\t5. Other" +
                                                    "\n\t\t\t\t\t6. Back\n");
                                                int cash = Console.ReadKey().KeyChar;
                                                if (cash == '1')
                                                {
                                                    if (banks.banks[i].Clients[j].bankCards[card].Balance - 10 >= 0)
                                                    {
                                                        banks.banks[i].Clients[j].bankCards[card].Balance -= 10;
                                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tYour cash is sending...");
                                                        Thread.Sleep(2000);
                                                        Console.Clear();
                                                        Console.WriteLine($"\n\n\n\n\t\t\t\t\t10$ sended to {banks.banks[ii].Clients[jj].bankCards[card2].Fullname}'s card");
                                                    }
                                                    else
                                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tNot enough money in card!");
                                                    Console.ReadKey();
                                                    goto entered;
                                                }
                                                else if (cash == '2')
                                                {
                                                    if (banks.banks[i].Clients[j].bankCards[card].Balance - 20 >= 0)
                                                    {
                                                        banks.banks[i].Clients[j].bankCards[card].Balance -= 20;
                                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tYour cash is sending...");
                                                        Thread.Sleep(2000);
                                                        Console.Clear();
                                                        Console.WriteLine($"\n\n\n\n\t\t\t\t\t20$ sended to {banks.banks[ii].Clients[jj].bankCards[card2].Fullname}'s card");
                                                    }
                                                    else
                                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tNot enough money in card!");
                                                    Console.ReadKey();
                                                    goto entered;
                                                }
                                                else if (cash == '3')
                                                {
                                                    if (banks.banks[i].Clients[j].bankCards[card].Balance - 50 >= 0)
                                                    {
                                                        banks.banks[i].Clients[j].bankCards[card].Balance -= 50;
                                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tYour cash is sending...");
                                                        Thread.Sleep(2000);
                                                        Console.Clear();
                                                        Console.WriteLine($"\n\n\n\n\t\t\t\t\t50$ sended to {banks.banks[ii].Clients[jj].bankCards[card2].Fullname}'s card");
                                                    }
                                                    else
                                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tNot enough money in card!");
                                                    Console.ReadKey();
                                                    goto entered;
                                                }
                                                else if (cash == '4')
                                                {
                                                    if (banks.banks[i].Clients[j].bankCards[card].Balance - 100 >= 0)
                                                    {
                                                        banks.banks[i].Clients[j].bankCards[card].Balance -= 100;
                                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tYour cash is sending...");
                                                        Thread.Sleep(2000);
                                                        Console.Clear();
                                                        Console.WriteLine($"\n\n\n\n\t\t\t\t\t100$ sended to {banks.banks[ii].Clients[jj].bankCards[card2].Fullname}'s card");
                                                    }
                                                    else
                                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tNot enough money in card!\n");
                                                    Console.ReadKey();
                                                    goto entered;
                                                }
                                                else if (cash == '5')
                                                {
                                                    int userCash;
                                                    Console.Clear();
                                                    Console.WriteLine("Enter your cash : "); userCash = Convert.ToInt32(Console.ReadLine());
                                                    if (banks.banks[i].Clients[j].bankCards[card].Balance - userCash >= 0)
                                                    {
                                                        banks.banks[i].Clients[j].bankCards[card].Balance -= userCash;
                                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tYour cash is sending...");
                                                        Thread.Sleep(2000);
                                                        Console.Clear();
                                                        Console.WriteLine($"\n\n\n\n\t\t\t\t\t{userCash}$ sended to {banks.banks[ii].Clients[jj].bankCards[card2].Fullname}'s card");
                                                    }
                                                    else
                                                        Console.WriteLine("\n\n\n\n\t\t\t\t\tNot enough money in card!\n");
                                                    Console.ReadKey();
                                                    goto entered;
                                                }
                                                else if (cash == '6')
                                                    goto entered;
                                                else
                                                    goto sendingCash;
                                            }
                                            else
                                                ptrue2 = true;
                                        }
                                    }
                                }
                                goto enteringPAN;
                            }
                            else if (ch1 == '4')
                                goto start;

                            break;
                        }
                        else
                            ptrue = true;
                    }
                }
            }
            goto start;

        }
        static void Main(string[] args)
        {
            process();
        }
    }
}
