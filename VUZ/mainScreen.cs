using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUZ
{
    internal class MainScreen
    {

        private enum Alpha { But1, But2, But3, But4, But5};
        int button_count;
        private Alpha current_Button;

        private string[] button_Name;

        //private int[] massa = new int[2 * (Console.WindowWidth * 2 + Console.WindowHeight)];

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        public MainScreen()
        {
           

            button_count = Enum.GetValues(typeof(Alpha)).Length;
            button_Name = new string[button_count];
           

            button_Name[0] = " Добавление ";
            button_Name[1] = " Выборка по приказам ";
            button_Name[2] = " Выборка по преподавателям ";
            button_Name[3] = " Выборка студентов ";
            button_Name[4] = " Выход ";
        }

        public void ini()
        {
            current_Button = (int)Alpha.But1;
            Start();
        }

        private void Start()
        {
            Console.Clear();
            
            int down = button_count;

            for (int i = 0; i < button_count; i++)
            {

                int centerX = (Console.WindowWidth / 2) - (button_Name[i].Length / 2);
                int centerY = (Console.WindowHeight / 2) - down;

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

                down -= 2;
            }
           // ValueTuple<int, int> sdf = Console.GetCursorPosition();
            
            //Console.WriteLine(sdf.Item1);
            Choise();
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
                    if ((int)current_Button < button_count-1)
                    {
                        current_Button++;
                        Start();
                    }
                }

                if (chose_Button.Key == ConsoleKey.Enter)
                {
                    
                    switch (current_Button)
                    {
                        case Alpha.But1: Menu.switch_to_Add(); break;
                        case Alpha.But2: Menu.switch_to_PricazChoise(); break;
                        case Alpha.But3:Menu.switch_to_TeachChoise(); break;
                        case Alpha.But4: Menu.switch_to_StudChoise(); break;
                        case Alpha.But5: Environment.Exit(1); break;
                    }
                }



            } while (chose_Button.Key != ConsoleKey.Escape);

        }
    }
}
