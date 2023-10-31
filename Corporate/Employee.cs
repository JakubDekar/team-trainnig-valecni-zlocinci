using System.Buffers;
using System.Dynamic;

namespace Program{
    /// <summary>
    /// 
    /// POZOR !!!
    /// 
    /// smazat class Employee a nahradit radimoým Employee !!!
    /// </summary>
   public class Employee{
        public string Name{set;get;}
        public int Salary{set;get;}
        public string Position{set;get;}
        /// <summary>
        ///    this is constructor of class Employee
        /// </summary>
        /// <param name="name"></param>
        /// <param name="salary"></param>
        /// <param name="position"></param>
        public Employee(string name ,int salary, string position){
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
        }
        public double GetBonus(int plat){
            return Salary = Convert.ToInt32(Salary + (Salary * 0.1));
        }
        override public string ToString(){
            return "Name: " + Name + "Salary: " + Salary + "Position: " + Position;
        }
    }
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
        public Manager(int teamSize,string name ,int salary, string position):base(name,salary,position){
            this.teamSize = teamSize;
        }
        public new int GetBonus(int plat){
            return Salary = Convert.ToInt32(Salary + (Salary * 0.1) + (teamSize*100));
        }
    }
    class Developer:Employee{
        public string language {set;get;}
        override public string ToString(){
            return "programing language" + language;
        }
        ///<summary>
        ///    this is constructor of class Developer
        /// </summary>
        /// <param name="language"></param>
        /// <param name="name"></param>
        /// <param name="salary"></param>
        /// <param name="position"></param>
        public Developer(string language,string name ,int salary, string position):base(name,salary,position){
            this.language = language;
        }
        public new int GetBonus(int plat){
            if(language == "C#"){
                return Salary = Convert.ToInt32(Salary + (Salary * 0.15) + 500);
            }
            else{
                return Salary = Convert.ToInt32(Salary + (Salary * 0.1) + 300);
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
        public Salesperson(int sales,string name ,int salary, string position):base(name,salary,position){
            this.sales = sales;
        }
        public new int GetBonus(int plat){
            return Salary = Convert.ToInt32(Salary + (Salary * 0.05) + (sales*50));
        }
    class Company
    {
        /// <summary>
        /// uchovávaní zamestnancu
        /// </summary>
        private List<Employee> employees;

        public Company()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public void PrintEmployees()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        public void PayBonuses()
        {
            foreach (var employee in employees)
            {
                double bonus = employee.GetBonus(0);
                Console.WriteLine($"{employee.Name}: {bonus:C}");
            }
     }
    }
    }
}
