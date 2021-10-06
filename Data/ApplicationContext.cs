using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhamHuuDuy184.Models;

    public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<PhamHuuDuy184.Models.PersonPHD184> PersonPHD184 { get; set; }

        public DbSet<PhamHuuDuy184.Models.PHD0184> PHD0184 { get; set; }
    }
