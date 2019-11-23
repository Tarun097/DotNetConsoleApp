using System;
using System.Collections.Generic;

namespace MyProgramsLib
{
    public static class MyExtension
    {
        public static int Count<T>(this IEnumerable<T> collection) 
        {
            int count = 0;
            foreach(var emp in collection) 
            {
                count += 1;
            }
            return count;
        }

        public static IEnumerable<T> Filter<T>(this IEnumerable<T> collection, Func<T, bool> predicate) 
        {

            var filteredList = new List<T>();

            foreach (var item in collection)
            {
                if (predicate(item)) 
                {
                    filteredList.Add(item);
                }
            }

            return filteredList;
        }

        public static IEnumerable<T> DeferredExecutionFilter<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            //Only when something is pulled out of the IEnumerable, execution will start inside this method.
            //yield return will yield control back to caller , returning an item. Went next item is pulled
            //out in next iteration, excecution will pick up and resume from the point it jumped out of this filter method 

            foreach (var item in collection)
            {
                if (predicate(item))
                {
                    //Yield return can be used with return types IEnumerable<T> or IEnumerator<T>
                    yield return item;
                }
            }
        }

    }
}
