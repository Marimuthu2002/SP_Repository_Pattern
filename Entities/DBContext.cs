﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext>options):base(options) { }

        public DbSet<DBModel> Employee { get; set; }
    }
}
