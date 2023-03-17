using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUZ
{
    internal class Pricaz_Choise
    {


        private enum Alpha { P_Edu, P_Stu, P_Wor, P_All, Back };
        int button_count;
        private Alpha current_Button;

        private string[] button_Name;

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        public Pricaz_Choise()
        {

            button_count = Enum.GetValues(typeof(Alpha)).Length;
            button_Name = new string[button_count];

            button_Name[0] = " Приказы для преподавателей ";
            button_Name[1] = " Приказы для студентов ";
            button_Name[2] = " Приказы для рабочих ";
            button_Name[3] = " Все приказы ";
            button_Name[4] = " Назад ";

        }

        public void ini() 
        {
            current_Button = Alpha.P_Edu;
            Start();
        }


        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 
        private void Start()
        {
            Console.Clear();


            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Просмотр информации о приказах по префиксу:");
            Console.SetCursorPosition(4, 3);
            Console.WriteLine("1. идентификационный номер и название приказа");


            int down = 6;

            for (int i = 0; i < button_count; i++)
            {

                int centerX = 3;
                int centerY = down;

                int eValue = (int)current_Button;

                Console.SetCursorPosition(centerX, centerY);
                if (eValue == i)
                {
                    Console.Write(button_Name[i], Console.BackgroundColor = ConsoleColor.White,
                    Console.ForegroundColor = ConsoleColor.Black);
                }
                else
                {
                    Console.Write(button_Name[i], Console.BackgroundColor = ConsoleColor.Black,
                    Console.ForegroundColor = ConsoleColor.White);
                }

                down += 2;
            }

            Choise();

        }


        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private void P_Edu() 
        {
            Console.Clear();

            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Информация о приказах для преподавателей:");

            bool fine_order = false;
            int down = 3;
            int n = 0;

            foreach (Manager manager in Menu.GetManagers()) 
            {
                foreach (Orders orders in manager.get_Orders()) 
                {
                    
                    if (orders.get_Prefix() == "educator" || orders.get_Prefix() == "all") 
                    {
                        fine_order = true;
                        ++down;
                        Console.SetCursorPosition(3, down++);
                        Console.Write($"Приказ №{++n}:");

                        Console.SetCursorPosition(4, down++);
                        Console.Write($"Номер {orders.get_Number()}");

                        Console.SetCursorPosition(4, down++);
                        Console.Write($"Название {orders.get_Name()}");
                    }
                }
            }
            if (!fine_order) 
            {
                Console.SetCursorPosition(3, down++);
                Console.WriteLine("Приказов для преподавателей не найдено!");
            }

            Console.ReadKey();
            Start();
        }



        private void P_Wor()
        {
            Console.Clear();

            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Информация о приказах для рабочих:");

            bool fine_order = false;
            int down = 3;
            int n = 0;

            foreach (Manager manager in Menu.GetManagers())
            {
                foreach (Orders orders in manager.get_Orders())
                {

                    if (orders.get_Prefix() == "worker" || orders.get_Prefix() == "all")
                    {
                        fine_order = true;
                        ++down;
                        Console.SetCursorPosition(3, down++);
                        Console.Write($"Приказ №{++n}:");

                        Console.SetCursorPosition(4, down++);
                        Console.Write($"Номер {orders.get_Number()}");

                        Console.SetCursorPosition(4, down++);
                        Console.Write($"Название {orders.get_Name()}");
                    }
                }
            }
            if (!fine_order)
            {
                Console.SetCursorPosition(3, down++);
                Console.WriteLine("Приказов для рабочих не найдено!");
            }

            Console.ReadKey();
            Start();
        }



        private void P_Stu()
        {
            Console.Clear();

            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Информация о приказах для студентов:");

            bool fine_order = false;
            int down = 3;
            int n = 0;

            foreach (Manager manager in Menu.GetManagers())
            {
                foreach (Orders orders in manager.get_Orders())
                {

                    if (orders.get_Prefix() == "student" || orders.get_Prefix() == "all")
                    {
                        fine_order = true;
                        ++down;
                        Console.SetCursorPosition(3, down++);
                        Console.Write($"Приказ №{++n}:");

                        Console.SetCursorPosition(4, down++);
                        Console.Write($"Номер {orders.get_Number()}");

                        Console.SetCursorPosition(4, down++);
                        Console.Write($"Название {orders.get_Name()}");
                    }
                }
            }
            if (!fine_order)
            {
                Console.SetCursorPosition(3, down++);
                Console.WriteLine("Приказов для студентов не найдено!");
            }

            Console.ReadKey();
            Start();
        }


        private void P_All()
        {
            Console.Clear();

            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Информация о всех приказах:");

            bool fine_order = false;
            int down = 3;
            int n = 0;

            foreach (Manager manager in Menu.GetManagers())
            {
                foreach (Orders orders in manager.get_Orders())
                {
                        fine_order = true;
                    ++down;
                    Console.SetCursorPosition(3, down++);
                        Console.Write($"Приказ №{++n}:");

                        Console.SetCursorPosition(4, down++);
                        Console.Write($"Номер {orders.get_Number()}");

                        Console.SetCursorPosition(4, down++);
                        Console.Write($"Название {orders.get_Name()}");                   
                }
            }
            if (!fine_order)
            {
                Console.SetCursorPosition(3, down++);
                Console.WriteLine("Приказов не найдено!");
            }

            Console.ReadKey();
            Start();
        }
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private void Choise()
        {
            ConsoleKeyInfo chose_Button;

            Console.ResetColor();

            do
            {
                chose_Button = Console.ReadKey();

                if (chose_Button.Key == ConsoleKey.UpArrow)
                {

                    if (current_Button > 0)
                    {
                        current_Button--;
                        Start();
                    }
                }

                if (chose_Button.Key == ConsoleKey.DownArrow)
                {
                    if ((int)current_Button < button_count - 1)
                    {
                        current_Button++;
                        Start();
                    }
                }

                if (chose_Button.Key == ConsoleKey.Enter)
                {
                    switch (current_Button)
                    {
                        case Alpha.P_All: P_All(); break;
                        case Alpha.P_Stu: P_Stu(); break;
                        case Alpha.P_Wor: P_Wor(); break;
                        case Alpha.P_Edu: P_Edu(); break;
                        case Alpha.Back: Menu.switch_to_Main(); break;
                    }
                }



            } while (true);

        }
    }
}
