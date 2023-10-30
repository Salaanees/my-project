using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
   static class switch_functions
    {
       public  static void insert_doctor()
        {
            int age;

            Console.WriteLine("enter doctor_id");
            int d_id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter employee_id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter specialization");
            string special = Console.ReadLine();
            Console.WriteLine("enter age");
                star:
            try { 
             age = int.Parse(Console.ReadLine());
            }catch(Exception e)
            {
                Console.WriteLine("enter integer");
                goto star;
            }


            doctor new_d = new doctor(d_id, special, id, name, age);
            new_d.doctor_file_write();
            Console.WriteLine("inserted successfully.............");
        }
        public static void show_doctor()
        {
            doctor d = new doctor(1, "bons", 500, "reem", 45);
            d.doctor_file_read();
        }
        public static void show_nurse()
        {
            Inurse_report n = new nurse(1, 35, 500, 123, "reem", 25);
            n.nurse_file_read();
        }
        public static void start_doctor_section()
        {
            Console.WriteLine("welcom to doctor section ");
            Console.WriteLine("1-doctors' Information:");
            Console.WriteLine("2-doctors' Addition:");
            Console.WriteLine("");
        }

        public static void start_program()
        {
            Console.WriteLine("===============hospital system model====================");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("1-Employees                               2-Patiants");
        }

        public static void start_nurse_section()
        {
            Console.WriteLine("welcom to nurse section ");
            Console.WriteLine("1-nurses' Information:");
            Console.WriteLine("2-nurses' Addition:");
            Console.WriteLine("");
        }

        public static void insert_nurse()
        {
            int age;
            decimal hours;
            decimal wage;
            Console.WriteLine("enter doctor_id");
            int n_id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter employee_id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter number of hours working");
             
        star1:
            try
            {
                hours = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("enter number");
                goto star1;
            }
            Console.WriteLine("enter wage of hour");
            star2:
            try
            {
                wage = decimal.Parse(Console.ReadLine());
            }catch(Exception e)
            {
                Console.WriteLine("enter number");
                goto star2;
            }
            Console.WriteLine("enter age");
        star3:
            try
            {
                age = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("enter integer");
                goto star3;
            }


            nurse new_n = new nurse(n_id, hours, wage, id, name, age);
            new_n.nurse_file_write();
            Console.WriteLine("inserted successfully.............");
        }

        public static void start_employees_section()
        {
            Console.WriteLine("    welcome to employees section ");
            Console.WriteLine();
            Console.WriteLine("1-doctor                    2-nurse");
        } 

        public static void show_patient()
        {
            patient p = new patient("stomic", 500,33, "ayman");
            p.patient_file_read();
        }
        public static void insert_patient()
        {
           
           
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name of desise");
            string desise= Console.ReadLine();
            Console.WriteLine("enter the ammount of payment");
            decimal payment =decimal.Parse(Console.ReadLine());


            patient new_p = new patient(desise,payment, age,name );
            new_p.patient_file_write();
            Console.WriteLine("inserted successfully.............");
        }
    }
}
