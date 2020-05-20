using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_web_application.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Ostekake", Description="cheeeeesy"},
                new Category{CategoryId=1, CategoryName="Gullerot kake", Description="orange kake som smaker godt"},
                new Category{CategoryId=1, CategoryName="Berliner Boller", Description="Runde og søte boler"}
            };
    }
}
