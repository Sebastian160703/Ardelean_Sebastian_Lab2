﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ardelean_Sebastian_Lab2.Models;

namespace Ardelean_Sebastian_Lab2.Data
{
    public class Ardelean_Sebastian_Lab2Context : DbContext
    {
        public Ardelean_Sebastian_Lab2Context (DbContextOptions<Ardelean_Sebastian_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ardelean_Sebastian_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Ardelean_Sebastian_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
