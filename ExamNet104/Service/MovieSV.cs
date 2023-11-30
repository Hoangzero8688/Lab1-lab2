using ExamNet104.Models;
using ExamNet104.Repository;
using ExamNet104.ViewModel;

namespace ExamNet104.Service
{
    public class MovieSV : IMovieSV
    {
        private readonly IMovieRepo _movieRepo;

        public MovieSV(IMovieRepo movieRepo)
        {
            _movieRepo = movieRepo;
        }
        public void Add(MovieVM movie)
        {
            _movieRepo.Add(movie);
        }

        public Task<IEnumerable<MovieVM>> GetALl()
        {
            return _movieRepo.GetALl(); 
        }
    }
}
