using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            int main_choice;
            do
            {
            switch_functions.start_program();
             main_choice = int.Parse(Console.ReadLine());
                switch (main_choice)
                {


                    case 1:
                        switch_functions.start_employees_section();
                        int chose_emp = int.Parse(Console.ReadLine());
                        if (chose_emp == 1)
                        {
                            switch_functions.start_doctor_section();
                            doctor.doctor_option();

                        }
                        else
                        {
                            switch_functions.start_nurse_section();
                            nurse.nurse_option();
                        }
                        break;

                    case 2:
                        Console.WriteLine("===============patient section===============");
                        Console.WriteLine("1-patient information                   2-patient addition");

                        patient.patient_option();
                        break;


                }
            } while (main_choice!=0);
          

             
            










        }
    }
}
