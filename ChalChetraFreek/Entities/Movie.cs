using System.Collections.Generic;
using ChalChetraFreek.DataType;

namespace ChalChetraFreek.Entities
{
    public class Movie
    {
        //todo : Movie Image

        public string Name { get; set; }

        public string Year { get; set; }

        public string Description { get; set; }

        public Rating Type { get; set; }

        public List<Award> Awards { get; set; }

        public List<Celebrity> Produces { get; set; }

        public List<Celebrity> Writers { get; set; }

        public List<Character> Cast { get; set; }

        //todo: Place it in a better place
        public bool MustWatch { get; set; }

        public List<Song> Songs { get; set; }
    }
}
