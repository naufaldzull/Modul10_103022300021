using Microsoft.AspNetCore.Mvc;

namespace modul10_103022300021.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private static List<Movie> DaftarFilm = new List<Movie>
        {
           new Movie("The Shawshank Redemption", "Frank Darabont",["Tim Robbins", "Morgan Freeman", "Bon Gunton"], "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
           new Movie("The Godfather", "Francis Ford Coppola", ["Marlon Brando", "Al Pacino", "James Caan"], "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
           new Movie("The Dark Knight", "Christopher Nolan", ["Christian Bale", "Heath Leadger", "Aaron Eckhart"], "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness."),
        };

        [HttpGet]

        public IEnumerable<Movie> Get()
        {
            return DaftarFilm;
        }

        [HttpGet("{id}")]

        public Movie Get(int id)
        {
            return DaftarFilm[id];
        }

        [HttpPost]
        public void Post([FromBody] Movie movie)
        {
            DaftarFilm.Add(movie);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DaftarFilm.RemoveAt(id);
        }

    }
}
