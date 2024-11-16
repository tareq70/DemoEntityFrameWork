using Demo03EntityFrameWork.Contexts;
using Demo03EntityFrameWork.Entities;
using EntityFrameWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Transactions;
using System.Xml.Linq;

namespace Demo03EntityFrameWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo1
            EnterPriseDbContext dbContext = new EnterPriseDbContext();//open connectio with database
                                                                      //dbContext.Employees.Add();

            //dbContext.Database.Migrate(); 
            #endregion


            #region Demo2
            // try
            // {
            //  //Crud => Query Object Model
            // }
            //finally
            // {
            //     //Release || Free || Deallocate || Close || Dispose UnManaged Resources
            //     dbContext.Dispose(); //close Db Connection

            // }

            //Syntax Suger => Try Finaly

            //using (EnterPriceG01DbContext dbContext = new EnterPriceG01DbContext())
            //{

            //}

            // this is using


            //CRUD => Query Object Model
            #region Emp01 ,Emp02
            //Employee Emp01 = new Employee()
            //{
            //    //EmpId =1 //Invalid =>Column Has Idenitity
            //    Name = "Aya",
            //    Age = 32,
            //    Salary = 320_000,
            //    Email = "Aya1212@gmail.com",
            //    Password = "password"

            //};
            //Employee Emp02 = new Employee()
            //{
            //    //EmpId =1 //Invalid =>Column Has Idenitity
            //    Name = "Ahmed",
            //    Age = 36,
            //    Salary = 32_000,
            //    Email = "Ahmed1212@gmail.com",
            //    Password = "password13"

            //}; 
            #endregion

            #region Insert
            //State
            //Console.WriteLine(dbContext.Entry(Emp01).State);//Detached

            //dbContext.Employees.Add(Emp01); //Add Localy   -->best
            //dbContext.Set<Employee>().Add(Emp01);        -->best
            //dbContext.Add(Emp01);
            //dbContext.Entry(Emp01).State = EntityState.Added;

            //After Adding in dbSet
            //Console.WriteLine(dbContext.Entry(Emp01).State);//Add Localy

            //Add in Database
            //dbContext.SaveChanges(); //Add Remote ()
            //Console.WriteLine(dbContext.Entry(Emp01).State);//UnChanged

            #endregion

            #region Read
            //var Employee =(from E in dbContext.Employees
            //              where E.EmpId ==1
            //              select E).FirstOrDefault();

            //Console.WriteLine(Employee?.Name??"Not Found ");


            #endregion

            #region Update
            //Emp01.Name = "Hamada";
            //Console.WriteLine(dbContext.Entry(Emp01).State); // Detached

            //var Employee = (from E in dbContext.Employees
            //                where E.EmpId == 1
            //                select E).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(Employee).State);//Unchanged
            //Employee.Name = "Hamada"; //Update Localy
            //Console.WriteLine(dbContext.Entry(Employee).State);//Modified
            //dbContext.SaveChanges(); //Update Remotly (DB)
            //Console.WriteLine(dbContext.Entry(Employee).State);//Unchanged

            #endregion

            #region Delete
            //var Employee = (from E in dbContext.Employees
            //                where E.EmpId == 1
            //                select E).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(Employee).State);//Unchanged
            //dbContext.Employees.Remove(Employee); //Remove Employee
            //Console.WriteLine(dbContext.Entry(Employee).State);//Deleted
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(Employee).State);//Detached


            #endregion

            #endregion

            #region Demo4

            #region Join

            #region Query Syntax
            //Query Syntax

            //var Result = from E in dbContext.Emps
            //             join D in dbContext.Departments
            //             on E.Id equals D.DeptId
            //             where E.Salary > 5000
            //             select new
            //             {
            //                 EmpName = E.Name,
            //                 DepName = D.Name
            //             };
            #endregion

            #region Fluent Syntax

            ////Fluent Syntax

            //var Result = dbContext.Emps.Join(dbContext.Departments, E => E.Id, D => D.DeptId, (E, D) => new
            //{
            //    EmpName = E.Name,
            //    DeptName = D.Name,
            //    EmpSalary = E.Salary

            //}).Where(A => A.EmpSalary > 3000);

            #endregion

            #endregion

            #region View
            //var Result = dbContext.Emps.FromSqlRaw("Select * from EmployeeSalaryDepartmentView ");

            //var Result = from E in dbContext.EmployeeSalaryDepartmentView
            //             select E;

            foreach (var item in dbContext.EmployeeSalaryDepartmentView)
            {
                Console.WriteLine($"{item.EmployeeName} :: {item.DepartmentName}");
            }



            #endregion

            #region Tracking - No Tracking

            #region Tracking
            //Tracking
            //var employee = (from E in dbContext.Emps
            //                where E.Id == 1
            //                select E).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(employee).State);//Unchanged

            //employee.Name = "Ahmed";

            //Console.WriteLine(dbContext.Entry(employee).State);//Modified (Locally)

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(employee).State);//Unchanged

            #endregion

            #region  No Tracking
            //var employee = (from E in dbContext.Emps
            //                where E.Id == 1
            //                select E).AsNoTracking().FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(employee).State);//Detached

            //employee.Name = "Ahmed";

            //Console.WriteLine(dbContext.Entry(employee).State);//Detached

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(employee).State);//Detached

            #endregion

            #region Edit Default

            //dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;


            #endregion


            #endregion

            #region MaxBy , MinBy [LINQ Operators]

            //Employee[] employee =
            //{

            //    new Employee (){Id =1 ,Name ="Aya",Age=30,Salary =3_000},
            //    new Employee (){Id =2 ,Name ="omar",Age=20,Salary =4_000}

            //};

            ////var MaxEmployee = employee.Max();
            ////var MinEmployee = employee.Min();
            ////At Least one Object Must implement Icomparable

            ////var MaxEmployee = employee.MaxBy(E=> E.Salary);
            ////var MinEmployee = employee.MinBy(E => E.Salary);


            #endregion
            #endregion
        }
    }
}