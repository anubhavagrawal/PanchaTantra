using System.Collections.Generic;
using ChalChetraFreek.DataType;

namespace ChalChetraFreek.Entities
{
    public class Celebrity
    {
        public string Name { get; set; }
        
        public Date BornOn { get; set; }
        
        public List<Award> Awards{ get; set; }
        
        public List<Movie> Movies { get; set; }

        public bool MustKnow { get; set; }
    }
}