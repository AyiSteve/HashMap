using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Markup;

namespace Prob

{
    //Chain Hash Table

    public class ProbHashTable<MyKey, MyValue>
    {
        private const double thresholdLoadFactor = 0.75;
        private const int defaultSize = 10;

        private Node[] myHashTable;

        //Inner Class
        private class Node
        {
            public MyKey key { get; }
            public MyValue value { get; set; }

            public Node(MyKey Key, MyValue Value)
            {
                key = Key;
                value = Value;
            }
        }

        //Default everything

        public ProbHashTable()
        {
            myHashTable = new Node[defaultSize];

        }
        //Insert  a specific key and value
        public void insert(MyKey key,MyValue value)
        {
            //find index

            int index = hashFunction(key, myHashTable.Length);

            int tempIndex = ifExist(index, key);

            // Key already exists, update the value
            if (tempIndex != -1)
            {
                myHashTable[tempIndex].value = value;
                return;
            }

            //If that index area is null then we have to find a space that's not occupied

            while (myHashTable[index] != null)
            {
                index = (index + 1) % myHashTable.Length;

            }

            myHashTable[index] = new Node(key, value);

            rehashIfExceedCapacity();
        }

        //Find the value with specific key
        public MyValue get(MyKey key)
        {
            //get index
            int index = hashFunction(key,myHashTable.Length);
            //check if exist
            index = ifExist(index, key);

            // Key already exists, return the value
            if (index != -1)
            {
                return myHashTable[index].value;
            }

            throw new KeyNotFoundException($"Data not find with '{key}' given");
        }

        //Remove the element with specific ket
        public void remove(MyKey key)
        {
            int index = hashFunction(key, myHashTable.Length);
            index = ifExist(index, key);

            // Key already exists, set the element to null.
            if (index != -1)
            {
                myHashTable[index] = null;
                return;
            }
        }
        //Helper Method

        //find a value with specific index
        private int ifExist(int index, MyKey key)
        {
            while (myHashTable[index] != null)
            {
                if (myHashTable[index].key.Equals(key))
                {
                    // Key already exists, update the value
                    return index;
                }

                index = (index + 1) % myHashTable.Length;
            }

            return -1;

        }

        //Find Index
        private int hashFunction(MyKey key, int size)
        {
            //Get rid of the null warning;
            if (key == null)
            {
                return 0;
            }

            return Math.Abs(key.GetHashCode()) % size;
        }

        //Expand Size
        private void rehashIfExceedCapacity()
        {
            int count = 0;
            foreach (Node occupied in myHashTable)
            {
                if (occupied != null)
                {
                        count++;

                }

            }

            if ((double)count / myHashTable.Length > thresholdLoadFactor)
            {
                int newSize = myHashTable.Length * 2;
                Node[] newHashTable = new Node[newSize];
                for (int i =0; i< myHashTable.Length; i++)
                {
                    if (myHashTable[i] != null)
                    {
                        int newIndex = hashFunction(myHashTable[i].key, newSize);

                        while (newHashTable[newIndex] != null)
                        {
                            newIndex = (newIndex + 1) % newSize;
                        }

                        newHashTable[newIndex] = myHashTable[i];
                    }
                }
                myHashTable = newHashTable;
            }

        }

    }
}
