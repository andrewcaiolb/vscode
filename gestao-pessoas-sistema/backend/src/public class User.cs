public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Department { get; set; }
    public string Position { get; set; }
    public List<Feedback> Feedbacks { get; set; }
    public List<Pdi> Pdis { get; set; }
}