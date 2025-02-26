
namespace MoviesList.Models
{
    public class MovieDataAccess : IMovieList
    {
        private readonly MovieDbContext context;

        public MovieDataAccess(MovieDbContext context)
        {
            this.context = context;
        }

        public void Add(Movie movie)
        {
            context.movie.Add(movie);
            context.SaveChanges();
        }

        public List<Movie> GetAll()
        {
            return context.movie.ToList();
        }
    }
}

