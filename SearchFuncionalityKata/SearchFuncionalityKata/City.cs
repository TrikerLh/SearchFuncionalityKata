using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFuncionalityKata {
    public class City
    {
        private static  readonly List<string> Cities = new() { "Paris", "Budapest", "Skopje", "Rotterdam", "Valencia", "Vancouver", "Amsterdam","Vienna", "Sydney", "New York City", "London", "Bangkok", "Hong Kong", "Dubai", "Rome", "Istanbul" };

        public static List<string> Search(string textSearch)
        {
            if (textSearch.Length < 2)
                return new List<string>();

            return Cities.Where(c => c.ToLower().StartsWith(textSearch.ToLower())).ToList();
        }
    }
}
