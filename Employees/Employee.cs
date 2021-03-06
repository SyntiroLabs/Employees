﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    partial class Employee
    {
        // Field data
        // Derived classes can now directly access this information.
        protected string empName;
        protected int empId;
        protected float currPay;
        protected int empAge;
        protected string empSSN = "";

        #region Properties
        // Properties!
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("error! Name length exceeds 15 characters!");
                }
                else
                {
                    empName = value;
                }
            }
        }

        public int ID
        {
            get { return empId; }
            set { empId = value; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }
        #endregion

        #region Getters and Setters
        // Accessor (get method)
        public string GetName()
        {
            return Name;
        }

        // Mutator (set method)
        public void SetName(string name)
        {
            // Do a check on incoming value before making assignment.
            if (name.Length > 15)
            {
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            }
            else
            {
                Name = name;
            }
        }
        #endregion

        #region Constructors
        // Constructors
        public Employee() { }
        public Employee(string name, int id, float pay) : this(name, 0, id, pay)
        { }
        public Employee(string name, int age, int id, float pay) 
        {
            // Use properties when setting class data. Always!
            // This reduces the amount of duplicate error checks.
            
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
        }
        public Employee(string name, int age, int id, float pay, string ssn) : this(name, age, id, pay)
        {
            empSSN = ssn;
        }
        #endregion

        #region Methods
        // Methods

        // This method can be "overrideen" by a derived class by the addition of the "virtual" keyword.
        public virtual void GiveBonus (float amount)
        {
            Pay += amount;
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Pay: {0}", Pay);
        }
        #endregion

        // Contain a BenefitPackage object.
        protected BenefitPackage empBenefits = new BenefitPackage();

        // Expose certain benefit behaviors of object.
        public double GetBenefitCost()
        {
            return empBenefits.ComputePayDeduction();
        }

        // Expose object through a custom property.
        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }

    }
}
