using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VUZ
{
    internal class Manager:Humans
    {
        private string position;
        private List<Orders> orders;

        public Manager(string[] FIO, string dr, string position, List<Orders> orders) : base(FIO, dr)
        {
            this.position = position;
            this.orders = orders;
            //Input();
            //Console.Write("Должность: ");
            //position = Console.ReadLine();

            //orders = new List<Orders>();

            //int n = 0;
            //Console.Write("Введите кол-во приказов: ");
            //int count_disc = int.Parse(Console.ReadLine());

            //do
            //{
            //    Console.Write($"Приказ {++n}: ");
            //    string disc = Console.ReadLine();

            //    //orders.Add(disc);


            //} while (n != count_disc);

        }

        public List<Orders> get_Orders() 
        {
            return orders;
        }

    }
}
