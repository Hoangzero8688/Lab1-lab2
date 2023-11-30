using ExamNet104.Context;
using ExamNet104.Models;
using ExamNet104.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace ExamNet104.Repository
{
    public class MovieRepo : IMovieRepo
    {
        private readonly MyDbConext _myDbConext;

        public MovieRepo(MyDbConext myDbConext)
        {
            _myDbConext = myDbConext;
        }
        public void Add(MovieVM movieVM)
        {
            var user = new Movie
            {
                Id = movieVM.Id,
                name = movieVM.name,
                description = movieVM.description,
                rating = movieVM.rating
            };

            _myDbConext.Add(user);
            _myDbConext.SaveChanges();
        }
        public async Task<IEnumerable<MovieVM>> GetALl()
        {
            var user = await _myDbConext.movies.ToListAsync();
            return user.Select(x => new MovieVM
            {
                Id = x.Id,
                name = x.name,
                description = x.description,
                rating = x.rating
            });
        }
    }
}

      

