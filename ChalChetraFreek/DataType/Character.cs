using ChalChetraFreek.Entities;

namespace ChalChetraFreek.DataType
{
    //todo: Rename to make it more domain oriented 
    public class Character
    {
        public string Name { get; set; }

        public Celebrity PlayedBy { get; set; }
    }
}