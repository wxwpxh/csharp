using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci6_2
{
    public class Employee   //普通职工类
    {
        private double bsalary = 1000;   //基本工资
        private double psalary;         //实际工资
        private int n;                  //工作年数
        public int pn
        {
            get { return n; }
            set { n = value; }
        }
        public virtual double compsalary()   //计算普通员工工资
        {
            Console.Write("工作年数:");
            pn = int.Parse(Console.ReadLine());
            psalary = bsalary + 30 * pn;
            return psalary;
        }
    }
    public class UEmployee : Employee  //本科生职工类
    {
        public override double compsalary()
        {
            return 1.5 * base.compsalary();
        }
    }
    public class GEmployee : Employee  //研究生职工类
    {
        public override double compsalary()
        {
            return 2 * base.compsalary();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Console.WriteLine("该普通职工工资:{0}", emp1.compsalary());
            UEmployee emp2 = new UEmployee();
            Console.WriteLine("该本科生职工工资:{0}", emp2.compsalary());
            GEmployee emp3 = new GEmployee();
            Console.WriteLine("该研究生职工工资:{0}", emp3.compsalary());
        }
    }
}
