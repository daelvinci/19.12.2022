using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Transactions;

namespace Car_class
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
    internal class Car
    {
        public string Brand;
        public string Model;
        public double CurrentFuel;
        public double FuelFor1Km;
        public double Millage;


        public void Drive(int Km)
        {
            if(CurrentFuel == 0 && FuelFor1Km == 0)
            {
                Console.WriteLine("Error 404 System Not Found!");
            }

            if (CurrentFuel / FuelFor1Km >= Km)
            {
                Millage += Km;
                CurrentFuel -= (Km * FuelFor1Km);
                Console.WriteLine("Mesafeni Gede Bilersiz");
            }
            else
            {
                Console.WriteLine("Error 404 System Not Found!");
            }
        }

    }
    
}
