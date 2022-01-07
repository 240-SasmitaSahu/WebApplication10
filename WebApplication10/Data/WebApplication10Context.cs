﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication10.Department;

namespace WebApplication10.Data
{
    public class WebApplication10Context : DbContext
    {
        public WebApplication10Context (DbContextOptions<WebApplication10Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication10.Department.Departments> Departments { get; set; }
    }
}
