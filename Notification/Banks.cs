using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Banks
    {
        public List<Bank> banks = new List<Bank>();

        public void AddBank(Bank bank)
        {
            banks.Add(bank);
        }
        public List<Bank> GetBank() => banks;
        
        
        
    }

}
