using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
   abstract class  employee:person
    {
       protected int id;
        protected decimal salary;

        
        public employee(int id,string name,int age):base(name,age)
        {
            this.id = id;
            salary =1000;

        }

       
        public abstract decimal Earn();


    }
}
