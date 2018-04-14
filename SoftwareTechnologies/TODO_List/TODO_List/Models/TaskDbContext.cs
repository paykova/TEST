using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using TODO_List.Models;
using TODOList.Controllers;

namespace TODOList.Models
{
    public class TaskDbContext : DbContext 
    {
        public DbSet<Task> Tasks { get; set; }

        //public DbSet<Cat> Cats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=todo;user=root;");
        }
    }
}
