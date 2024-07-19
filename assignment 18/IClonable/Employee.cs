using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_18.IClonable
{
    class Department : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public object Clone()
        {
            return new Department
            {
                Id = this.Id,
                Name = this.Name,
            };
        }

        public override string ToString()
        {
            return $"ID : {Id} , Name : {Name}";
        }
    }
    internal class Employee : ICloneable, IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Department Department { get; set; }

        public object Clone()
        {
            return new Employee()
            {
                Id = this.Id,
                Name = this.Name, //ref of name
                Salary = this.Salary, //3000
                Department = (Department)this.Department.Clone(), //ref of department
            };
        }

        public int CompareTo(object? obj)
        {
            //-ve => this.salary < obj.salary
            //+ve => this.salary > obj.salary
            //0 => this.salary == obj.salary

            Employee passedEmp = (Employee)obj; //unsafe casting
            //if (this.Salary < passedEmp.Salary)
            //    return -1;
            //else if (this.Salary > passedEmp.Salary)
            //    return 1;
            //else 
            //    return 0;

            //OR

            return this.Salary.CompareTo(passedEmp.Salary);
        }

        //public object Clone()
        //{
        //    return new Employee(this)
        //    {
        //    };
        //}

        ////copy constructor
        //public Employee(Employee employee)
        //{
        //    this.Id = employee.Id;
        //    this.Name = employee.Name;
        //    this.Salary = employee.Salary;
        //    this.Department = (Department)employee.Department.Clone();
        //}

        public override string ToString()
        {
            return $"ID : {Id} , Name : {Name} , Salary : {Salary} , Department : {Department}";
        }
    }
}
