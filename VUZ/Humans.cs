using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUZ
{
    abstract class Humans
    {
        protected string[] FIO;
        protected string dr;

        public Humans(string[] FIO, string dr) 
        {
            this.FIO = FIO;
            this.dr = dr;
        }

        protected void Input() 
        {

            Console.Write("ФИО: ");
            FIO = Console.ReadLine().Split(' ');
            Console.Write("ДР: ");
            dr = Console.ReadLine();
        }

        protected void Output() 
        {
            foreach(string i in FIO)
            {
                Console.WriteLine(i + ' ');
            }
           // Console.WriteLine($"ДР: {dr} ");
        }
    }
}
