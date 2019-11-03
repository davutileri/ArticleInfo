using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Article.WebApi.Entities;

namespace Article.WebApi.DataAccess
{
    public interface IArticleDal: IEntityRepository<ArticleInfo>
    {
    }
}
