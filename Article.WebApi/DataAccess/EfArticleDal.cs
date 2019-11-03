using Article.WebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Article.WebApi.DataAccess
{
    public class EfArticleDal: EfEntityRepositoryBase<ArticleInfo,ArticleContext>, IArticleDal
    {
    }
}
