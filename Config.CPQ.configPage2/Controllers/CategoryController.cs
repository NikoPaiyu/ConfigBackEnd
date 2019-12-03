/*  Category controller is used to get the category details. 
    url: http://localhost:44315/api/category  */

using System;
using System.Collections.Generic;
using Config.CPQ.configPage2.Models;
using Microsoft.AspNetCore.Mvc;
using Config.CPQ.configPage2.Services;
namespace Config.CPQ.configPage2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController
    {
        private readonly CategoryService _categoryService;

        public CategoryController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public ActionResult<List<Category>> Get() =>
            _categoryService.Get();

        [HttpGet]
        [Route("{categoryId}")]
        public ActionResult<Category> Get(int categoryId)
        {
            var category = _categoryService.Get(categoryId);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }

        private ActionResult<Category> NotFound()
        {
            throw new NotImplementedException();
        }

    }
}
