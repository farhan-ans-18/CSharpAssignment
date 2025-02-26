namespace MoviesList.Models
{
    public interface IMovieList
    {
        void Add(Movie movie);
       List<Movie> GetAll();
    }
}
