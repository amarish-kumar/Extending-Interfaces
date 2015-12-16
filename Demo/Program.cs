using System;
using System.Collections;
using System.Collections.Generic;
using ExtendingInterface;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieRepository movieRepository = new MovieRepository();
            
            //Implementing plain way
            List<Movies> movies = movieRepository.GetMovies();

            Console.WriteLine("---------Writing Simple Way------------");
            foreach (var items in movies)
            {
                Console.WriteLine("Movie Name:- "+items.MovieName+
                                  ", Director Name:- "+items.DirectorName+
                                  ", Release Year:- "+items.ReleaseYear);
            }

            //Implementing Interface way
            IEnumerable<Movies> moviesEnumerable = movieRepository.GetMovies();

            Console.WriteLine("---------Writing Interface Way------------");
            foreach (var elems in moviesEnumerable)
            {
                Console.WriteLine("Movie Name:- " + elems.MovieName +
                                    ", Director Name:- " + elems.DirectorName +
                                    ", Release Year:- " + elems.ReleaseYear);
                
            }
            Console.ReadLine();

        }
    }
}
