using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ExtendingInterface
{
    public class MovieRepository
    {

        //Get all Movies Generic Way
        public List<Movies> GetMovies()
        {
            return new List<Movies>
           {
               new Movies
               {
                   DirectorName = "Gareth Edwards",
                   MovieName = "Godzilla",
                   ReleaseYear = "2014"
               },
               new Movies
               {
                   DirectorName = "James Cameron",
                   MovieName = "Avatar",
                   ReleaseYear = "2009"
               },
               new Movies
               {
                   DirectorName = "James Cameron",
                   MovieName = "Titanic",
                   ReleaseYear = "1997"
               },
               new Movies
               {
                   DirectorName = "Lee Tamahori",
                   MovieName = "Die Another Day",
                   ReleaseYear = "2002"
               },
                new Movies
               {
                   DirectorName = "Colin Trevorrow",
                   MovieName = "Jurassic World",
                   ReleaseYear = "2015"
               }
           };

        }

        //Getting Movie by Director Name
        public Movies GetMovieByDirectorName(string lastName)
        {
            var movies = new List<Movies>()
            {
               new Movies
               {
                   DirectorName = "Gareth Edwards",
                   MovieName = "Godzilla",
                   ReleaseYear = "2014"
               },
               new Movies
               {
                   DirectorName = "James Cameron",
                   MovieName = "Avatar",
                   ReleaseYear = "2009"
               },
               new Movies
               {
                   DirectorName = "James Cameron",
                   MovieName = "Titanic",
                   ReleaseYear = "1997"
               },
               new Movies
               {
                   DirectorName = "Lee Tamahori",
                   MovieName = "Die Another Day",
                   ReleaseYear = "2002"
               },
                new Movies
               {
                   DirectorName = "Colin Trevorrow",
                   MovieName = "Jurassic World",
                   ReleaseYear = "2015"
               }
                
            };

            Movies result = movies.FirstOrDefault(m => m.DirectorName.Contains(lastName));
            return result;

        }
    }
}
