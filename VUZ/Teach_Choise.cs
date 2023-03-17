using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace VUZ
{
    internal class Teach_Choise
    {


        //private List<Manager> managers;
        //private List<Student> students;
        //private List<Educator> educators;

        private enum Alpha { input, Back };
        int button_count;
        private Alpha current_Button;

        private string[] button_Name;

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        public Teach_Choise()
        {
            
            button_count = Enum.GetValues(typeof(Alpha)).Length;
            button_Name = new string[button_count];

            button_Name[0] = " Ввод преподавателя ";
            button_Name[1] = " Назад ";

        }


        public void ini()
        {
            current_Button = Alpha.input;
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
            Console.WriteLine("Просмотр информации о преподавателе:");
            Console.SetCursorPosition(4, 3);
            Console.WriteLine("1. Список дискиплин преподавателя");
            Console.SetCursorPosition(4, 4);
            Console.WriteLine("2. Список должников по каждой дисциплине");
            Console.WriteLine("");

            int down = 7;

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

        private void input_Edu() 
        {
            Console.Clear();
            Console.SetCursorPosition(2, 1);
            Console.Write("Введите полное ФИО преподавателя:");
            string[] FIO = Console.ReadLine().Split(' ');

            int down = 3;
            bool search_tr = false;

            foreach (Educator educator in Menu.GetEducators()) 
            {
                
                Console.SetCursorPosition(2, ++down);
                Console.Write($"Преподаватель ");
                foreach (string fio in educator.get_FIO())
                {
                    Console.Write($"{fio} ");
                }
                Console.Write($"| Кафедра \"{educator.get_Department()}\"");

                Console.SetCursorPosition(2, ++down);
                if (educator.get_FIO().SequenceEqual(FIO))
                {
                    search_tr= true;
                    Console.SetCursorPosition(2, ++down);
                    Console.Write($"Дисиплины               Должники");
                    //List<string> temp_discipline = i.get_discipline();
                    int n = 1;

                    foreach (string discipline in educator.get_discipline()) 
                    {
                        Console.SetCursorPosition(2, ++down);
                        Console.Write($"{n++}. {discipline}");

                        List<Student> students = Menu.GetStudents();

                        int d = 1;
                        foreach (Student student in students) 
                        {
                            if (student.get_Marks().ContainsKey(discipline) && student.get_Marks().ContainsValue(2)) 
                            {
                                Console.SetCursorPosition(25, down++);
                                Console.Write($"{d++}. ");
                                foreach (string fio in student.get_FIO())
                                {
                                    Console.Write($"{fio} ");
                                }
                                Console.Write($"| {student.get_Group()}");
                            }
                        }
                    }

                }

            }
            if(search_tr)
            {
                Console.SetCursorPosition(3, down);
                Console.Write("Преподавателей с таким ФИО не найдено!");
            }
            Console.ReadKey();
            Start();
        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////
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
                       
                        case Alpha.input: input_Edu(); ; break;
                        case Alpha.Back: Menu.switch_to_Main(); break;
                    }
                }



            } while (true);

        }



    }
}

