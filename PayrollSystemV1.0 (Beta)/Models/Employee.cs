using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll
{
    public abstract class Employee : IPrintable
    {
        // Class variables

        private string name;
        private int age;
        private Vehicle vehicle;

        // Methods

        public Employee()
        {
            this.name = "";
            this.age = 0;
            this.vehicle = null;
        }

        public Employee(string name, int age)
        {
            this.age = age;
            this.age = age;
            this.vehicle = null;
        }

        public Employee(string name, int age, Vehicle vehicle)
        {
            this.name = name;
            this.age = age;
            this.vehicle = vehicle;
        }

        public Vehicle Vehicle
        {
            get
            {
                return this.vehicle;
            }
            set
            {
                this.vehicle = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value >= 0)
                {
                    this.age = value;
                }
                else
                {
                    this.age = 0;
                }
                
            }
        }

        public int CalcBirthYear()
        {
            return (2018 - this.age);
        }

        public abstract double CalcEarnings();

        public virtual string PrintMyData()
        {
            string info;

            if (this.vehicle != null)
            {
                info = "Name: " + this.name + "\n" + "Age: " + this.age + "\n" + "Vehicle Info: " + "\n" + this.vehicle.PrintMyData();
            }
            else
            {
                info = "Name: " + this.name + "\n" + "Age: " + this.age + "\n" + "Vehicle Info: " + "\n" + " -This employee has no registered vehicle.";
            }
            return info;
        }

    }
}
