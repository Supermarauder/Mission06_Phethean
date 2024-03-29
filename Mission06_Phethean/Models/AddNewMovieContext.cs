﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Mission06_Phethean.Models
{
    public class AddNewMovieContext : DbContext
    {
        public AddNewMovieContext(DbContextOptions<AddNewMovieContext> options) : base(options)
        {
        }
        public DbSet<AddMovieModel> NewMovie { get; set; }
    }
}
