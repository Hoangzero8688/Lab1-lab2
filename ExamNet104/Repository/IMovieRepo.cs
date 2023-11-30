using ExamNet104.Models;
using ExamNet104.ViewModel;

namespace ExamNet104.Repository
{
    public interface IMovieRepo
    {
        public Task<IEnumerable<MovieVM>> GetALl();

        public void Add(MovieVM movie);

    }
}
