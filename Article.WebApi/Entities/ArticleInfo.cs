using Article.WebApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Article.WebApi.Entities
{
    [Table("ArticleInfo")]
    public class ArticleInfo: IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string JournalTitle { get; set; }
        public int JournalIssue { get; set; }
    }
}
