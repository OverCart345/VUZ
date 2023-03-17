using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUZ
{
    internal class Stud_chose
    {


        private enum Alpha { Next, Back };
        int button_count;
        private Alpha current_Button;

        private string[] button_Name;

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        public Stud_chose()
        {

            button_count = Enum.GetValues(typeof(Alpha)).Length;
            button_Name = new string[button_count];

            button_Name[0] = " Ввести дисциплину ";
            button_Name[1] = " Назад ";

        }

        public void ini()
        {
            current_Button = Alpha.Next;
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
            Console.WriteLine("Просмотр информации студентах должниках по выбранной дисциплине:");
            Console.SetCursorPosition(4, 3);
            Console.WriteLine("1. ФИО и группа студента");


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

        private void P_Dis()
        {
            Console.Clear();

            Console.SetCursorPosition(2, 1);
            Console.Write("Введите название дисциплины: ");
            string discipline = Console.ReadLine();

            int down = 3;
            int n = 0;
            bool find_disc = false;

            foreach (Student student in Menu.GetStudents()) 
            {
                if (student.get_Marks().ContainsKey(discipline) && student.get_Marks().ContainsValue(2))
                {
                    if (!find_disc) 
                    {
                        Console.SetCursorPosition(3, down++);
                        Console.WriteLine($"Должники по дисциплине {discipline}:");
                        find_disc= true;
                    }

                    Console.SetCursorPosition(4, down++);
                    Console.Write($"{++n}. ");
                    foreach (string fio in student.get_FIO())
                    {
                        Console.Write($"{fio} ");
                    }
                    Console.Write($"| {student.get_Group()}");
                }
            }
            if (!find_disc) 
            {
                Console.SetCursorPosition(3, down++);
                Console.WriteLine($"Должники по дисциплине {discipline} не найдены");
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
                        case Alpha.Next: P_Dis(); break;

                        case Alpha.Back: Menu.switch_to_Main(); break;
                    }
                }



            } while (true);

        }
    }
}
