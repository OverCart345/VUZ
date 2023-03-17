using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VUZ
{
    internal class Menu
    {
        static private List<Manager> maneger;
        static private List<Student> student;
        static private List<Educator> educator;
        static private List<Worker> worker;

        static private MainScreen mainScreen;
        static private Add add;
        static private Teach_Choise teach_choise;
        static private Pricaz_Choise pricaz_choise;
        static private Stud_chose stud_chose;

        public Menu() 
        {
            Console.CursorVisible = false;

            maneger= new List<Manager>();
            student= new List<Student>();
            educator= new List<Educator>();
            worker= new List<Worker>();

            mainScreen = new MainScreen();
            add = new Add();
            teach_choise= new Teach_Choise();
            pricaz_choise= new Pricaz_Choise();
            stud_chose = new Stud_chose();
            switch_to_Main();
        }

        static public List<Manager> GetManagers() { return maneger; }

        static public List<Student> GetStudents() { return student; }

        static public List<Educator> GetEducators() { return educator; }

        static public void add_Maneger(string[] FIO, string dr, string position, List<Orders> orders) 
        {
            maneger.Add(new Manager(FIO, dr, position, orders));
        }

        static public void add_Educator(string[] FIO, string dr, string department, List<string> discipline)
        {
            educator.Add(new Educator(FIO, dr, department, discipline));
        }

        static public void add_Student(string[] FIO, string dr, string groupe, Dictionary<string, int> marks)
        {
            student.Add(new Student(FIO, dr, groupe, marks));
        }

        static public void add_Worker(string[] FIO, string dr)
        {
            worker.Add(new Worker(FIO, dr));
        }

        static public void switch_to_Main() { mainScreen.ini(); }

        static public void switch_to_Add() { add.ini(); }

        static public void switch_to_TeachChoise()  { teach_choise.ini(); }

        static public void switch_to_PricazChoise() { pricaz_choise.ini(); }

        static public void switch_to_StudChoise() { stud_chose.ini(); }

        static public void down(int value) 
        {
            ValueTuple<int, int> sdf = Console.GetCursorPosition();
            Console.SetCursorPosition(sdf.Item1, sdf.Item2 + value);
        }
    }
}
