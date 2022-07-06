using Microsoft.AspNetCore.Mvc;

namespace WebAPI_React.Controllers
{
    [ApiController]
    [Route("Movies")]
    public class MoviesController : Controller
    {
        List<Movie> Movies;
        public MoviesController()
        {
            Movies = new List<Movie>();
            Movies.Add(new Movie { Id = 1, Name = "Batman", Content = "The Best Movie" });
            Movies.Add(new Movie { Id = 2, Name = "Joker", Content = "The Best Movie of 2020" });
            Movies.Add(new Movie { Id = 3, Name = "Batman Begins", Content = "The Best Movie of 2019" });
            Movies.Add(new Movie { Id = 4, Name = "Gladiator", Content = "The Best Movie of 1996" });
            Movies.Add(new Movie { Id = 5, Name = "Iron Man", Content = "The Best Comic Movie" });
            Movies.Add(new Movie { Id = 6, Name = "James Bond", Content = "The Best JamesBond 007" });
            Movies.Add(new Movie { Id = 7, Name = "Twilight", Content = "The Best Dracula Movie" });
            Movies.Add(new Movie { Id = 8, Name = "The Dark Knight", Content = "The Best Joker and batman" });
            Movies.Add(new Movie { Id = 9, Name = "True Lies", Content = "The Best Movie which i dont know" });
        }

        [HttpGet]
        public List<Movie> Index()
        {
            return Movies;
        }
        [HttpGet]
        [Route("/getmovie/{id}")]
        public Movie GetMovie(int id)
        {
            var x = Movies.FirstOrDefault(x => x.Id == id);
            return x;
        }
        [HttpPost]
        [Route("/addmovie")]
        public List<Movie> AddMovie(int id, string name, string content)
        {
            var Movie = new Movie();
            Movie.Id = id;
            Movie.Name = name;
            Movie.Content = content;
            Movies.Add(Movie);
            return Movies;
        }
        [HttpPut]
        [Route("/updatemovie")]
        public List<Movie> UpdateMovie(int id, string name, string content)
        {
            var movie = Movies.SingleOrDefault(x => x.Id == id);
            movie.Id = id;
            movie.Name = name;
            movie.Content = content;
            Movies.Add(movie);
            return Movies;
        }
        [HttpDelete]
        [Route("/deletemovie")]
        public List<Movie> DeleteMovie(int id)
        {
            var y = Movies.FirstOrDefault(x => x.Id == id);
            Movies.Remove(y);
            return Movies;
        }
    }
}
