using _3_Repository.Interfaces;
using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository
{
    public class Context : DbContext, IDataSource
    {
        public DbSet<User> Users { get;set; }
        public DbSet<Child> Children { get ; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // optionsBuilder.UseSqlServer(@"Data Source=sqlsrv;Initial Catalog=Miri;Integrated Security=True;TrustServerCertificate=True");
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\מסמכים\\miriii.mdf;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True");
            //base.OnConfiguring(optionsBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Hmo;Trusted_Connection=True");
        //}

    }
}

    


