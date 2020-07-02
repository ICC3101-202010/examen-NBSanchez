using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Persona
    {
        protected string Name;
        private int Age;
        private string Nation;
        private int Salary;

        public void SetPerson(string Name, int Age, string Nation, int Salary)
        {
            this.Name = Name;
            this.Age = Age;
            this.Nation = Nation;
            this.Salary = Salary;
        }

        public string GetName()
        {
            return Name;
        }
        public int GetAge()
        {
            return Age;
        }
        public string GetNation()
        {
            return Nation;
        }
        public int GetSalary()
        {
            return Salary;
        }
    }
  

}
