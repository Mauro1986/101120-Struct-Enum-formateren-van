using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum WorkingDays
    { 
    Monday,  //0                                                                            //Al deze dagen zijn Integers (geen strings)
    Thuesday,//1
    Wednesday=3,      //2   //je kan adres zelf kiezen (vb om 0 weg te laten en vanaf 1 beginnen tellen)(
    Thurseday,//3           // word 4
    Friday//4               // word 5
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region ENUMMERATIE
            //WorkingDays d = (WorkingDays)1;
            //Console.WriteLine(d);

            //WorkingDays d = WorkingDays.Wednesday;
            //Console.WriteLine(d);


            //WorkingDays a = WorkingDays.Friday;
            //Console.WriteLine((int)a);


            foreach (int i in Enum.GetValues(typeof(WorkingDays)))              //Enum.GetValues(typof     Toont alle plaatsen 0,1,2,3,4(int)     ENUMARATE VALUES
            {
                Console.WriteLine(i);
            }

            foreach (string j in Enum.GetNames(typeof(WorkingDays)))            //Enum.GetNames(typeof     Toont alle dagen(strings)                ENUMARATE NAMES
            {
                Console.WriteLine(j);
            }
            #endregion


            Console.WriteLine("Select day please");
            WorkingDays d = WorkingDays.Thuesday;

            int naam = (int)d;
            Console.WriteLine();
        }
    }
}
