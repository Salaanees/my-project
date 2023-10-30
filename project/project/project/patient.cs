using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace project
{
   sealed class patient:person
    {
        string desise;
        decimal payment;

        public patient(string desise,decimal payment,int age,string name):base(name,age)
        {

            this.desise = desise;
            this.payment = pay();
        }
         
        public decimal  pay()
        {
            if (desise == "brain")
            {
                return 10000 + payment;
            }
            else if (desise == "stomic")
            {
                return 2000 + payment;
            }

            else if (desise == "teeth")
            {
                return 150 + payment;
            }
            else
                return payment;
        }

        static public void patient_option()
        {
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    switch_functions.show_patient();
                    break;

                case 2:
                    switch_functions.insert_patient();
                    break;
            }
        }

        public void patient_file_read()
        {
            FileStream stream = null;
            string file_name = "E:\\patient_file.txt";
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

        public void patient_file_write()
        {
            FileStream stream = null;
            string file_name = "E:\\patient_file.txt";
            try
            {
                stream = new FileStream(file_name, FileMode.Append, FileAccess.Write);
                StreamWriter s = new StreamWriter(stream);
                s.WriteLine("patient name: " +Name);
                s.WriteLine("Age : " + Age);
                s.WriteLine("desise : " + desise);
                s.WriteLine("payment : " + pay());
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


    }
}
