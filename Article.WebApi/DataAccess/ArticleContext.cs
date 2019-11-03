using Article.WebApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Article.WebApi.DataAccess
{
    public class ArticleContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Article;Trusted_Connection=true");
        }

        public DbSet<ArticleInfo> ArticleInfos { get; set; }
    }
}
