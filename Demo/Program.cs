using System;
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
            /*Console.WriteLine("Enter Director Name");
            string directorName = Console.ReadLine();*/

            List<Movies> movies = movieRepository.GetMovies();

            foreach (var items in movies)
            {
                Console.WriteLine("Movie Name:- "+items.MovieName+
                                  ", Director Name:- "+items.DirectorName+
                                  ", Release Year:- "+items.ReleaseYear);
            }

            Console.ReadLine();

        }
    }
}
