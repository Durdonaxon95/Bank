namespace BankApp.Classes
{
    public class Hisobraqam
    {
        public int Bankhisobi { get;  private set; }
        public decimal Balans { get; private set; }
         
        public Hisobraqam(int bankhisobi, decimal dastlabkibalans)
        {
            Bankhisobi = bankhisobi;
            Balans = dastlabkibalans;
        }
        public void Deposit(decimal amount)
        {
            Balans += amount;
            Console.WriteLine($"Hisob raqami {Bankhisobi}: {amount} so'm kiritildi.\nYangi balans: {Balans} so'm");
            
        }
        public bool Pulyechish(decimal amount)
        {
            if(amount > Balans)
            {
                Console.WriteLine($"Hisob raqami {Bankhisobi}: {amount} so'm yechib bo'lmaydi.\nBalans yetarli emas.");
                return false;
            }
            else
            {
                Balans -= amount;
                Console.WriteLine($"Hisob raqami {Bankhisobi}: {amount} so'm yechildi.\nYangi balans: {Balans} so'm");
                return true;
            }
        }
    }
}