using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUZ
{
    internal class Orders
    {
        private string prefix;
        private int number;
        private string name;
        private string text;

        public Orders(string prefix, int number, string name, string text)
        { 
            this.prefix = prefix;
            this.number = number;
            this.name = name;
            this.text = text;
        
        }

        public string get_Prefix() { return prefix; }     
        public int get_Number() { return number;}
        public string get_Name() { return name; }


    }
}
