namespace BooksSample.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Isbn { get; set; }

        public override string ToString() => Title;
    }
}
