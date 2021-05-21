using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DBKINOTEATR.Models;

namespace DBKINOTEATR.Data
{
    public class DBKINOTEATRContext : DbContext
    {
        public DBKINOTEATRContext (DbContextOptions<DBKINOTEATRContext> options)
            : base(options)
        {
        }

        public DbSet<DBKINOTEATR.Models.DOLJNOSTI> DOLJNOSTI { get; set; }

        public DbSet<DBKINOTEATR.Models.SOTRUDNIKI> SOTRUDNIKI { get; set; }

        public DbSet<DBKINOTEATR.Models.FILMS> FILMS { get; set; }

        public DbSet<DBKINOTEATR.Models.JANRI> JANRI { get; set; }

        public DbSet<DBKINOTEATR.Models.MESTA> MESTA { get; set; }

        public DbSet<DBKINOTEATR.Models.REPERTUAR> REPERTUAR { get; set; }
    }
}
