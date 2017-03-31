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
            get => this.benefit;
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
            get //  只有get代表為唯讀屬性；
            {
                return this.baseSalary + this.benefit;
            }
        }
    }
}