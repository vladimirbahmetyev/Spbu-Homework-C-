using System;

namespace Hw2_3
{
    public class HashTable
    {
        private const int sizeOfHashTable = 10000;

        private List[] hashTableElements;
        public HashTable()
        {
            hashTableElements = new List[sizeOfHashTable];

            for (var i = 0; i < sizeOfHashTable; ++i)
            {
                hashTableElements[i] = new List();
            }
        }

        private int HashFunction(string inputString)
        {
            int hash = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                hash = hash + inputString[i] * i + 1701;
            }
            return Math.Abs(hash) % sizeOfHashTable;
        }

        public bool IsElementInHashTable(string inputString)
        {
            return hashTableElements[HashFunction(inputString)].IsElementInList(inputString);
        }

        public void AddNewElementToHashTable(string inputString)
        {
            if (!IsElementInHashTable(inputString))
            {
                hashTableElements[HashFunction(inputString)].AddValueToPosition(inputString, 0);
            }
        }

        public void DeleteElementFromHashTable (string deleteString)
        {
            if (IsElementInHashTable(deleteString))
            {
                hashTableElements[HashFunction(deleteString)].DeleteElementFromList(deleteString);
            }
        }

    }
}
