using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesHashTable
{
    internal class DoubleHashingTable
    {
        private string[] hashTable;
        private int tableSize, hashValue;

        // Constructor
        public DoubleHashingTable(int tableSize, int hash)
        {
            //Write your code          
        }
        private int Hash1(int key)
        {
            return 0; //This is dummy code. Modify this and write your code
        }
        private int Hash2(int key)
        {
            return 0; //This is dummy code. Modify this and write your code
        }
        // Insert using linear probing
        public void Insert(string countryName, int key)
        {
            //Write your code
        }          
 
        // Search in hash table
        public int Search(string countryName, int key)
        {
            return 0; //This is dummy code. Modify this and write your code
        }
        //Search by name
        public int Search(string countryName)
        {

            return 0; //This is dummy code. Modify this and write your code
        }

        // Display hash table
        public void Display()
        {
            Console.WriteLine("Hash Table:");
            for (int i = 0; i < tableSize; i++)
            {
                if (hashTable[i] != null)
                    Console.WriteLine($"Index {i}: {hashTable[i]}");
                else
                    Console.WriteLine($"Index {i}: Empty");
            }
        }
        public void Display(int i)
        {
            Console.WriteLine(i + " th entry in Hash Table is: " + hashTable[i]);
        }
    }
}

