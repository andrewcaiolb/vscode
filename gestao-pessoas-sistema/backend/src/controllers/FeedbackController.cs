public class FeedbackController
{
    private readonly FeedbackService _feedbackService;

    public FeedbackController(FeedbackService feedbackService)
    {
        _feedbackService = feedbackService;
    }

    [HttpPost]
    [Route("api/feedback")]
    public IActionResult CreateFeedback([FromBody] Feedback feedback)
    {
        if (feedback == null)
        {
            return BadRequest("Feedback não pode ser nulo.");
        }

        _feedbackService.AddFeedback(feedback);
        return CreatedAtAction(nameof(GetFeedbacks), new { id = feedback.Id }, feedback);
    }

    [HttpGet]
    [Route("api/feedback")]
    public IActionResult GetFeedbacks()
    {
        var feedbacks = _feedbackService.GetAllFeedbacks();
        return Ok(feedbacks);
    }

    [HttpDelete]
    [Route("api/feedback/{id}")]
    public IActionResult DeleteFeedback(int id)
    {
        var feedback = _feedbackService.GetFeedbackById(id);
        if (feedback == null)
        {
            return NotFound();
        }

        _feedbackService.RemoveFeedback(id);
        return NoContent();
    }
}