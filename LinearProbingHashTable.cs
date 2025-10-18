using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesHashTable
{
    internal class LinearProbingHashTable
    {
        private string[] hashTable;
        private int tableSize, hashValue; 

        // Constructor
        public LinearProbingHashTable(int tableSize,int hash)
        {            
            //Write your code here
        }
        private int Hash(int key)
        {

            return 0; //This is dummy code. Modify this and write your code
        }
        // Insert using linear probing
        public void Insert(string countryName, int key)
        {

            //Write your code here
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
            //Write your code
        }
        public void Display(int i)
        {
            Console.WriteLine(i+" th entry in Hash Table is: " + hashTable[i]);            
        }
    }
}
