using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Manager : Employee
    {
        protected int monthlyBonus;
        protected int workhrs;
        public Manager(string name, int saleryPerMonth, int monthlyBonus, int workhrs) : base(name, saleryPerMonth)
        {
            this.monthlyBonus = monthlyBonus;
            this.workhrs = workhrs;
        }


        public override int GetSalaryPerMonth()
        {
            int salery = base.GetSalaryPerMonth();
            if (workhrs > 180)
            {
                salery = salery + monthlyBonus;
            }
            return salery;
        }
        
    }
} 
        
    

