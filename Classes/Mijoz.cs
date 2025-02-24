namespace BankApp.Classes
{
    public class Mijoz : Umumiy
    {
        public int MijozID { get; private set; }
        public List<Hisobraqam> Hisoblar{ get; private set; }

        public Mijoz(string ism, string manzil, int mijozID) : base(ism, manzil)
        {
            MijozID = mijozID;
            Hisoblar = new List<Hisobraqam>();
        }
        public void HisobAdd(Hisobraqam hisob)
        {
            Hisoblar.Add(hisob);
        }
       public void Hisoblarnikorsatish() 
       {
        Console.WriteLine($"Mijoz: {Ism} ({MijozID}) - Hisoblar:");
        foreach ( var acc in Hisoblar)
        {
            Console.WriteLine($"Hisob raqami: {acc.Bankhisobi} Balans: {acc.Balans} so'm");
        }
       }

    }
} 