using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Reflection;
using System.Xml.Linq;

namespace Chain
{

//Chain Hash Table
public class ChainHashTable<MyKey, MyValue>
{
    private const int defaultSize = 10;
    private const double thresholdLoadFactor = 1.5;
    private LinkedList<Node>[] myHashTable;


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
    public ChainHashTable()
    {
            myHashTable = new LinkedList<Node>[defaultSize];
    }

  

    

    //Insert with a specific key and value

    public void insert(MyKey key, MyValue value)
    {
        //find index
        int index = hashFunction(key);

        //If that index area is null then we create a space in there
        if (myHashTable[index] == null)
        {
                myHashTable[index] = new LinkedList<Node>();
        }

            //If key exist, we update it's value
            foreach (var node in myHashTable[index])
            {
                if (node.key != null)
                {
                    if (node.key.Equals(key))
                    {
                        node.value = value;
                        return;
                    }
                }
            }

            //If key doesn't exist, we add the node with specific key and value to the end of the index.
            myHashTable[index].AddLast(new Node(key, value));

            //Resize if capcity is over.
            rehashIfExceedCapacity();

    }

        //Get a specific value with specific key
    public MyValue get(MyKey key)
    {
        //find index
        int index = hashFunction(key);

            //Making sure the table isn't empty
            if (myHashTable[index] != null)
            {
            //Search for the node
            foreach (var node in myHashTable[index])
            {
                if (node.key != null)
                {
                    //Return the value if find
                    if (node.key.Equals(key))
                    {
                        return node.value;
                    }
                }
            }



        }

        //If not exist, exception will be throw
        throw new KeyNotFoundException($"Data not find with '{key}' given");
    }

        //Remove a element with speicific key
    public void remove(MyKey key)
    {
        int index = hashFunction(key);

        if (myHashTable[index] != null)
        {
                // Remove the node from the list
                foreach (Node node in myHashTable[index])
            {
                if (node.key != null)
                {
                    //Return the value if find
                    if (node.key.Equals(key))
                    {
                            myHashTable[index].Remove(node);
                            break;

                        }
                 }
            }
        }
    }
        //Helper Method
        //Convert key to array index
        private int hashFunction(MyKey key)
        {

            //Get rid of the null warning;
            if (key == null)
            {
                return 0;
            }

            return Math.Abs(key.GetHashCode()) % myHashTable.Length;
        }

        //Helper Method
        //If size is bigger then the LoadFactorThresHold then resize to two times.
        private void rehashIfExceedCapacity()
        {
            //Find total item added in table
            int count = 0;
            foreach (var block in myHashTable)
            {
                if (block != null)
                {
                    count += block.Count;

                }
            }

            //if count/myhashtable.length is bigger then the load factor, then we will have to resize
            if (thresholdLoadFactor < (double)count / myHashTable.Length)
            {
                int newSize = myHashTable.Length * 2;
                LinkedList<Node>[] newTable = new LinkedList<Node>[newSize];

                //Copy everything from old hashtable to new and rehash all item
                foreach (var block in myHashTable)
                {
                    if (block != null)
                    {
                        foreach (var node in block)
                        {
                            if (node.key != null)
                            {
                                int newIndex = Math.Abs(node.key.GetHashCode()) % newSize;

                                if (newTable[newIndex] == null)
                                {
                                    newTable[newIndex] = new LinkedList<Node>();
                                }


                                newTable[newIndex].AddLast(new Node(node.key, node.value));
                            }
                        }
                    }


                }
                myHashTable = newTable;

            }
        }


    }

}


