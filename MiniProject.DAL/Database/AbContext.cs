using Microsoft.EntityFrameworkCore;
using MiniProject.DAL.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.DAL.Database
{
    public class AbContext : DbContext
    {
        // startup.css + ini fil
        //public AbContext(DbContextOptions<AbContext> options): base(options) { }

        // 1) data til database - seed
        // 2) data fra en klasse til database..
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=TEC-5350-LA0052;Database=flemmingErSej; Trusted_Connection=True");
        }
        //"Server=TEC-5350-LA0052;Database=libraryProject002 ;Trusted_Connection=True;"

        //public DatabaseContext(DbContextOptions<DatabaseContext> options) :
        //   base(options)
        //{ }
        // min property Author svare til en tabel 
        // når vi skriver context.Author   , så tager vi fat i linjen nedenunder, som
        // er en tabel i databasen, pga EntityFramework
        public DbSet<Author> Author { get; set; }

    }
}
