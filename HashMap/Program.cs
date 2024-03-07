using System;
using System.Collections.Generic;
using Chain;
using Prob;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    public static void testChain()
    {
        Console.WriteLine("--------------------ChainingHashTable test (Phone Book)--------------------");
        ChainHashTable<string, string> chainTest = new ChainHashTable<string, string>();
        Console.WriteLine("chainHashTable Created \n \n \n");


        Console.WriteLine("--------------------Testing Insert Method--------------------");
        chainTest.insert("John Smith", "521-8976");
        Console.WriteLine("John Smith Added");
        chainTest.insert("Lisa Smith", "521-1234");
        Console.WriteLine("Lisa Smith Added");
        chainTest.insert("Sandra Dee", "521-9655");
        Console.WriteLine("Sandra Dee Added");
        chainTest.insert("Din Tai Fung", "698-1095");
        Console.WriteLine("Din Tai Fung Added");
        chainTest.insert("McDonald's", "641-5181");
        Console.WriteLine("McDonald's Added");
        chainTest.insert("Kizuki", "406-7926");
        Console.WriteLine("Kizuki Added");
        chainTest.insert("Burger King", "746-0336");
        Console.WriteLine("Burger King Added");
        chainTest.insert("Walmart", "925-6278");
        Console.WriteLine("Walmart Added");
        chainTest.insert("Happy Lemon", "453-5352");
        Console.WriteLine("Happy Lemon Added");
        chainTest.insert("Emergency Phone Number", "911");
        Console.WriteLine("Emergency Phone Number Added");
        chainTest.insert("Random Number1", "888-8888");
        Console.WriteLine("Random Number1 Added");
        chainTest.insert("Random Number2", "999-9999");
        Console.WriteLine("Random Number2 Added");
        chainTest.insert("Love Zhou", "520-1314");
        Console.WriteLine("Love Zhou Added");

        Console.WriteLine("\n \n \n --------------------Testing Get Method--------------------");
        Console.WriteLine("Get Kizuki's Phone Number: " + chainTest.get("Kizuki"));
        Console.WriteLine("Get Emergency's Phone Number Phone Number: " + chainTest.get("Emergency Phone Number"));
        Console.WriteLine("Get Walmart's Phone Number: " + chainTest.get("Walmart"));
        Console.WriteLine("Get Din Tai Fung's Phone Number: " + chainTest.get("Din Tai Fung"));
        Console.WriteLine("Get Lisa Smith's Phone Number: " + chainTest.get("Lisa Smith"));

        Console.WriteLine("\n \n \n --------------------Updating Exists Number--------------------");
        chainTest.insert("Kizuki", "111-1111");
        Console.WriteLine("Kizuki Updated");
        Console.WriteLine("Get Kizuki's Phone Number: " + chainTest.get("Kizuki"));
        chainTest.insert("Din Tai Fung", "333-3333");
        Console.WriteLine("Din Tai Fung Updated");
        Console.WriteLine("Get Din Tai Fung's Phone Number: " + chainTest.get("Din Tai Fung"));
        chainTest.insert("Lisa Smith", "555-5555");
        Console.WriteLine("Lisa Smith Updated");
        Console.WriteLine("Get Lisa Smith's Phone Number: " + chainTest.get("Lisa Smith"));



        Console.WriteLine("\n \n \n --------------------Testing Remove Method--------------------");
        chainTest.remove("Kizuki");
        Console.WriteLine("Kizuki Removed");
        chainTest.remove("Happy Lemon");
        Console.WriteLine("Happy Lemon Removed");
        chainTest.remove("Random Number");
        Console.WriteLine("Random Number Removed");
        chainTest.remove("John Smith");
        Console.WriteLine("John Smith Removed");


        Console.WriteLine("\n \n \n --------------------Get Element That's Removed (Should Throw Exception But was catched)--------------------");
        Console.WriteLine("Call Get Method for Kizuki");
        try
        {
            Console.WriteLine("Get Kizuki's Phone Number: " + chainTest.get("Kizuki"));
            return;
        }
        catch (Exception e)
        {
            Console.WriteLine("Can't find Kizuki");
        }
        Console.WriteLine("Call Get Method for Happy Lemon");
        try
        {
            Console.WriteLine("Get Happy Lemon Phone Number: " + chainTest.get("Happy Lemon"));
            return;  
        }
        catch (Exception e)
        {
            Console.WriteLine("Can't find Happy Lemon");
        }

        Console.WriteLine("\n \n \n --------------------Chaining Hash Table Test Ends--------------------");
    }

    public static void testProb()
    {
        Console.WriteLine("--------------------ProbingHashTable test (Phone Book)--------------------");
        ProbHashTable<string, string> probTest = new ProbHashTable<string, string>();
        Console.WriteLine("chainHashTable Created \n \n \n");


        Console.WriteLine("--------------------Testing Insert Method--------------------");
        probTest.insert("John Smith", "521-8976");
        Console.WriteLine("John Smith Added");
        probTest.insert("Lisa Smith", "521-1234");
        Console.WriteLine("Lisa Smith Added");
        probTest.insert("Sandra Dee", "521-9655");
        Console.WriteLine("Sandra Dee Added");
        probTest.insert("Din Tai Fung", "698-1095");
        Console.WriteLine("Din Tai Fung Added");
        probTest.insert("McDonald's", "641-5181");
        Console.WriteLine("McDonald's Added");
        probTest.insert("Kizuki", "406-7926");
        Console.WriteLine("Kizuki Added");
        probTest.insert("Burger King", "746-0336");
        Console.WriteLine("Burger King Added");
        probTest.insert("Walmart", "925-6278");
        Console.WriteLine("Walmart Added");
        probTest.insert("Happy Lemon", "453-5352");
        Console.WriteLine("Happy Lemon Added");
        probTest.insert("Emergency Phone Number", "911");
        Console.WriteLine("Emergency Phone Number Added");
        probTest.insert("Random Number1", "888-8888");
        Console.WriteLine("Random Number1 Added");
        probTest.insert("Random Number2", "999-9999");
        Console.WriteLine("Random Number2 Added");
        probTest.insert("Love Zhou", "520-1314");
        Console.WriteLine("Love Zhou Added");

        Console.WriteLine("\n \n \n --------------------Testing Get Method--------------------");
        Console.WriteLine("Get Kizuki's Phone Number: " + probTest.get("Kizuki"));
        Console.WriteLine("Get Emergency's Phone Number Phone Number: " + probTest.get("Emergency Phone Number"));
        Console.WriteLine("Get Walmart's Phone Number: " + probTest.get("Walmart"));
        Console.WriteLine("Get Din Tai Fung's Phone Number: " + probTest.get("Din Tai Fung"));
        Console.WriteLine("Get Love Zhou's Phone Number: " + probTest.get("Love Zhou"));

        Console.WriteLine("\n \n \n --------------------Updating Exists Number--------------------");
        probTest.insert("Kizuki", "111-1111");
        Console.WriteLine("Kizuki Updated");
        Console.WriteLine("Get Kizuki's Phone Number: " + probTest.get("Kizuki"));
        probTest.insert("Din Tai Fung", "333-3333");
        Console.WriteLine("Din Tai Fung Updated");
        Console.WriteLine("Get Din Tai Fung's Phone Number: " + probTest.get("Din Tai Fung"));
        probTest.insert("Lisa Smith", "555-5555");
        Console.WriteLine("Lisa Smith Updated");
        Console.WriteLine("Get Lisa Smith's Phone Number: " + probTest.get("Lisa Smith"));



        Console.WriteLine("\n \n \n --------------------Testing Remove Method--------------------");
        probTest.remove("Kizuki");
        Console.WriteLine("Kizuki Removed");
        probTest.remove("Happy Lemon");
        Console.WriteLine("Happy Lemon Removed");
        probTest.remove("Random Number");
        Console.WriteLine("Random Number Removed");
        probTest.remove("John Smith");
        Console.WriteLine("John Smith Removed");


        Console.WriteLine("\n \n \n --------------------Get Element That's Removed (Should Throw Exception But was catched)--------------------");
        Console.WriteLine("Call Get Method for Kizuki");
        try
        {
            Console.WriteLine("Get Kizuki's Phone Number: " + probTest.get("Kizuki"));
            return;
        }
        catch (Exception e)
        {
            Console.WriteLine("Can't find Kizuki");
        }
        Console.WriteLine("Call Get Method for Happy Lemon");
        try
        {
            Console.WriteLine("Get Happy Lemon Phone Number: " + probTest.get("Happy Lemon"));
            return;
        }
        catch (Exception e)
        {
            Console.WriteLine("Can't find Happy Lemon");
        }

        Console.WriteLine("\n \n \n --------------------Probing Hash Table Test Ends--------------------");
    }

    public static void Main()
    {
        testChain();
        Console.WriteLine("\n \n \n");

        testProb();




    }
}

