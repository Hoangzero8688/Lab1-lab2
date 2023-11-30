using ExamNet104.Models;
using ExamNet104.ViewModel;

namespace ExamNet104.Service
{
    public interface IMovieSV
    {
        public Task<IEnumerable<MovieVM>> GetALl();

        public void Add(MovieVM movie);
    }
}
