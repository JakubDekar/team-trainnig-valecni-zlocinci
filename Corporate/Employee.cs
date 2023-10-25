using System.Buffers;
using System.Dynamic;

namespace Program{
    /// <summary>
    ///     this is class manager which is inherited from class Employee
    /// </summary>
    class Manager:Employee{
        public int teamSize{set;get;}
        override public string ToString(){
            return base.ToString() + "Team size: " + teamSize;
        }
        /// <summary>
        ///    this is constructor of class Manager
        /// </summary>
        /// <param name="teamSize"></param>
        /// <param name="name"></param>
        /// <param name="salary"></param>
        /// <param name="position"></param>
        public Manager(int teamSize,string name ,string salary, string position):base(name,salary,position){
            this.teamSize = teamSize;
        }
        public int GetBonus(int plat):base(plat){
            return Salary = Salary + (Salary * 0.1) + (teamSize*100);
        }
    }
    class Developer:Employee{
        public string language {set;get;}
        override public string ToString(){
            return "programing language" + language;
        }
        /// <summary>
        ///    this is constructor of class Developer
        /// </summary>
        /// <param name="language"></param>
        /// <param name="name"></param>
        /// <param name="salary"></param>
        /// <param name="position"></param>
        public Developer(string language,string name ,string salary, string position):base(name,salary,position){
            this.language = language;
        }
        public int GetBonus(int plat):base(plat){
            if(language == "C#"){
                return Salary = Salary + (Salary * 0.15) + 500;
            }
            else{
                return Salary = Salary + (Salary * 0.1) + 300;
            }
        }

    }
    class Salesperson:Employee{
        public int sales {set;get;}
        override public string ToString(){
            return "sales" + sales;
        }
        /// <summary>
        ///   this is constructor of class Salesperson
        /// </summary>
        /// <param name="sales"></param>
        /// <param name="name"></param>
        /// <param name="salary"></param>
        /// <param name="position"></param>
        public Salesperson(int sales,string name ,string salary, string position):base(name,salary,position){
            this.sales = sales;
        }
        public int GetBonus(int plat):base(plat){
            return Salary = Salary + (Salary * 0.05) + (sales*50);
        }

    }
}
