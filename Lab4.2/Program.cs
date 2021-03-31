using System;
using System.Collections.Generic;

namespace Lab4._2
{
    class Movies
    {
        //build a movie class with two (private) string fields 
        //build a constructor with these fields
        public string MovieGenre;
        public string MovieTitle;
        public Movies(string genre, string title)
        {
            MovieGenre = genre;
            MovieTitle = title;
        }

        public string GenreMethod()
        {
            return MovieGenre;
        }

        public string TitleMethod()
        {
            return MovieTitle;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            //create a list and store 10 movies with a mixture of categories
            //when user enters category display all movies within that category
            //loop if continue
            bool validGenre = false;
            bool cont = true;
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There's 10 movies in this list.");
            while (cont)
            {
                Console.Write("What category are you interested in? ");
                string userGenre = Console.ReadLine();

                //list of movies and genres
                List<Movies> movieList = new List<Movies>();
                movieList.Add(new Movies("horror", "Sinister"));
                movieList.Add(new Movies("comedy", "Little Nicky"));
                movieList.Add(new Movies("thriller", "The Shining"));
                movieList.Add(new Movies("family", "Shrek"));
                movieList.Add(new Movies("comedy", "The Change Up"));
                movieList.Add(new Movies("action", "Deadpool"));
                movieList.Add(new Movies("action", "Blow"));
                movieList.Add(new Movies("comedy", "Big Daddy"));
                movieList.Add(new Movies("horror", "Pet Sematary"));
                movieList.Add(new Movies("family", "The Nightmare Before Christmas"));

                //valid genre
                foreach (var elem in movieList)
                {
                    if (elem.GenreMethod().Contains(userGenre))
                    {
                        Console.WriteLine($"{elem.TitleMethod()}");
                        validGenre = true;
                    }
                }
                //invalid genre
                if (validGenre == false)
                {
                    Console.WriteLine("Invalid");
                }

                bool validYN = false;
                while (!validYN)
                {
                    Console.WriteLine("Continue? (y/n)");
                    string yn = Console.ReadLine().ToLower();

                    if (yn != "y" && yn != "n")
                    {
                        Console.WriteLine("Please enter 'y' or 'n'");
                    }
                    else
                    {
                        validYN = true;
                        if (yn == "n")
                        {
                            cont = false;
                            Console.WriteLine("Goodbye!");
                        }
                    }
                }
            }

        }
    }
}
