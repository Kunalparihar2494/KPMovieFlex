using KPMovieFlex.Models;

namespace KPMovieFlex.Repository
{
    public interface IMovie
    {
        List<MovieModel> getAllMovie();
        MovieModel getMovieByName(string name);
        MovieModel getMovieByGenre(string genre);
        MovieModel getMovieByOtt(string ott);
        MovieModel getMovieByLanguage(string language);
    }
}
