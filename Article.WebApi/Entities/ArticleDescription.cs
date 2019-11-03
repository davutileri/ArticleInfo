using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Article.WebApi.Entities
{
    public class ArticleDescription: IEntity
    {
        [Key]
        public int ID { get; set; }
        public int ArticleID { get; set; }
        public string Description { get; set; }
    }
}
