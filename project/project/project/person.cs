using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class person
    {
        string name;
        int age;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if(value<=20)
                {
                    Console.WriteLine("wrong age...enter age again");
                    Age = int.Parse(Console.ReadLine());
                }
                else
                    age = value;
            }
            
        }
        public person(string name,int age)
        {
            this.Age = age;
            this.Name = name;
        }
    }
}
