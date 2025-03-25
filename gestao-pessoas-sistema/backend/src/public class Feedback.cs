public class Feedback
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int EvaluatorId { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
    public FeedbackType Type { get; set; }
    public User User { get; set; }
}