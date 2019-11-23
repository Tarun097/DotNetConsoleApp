
using MyProgramsLib;
using MyProgramsLib.Model;
using System.Collections.Generic;
using System.Linq;

namespace DotNetConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Print top file largest files in a dir
            //var largestFiles = new LargestFiles();
            //largestFiles.PrintTopFiveLargestFiles(@"C:\Windows");
            //largestFiles.PrintTopFiveLargestFilesuisngLinq(@"C:\Windows");
            #endregion

            #region How foreach works internally - IEnumerable interface
            //var testClass = new UseWhileInsteadOfForEach();
            //testClass.Execute();
            #endregion

            #region Create your own Employee Extenstion method
            //var employess = new List<Employee>()
            //{
            //    new Employee(){Id = 1, Name = "Alex" },
            //    new Employee(){Id = 2, Name = "Sam" }
            //};
            //System.Console.WriteLine(employess.Count());
            #endregion

            #region LINQ Query syntax types
            //string[] cities = { "New York", "Bangalore", "Mumbai", "Chennai", "New Delhi"};

            ////Method Syntax
            ////var filteredCities = cities.Where(c => c.StartsWith("N")).OrderBy(c => c);

            ////Query Syntax
            //var filteredCities = from city in cities
            //            where city.StartsWith("N")
            //            orderby city
            //            select city;

            //foreach (var city in filteredCities)
            //{
            //    System.Console.WriteLine(city);
            //}
            #endregion

            #region Deferred Execution in Linq

            var movies = new List<Movie>()
            {
                new Movie {Title = "The Dark Knight",    Rating = 8.9f, Year = 2008},
                new Movie {Title = "The Kings's Speech", Rating = 8.0f, Year = 2010},
                new Movie {Title = "Casablanca",         Rating = 8.5f, Year = 1942},
                new Movie {Title = "Star Wars V",        Rating = 8.7f, Year = 1980}
            };

            //Here query is defined
            var query = movies.DeferredExecutionFilter(m => m.Year > 2000);

            //Here query is executed
            foreach (var item in query)
            {
                System.Console.WriteLine(item.Title);
            }

            #endregion


            System.Console.ReadKey();

        }
    }
}
