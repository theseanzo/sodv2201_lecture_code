using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_3_OOConcepts
{
    class BankAccount
    {
        public float amountInBank = 0.0f;
        public void addFunds(float amount)
        {
            this.amountInBank += amount;
        }
        public void removeFunds(float amount)
        {
            this.amountInBank -= amount;
        }
    }
    class SavingsAccount : BankAccount
    {

    }
}
