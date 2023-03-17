using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VUZ
{
    internal class Educator:Humans
    {
        private string department;
        private List<string> discipline;

        public Educator(string[] FIO, string dr, string department, List<string> discipline) : base(FIO, dr)
        {
            this.discipline = discipline;
            this.department = department;

            //Input();
            //Console.Write("Кафедра: ");
            //department = Console.ReadLine();

            //discipline= new List<string>();

            //int n = 0;
            //Console.Write("Введите кол-во дисциплин: ");
            //int count_disc = int.Parse(Console.ReadLine());          

            //do
            //{
            //    Console.Write($"Дисциплина {++n}: ");
            //    string disc = Console.ReadLine();

            //    discipline.Add(disc);


            //} while (n != count_disc);

        }

        public string get_Department() 
        {
            return department;
        }

        public void show()
        {
            Output();
            Console.WriteLine($"department - {department}");

        }

        public string[] get_FIO() 
        {
            return FIO;
        }

        public List<string> get_discipline()
        {
            return discipline;
        }

    }
}
