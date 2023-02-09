namespace PearlNeckles2023
// See https://aka.ms/new-console-template for more information
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Create a couple of Random pearls
            Console.WriteLine("Create a couple of Random pearls");
            Console.WriteLine(Pearl.Factory.CreateRandomPearl());
            Console.WriteLine(Pearl.Factory.CreateRandomPearl());

            //Create using empty constructor
            Console.WriteLine("\nCreate an empty pearl");
            Console.WriteLine(new Pearl());

            //Create a random Necklaces
            Console.WriteLine("\nCreate a random Necklaces");
            var necklace = Necklace.Factory.CreateRandomNecklace(35);
            Console.WriteLine(necklace);
            Console.WriteLine($"Nr of pearls: {necklace.Count()}");
            Console.WriteLine($"Nr of Freshwater pearls: {necklace.Count(PearlType.FreshWater)}");
            Console.WriteLine($"Nr of Saltwater pearls: {necklace.Count(PearlType.SaltWater)}");
            Console.WriteLine($"Price of the necklace: {necklace.Price}");

            Console.WriteLine("\nFor loop");
            for (int i = 0; i < necklace.Count(); i++)
            {
                Console.WriteLine(necklace[i]);
            }

            Console.WriteLine("\nFor each loop");
            foreach (var item in necklace)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(necklace.Sum(p => p.Price));


            var necklace10 = necklace.FindAllOfSize(10);
            Console.WriteLine(necklace10);

            /*
            //Sort the Necklace
            Console.WriteLine("\nSort the Necklace");
            necklace.Sort();
            Console.WriteLine(necklace);



            //Find a pearl, test by using a kown pearl
            Console.WriteLine("\nFind a pearl, test by using a kown pearl");
            var findPearl = necklace[23];
            Console.WriteLine($"Looking for Pearl:\n{findPearl}");
            int idx = necklace.IndexOf(findPearl);
            if (idx == -1)
            {
                Console.WriteLine("Could not find the pearl");
            }
            else
            {
                Console.WriteLine($"Pearl found in position {idx}");
            }
            
            
            
            //Find all 10mm pearls in a new necklace
            Console.WriteLine("\nFind all 10mm pearls in a new necklace");
            var necklace10 = necklace.FindAllOfSize(10);
            Console.WriteLine(necklace10);
            
            
            //Necklace written to file using Stream Adapter Layer
            Console.WriteLine("\nNecklace written to file using Stream Adapter Layer");
            var s = necklace.Write("Necklace.txt");
            Console.WriteLine(s);
            */

        }
    }
}