using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA
{
    public class Employee
    {
        private string name;
        private int baseSalary;
        private int benefit;
        private int salary;

        public string Name { get => name; set => name = value; }

        public int BaseSalary
        {
            get { return this.baseSalary; }
            set
            {
                if (value < 22000)
                {
                    this.baseSalary = 22000;
                }
                else
                {
                    this.baseSalary = value;
                }
            }
        }

        public int Benefit
        {
            get => Benefit;
            set
            {
                if (value < 0)
                {
                    this.benefit = 0;
                }
                else
                {
                    this.benefit = value;
                }
            }
        }

        public int Salary
        {
            get => Salary;
            set
            {
                this.salary = this.baseSalary + this.benefit;
            }
        }
    }
}