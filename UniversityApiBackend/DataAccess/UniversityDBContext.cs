﻿using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models.DataModels;
namespace UniversityApiBackend.DataAccess
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options)
        {

        }
        // TODO: Add DbSets (Tables of our data base)
        public DbSet<Users>? Users { get; set; }
    }
}
