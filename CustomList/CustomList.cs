using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class GenericList<T> : IEnumerable<T>, IComparable<T>
    {
        T[] List;
        int length;
       

        public GenericList()
        {
            this.List = new T[0];
            this.length = 0;
        }

        public void AddToList(T ItemtoAdd)
        {
            T[] temporaryList = new T[List.Length + 1];

            for (int i = 0; i < List.Length; i++)
            {
                temporaryList[i] = List[i];
            }

            temporaryList[List.Length] = ItemtoAdd;
            List = temporaryList;

            this.length++;

        }
        public void RemoveFromListByIndex(int IndexToRemove)
        {
            int a = 0;
            T[] temporaryList = new T[List.Length - 1];
            for (int i = 0; i < List.Length; i++)
            {
                if (i != IndexToRemove)
                {
                    temporaryList[a] = List[i];
                    a++;
                }
            }
            length--;
            List = temporaryList;
        }
        public void RemoveAllFromListByValue(T itemToRemove)
        {
            int indexToRemove;

            for (int i = 0; i < List.Length; i++)
            {
                if (List[i].Equals(itemToRemove))
                {
                    indexToRemove = i;
                    RemoveFromListByIndex(indexToRemove);
                    RemoveAllFromListByValue(itemToRemove);
                }
            }
        }
        public void RemoveFromListByValue(T itemToRemove)
        {
            int indexToRemove;

            for (int i = 0; i < this.length; i++)
            {
                if (List[i].Equals(itemToRemove))
                {
                    indexToRemove = i;
                    RemoveFromListByIndex(indexToRemove);
                    break;
                }
            }
        }
        public void Count()
        {
            Console.WriteLine(List.Length);
        }
        public void PrintArray()
        {
            for (int i = 0; i < List.Length; i++)
            {
                Console.WriteLine(List[i]);
            }
        }
        public void ConvertToString()
        {
            string convertedString = "";

            for (int i = 0; i < List.Length; i++)
            {
                convertedString = convertedString + Convert.ToString(List[i]);
            }
            PrintConvertedString(convertedString);
        }
        public void PrintConvertedString(string convertedString)
        {
            Console.WriteLine(convertedString);
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < List.Length; i++)
            {
                yield return List[i];
            }
        }
        public static GenericList<T> operator -(GenericList<T> t1, GenericList<T> t2)
        {

                for (int a = 0; a < t2.length; a++)
                {

                        t1.RemoveFromListByValue(t2.List[a]);
                }

            return t1;
        }
        public static GenericList<string> operator +(GenericList<T> t1, GenericList<T> t2)
        {
            string temporaryVariable;
            GenericList<string> temporaryList = new GenericList<string>();

            if (t1.length >= t2.length)
            {

                for (int i = 0; i < t2.length; i++)
                {
                    temporaryVariable = String.Format("{0}{1}", t1.List[i], t2.List[i]);
                    temporaryList.AddToList(temporaryVariable);
                }
                for (int i = t2.length; i < t1.length; i++)
                {
                    temporaryList.AddToList(String.Format("{0}", t1.List[i]));
                }
            }
            else
            {
                for (int i = 0; i < t1.length; i++)
                {
                    temporaryVariable = String.Format("{0}{1}", t1.List[i], t2.List[i]);
                    temporaryList.AddToList(temporaryVariable);
                }
                for (int i = t1.length; i < t2.length; i++)
                {
                    temporaryList.AddToList(String.Format("{0}", t2.List[i]));
                }
            }

            return temporaryList;
        }


        public GenericList<T> Zip(GenericList<T> t1, GenericList<T> t2)
        {
            GenericList<T> ZippedList = new GenericList<T>();

            if (t1.length > t2.length)
            {

                for (int i = 0; i < t2.length; i++)
                {
                    ZippedList.AddToList(t1.List[i]);
                    ZippedList.AddToList(t2.List[i]);
                }
                for (int i = t2.length; i < t1.length; i++)
                {
                    ZippedList.AddToList(t1.List[i]);
                }
            }
            else
            {
                for (int i = 0; i < t1.length; i++)
                {
                    ZippedList.AddToList(t1.List[i]);
                    ZippedList.AddToList(t2.List[i]);
                }
                for (int i = t1.length; i < t2.length; i++)
                {
                    ZippedList.AddToList(t2.List[i]);
                }
            }
            return ZippedList;
        }
    
    public GenericList<T> SortThisList()
    {
            GenericList<T> SortedList = new GenericList<T>();

            dynamic reset = 0;

            for (int i = 0; i < List.Length; i++)
            {
                for (int a = 0; a < List.Length - 1; a++)
                {
                    if (Comparer.Default.Compare(List[a], List[a + 1]) > 0)
                    {
                        reset = List[a + 1];
                        List[a + 1] = List[a];
                        List[a] = reset;
                    }
                }
            }
                for (int b = 0; b < List.Length; b++)
                    SortedList.AddToList(List[b]);
                return SortedList;
            

    //GenericList<T> sortedList = new GenericList<T>();
            

    //var ToBeSorted = from a in this.List
    //                 orderby a
    //                 select a;

    //foreach (T index in ToBeSorted)
    //{
    //    int i = 0;
    //    sortedList.AddToList(index);
    //    i++;
    //}


    //return sortedList;

    ////Array.Sort<T>(this.List);
    }

   //public GenericList<T> MakeAListSortableFirstStep()
   //     

IEnumerator IEnumerable.GetEnumerator()
{
    for (int i = 0; i < List.Length; i++)
    {
        yield return List[i];

    }
}
public bool CompareTo(T t1, T t2)
{
            int int1;
            int int2;

            if (int.TryParse(t1.ToString(), out int1) && int.TryParse(t2.ToString(), out int2))
            {

                if (int1 > int2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            //return t1.ToString().CompareTo(ToString());
        }

        public int CompareTo(T other)
        {
            int int1;
            int int2;
            string string1;
            string string2;


            if (int.TryParse(this.ToString(), out int1) && int.TryParse(other.ToString(), out int2))
            {

                if (int1 > int2)
                {
                    return 1;
                }
                else if (int1 == int2)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                string1 = this.ToString();
                string2 = other.ToString();

                return string1.CompareTo(string2);

            }
        }
    }
}

