//aşağıdaki kod,beritabanındaki filmleri temsil eden bir DbSet<Movie> özelliği oluşturur.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PatlamısMısır.com.Models;

namespace PatlamısMısır.com.Data
{
    public class PatlamısMısırcomContext : DbContext
    {
        public PatlamısMısırcomContext (DbContextOptions<PatlamısMısırcomContext> options)
            : base(options)
        {
        }

        public DbSet<PatlamısMısır.com.Models.movie> movie { get; set; } = default!;
    }
}
