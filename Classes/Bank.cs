
namespace BankApp.Classes
{
    class Bank
    {
        public string BankNomi { get; private set; } 
        public List<Mijoz> Mijozlar { get; private set; } 

        public Bank(string banknomi)
        {
            BankNomi = banknomi;
            Mijozlar = new List<Mijoz>();
        }

        public void MijozQoshish(Mijoz mijoz)
        {
            Mijozlar.Add(mijoz); 
            Console.WriteLine($"{mijoz.Ism} {BankNomi}ning mijoziga aylandi");    
        }

        public void BarchaMijozlar()
        {
            Console.WriteLine($"Bank: {BankNomi} - Mijozlar ro'yxati:");
            foreach (var mijoz in Mijozlar)
            {
                mijoz.Hisoblarnikorsatish();
            }
        }

       
    }    

}