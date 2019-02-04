﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Student
{
    class Student
    {
        public int SoonerID { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsOnProbation { get; set; }
        public double GPA { get; set; }
        private double BursarBalance;

        /// <summary>
        /// Default constructor for the Student class.
        /// Sets all the instance variables to their default values.
        /// </summary>
        public Student()
        {
            SoonerID = 0;
            FirstName = "";
            LastName = "";
            IsOnProbation = false;
            GPA = 0.0;
            BursarBalance = 0.0;
        }
    }
}
