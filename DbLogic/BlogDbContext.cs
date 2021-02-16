﻿using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbLogic
{
    public class BlogDbContext : DbContext
    {
        /*
         * dotnet ef migrations add Initial
         * dotnet ef database update
         */
        public DbSet<BlogArticle> BlogArticles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=..\DbLogic\Blog.db");
    }
}
