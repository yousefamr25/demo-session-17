using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace demo_session_17
{
    internal struct Employee
    {
        #region attributes
        public int id;
        private string? name;
        private decimal salary;


        #endregion

        #region constructors
        public Employee(int id, string? name, decimal salary,int age)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            Age = age;
        }
        public override string ToString()
        {
            return $"id={id}\nname={name}\nsalary={salary:c}\nAge={Age}";
        }



        #endregion
        #region 1- appling Encapsulation using getter and setter function
        //getter 
        public string? GetName()
        {
            return name;
        }
        //setter
        public void SetName(string? name)
        {
            this.name = name?.Length>5 ?name.Substring(0,5):name ;
        }



        #endregion

        #region 2- Apling encapsulation using property
        //[full property, automatic property,indexer]
        //recomended
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary=value <3000 ? 3000:value;
            }

          
           
        }
        //Ful property 
        //private int age;
        //public int Age
        //{
        //    get
        //    {
        //        return age;
        //    }
        //    set
        //    {
        //        age = value;
        //    }
        //}
        //automatic prop
        public int Age { get; set; }
        private decimal deduction;
        public decimal Deduction { //Read only prop
            get {
                return Salary * 0.2M;
            
            
            }
        }
        

















        #endregion





    }
}
