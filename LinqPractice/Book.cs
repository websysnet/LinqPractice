namespace LinqPractice
{
    private readonly _books;
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Datime DatePublisher { get; set; }
        public string[] Categories { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }     
        public decimal Price { get; set; }

    }
       
    
}