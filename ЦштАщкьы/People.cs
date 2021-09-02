using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ЦштАщкьы
{
    class People
    {
        private int age;
        private int rost;
        private string name;
        private bool IsWork;

        public string Name { get => name; set => name = value; }
        public int Rost { get => rost; set => rost = value; }
        public int Age { get => age; set => age = value; }
        public bool Iswork { get => IsWork; set => IsWork = value; }

        public override string ToString()
        {
            return "Name: " + name + "\n"
                + "Age: " + age + "\n"
                + "Rost: " + rost + "\n"
                + "Rabotaet: " + IsWork;
        }
    }
}
