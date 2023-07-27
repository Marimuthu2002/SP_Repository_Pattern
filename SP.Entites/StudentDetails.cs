using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Entites
{
    public class StudentDetails : DbContext
    {
        public StudentDetails(DbContextOptions<StudentDetails> options) : base(options) { }

        public DbSet<StudentDBModel> SP_InsertStudDetails { get; set; }
    }
}
