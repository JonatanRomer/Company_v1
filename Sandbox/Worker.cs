﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Worker : Employee
    {
        private string Skill;
        public Worker(string name, int saleryPerMonth, string Skill) : base(name, saleryPerMonth)
        {
            
        }
    }
}
