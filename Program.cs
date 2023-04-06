using System;
using System.Collections.Generic;
using System.Collections;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        { 
            ArrayList arList=new ArrayList();
            arList.Add("a");
            arList.Add("b");
            arList.Add(1);
            arList.Add(true);
            arList.Add(-1);
            arList.Add(3.5f);

            foreach(var x in arList){
                Console.WriteLine(x);
            }

        /*    arList.Sort(); // aynı tip element var ise çalışır (int)
            foreach(var x in arList){
                Console.WriteLine(x);
            }*/

            Console.WriteLine(arList.BinarySearch(1));
             Console.WriteLine("***********************************");

            string[] isimler={"Ali","Ahmet","Ayşe"};
            arList.AddRange(isimler);

            foreach(var x in arList){
                Console.WriteLine(x);
            }

            arList.Clear();
            Console.WriteLine("cap="+arList.Count);
        }

    }

}