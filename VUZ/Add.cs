using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VUZ
{
    internal class Add
    {

       // private List<Manager> managers;
       // private List<Student> students;
       // private List<Educator> educators;

        private enum Alpha { stud, teach, manag, worker, Back};
        int button_count;
        private Alpha current_Button;

        private string[] button_Name;

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        public Add()
        {

            button_count = Enum.GetValues(typeof(Alpha)).Length;
            button_Name = new string[button_count];

            button_Name[0] = " Добавление студента ";
            button_Name[1] = " Добавление преподавателя ";
            button_Name[2] = " Добавление управляющего ";
            button_Name[3] = " Добавление работника ";
            button_Name[4] = " Назад ";

        }

        public void ini()
        {
            current_Button = Alpha.stud;
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
            Console.WriteLine("Добавление человека в базу данных университета");
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("");
            int down = 4;

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

        private void add_Students() 
        {
            Console.Clear();

            Console.SetCursorPosition(2, 1);
            Console.Write("Введите количество добавляемых студентов: ");
            int count = int.Parse(Console.ReadLine());
            int n = 0;
            int down = 3;

            do
            {
                Console.SetCursorPosition(3, down++);
                Console.WriteLine($"Ввод студента {++n}");
                Console.SetCursorPosition(3, down++);
                Console.Write("фИО: ");
                string[] FIO = Console.ReadLine().Split(' ');

                Console.SetCursorPosition(3, down++);
                Console.Write("Дата рождения: ");
                string DR = Console.ReadLine();

                Console.SetCursorPosition(3, down++);
                Console.Write("Группа: ");
                string groupe = Console.ReadLine();

                Console.SetCursorPosition(3, down++);
                Console.Write("Введите кол-во дисциплин: ");
                int count_disc = int.Parse(Console.ReadLine());

                Dictionary<string, int> marks = new Dictionary<string, int>();
                int n2 = 0;

                do
                {
                    Console.SetCursorPosition(3, down++);
                    Console.Write($"Дисциплина {++n2}: ");
                    string disc = Console.ReadLine();

                    Console.SetCursorPosition(3, down++);
                    Console.Write($"оценка по Дисциплине \"{disc}\": ");
                    int marks_temp = int.Parse(Console.ReadLine());


                    marks.Add(disc, marks_temp);



                } while (n2 != count_disc);

                Menu.add_Student(FIO, DR, groupe, marks);
               // Student stud = new Student(FIO, DR, groupe, marks);
                //students.Add(stud);



                down += 2;

            } while (n != count);

            down += 2;

            Console.SetCursorPosition(3, down++);
            Console.WriteLine("Данные успешно зписаны!");
            Console.SetCursorPosition(3, ++down);
            Console.WriteLine(" Для продолжение нажмите на любую кнопку ", Console.BackgroundColor = ConsoleColor.White,
                Console.ForegroundColor = ConsoleColor.Black);

            Console.ReadKey();
            Console.ResetColor();
            Start();
        }


     

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private void add_Educators()
        {
            Console.Clear();

            Console.SetCursorPosition(2, 1);
            Console.Write("Введите количество добавляемых преподавателей: ");
            int count = int.Parse(Console.ReadLine());
            int n = 0;
            int down = 3;

            do
            {
                Console.SetCursorPosition(3, down++);
                Console.WriteLine($"Ввод преподавателя {++n}");
                Console.SetCursorPosition(3, down++);
                Console.Write("фИО: ");
                string[] FIO = Console.ReadLine().Split(' ');

                Console.SetCursorPosition(3, down++);
                Console.Write("Дата рождения: ");
                string DR = Console.ReadLine();

                Console.SetCursorPosition(3, down++);
                Console.Write("Кафедра: ");
                string department = Console.ReadLine();

                Console.SetCursorPosition(3, down++);
                Console.Write("Введите кол-во дисциплин: ");
                int count_disc = int.Parse(Console.ReadLine());

                List<string> discipline = new List<string>();
                int n2 = 0;

                do
                {
                    Console.SetCursorPosition(3, down++);
                    Console.Write($"Дисциплина {++n2}: ");
                    string disc = Console.ReadLine();

                    discipline.Add(disc);


                } while (n2 != count_disc);

                Menu.add_Educator(FIO, DR, department, discipline);
              //  Educator edu = new Educator(FIO, DR, department, discipline);
               // educators.Add(edu);



                down += 2;

            } while (n != count);

            down += 2;

            Console.SetCursorPosition(3, down++);
            Console.WriteLine("Данные успешно зписаны!");
            Console.SetCursorPosition(3, ++down);
            Console.WriteLine(" Для продолжение нажмите на любую кнопку ", Console.BackgroundColor = ConsoleColor.White,
                Console.ForegroundColor = ConsoleColor.Black);

            Console.ReadKey();
            Console.ResetColor();
            Start();
        }

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 


        private void add_Manager()
        {
            Console.Clear();

            Console.SetCursorPosition(2, 1);
            Console.Write("Введите количество добавляемых управляющих: ");
            int count = int.Parse(Console.ReadLine());
            int n = 0;
            int down = 3;

            do
            {
                Console.SetCursorPosition(3, down++);
                Console.WriteLine($"Ввод упровляющего {++n}");
                Console.SetCursorPosition(3, down++);
                Console.Write("фИО: ");
                string[] FIO = Console.ReadLine().Split(' ');

                Console.SetCursorPosition(3, down++);
                Console.Write("Дата рождения: ");
                string DR = Console.ReadLine();

                Console.SetCursorPosition(3, down++);
                Console.Write("Должность: ");
                string position = Console.ReadLine();

                Console.SetCursorPosition(3, down++);
                Console.Write("Введите кол-во приказов: ");
                int count_disc = int.Parse(Console.ReadLine());

                List<Orders> order = new List<Orders>();
                int n2 = 0;

                do
                {
                    Console.SetCursorPosition(3, down++);
                    Console.Write($"Приказ {++n2}: ");

                    Console.SetCursorPosition(3, down++);
                    Console.Write($"Префикс(worker|educator|student|all): ");
                    string prefix = Console.ReadLine();

                    Console.SetCursorPosition(3, down++);
                    Console.Write($"Номер: ");
                    int number = int.Parse(Console.ReadLine());

                    Console.SetCursorPosition(3, down++);
                    Console.Write($"Название: ");
                    string name = Console.ReadLine();

                    Console.SetCursorPosition(3, down++);
                    Console.Write($"Описание: ");
                    string ops = Console.ReadLine();

                    Orders ord = new Orders(prefix, number, name, ops);

                    order.Add(ord);


                } while (n2 != count_disc);

                Menu.add_Maneger(FIO, DR, position, order);
                //Manager man = new Manager(FIO, DR, position, order);
                //managers.Add(man);



                down += 2;

            } while (n != count);

            down += 2;

            Console.SetCursorPosition(3, down++);
            Console.WriteLine("Данные успешно зписаны!");
            Console.SetCursorPosition(3, ++down);
            Console.WriteLine(" Для продолжение нажмите на любую кнопку ", Console.BackgroundColor = ConsoleColor.White,
                Console.ForegroundColor = ConsoleColor.Black);

            Console.ReadKey();
            Console.ResetColor();
            Start();
        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 

        private void add_Worker()
        {
            Console.Clear();

            Console.SetCursorPosition(2, 1);
            Console.Write("Введите количество добавляемых работников: ");
            int count = int.Parse(Console.ReadLine());
            int n = 0;
            int down = 3;

            do
            {
                Console.SetCursorPosition(3, down++);
                Console.WriteLine($"Ввод работника {++n}");

                Console.SetCursorPosition(3, down++);
                Console.Write("фИО: ");
                string[] FIO = Console.ReadLine().Split(' ');

                Console.SetCursorPosition(3, down++);
                Console.Write("Дата рождения: ");
                string DR = Console.ReadLine();
          

                Menu.add_Worker(FIO, DR);


                down += 2;

            } while (n != count);

            down += 2;

            Console.SetCursorPosition(3, down++);
            Console.WriteLine("Данные успешно зписаны!");
            Console.SetCursorPosition(3, ++down);
            Console.WriteLine(" Для продолжение нажмите на любую кнопку ", Console.BackgroundColor = ConsoleColor.White,
                Console.ForegroundColor = ConsoleColor.Black);

            Console.ReadKey();
            Console.ResetColor();
            Start();
        }

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
                        case Alpha.stud: add_Students(); break;
                        case Alpha.teach: add_Educators(); break;
                        case Alpha.manag: add_Manager(); break;
                        case Alpha.worker: add_Worker(); break;
                        case Alpha.Back: Menu.switch_to_Main(); break;
                    }
                }



            } while (true);

        }

     

    }
}
