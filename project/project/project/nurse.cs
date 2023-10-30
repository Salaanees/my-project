using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace project
{
    class nurse:employee,Inurse_report
    {
        int nurse_id;
        decimal hours;
        decimal wage;
        public nurse(int nurse_id, decimal hours, decimal wage, int emp_id,string name,int age)
            :base(emp_id,name,age)
        {
            this.nurse_id = nurse_id;
            this.hours = hours;
            this.wage = wage;
        }
     

        public override decimal Earn()
        {
            if (hours <= 40)
            {
                return wage * hours;
            }
            else
                return (40 * wage) + ((hours - 40) * wage * 1.5m);
        }



        public void nurse_file_write()
        {
            FileStream stream = null;
            string file_name = "E:\\nurse_file.txt";
            try
            {
                stream = new FileStream(file_name, FileMode.Append, FileAccess.Write);
                StreamWriter s = new StreamWriter(stream);
                s.WriteLine("Employee_ID: " + id);
                s.WriteLine("nurse_ID: " +nurse_id);
                s.WriteLine("Name: " + Name);
                s.WriteLine("Age: " + Age);
                s.WriteLine("Salary: " + Earn());
                s.WriteLine("================================");
                s.Flush();
                s.Close();
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }

        public void nurse_file_read()
        {
            FileStream stream = null;
            string file_name = "E:\\nurse_file.txt";
            try
            {
                stream = new FileStream(file_name, FileMode.Open, FileAccess.Read);
                StreamReader r = new StreamReader(stream);
                string text = r.ReadToEnd();
                Console.WriteLine(text);
                r.Close();
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }

        static public void nurse_option()
        {
            int ch = int.Parse(Console.ReadLine()); 
            switch (ch)
            {
                case 1:
                    switch_functions.show_nurse();
                    break;

                case 2:
                    switch_functions.insert_nurse();
                    break;
            }
        }

    }
}
