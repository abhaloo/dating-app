using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    //This class enables connections to the database for updating entity data
    //extends from the DbContext class
    public class DataContext : DbContext
    {
        //constructor 
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        //User table
        public DbSet<AppUser> Users { get; set; }
    }
}