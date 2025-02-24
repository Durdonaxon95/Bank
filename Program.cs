using System;
using BankApp.Classes;
namespace BankApp.Classes
{
    class Program
    {
        static void Main()
        {
            Bank myBank = new Bank("O'zbekiston Milliy Banki");

            Mijoz mijoz1 = new Mijoz("Qilichova Durdona", "Samarqand viloyati", 101);
            Mijoz mijoz2 = new Mijoz("Malikov Fayozxon", "Samarqand viloyati", 102);
            Mijoz mijoz3 = new Mijoz("Karimov Alisher", "Toshkent shahri", 103);

            Hisobraqam acc1 = new Hisobraqam(1001, 1000000);
            Hisobraqam acc2 = new Hisobraqam(1002, 150000);
            Hisobraqam acc3 = new Hisobraqam(1003, 200000);

            mijoz1.HisobAdd(acc1);
            mijoz1.HisobAdd(acc2);
            mijoz2.HisobAdd(acc3);
             
            Hisobraqam acc4 =new Hisobraqam(1004,750000); 
            mijoz3.HisobAdd(acc4);

            myBank.MijozQoshish(mijoz1);
            myBank.MijozQoshish(mijoz2);
            myBank.MijozQoshish(mijoz3);
            

            myBank.BarchaMijozlar();

            acc1.Deposit(250000);
            acc1.Pulyechish(10000);
            acc2.Deposit(10000);
            acc3.Pulyechish(20000);

            myBank.BarchaMijozlar();

        }
    }
}