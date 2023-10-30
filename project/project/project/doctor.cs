using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace project
{
    class doctor:employee,Idoctor_report
    {
        int doctor_id;
       public string spcialization;
        public doctor(int doc_id,string spcialization,int id,string name,int age):base (id,name,age)
        {
            this.doctor_id =doc_id;
            this.spcialization = spcialization;



        }



        public override decimal Earn()
        {
            return salary + (.15m * salary);
        }

       public  void  doctor_file_write()
        {
            FileStream stream = null;
            string file_name = "E:\\doctor_file.txt";
            try
            {
                stream = new FileStream(file_name, FileMode.Append, FileAccess.Write);
                StreamWriter s = new StreamWriter(stream);
                s.WriteLine("Employee_ID: " + id);
                s.WriteLine("Doctor_ID: " + doctor_id);
                s.WriteLine("Name: " + Name);
                s.WriteLine("Age: " + Age);
                s.WriteLine("Salary: " + Earn());
                s.WriteLine("spcialization: " + spcialization);
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

        public  void doctor_file_read()
        {
            FileStream stream = null;
            string file_name = "E:\\doctor_file.txt";
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
           

    static public void doctor_option()
        {
            int ch = int.Parse(Console.ReadLine()); 
            switch (ch)
            {
                case 1:
                    switch_functions.show_doctor();
                    break;

                case 2:
                    switch_functions.insert_doctor();
                    break;
            }
        }

    }
}
