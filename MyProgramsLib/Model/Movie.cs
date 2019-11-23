using System;

namespace MyProgramsLib.Model
{
    public class Movie
    {
        private int _year;

        public string Title { get; set; }
        public float Rating { get; set; }
        public int Year {
            get
            {
                Console.WriteLine($"{Title}, {Rating}, {_year}");
                return _year;
            }
            set
            {
                _year = value;
            } 
        }
    }
}
