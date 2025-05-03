namespace BookstoreManagement.Communication.Requests;

public class RequestBooksJson
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public float Price { get; set; }
    public int Stock { get; set; }
    public enum Genre
    {
        Fiction,
        NonFiction,
        Mystery,
        SciFi,
        Fantasy,
        Biography,
        History,
        Romance
    }
}