using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_repository
{
    public class MovieLibrary : IEnumerable
    {
        private readonly AppDbContext _dbContext;

        public MovieLibrary(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var movie in _dbContext.Movies.Where(m => IsNightTime() || !m.IsAdult))
            {
                yield return movie.Title;
            }
        }

        private bool IsNightTime() => DateTime.Now.Hour >= 23 || DateTime.Now.Hour < 7;
    }
}