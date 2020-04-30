using System;

namespace MobilePhone
{
    class Program
    {
        static void Main(string[] args)
        {
            MobilePhone mph = new MobilePhone("Galaxy", "Samsung", 465, "Hristiyan Nikolov");
            
            string brand = "";
            string model = "";
            double price = 0;
            string owner = "";

            Console.Write("Devices count: ");
            int count = int.Parse(Console.ReadLine());

            MobilePhone[] mphTest = new MobilePhone[count];
            int[] arrTest = { 5, 43, 20 };

            for (int i = 0; i < mphTest.Length; i++)
            {
                Console.Write("Brand: ");
                brand = Console.ReadLine();

                Console.Write("Model: ");
                model = Console.ReadLine();

                Console.Write("Price: ");
                price = double.Parse(Console.ReadLine());

                Console.Write("Owner: ");
                owner = Console.ReadLine();

                mphTest[i] = MobilePhoneTest.CreatePhone(brand, model, price, owner);
            }

            for (int i = 0; i < mphTest.Length; i++)
            {
                Console.WriteLine($"Phone №{i + 1}");
                mphTest[i].PrintInfo();
                Console.WriteLine();
            }


            MobilePhone galaxyS2 = new MobilePhone("Samsung", "Galaxy S II Plus", 439);




            galaxyS2.MakeCall("George", 3, 25);

            galaxyS2.MakeCall("Amanda", 12, 32);

            galaxyS2.ViewCallHistory();

            galaxyS2.GetSum(0.24m);
        }
    }
}
