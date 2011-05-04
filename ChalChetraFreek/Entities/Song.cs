namespace ChalChetraFreek.Entities
{
    public class Song
    {
        public string Titel { get; set; }

        public Celebrity Singer { get; set; }

        public Celebrity Lyricist { get; set; }

        //public bool MustListen { get; set; }
    }
}