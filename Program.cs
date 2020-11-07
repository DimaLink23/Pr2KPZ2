using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Pr2KPZ
{
    class Program
    {
        static void Main(string[] args)
        {
           void ReadWorkersArray(){ }/// – читає з клавіатури дані і повертає масив об’єктів типу Worker(n штук);

                                     ///ReadWorkersArray() – читає з клавіатури дані і повертає масив об’єктів типу
                                     ///Worker(n штук);
                                     ///         -PrintWorker() – приймає об’єкт типу Worker і виводить його на екран;
                                     ///      -PrintWorkers() – приймає масив об’єктів типу Worker і виводить його на екран;
                                     ///   -GetWorkersInfo() – приймає масив об’єктів типу Worker і повертає через out-
                                     ///параметри найбільшу та найменшу зарплату серед усіх працівників.



            ///   -SortWorkerBySalary() – приймає масив об’єктів типу Worker і сортує його за
            ///спаданням зарплати;
            ///     -SortWorkerByWorkExperience() – приймає масив об’єктів типу Worker і сортує
            ///    його за зростанням стажу роботи.
                
            Worker obj1 = new Worker();
            Console.WriteLine($"Введіть рік і місяць ");
            obj1.Temp();
            obj1.GetTotalExperience();
        }
    }
    class Worker
    {
        private string Name;
        private int Year;
        private int Month;
        private string WorkPlace;

        public Worker()
        { }
        public Worker(string Name, int Year, int Month)
        {
            this.Name = Name;
            this.Year = Year;
            this.Month = Month;
        }


        public Worker(string n)
        {
            Name = n;
        }
        public void Temp() 
        {
            
            int a = 2;

            int b = 2;

            Year = a;
            Month = b;

        }

        ///Властивості
        public string name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }
        

         public interface ICloneable
        {
            object Clone();
        }

        public void GetTotalExperience()
        {
            DateTime date1 = DateTime.Now;
            Console.WriteLine(date1);
            date1.Year
          DateTime date2 = new DateTime(Year, Month);
           /// Console.WriteLine(date2);
       
           /// Console.WriteLine(date3);
        }
        public void GetTotalMoney() 
        {
            ///рахує всю зарплату
        }

    }
    class Company
    {
        private string Name;
        private string Position;
        private int Salary;

        public Company()
        { }
     
        public Company(string Name, string Position, int Salary)
        {
            this.Name = Name;
            this.Position = Position;
            this.Salary = Salary;
        }
        public Company(string n)
        {
            Name = n;
        }

        ///Властивості
        public string name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }
        public interface ICloneable
        {
            object Clone();
        }
    }
}
