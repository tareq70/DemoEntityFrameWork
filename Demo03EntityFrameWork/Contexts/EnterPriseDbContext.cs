using Demo03EntityFrameWork.Entities;
using EntityFrameWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03EntityFrameWork.Contexts
{
    internal class EnterPriseDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server =. ;Database =EnterPrice ;Trusted_Connection =True");
        public DbSet<Employee> Emps { get; set; }
        public DbSet<product> products { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<project> projects { get; set; }

        public DbSet<EmployeeSalaryDepartmentView> EmployeeSalaryDepartmentView { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Employee>()
                        .Property(E => E.Name)
                        .HasDefaultValue("Test")
                        .IsRequired(false);
            modelBuilder.Entity<Department>().ToView("Departments");

            modelBuilder.Entity<Department>()
                         .HasKey(e => e.DeptId);
            modelBuilder.Entity<Department>()
                        .Property(e => e.DeptId)
                        .UseIdentityColumn(10, 10);

            modelBuilder.Entity<EmployeeSalaryDepartmentView>().ToView("EmployeeSalaryDepartmentView").HasNoKey();
            base.OnModelCreating(modelBuilder);
        }
        #region Fluent APIs

        //modelBuilder.Entity<Employee>()
        //            .Property(E => E.Name)
        //            .HasDefaultValue("Test")
        //            .IsRequired(false);
        //modelBuilder.Entity<Department>().ToView("Departments");

        //modelBuilder.Entity<Department>()
        //             .HasKey(e => e.DeptId);
        //modelBuilder.Entity<Department>()
        //            .Property(e => e.DeptId)
        //            .UseIdentityColumn(10, 10);

        //modelBuilder.Entity<Department>()
        //            .Property(e => e.Name)
        //            .HasColumnName("DepartName")
        //            .HasColumnType("VarChar")
        //            .HasMaxLength(100)
        //            .HasDefaultValue("Test")
        //            .IsRequired(false);
        //.HasAnnotation("Maxlength", "50");

        //modelBuilder.Entity<Department>()
        //          .Property(e => e.Dateofcreat)
        //          //.HasDefaultValue(DateTime.Now);
        //          .HasDefaultValueSql("GETDATE()");  
        #endregion

        #region MyRegion
        //    ModelBuilder.Entity<Department>(e =>
        //        {

        //            e
        //              .HasKey(e => e.DeptId);
        //            e
        //              .Property(e => e.DeptId)
        //              .UseIdentityColumn(10, 10);

        //    e
        //      .Property(e => e.Name)
        //              .HasColumnName("DepartName")
        //              .HasColumnType("VarChar")
        //              .HasMaxLength(100)
        //              .HasDefaultValue("Test")
        //              .IsRequired(false);
        //    //.HasAnnotation("Maxlength", "50");

        //    e
        //      .Property(e => e.Dateofcreat)
        //              //.HasDefaultValue(DateTime.Now);
        //              .HasDefaultValueSql("GETDATE()");

        //});

        //    //.HasKey("DeptId");

        //ModelBuilder.ApplyConfiguration(new DepartmentConfiguartions());

        //    base.OnModelCreating(modelBuilder); 
        #endregion


    }
}
