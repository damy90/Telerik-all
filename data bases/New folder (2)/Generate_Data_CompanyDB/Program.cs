using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Data_CompanyDB
{
    class Program
    {


        public static System.String GetRandomString(System.Int32 length)
        {
            System.Byte[] seedBuffer = new System.Byte[4];
            using (var rngCryptoServiceProvider = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                rngCryptoServiceProvider.GetBytes(seedBuffer);
                System.String chars = "-abcdefghijklmnopqrstuvwxyz ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                System.Random random = new System.Random(System.BitConverter.ToInt32(seedBuffer, 0));
                return new System.String(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            }
        }
        static void Main(string[] args)
        {

            Random random = new Random();


            CompanyEntities company = new CompanyEntities();



            Department dep = new Department();

            for (int i = 0; i < 100; i++)
			{
                dep.Name = GetRandomString(random.Next(11, 50));
                company.Departments.Add(dep);
                Console.WriteLine(dep.Name.ToString());
                company.SaveChanges();
			}

            Employee emp = new Employee();

            List<int> departmentIDs=new List<int>();
            
            
            foreach (var item in company.Departments)
                departmentIDs.Add(item.ID);

            for (int i = 0; i < 100; i++)
            {
                emp.FirstName = GetRandomString(random.Next(6, 20));
                emp.LastName = GetRandomString(random.Next(6, 20));
                emp.DepartmentID = departmentIDs.ElementAt(random.Next(0, departmentIDs.Count - 1));
                emp.YearSalary = random.Next(50000, 200000);
                
                company.Employees.Add(emp);
                //Console.WriteLine(emp.FirstName);
                company.SaveChanges();
            }

            List<int> empIDs = new List<int>();

            foreach (var item in company.Employees)
            {
                empIDs.Add(item.ID);
            }

            foreach (var item in company.Employees)
            {
                item.ManagerID=empIDs.ElementAt(random.Next(0, empIDs.Count - 1));
                company.SaveChanges();
            }  

           

            
            




        }
    }
}
