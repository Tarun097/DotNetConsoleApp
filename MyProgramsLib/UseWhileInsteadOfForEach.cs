using MyProgramsLib.Model;
using System.Collections;
using System.Collections.Generic;

namespace MyProgramsLib
{
    public class UseWhileInsteadOfForEach
    {

        public void Execute() 
        {
            IEnumerable<Employee> employess = new List<Employee>() 
            {
                new Employee(){ Id = 1, Name="Alex" }
            };

            var enumerator = employess.GetEnumerator();

            while (enumerator.MoveNext()) 
            {
                System.Console.WriteLine(enumerator.Current.Name);
            }


        }

    }



}
