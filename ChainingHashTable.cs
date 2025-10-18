using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesHashTable
{
    internal class ChainingHashTable
    {
        private LinkedList<string>[] hashTable;
        private int tableSize, hashValue; 

        // Constructor
        public ChainingHashTable(int tableSize, int hash)
        {
            //Write your code
        }
        private int Hash(int key)
        {
            return 0; //This is dummy code. Modify this and write your code
        }
        // Insert using chaining
        public void Insert(string countryName, int key)
        {
            //Write your code           
        }

        // Search in hash table
        public int Search(string countryName, int key)
        {
            return 0; //This is dummy code. Modify this and write your code                      
        }

        // Search in hash table
        public int Search(string countryName)
        {
            return 0; //This is dummy code. Modify this and write your code
        }

        // Display hash table
        public void Query()
        {
            //Write your code
        }

        // Display hash table
        public void Display()
        {
            Console.WriteLine("Hash Table:");

            for (int i = 0; i < tableSize; i++)
            {
                Console.Write($"Index {i}: ");
                if (hashTable[i] == null)
                    Console.WriteLine("Empty");
                else
                {
                    foreach (string item in hashTable[i])
                        Console.Write(item + " -> ");
                    Console.WriteLine("null");
                }
            }
        }

        // Display hash table
        public void Display(int i)
        {
            Console.WriteLine(i+" th entry in Hash Table :");            
            Console.Write($"Index {i}: ");
            if (hashTable[i] == null)
                Console.WriteLine("Empty");
            else
            {
                    foreach (string item in hashTable[i])
                        Console.Write(item + " -> ");
                    Console.WriteLine("null");
            }
            
        }
    }

    
}

