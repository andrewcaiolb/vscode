public class FeedbackService
{
    private readonly List<Feedback> feedbacks;

    public FeedbackService()
    {
        feedbacks = new List<Feedback>();
    }

    public void AddFeedback(Feedback feedback)
    {
        feedbacks.Add(feedback);
    }

    public List<Feedback> GetAllFeedbacks()
    {
        return feedbacks;
    }

    public void RemoveFeedback(int id)
    {
        var feedback = feedbacks.FirstOrDefault(f => f.Id == id);
        if (feedback != null)
        {
            feedbacks.Remove(feedback);
        }
    }
}