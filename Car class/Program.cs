using System;
using System.IO;

namespace Car_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Aşağıdaki parametrlərə sahib Car class yaradın
            //- Brand
            //- Model
            //- CurrentFuel - masinin hazirki benzin miqdari
            //- FuelFor1Km - masinin 1 km ucun xerclediyi benzin
            //- Millage - Masinin bu vaxtadək neçə km sürüldüyü
            //- Drive() - sürülmə metodu.Bu metod int parametr qeəbul edir (neçə km sürmək istədiyimiz)
            // Car obyekti yaradın drive metodunu işə saldıqda arqument olaraq neçə km sürmək istədyimizi daxil edirik 
            //    və əgər benzin kifayət edirsə maşının millage dəyəri və benzini azalır, benzin kifayət etmirsə console-da xəta mesajı yazılır
            //

            Car Lamborghini = new Car
            { 
                Brand="Lamborghini",
                Model="Huracan Evo",
                CurrentFuel=42,
                FuelFor1Km=3,
                Millage=87000,
            
            };
            Lamborghini.Drive(15);

        }
    }
}
