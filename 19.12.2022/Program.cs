using System;
using System.Reflection.Metadata;

namespace _19._12._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            1 - ci tapşırıqda yaratdığınız Notebook classindan bir notebook array - i duzeldin
            //   Layihə işə düşdükdə bizdən minPrice dəyəri daxil etməyimizi və daha sonra maxPrice dəyəri daxil etməyimizi istəsin.
            //Daha sonra yaratmış olduğumuz array - də minPrice və maxPrice aralığında qiyməti olan notebookların adlarını console - a yazdırsız

            Console.WriteLine("Minimum qiymeti daxil edin!");
            string MinPriceStr = Console.ReadLine();
            int MinPrice = Convert.ToInt32(MinPriceStr);

            Console.WriteLine("Maximum qiymeti daxil edin!");
            string MaxPriceStr = Console.ReadLine();
            int MaxPrice = Convert.ToInt32(MaxPriceStr);

            Notebook Asus = new Notebook();
            Asus.Price = 3000;
            Asus.Name = "Asus Xtr";
            Asus.Brand = "Asus";

            Notebook Intel = new Notebook
            {
                Price = 1200,
                Name = "Intel RPX",
                Brand= "Intel"
            };


            Notebook Hp = new Notebook
            {
                Price = 2090,
                Name = "Hp 700",
                Brand = "Hp"
            };

            Notebook Sony = new Notebook
            {
                Price = 5700,
                Name = "Sony oavio",
                Brand = "Sony"
            };
            Notebook Acer = new Notebook
            {
                Price = 2800,
                Name= "Acer Wind",
                Brand= "Acer"
            };

            Notebook[] Notbuklar = new Notebook[] { Acer, Sony, Hp, Asus };


            for (int i = 0; i < Notbuklar.Length; i++)
            {
                if (Notbuklar[i].Price >= MinPrice && Notbuklar[i].Price <= MaxPrice)
                {
                    Console.WriteLine($"Notbuk: {Notbuklar[i].Name}  Qiymeti: {Notbuklar[i].Price}");
                }
            }

        }


    }
}
