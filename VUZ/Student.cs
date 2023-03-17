using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VUZ
{
    internal class Student : Humans
    {
        private string groupe;
        private Dictionary<string, int> marks;
        public Student(string[] FIO, string dr, string groupe, Dictionary<string, int> marks): base(FIO, dr)
        {
            this.groupe = groupe;
            this.marks = marks;

            /*Input();
            Console.Write("Группа: ");
            groupe = Console.ReadLine();

            int n = 0;
            Console.Write("Введите кол-во дисциплин: ");
            int count_disc = int.Parse(Console.ReadLine());

            marks = new Dictionary<string, int[]>();

            do
            {
                Console.Write($"Дисциплина {++n}: ");
                string disc = Console.ReadLine();

                Console.Write($"оценки по Дисциплине \"{disc}\"(через пробел): ");
                int[] marks_temp = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), int.Parse);

                
                marks.Add(disc, marks_temp);



            } while (n != count_disc);*/


        }

        public Dictionary<string, int> get_Marks() 
        {
            return marks;
        }

        public string[] get_FIO() 
        {
            return FIO;
        }

        public string get_Group() 
        {
            return groupe;
        }

        public void show()
        {
            Output();
            Console.WriteLine($"groupe - {groupe}");
            foreach (var kvp in marks)
            {
                Console.WriteLine(kvp.Key);
              
                    Console.WriteLine($" {kvp.Value} ");
                
                
            }

        }
    }
}
