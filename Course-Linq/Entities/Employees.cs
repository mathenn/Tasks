﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Course.Entities
{
    public class Employees
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employees(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }

        public override string ToString()
        {
            return Name
            + ", "
            + Email
            + ", "
            + Salary;
        }
    }
}
