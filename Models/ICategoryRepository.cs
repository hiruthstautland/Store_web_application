using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_web_application.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
