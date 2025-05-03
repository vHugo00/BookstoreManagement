namespace BookstoreManagement.Communication.Responses;

public class ResponseBooksJson
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public float Price { get; set; }
    public int Stock { get; set; }

}