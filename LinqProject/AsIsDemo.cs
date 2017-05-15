using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    public class AsIsDemo
    {
        public void DirectCastObject(object frank)
        {
            try
            {
                Employee emp = (Employee) frank;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UseAsToCastObj(object frank)
        {
            Employee emp = frank as Employee;
            if (emp == null)
            {
                Console.WriteLine("无效的转换");
            }
        }

        public void IsTest(object frank)
        {
            if (frank is Employee)
            {
                Console.WriteLine("有效的对象");
            }
            else
            {
                Console.Write("无效对象");
            }
        }
    }

    public class Employee
    {
        public string EmployeeCode { get; set; }

        public string EmpName { get; set; }
    }
}
