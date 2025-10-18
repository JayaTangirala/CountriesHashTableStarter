using System.Diagnostics;

namespace CountriesHashTable
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[,] country = ReadFile.readCSV();
            
            Console.WriteLine("Linear Probing..........................................");
           /* LinearProbingHashTable countryTable1 = new LinearProbingHashTable(242,242);
            for (int i = 1; i < 242; i++)
            {
                //Console.WriteLine(country[i,0] +"\t"+ int.Parse(country[i,3]));               
                countryTable1.Insert(country[i,0], int.Parse(country[i,3]));
            }
            countryTable1.Display(0); //Mexico
            countryTable1.Display(241); //Falkland Islands (Malvinas)
            countryTable1.Display(52); //Barbados

            int index=countryTable1.Search("United Kingdom");
            if (index == -1)
                Console.WriteLine("United Kingdom not found");
            else 
                Console.WriteLine("United Kingdom is found at " + index); //UK is found at 100
           
            index = countryTable1.Search("United Kingdom",826); //Key of United Kingdom is 826 in the file
            if (index == -1)
                Console.WriteLine("United Kingdom not found");
            else
                Console.WriteLine("United Kingdom is found at " + index); //UK is found at 100
           */
            Console.WriteLine("Double Hashing..........................................");
           /* DoubleHashingTable countryTable2 = new DoubleHashingTable(242, 242);
            for (int i = 1; i < 242; i++)
            {
                //Console.WriteLine(country[i, 0] + "\t" + int.Parse(country[i, 3]));
                countryTable2.Insert(country[i, 0], int.Parse(country[i, 3]));
            }
            countryTable2.Display(0); //Mexico
            countryTable2.Display(241); //Equatorial Guinea
            countryTable2.Display(52); //Hong Kong S.A.R. China

            index = countryTable2.Search("United Kingdom");
            if (index == -1)
                Console.WriteLine("United Kingdom not found");
            else
                Console.WriteLine("United Kingdom is found at " + index); //UK is found at 100

            index = countryTable2.Search("United Kingdom", 826); //Key of United Kingdom is 826 in the file
            if (index == -1)
                Console.WriteLine("United Kingdom not found");
            else
                Console.WriteLine("United Kingdom is found at " + index); //UK is found at 100
           */
            Console.WriteLine("Chaining..........................................");
           /* ChainingHashTable countryTable3 = new ChainingHashTable(100, 100);
            for (int i = 1; i < 242; i++)
            {
                //Console.WriteLine(country[i, 0] + "\t" + int.Parse(country[i, 3]));
                countryTable3.Insert(country[i, 0], int.Parse(country[i, 3]));
            }
            countryTable3.Query();
           */
        }
    }
}