using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    public abstract class Bank
    {
        public string Name { get; set; }
        public string SurnameName { get; set; }
        public string Code { get; set; }
        public string CvvCode { get; set; }
        public decimal Balance { get; set; }

        public Bank(string name, string surnameName, string code, string cvvCode, decimal balance)
        {
            Name = name;
            SurnameName = surnameName;
            Code = code;
            CvvCode = cvvCode;
            Balance = balance;
        }

        public abstract decimal Withdraw(decimal amount);
        public abstract decimal Deposit(decimal amount);

    }

    public class UniCard : Bank
    {
        public UniCard(string name, string surnameName, string code, string cvvCode, decimal balance) : base(name, surnameName, code, cvvCode, balance)
        {
            Name = name;
            SurnameName = surnameName;
            Code = code;
            CvvCode = cvvCode;
            Balance = balance;
        }

        public override decimal Deposit(decimal amount)
        {
            Balance += amount;
            return Balance;
        }

        public override decimal Withdraw(decimal amount)
        {
            Balance -= amount + (amount * (decimal)1.5);
            return Balance;

        }
    }

    public class Accessbank : Bank
    {
        public Accessbank(string name, string surnameName, string code, string cvvCode, decimal balance) : base(name, surnameName, code, cvvCode, balance)
        {
            Name = name;
            SurnameName = surnameName;
            Code = code;
            CvvCode = cvvCode;
            Balance = balance;
        }

        public override decimal Deposit(decimal amount)
        {
            Balance += amount;
            Balance -= amount * (decimal)0.3;
            return Balance;
        }

        public override decimal Withdraw(decimal amount)
        {
            Balance -= amount + (amount * (decimal)1.6);
            return Balance;
        }
    }


    public class PashaBank : Bank
    {
        public PashaBank(string name, string surnameName, string code, string cvvCode, decimal balance) : base(name, surnameName, code, cvvCode, balance)
        {
            Name = name;
            SurnameName = surnameName;
            Code = code;
            CvvCode = cvvCode;
            Balance = balance;
        }

        public override decimal Deposit(decimal amount)
        {
            Balance += amount;
            Balance -= amount * (decimal)0.6;
            return Balance;
        }

        public override decimal Withdraw(decimal amount)
        {
            Balance -= amount + (amount * (decimal)1.1);
            return Balance;
        }
    }

    public class LeoBank : Bank
    {
        public LeoBank(string name, string surnameName, string code, string cvvCode, decimal balance) : base(name, surnameName, code, cvvCode, balance)
        {
            Name = name;
            SurnameName = surnameName;
            Code = code;
            CvvCode = cvvCode;
            Balance = balance;
        }

        public override decimal Deposit(decimal amount)
        {
            Balance += amount;
            return Balance;
        }

        public override decimal Withdraw(decimal amount)
        {
            Balance -= amount;
            return Balance;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            UniCard uniCard = new UniCard("Vusal", "Zeynalov", "5959595959595959", "599", 50);
            Accessbank accessBank = new Accessbank("Vusal", "Zeynalov", "5959595959595959", "599", 30);
            PashaBank pashaBank = new PashaBank("Vusal", "Zeynalov", "5959595959595959", "599", 200);
            LeoBank leoBank = new LeoBank("Vusal", "Zeynalov", "5959595959595959", "599", 80);

            Console.WriteLine(accessBank.Deposit(10));
        }
    }
}



//Istediyim netice:
//2) Her 4 kart class-dan object yradib butov metodlarin duzgun ishleyib ishlememesini yoxlayirsiniz.
//3) Kartin xususiyyetleri kenardan teyin ola bilmesin.
//4) Kartin melumatlarini constructor terefinden teyin olunmasi.
