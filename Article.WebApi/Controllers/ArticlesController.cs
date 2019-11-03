using Article.WebApi.DataAccess;
using Article.WebApi.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Article.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlesController: ControllerBase
    {
        IArticleDal _articleDal;
        public ArticlesController(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var article = _articleDal.GetList();
                if (article == null)
                {
                    return NotFound("There is no any article to show!");
                }
                return Ok(article);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var article = _articleDal.Get(p => p.Id == id);
                if (article == null)
                {
                    return NotFound($"There is no article with Id:{id}");
                }
                return Ok(article);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Add([FromBody]ArticleInfo articleInfo)
        {
            try
            {
                _articleDal.Add(articleInfo);
                return new StatusCodeResult(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody]ArticleInfo articleInfo)
        {
            try
            {
                _articleDal.Update(articleInfo);
                return Ok(articleInfo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _articleDal.Delete(new ArticleInfo { Id = id });
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
