﻿using codePulse.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace codePulse.API.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
                
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }


    }
}
