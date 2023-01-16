using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Kolawole.Collection.Generic
{
    //public  class List : System.Collections.Generic.List<int>
    // {
    //     public void LinearSearch(int val)
    //     {
    //        foreach(int i in this)
    //         {
    //             if(i == val)
    //             {
    //                 Console.WriteLine("Found");
    //                 return;
    //             }
    //         }
    //         Console.WriteLine("Not Found");
    //     }
    // }

    public class List<T> : System.Collections.Generic.List<T>
    {
        public void LinearSearch(int val)
        {
            foreach (var i in this)
            {
                if (val.ToString() == i.ToString())
                {
                    Console.WriteLine("Foundd");
                    return;
                }
            }
            Console.WriteLine("Not Found");
        }
    }

    //This ClassUtils Allows us to call a method directly on an object 
    public static class ListUtils
    {
        public static void listmethod<T>(this List<T>list, int num)
        {
            foreach(var l in list)
            {
                Console.WriteLine(l + num.ToString());
            }
        }

        public static T returner<T>(this T myObj)
        {
            Console.WriteLine(myObj);
            return myObj;
        }
        public static int returnInt(this List<int> list)
        {
            Console.WriteLine(list[0]);
            return list[0];
        }
       +
    }
}
