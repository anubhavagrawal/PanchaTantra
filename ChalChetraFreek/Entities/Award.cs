using System;

namespace ChalChetraFreek.Entities
{
    public class Award
    {
        public short Year { get; private set; }
        public string Name { get; private set; }
        public string Category { get; private set; }

        public Award(short year, string name, string category)
        {
            if ( DateTime.Now.Year < year )
                throw new ArgumentException("Award Year should be less then or equal to present year");
            Year = year;
            Name = name;
            Category = category;
        }
    }
}