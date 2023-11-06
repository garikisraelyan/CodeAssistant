public class Conversation
{
    public int Id { get; set; }
    public string UserQuestion { get; set; }
    public string ChatbotResponse { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}
