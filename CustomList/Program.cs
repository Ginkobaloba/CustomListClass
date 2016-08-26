using System;

namespace CustomList
{
    class Program
    {
        static void Main()
        {
            
            GenericList<string> alphabet = new GenericList<string>();
            GenericList<string> addedList = new GenericList<string>();
            GenericList<int> subtractedList = new GenericList<int>();
            GenericList<int> zippedList = new GenericList<int>();
            GenericList<int> testList = new GenericList<int>();
            GenericList<int> testList2= new GenericList<int>();


            for (int i = 0; i < 10; i++)
            {
                testList.AddToList(2);
                testList.AddToList(1);
                testList.AddToList(3);
                testList.AddToList(2);

                testList2.AddToList(1);
                testList2.AddToList(2);
                testList2.AddToList(3);


            alphabet.AddToList("NOSE");
            alphabet.AddToList("OLD");
            alphabet.AddToList("POTATO");
            alphabet.AddToList("QUIL");
            alphabet.AddToList("RABBIT");
            alphabet.AddToList("SNAIL");
            alphabet.AddToList("TURTLE");
            alphabet.AddToList("UMBRELLA");
            alphabet.AddToList("VOLE");
            alphabet.AddToList("WOLF");
            alphabet.AddToList("XYLOPHONE");
            alphabet.AddToList("YAWN");
            alphabet.AddToList("ZEBRA");
            alphabet.AddToList("ANIMAL");
            alphabet.AddToList("BEAVER");
            alphabet.AddToList("COW");
            alphabet.AddToList("DOG");
            alphabet.AddToList("ELEPHANT");
            alphabet.AddToList("FARM");
            alphabet.AddToList("GARY");
            alphabet.AddToList("HOWARD");
            alphabet.AddToList("ISRAEL");
            alphabet.AddToList("JIMMY");
            alphabet.AddToList("KOHLS");
            alphabet.AddToList("LEMON");
            alphabet.AddToList("MANDRIN");
        }

            alphabet.SortThisList();
            testList.SortThisList();

            testList.SortThisList();
            alphabet.PrintArray();

            testList.ConvertToString();
            testList2.ConvertToString();

            testList.RemoveFromListByValue(2);
            testList2.RemoveFromListByValue(1);

            testList.PrintArray();
            testList2.PrintArray();

            testList.ConvertToString();
            testList2.ConvertToString();

            addedList = testList + testList2;
            addedList.PrintArray();

            subtractedList = testList - testList2;
            subtractedList.PrintArray();

            zippedList = testList2.Zip(testList, testList2);
            zippedList.PrintArray();


            Console.ReadLine();
        }
    }
}
    

