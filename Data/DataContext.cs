using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using classdotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace classdotnet.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Character> Characters { get; set; }
    }
}