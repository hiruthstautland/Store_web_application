using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_web_application.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie {PieId = 1, Name="Ostekake med lime", Price=123.49M, ShortDescription="cheeesy", LongDescription="Ostekake med lime Ostekake med lime"},
                new Pie {PieId = 2, Name="Gulerotkake med krem", Price=73.99M, ShortDescription="cheeesy med krem", LongDescription="Gulerotkake med krem krem krem krem krem"},
                new Pie {PieId = 3, Name="Gulerotkake med mandelbunn", Price=135.49M, ShortDescription="gulerotkake", LongDescription="Gulerotkake med mandelbunnmandelbunn mandelbunn"},
                new Pie {PieId = 4, Name="Ostekake med gele", Price=99.49M, ShortDescription="cheeesy and gely", LongDescription="Ostekake med geleOstekake med geleOstekake med geleOstekake med geleOstekake med geleOstekake med gele"}
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
